namespace LoginCleanArchitectureApp_NET.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string Role { get; set; } 
    }
}
