using EDT.BookStore.API.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDT.BookStore.API.Services
{
    public class ContactService : IContactService
    {
        private readonly IMongoCollection<Contact> _contacts;
        private readonly IMongoCollection<Group> _groups;

        public ContactService(IContactDatabaseSettings settings)
        {
            var mongoClient = new MongoClient(settings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(settings.DatabaseName);
            _contacts = mongoDatabase.GetCollection<Contact>(settings.ContactsCollectionName);
            _groups = mongoDatabase.GetCollection<Group>(settings.GroupsCollectionName);
        }

        public async Task<IList<Contact>> GetAsync()
        {
            return await _contacts
                .Aggregate()
                .Lookup<Contact, Group, Contact>(
                    _groups,
                    local => local.GroupIds,
                    from => from.GroupId,
                    result => result.Groups)
                .ToListAsync();
        }
    }
}
