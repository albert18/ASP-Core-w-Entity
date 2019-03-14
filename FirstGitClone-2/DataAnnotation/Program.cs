using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotation
{
    [Table("Author")]
    class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [MaxLength(15)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(15), Required]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return FirstName + "" + LastName; }
        }

        public List<Book> Books { get; set; }
    }

    [Table("Book")]
    class Book
    {
        [Key, Column(Order = 0)]
        public int BookId { get; set; }

        [Column(Order = 1)]
        [Required]
        public string BookName { get; set; }

        [Column(Order = 2)]
        [ConcurrencyCheck]
        [Required]
        public double PricePerUnit { get; set; }

        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedOn { get; set; }

        [Column(Order = 4)]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }

    [NotMapped]
    class Test
    {
        [Key]
        public int TestId { get; set; }
    }

    class EFCoreQorganizationDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=AlbertG-PC;Database=ASP-Core-w-Entity;Trusted_Connection=True;");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //        modelBuilder.Entity<Book>()

        //}

    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Insert
            //EFCoreQorganizationDb shopDbContext = new EFCoreQorganizationDb();
            //Author author = new Author() { FirstName = "Manzoor", LastName = "Ahmed" };

            ////shopDbContext.Authors.Add(author); ----Old version approach
            ////shopDbContext.SaveChanges();

            //shopDbContext.Add<Author>(author);
            //shopDbContext.SaveChanges();
            #endregion

            #region Delete
            //// Author author = new Author(); //Garbage Collection - CLR


            ////ShopDbContext shopDbContext = new ShopDbContext();
            ////shopDbContext.Dispose();

            //using (ShopDbContext shopDbContext = new ShopDbContext())
            //{
            //    Author author = shopDbContext.Authors.Find(4);

            //    //shopDbContext.Authors.Remove(author);
            //    //shopDbContext.SaveChanges();

            //    shopDbContext.Remove<Author>(author);
            //    shopDbContext.SaveChanges();
            //} 
            #endregion

            #region Update
            ////Connected approach
            //using (ShopDbContext shopDbContext = new ShopDbContext())
            //{
            //    Author author = shopDbContext.Authors.Find(3);
            //    author.FirstName = "Jack";
            //    shopDbContext.Update<Author>(author);
            //    shopDbContext.SaveChanges();
            //} 
            #endregion
        }
    }
}
