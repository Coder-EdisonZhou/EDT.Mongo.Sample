﻿using EDT.BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDT.BookStore.API.Services
{
    public interface IBookService
    {
        IList<Book> Get();

        Task<IList<Book>> GetAsync();

        Book Get(string id);

        Task<Book> GetAsync(string id);

        Book Create(Book book);

        Task<Book> CreateAsync(Book book);

        void Update(string id, Book bookIn);

        Task UpdateAsync(string id, Book bookIn);

        void Remove(string id);

        Task RemoveAsync(string id);
    }
}
