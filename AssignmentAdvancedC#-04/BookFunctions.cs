using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAdvancedC__04
{
    public class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            return b.Title;
        }

        public static string GetAuthors(Book b)
        {
            return string.Join(",", b.Authors);
        }

        public static string GetPrice(Book b)
        {
            return b.Price.ToString();
        }
    }
}
