using AI.HomeExpenses.Authors;
using AI.HomeExpenses.Books;
using AutoMapper;

namespace AI.HomeExpenses;

public class HomeExpensesApplicationAutoMapperProfile : Profile
{
    public HomeExpensesApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
         CreateMap<Book, BookDto>();
         CreateMap<CreateUpdateBookDto, Book>();
         CreateMap<Author, AuthorDto>();
         CreateMap<Author, AuthorLookupDto>();
    }
}
