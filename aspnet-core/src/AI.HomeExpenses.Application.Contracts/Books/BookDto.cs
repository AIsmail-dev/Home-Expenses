using System;
using Volo.Abp.Application.Dtos;
using AI.HomeExpenses.Localization;

namespace AI.HomeExpenses.Books;

public class BookDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public BookType Type { get; set; }
    public HomeExpensesResource Resources { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
    public Guid AuthorId { get; set; }
    public string AuthorName { get; set; }

}
