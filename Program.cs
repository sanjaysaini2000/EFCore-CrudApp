using System;

namespace EFCore_CrudApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudUtility.AddBook();
            CrudUtility.GetBooks();

            Console.Write("Enter Book's Id to be deleted : ");
            int deletedBookId = int.Parse(Console.ReadLine());
            CrudUtility.DeleteBook(deletedBookId);

            Console.Write("Enter Book's Id to be updated : ");
            int updatedBookId = int.Parse(Console.ReadLine());
            Console.Write("Enter Book's Title : ");
            string bookTitle = Console.ReadLine();
            Console.Write("Enter Book's Gener : ");
            string bookGener = Console.ReadLine();
            CrudUtility.UpdateBookDetails(updatedBookId, bookTitle, bookGener);

            CrudUtility.GetBooks();
        }
    }
}
