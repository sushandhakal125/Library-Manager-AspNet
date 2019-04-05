using Abp.Application.Services;
using AutoMapper;
using LibraryApp.Books.DTO;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Books
{
    public class BookAppService : ApplicationService, IBookAppService
    {
        private readonly BookManager _bookManager;
        public BookAppService(BookManager bookManager)
        {
            _bookManager = bookManager;
        }
        public async Task Create(CreateBookInput input)
        {
            Book output = Mapper.Map<CreateBookInput, Book>(input);
            await _bookManager.Create(output);
        }

        public void Delete(DeleteBookInput input)
        {
            _bookManager.Delete(input.Id);
        }

        public GetBookOutput GetBookById(GetBookInput input)
        {
            var getBook = _bookManager.GetBookByID(input.Id);
            GetBookOutput output = Mapper.Map<Book, GetBookOutput>(getBook);
            return output;
        }

        public IEnumerable<GetBookOutput> ListAll()
        {
            var getAll = _bookManager.GetAllList().ToList();
            List<GetBookOutput> output = Mapper.Map<List<Book>, List<GetBookOutput>>(getAll);
            return output;
        }

        public void Update(UpdateBookInput input)
        {
            Book output = Mapper.Map<UpdateBookInput, Book>(input);
            _bookManager.Update(output);
        }
    }
}
