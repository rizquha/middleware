namespace Middleware.Models
{
    public class Posts
    {
        public int id {get;set;}
        public string list {get;set;}
        public bool status {get;set;}=false;
        public User User {get;set;}
    }
}