using EDT.BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDT.BookStore.API.Services
{
    public interface IContactService
    {
        Task<IList<Contact>> GetAsync();
    }
}
