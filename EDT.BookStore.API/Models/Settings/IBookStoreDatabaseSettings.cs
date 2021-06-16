namespace EDT.BookStore.API.Models
{
    public interface IBookStoreDatabaseSettings : IMongoDatabaseSettings
    {
        string BooksCollectionName { get; set; }
    }
}
