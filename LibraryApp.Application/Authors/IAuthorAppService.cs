using Abp.Application.Services;
using LibraryApp.Authors.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Authors
{
    public interface IAuthorAppService : IApplicationService
    {
        IEnumerable<GetAuthorOutput> ListAll();
        Task Create(CreateAuthorInput input);
        void Delete(DeleteAuthorInput input);
        void Update(UpdateAuthorInput input);
        GetAuthorOutput GetAuthorById(GetAuthorInput input);
    }
}
