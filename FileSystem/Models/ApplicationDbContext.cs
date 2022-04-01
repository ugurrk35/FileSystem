using Microsoft.EntityFrameworkCore;

namespace FileSystem.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<FileDatabaseModel> FileDatabaseModels { get; set; }
        public DbSet<FileSystemModel> FileSystemModels { get; set; }
        public DbSet<FileModel> FileModels { get; set; }
    }
}
