using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AI.HomeExpenses.Incomings;

public interface IIncomingItemAppService :
    ICrudAppService< //Defines CRUD methods
        IncomingItemDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateIncomingItemDto> //Used to create/update a book
{
    // ADD the NEW METHOD
    Task<ListResultDto<LookupDto>> GetOccurenceTypeLookupAsync();
}