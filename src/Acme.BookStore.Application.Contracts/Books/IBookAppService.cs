using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IBookAppService :
        ICrudAppService< //Defines CRUD methods
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto> //Used to create/update a book
    {
        Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();
        Task<PagedResultDto<BookDto>> GetList1Async(PagedAndSortedResultRequestDto input, CreateUpdateBookDto book);
        Task<PagedResultDto<BookDto>> GetList2Async(CreateUpdateBookDto book,PagedAndSortedResultRequestDto input);
    }
}
