using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public interface ICategoryManager : IDomainService
    {
        IEnumerable<Category> GetAllList();
        Category GetCategoryByID(int id);
        Task<Category> Create(Category entity);
        void Update(Category entity);
        void Delete(int id);
    }
}
