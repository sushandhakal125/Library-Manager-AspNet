using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public interface IBookManager : IDomainService
    {
        IEnumerable<Book> GetAllList();
        Book GetBookByID(int id);
        Task<Book> Create(Book entity);
        void Update(Book entity);
        void Delete(int id);
    }
}
