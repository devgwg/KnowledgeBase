namespace Domain.KnowledgeBase.Entities;

public class Topic
{

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; } // lista linkow
    public string Status { get; set; } // Zrobic enum
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

