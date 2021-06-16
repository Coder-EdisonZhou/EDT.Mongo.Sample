namespace EDT.BookStore.API.Models
{
    public interface IContactDatabaseSettings : IMongoDatabaseSettings
    {
        string ContactsCollectionName { get; set; }

        string GroupsCollectionName { get; set; }
    }
}
