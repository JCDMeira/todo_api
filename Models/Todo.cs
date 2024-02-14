namespace TodoApi.Models
{
    public class Todo: MongoBaseEntity
    {
        public string Title { get; set; } = null!;
    }
}
