using Abp.Application.Services;
using AutoMapper;
using LibraryApp.Categories.DTO;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Categories
{
    public class CategoryAppService : ApplicationService, ICategoryAppService
    {
        private readonly CategoryManager _categoryManager;
        public CategoryAppService(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public async Task Create(CreateCategoryInput input)
        {
            Category output = Mapper.Map<CreateCategoryInput, Category>(input);
            await _categoryManager.Create(output);
        }

        public void Delete(DeleteCategoryInput input)
        {
            _categoryManager.Delete(input.Id);
        }

        public GetCategoryOutput GetCategoryById(GetCategoryInput input)
        {
            var getCategory = _categoryManager.GetCategoryByID(input.Id);
            GetCategoryOutput output = Mapper.Map<Category, GetCategoryOutput>(getCategory);
            return output;
        }

        public IEnumerable<GetCategoryOutput> ListAll()
        {
            var getAll = _categoryManager.GetAllList().ToList();
            List<GetCategoryOutput> output = Mapper.Map<List<Category>, List<GetCategoryOutput>>(getAll);
            return output;
        }

        public void Update(UpdateCategoryInput input)
        {
            Category output = Mapper.Map<UpdateCategoryInput, Category>(input);
            _categoryManager.Update(output);
        }
    }
}
