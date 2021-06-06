namespace EDT.BookStore.API.Models
{
    public interface IBookStoreDatabaseSettings
    {
        string BooksCollectionName { get; set; }

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }
}
