namespace Domain.KnowledgeBase.Entities;

public class Tag
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; private set; }




    public Tag(Guid id, string name, DateTime createdAt)
    {
        Id = id;
        Name = name;
        CreatedAt = createdAt;
    }
}

