using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

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

        //[Column(Order = 3)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime CreatedOn { get; set; }

        [Column(Order = 3)]
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
            // Author author = new Author(); //Garbage Collection - CLR

            //EFCoreQorganizationDb shopDbContext = new EFCoreQorganizationDb();
            //shopDbContext.Dispose();

            //using (EFCoreQorganizationDb shopDbContext = new EFCoreQorganizationDb())
            //{
            //    Author author = shopDbContext.Authors.Find(3);

            //    //shopDbContext.Authors.Remove(author);
            //    //shopDbContext.SaveChanges();

            //    shopDbContext.Remove<Author>(author);
            //    shopDbContext.SaveChanges();
            //}
            #endregion

            #region Update
            ////Connected approach
            //using (EFCoreQorganizationDb shopDbContext = new EFCoreQorganizationDb())
            //{
            //    Author author = shopDbContext.Authors.Find(2);
            //    author.FirstName = "Jack";
            //    shopDbContext.Update<Author>(author);
            //    shopDbContext.SaveChanges();
            //}
            #endregion

            #region Sample
            //Console.Write("Enter Book Id : ");
            //int BookId = int.Parse(Console.ReadLine());

            //using (var myD = new EFCoreQorganizationDb())
            //{
            //    Book book = myD.Books.Find(BookId);

            //    Console.WriteLine("BookId: {0} Name: {1} Price: {2}", book.BookId, book.BookName, book.PricePerUnit);

            //    Console.ReadLine();

            //} 
            #endregion

            #region Select Operation
            //using (var myD = new EFCoreQorganizationDb())
            //{
            //    //Book book;

            //    //FirstOrDefault grab the first but can be multiple
            //    //book = myD.Books.Where(x => x.PricePerUnit == 12.96).FirstOrDefault();

            //    //SingleOrDefault grab the first one

            //    //if (book != null)
            //    //{
            //    //    Console.WriteLine("BookId:{0} Name:{1} Price:{2}"
            //    //        , book.BookId, book.BookName, book.PricePerUnit);
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Book Not Found");
            //    //}


            //    //select count(*) from Book
            //    //int NumberOfBooks = myD.Books.Count();
            //    //Console.WriteLine("Number Of Books are " + NumberOfBooks);


            //    //PricePerUnit>5000
            //    //List<Book> list = shopDbContext.Books.Where(x => x.PricePerUnit > 5000).ToList();


            //    //List<Book> list = myD.Books.Where(x => x.AuthorId == 1).ToList();

            //    //Get All the books whose author's first name is "Manzoor"
            //    //int AuthorId = myD.Authors.Where(x => x.FirstName == "Manzoor").FirstOrDefault().AuthorId;
            //    //List<Book> list = myD.Books.Where(x => x.AuthorId == 1).ToList();

            //    ////List<Book> list = myD.Books.Where(x => x.Author.FirstName == "Manzoor").ToList();

            //    //foreach (var book in list)
            //    //{
            //    //    Console.WriteLine("BookId:{0} Name:{1} Price:{2}", book.BookId, book.BookName, book.PricePerUnit);
            //    //}

            //} 
            #endregion

            #region Section 6
            //using (var shopDbContext= new EFCoreQorganizationDb())
            //{
            //    //Eager Loading Related entities
            //    IEnumerable<Author> authors = shopDbContext.Authors.Include(x=>x.Books).ToList();

            //    foreach (var item in authors)
            //    {
            //        Console.WriteLine("Books of Author {0} are :", item.FullName);
            //        foreach (var book in item.Books)
            //        {
            //            Console.WriteLine("BookId : {0} BookName {1}", book.BookId,book.BookName);
            //        }
            //    }

            //    Console.ReadLine();
            //} 
            #endregion

            #region Section 7
            //using (var shopDbContext = new EFCoreQorganizationDb())

            //{

            //    //List<Book> list = shopDbContext.Books.ToList();

            //    //foreach (var item in list)
            //    //{
            //    //    Console.WriteLine("BookId : {0} BookName : {1} Price : {2}", item.BookId, item.BookName, item.PricePerUnit);
            //    //}

            //    //Add Record
            //    //shopDbContext.Books.Add(new Book() { BookName = "ASP", PricePerUnit = 15.00, AuthorId = 1 });
            //    //shopDbContext.SaveChanges();
            //    //-----------------------------------------------------------------
            //    //Immediate Mode - List, IEnumerable
            //    //IEnumerable<Book> list = shopDbContext.Books.ToList();

            //    //Deffered Mode - IEnumerable, IQueryable
            //    //IEnumerable<Book> list = shopDbContext.Books;
            //    IQueryable<Book> list = shopDbContext.Books;

            //    //foreach (var item in list)
            //    //{
            //    //    Console.WriteLine("BookId : {0} BookName : {1} Price : {2}", item.BookId, item.BookName, item.PricePerUnit);
            //    //}

            //    //foreach (var item in list)
            //    //{
            //    //    Console.WriteLine("BookId : {0} BookName : {1} Price : {2}", item.BookId, item.BookName, item.PricePerUnit);
            //    //}

            //    foreach (var item in list.Where(x => x.AuthorId == 1))
            //    {
            //        Console.WriteLine("BookId : {0} BookName : {1} Price : {2}", item.BookId, item.BookName, item.PricePerUnit);
            //    }



            //    Console.ReadLine();
            //} 
            #endregion

            #region Section 8
            using (var shopDbContext = new EFCoreQorganizationDb())
            {

                //Normal - note must all column
                //IEnumerable<Book> books = shopDbContext.Books.FromSql("Select * from [dbo].[Book]").ToList();

                //Book Authors
                //IEnumerable<Book> booksByAuthor = shopDbContext.Books.FromSql("Select * from [dbo].[Book] where AuthorId=1").ToList();

                //Passing Parameter = not best approach
                //int AuthorId = 1;
                //IEnumerable<Book> booksByAuthor = shopDbContext.Books.FromSql("Select * from [dbo].[Book] where AuthorId ={0}", AuthorId).ToList();


                int AuthorId = 1;
                //IEnumerable<Book> booksByAuthor = shopDbContext.Books.FromSql("Select * from [dbo].[Book] where AuthorId ={0}", AuthorId).ToList();




                Console.ReadLine();
            }
            #endregion
        }
    }
}
