namespace TodoApi.Models
{
    public class User: MongoBaseEntity
    {
        public string UserName { get; set; }= null!; 
        public string UserEmail { get; set;} = null!;

    }
}
