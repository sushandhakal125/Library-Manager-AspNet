using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class CategoryManager : DomainService, ICategoryManager
    {
        private readonly IRepository<Category> _repositoryCategory;
        public CategoryManager(IRepository<Category> repositoryCategory)
        {
            _repositoryCategory = repositoryCategory;
        }
        public async Task<Category> Create(Category entity)
        {
            var category = _repositoryCategory.FirstOrDefault(x => x.Id == entity.Id);
            if (category != null)
            {
                throw new UserFriendlyException("Already exists.");
            }
            else
            {
                return await _repositoryCategory.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var category = _repositoryCategory.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repositoryCategory.Delete(category);
            }
        }

        public IEnumerable<Category> GetAllList()
        {
            return _repositoryCategory.GetAllIncluding(x => x.Books);
        }

        public Category GetCategoryByID(int id)
        {
            return _repositoryCategory.Get(id);
        }

        public void Update(Category entity)
        {
            _repositoryCategory.Update(entity);
        }
    }
}
