using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToAdd, bookToDelete;

            List<string> myBooks = new List<string>() { "Batman", "Crooked Thieves", "Chariots of Fire", "The Waltons" };
            Console.WriteLine("Choices:  A-Add D-Delete L-List S-Sort X-Exit)");

            //get first user response
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            //loop while user does not select X
            do
            {
                switch (response)
                {
                    case 'A':
                        AddNewBook(myBooks);
                        break;
                    case 'D':
                        Console.WriteLine("Type the name of the book you would like to delete:");
                        bookToDelete = Console.ReadLine();
                        myBooks.Remove(bookToDelete);
                        break;
                    case 'L':
                        for (int i = 0; i < myBooks.Count; i++)
                        {
                            Console.WriteLine(myBooks[i]);
                        }
                        break;
                    case 'S':
                        myBooks.Sort();
                        break;
                    case 'F':

                        myBooks.ForEach(Console.WriteLine);

                        break;
                    default:
                        break;
                }
                Console.WriteLine("What would you like to do next: A, D, L, S or X?:");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            while (response != 'X');

        }


        //METHOD Pass in List and Return Updated List 
        static List<string> AddNewBook(List<string> obj)
        {
            Console.WriteLine("Type the name of the book /n you would like to add:");
            string bbb = Console.ReadLine();
            obj.Add(bbb);
            //myBooks.Add(Console.ReadLine());
            return (obj);
        }



    }//end class
}//end namespace