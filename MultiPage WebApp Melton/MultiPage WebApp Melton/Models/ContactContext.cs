using Microsoft.EntityFrameworkCore;

namespace MultiPage_WebApp_Melton.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
           : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                        
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Bob",
                    Number = 1234567890,
                    Address = "123 Fake Street",
                    Note = "Co-worker"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Sarah",
                    Number = 0987654321,
                    Address = "111 Maple Drive",
                    Note = "A"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Tom",
                    Number = 1032547698,
                    Address = "222 Sunset Lane",
                    Note = "Tailor"
                }
            );
        }
    }
}
