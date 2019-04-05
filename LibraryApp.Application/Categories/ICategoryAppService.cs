using Abp.Application.Services;
using LibraryApp.Categories.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Categories
{
    public interface ICategoryAppService : IApplicationService
    {
        IEnumerable<GetCategoryOutput> ListAll();
        Task Create(CreateCategoryInput input);
        void Delete(DeleteCategoryInput input);
        void Update(UpdateCategoryInput input);
        GetCategoryOutput GetCategoryById(GetCategoryInput input);
    }
}
