using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAdvancedC__04
{

    public delegate string BookDelegate (Book b);
    public class LibraryEngine
    {
        // a. User Defined Delegate Datatype
        public static void ProcessBooksUserDefined(List<Book> Books, BookDelegate bookDelegate)
        {
            foreach (Book b in Books)
            {
                Console.WriteLine(bookDelegate(b));
            }
        }

        // b. BCL Delegates
        public static void ProcessBooksFunC(List<Book> Books, Func<Book, string> FuncDelegate )
        {
            foreach (Book b in Books)
            {
                Console.WriteLine(FuncDelegate(b));
            }
        }
    }
}
