using ApplicationDomain;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer
{
    public class ExamDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; } 
        public DbSet<ResidentialInfo> ResidentialInfos { get; set; }
        public DbSet<Image> Images { get; set; }

        public ExamDbContext(DbContextOptions options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PersonalInfo>().HasOne(p => p.ProfilePic).WithOne(i => i.PersonalInfo).OnDelete(DeleteBehavior.Cascade);
        //}
    }
}
