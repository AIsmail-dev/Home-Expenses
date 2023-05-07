using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using AI.HomeExpenses.Authors;
using AI.HomeExpenses.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace AI.HomeExpenses.Incomings;

[Authorize(HomeExpensesPermissions.IncomingItems.Default)]
public class IncomingItemAppService :
    CrudAppService<
        IncomingItem, //The Book entity
        IncomingItemDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateIncomingItemDto>, //Used to create/update a book
    IIncomingItemAppService //implement the IBookAppService
{
    private readonly IOccurenceTypeRepository _occurenceTypeRepository;
    private readonly IIncomingCategoryRepository _incomingCategoryRepository;

    public IncomingItemAppService(
        IRepository<IncomingItem, Guid> repository,
        IOccurenceTypeRepository occurenceTypeRepository,
        IIncomingCategoryRepository incomingCategoryRepository)
        : base(repository)
    {
        _occurenceTypeRepository = occurenceTypeRepository;
        _incomingCategoryRepository = incomingCategoryRepository;
        GetPolicyName = HomeExpensesPermissions.IncomingItems.Default;
        GetListPolicyName = HomeExpensesPermissions.IncomingItems.Default;
        CreatePolicyName = HomeExpensesPermissions.IncomingItems.Create;
        UpdatePolicyName = HomeExpensesPermissions.IncomingItems.Edit;
        DeletePolicyName = HomeExpensesPermissions.IncomingItems.Create;
    }

    public override async Task<IncomingItemDto> GetAsync(Guid id)
    {
        //Get the IQueryable<IncomingItem> from the repository
        var queryable = await Repository.GetQueryableAsync();

        //Prepare a query to join incomingitems and incomngcategorys and 
        var query = from incomingItem in queryable
            join occurenceType in await _occurenceTypeRepository.GetQueryableAsync() on incomingItem.OccuranceTypeId equals occurenceType.Id
            join incomingCategory in await _incomingCategoryRepository.GetQueryableAsync() on incomingItem.IncomingCategoryId equals incomingCategory.Id
            where incomingItem.Id == id
            select new { incomingItem, occurenceType };

        //Execute the query and get the IncomingItem with OccurenceType
        var queryResult = await AsyncExecuter.FirstOrDefaultAsync(query);
        if (queryResult == null)
        {
            throw new EntityNotFoundException(typeof(IncomingItem), id);
        }

        var incomingItemDto = ObjectMapper.Map<IncomingItem, IncomingItemDto>(queryResult.incomingItem);
        incomingItemDto.OccurenceTypeName = queryResult.occurenceType.Name;
        incomingItemDto.IncomingCategoryName = queryResult.incomingItem.Name;
        return incomingItemDto;
    }

    public override async Task<PagedResultDto<IncomingItemDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        //Get the IQueryable<IncomingItem> from the repository
        var queryable = await Repository.GetQueryableAsync();

        //Prepare a query to join IncomingItem and OccurenceType
        var query = from incomingItem in queryable
            join occurenceType in await _occurenceTypeRepository.GetQueryableAsync() on incomingItem.OccuranceTypeId equals occurenceType.Id
            join incomingCategory in await _incomingCategoryRepository.GetQueryableAsync() on incomingItem.OccuranceTypeId equals incomingCategory.Id
            select new {incomingItem, occurenceType, incomingCategory};

        //Paging
        query = query
            .OrderBy(NormalizeSorting(input.Sorting))
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount);

        //Execute the query and get a list
        var queryResult = await AsyncExecuter.ToListAsync(query);

        //Convert the query result to a list of IncomingItemDto objects
        var incomingItemDtos = queryResult.Select(x =>
        {
            var incomingItemDto = ObjectMapper.Map<IncomingItem, IncomingItemDto>(x.incomingItem);
            incomingItemDto.OccurenceTypeName = x.occurenceType.Name;
            incomingItemDto.IncomingCategoryName = x.incomingCategory.Name;
            return incomingItemDto;
        }).ToList();

        //Get the total count with another query
        var totalCount = await Repository.GetCountAsync();

        return new PagedResultDto<IncomingItemDto>(
            totalCount,
            incomingItemDtos
        );
    }

    public async Task<ListResultDto<LookupDto>> GetOccurenceTypeLookupAsync()
    {
        var occurenceTypes = await _occurenceTypeRepository.GetListAsync();

        return new ListResultDto<LookupDto>(
            ObjectMapper.Map<List<OccurenceType>, List<LookupDto>>(occurenceTypes)
        );
    }

    private static string NormalizeSorting(string sorting)
    {
        if (sorting.IsNullOrEmpty())
        {
            return $"incomingItem.{nameof(IncomingItem.Name)}";
        }

        if (sorting.Contains("occurenceTypeName", StringComparison.OrdinalIgnoreCase))
        {
            return sorting.Replace(
                "occurenceTypeName",
                "occurenceType.Name",
                StringComparison.OrdinalIgnoreCase
            );
        }

        return $"occurenceType.{sorting}";
    }
}
