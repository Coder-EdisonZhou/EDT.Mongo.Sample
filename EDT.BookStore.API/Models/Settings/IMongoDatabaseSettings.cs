namespace EDT.BookStore.API.Models
{
    public interface IMongoDatabaseSettings
    {
        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }
}
