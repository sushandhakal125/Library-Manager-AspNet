using Abp.Application.Services;
using AutoMapper;
using LibraryApp.Authors.DTO;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Authors
{
    public class AuthorAppService : ApplicationService, IAuthorAppService
    {
        private readonly AuthorManager _authorManager;
        public AuthorAppService(AuthorManager authorManager)
        {
            _authorManager = authorManager;
        }
        public async Task Create(CreateAuthorInput input)
        {
            Author output = Mapper.Map<CreateAuthorInput, Author>(input);
            await _authorManager.Create(output);
        }

        public void Delete(DeleteAuthorInput input)
        {
            _authorManager.Delete(input.Id);
        }

        public GetAuthorOutput GetAuthorById(GetAuthorInput input)
        {
            var getAuthor = _authorManager.GetAuthorByID(input.Id);
            GetAuthorOutput output = Mapper.Map<Author, GetAuthorOutput>(getAuthor);
            return output;
        }

        public IEnumerable<GetAuthorOutput> ListAll()
        {
            var getAll = _authorManager.GetAllList().ToList();
            List<GetAuthorOutput> output = Mapper.Map<List<Author>, List<GetAuthorOutput>>(getAll);
            return output;
        }

        public void Update(UpdateAuthorInput input)
        {
            Author output = Mapper.Map<UpdateAuthorInput, Author>(input);
            _authorManager.Update(output);
        }
    }
}
