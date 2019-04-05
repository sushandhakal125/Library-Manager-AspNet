using Abp.Application.Services;
using LibraryApp.Books.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Books
{
    public interface IBookAppService : IApplicationService
    {
        IEnumerable<GetBookOutput> ListAll();
        Task Create(CreateBookInput input);
        void Delete(DeleteBookInput input);
        void Update(UpdateBookInput input);
        GetBookOutput GetBookById(GetBookInput input);
    }
}
