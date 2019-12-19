using System;
using System.Linq;

namespace EFCore_CrudApp
{

    public static class CrudUtility
    {
        public static void AddMember()
        {
            using (var dbcontext = new CrudAppDbContext())
            {
                Console.WriteLine("**********Enter Member details**********");
                Console.WriteLine("----------------------------------------");
                Console.Write("Member Name : ");
                string name = Console.ReadLine();
                Console.Write("Member Contact No. : ");
                string phoneno = Console.ReadLine();
                Console.Write("Member City : ");
                string city = Console.ReadLine();

                var member = new Member { Name = name, City = city, PhoneNo = phoneno };
                dbcontext.Members.Add(member);
                dbcontext.SaveChanges();
            }
        }

        public static void GetMembers()
        {
            using (var dbcontext = new CrudAppDbContext())
            {
                var query = from m in dbcontext.Members orderby m.Id select m;

                Console.WriteLine("List of Members....");

                foreach (var m in query)
                {
                    Console.WriteLine("id - {0}", m.Id);
                    Console.WriteLine("Name - {0}", m.Name);
                    Console.WriteLine("PhoneNo - {0}", m.PhoneNo);
                    Console.WriteLine("City - {0}", m.City);
                }
                Console.ReadKey();
            }
        }

        public static void AddBook()
        {
            using (var dbcontext = new CrudAppDbContext())
            {
                Console.WriteLine("**********Enter Book details**********");
                Console.WriteLine("--------------------------------------");
                Console.Write("Book Title : ");
                string title = Console.ReadLine();
                Console.Write("Book Gener : ");
                string gener = Console.ReadLine();
                Console.WriteLine(" ");

                var book = new Book { Title = title, Gener = gener };
                dbcontext.Books.Add(book);
                dbcontext.SaveChanges();
            }
        }

        public static void GetBooks()
        {
            using (var dbcontext = new CrudAppDbContext())
            {
                var query = from b in dbcontext.Books orderby b.Id select b;

                Console.WriteLine("**********List of Books**********");
                Console.WriteLine("---------------------------------");

                foreach (var b in query)
                {
                    Console.WriteLine("Details of Book No - {0}", b.Id);
                    Console.WriteLine("--------------------------------- ");
                    Console.WriteLine("Book Title - {0}", b.Title);
                    Console.WriteLine("Book Gener - {0}", b.Gener);
                    Console.WriteLine(" ");
                }
            }
        }

        public static void DeleteBook(int bookId)
        {
            using (var dbcontext = new CrudAppDbContext())
            {
                var query = from b in dbcontext.Books orderby b.Id select b;
                foreach (var b in query)
                {
                    if (b.Id == bookId)
                    {
                        dbcontext.Remove(b);
                        break;
                    }
                }
                dbcontext.SaveChanges();
            }
        }

        public static void UpdateBookDetails(int bookId, string title, string gener)
        {
            using (var dbcontext = new CrudAppDbContext())
            {
                var query = from b in dbcontext.Books orderby b.Id select b;
                foreach (var b in query)
                {
                    if (b.Id == bookId)
                    {
                        b.Title = title;
                        b.Gener = gener;
                        dbcontext.Update(b);
                        break;
                    }
                }
                dbcontext.SaveChanges();
            }
        }
    }
}