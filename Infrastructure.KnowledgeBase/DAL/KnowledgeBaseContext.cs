using Domain.KnowledgeBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.KnowledgeBase.DAL;

public class KnowledgeBaseContext: DbContext
{

    public DbSet<User> Users { get; set; }

    //Add Migration dotnet ef migrations add Init -o ./DAL/Migrations
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=WIN-UKHKSI6BDS2;Database=KnowledgeBaseDb;Trusted_Connection=True;Encrypt=false");
    }
}

