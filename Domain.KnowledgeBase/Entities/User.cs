namespace Domain.KnowledgeBase.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Email { get; private set; }
    public string Username { get; private set; }
    public string Password { get; private set; }
    public string FullName { get; private set; }
    public DateTime CreatedAt { get; private set; }




    public User(Guid id, string email, string username, string password, string fullName,
    DateTime createdAt)
    {
        Id = id;
        Email = email;
        Username = username;
        Password = password;
        FullName = fullName;
        CreatedAt = createdAt;
    }

}
