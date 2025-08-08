namespace AssignmentAdvancedC__04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>()
            {
             new Book
                    (iSBN: "ISBN1",
                    title: "Book1",
                    authors: new string[] { "Hazem", "Hazem2" },
                    publicationDate: new DateTime(2003, 11, 2),
                    price: 200m ),

             new Book
                    (iSBN: "ISBN2",
                    title: "Book2",
                    authors: new string[] { "Mahmoud", "Mahmoud2" },
                    publicationDate: new DateTime(2001, 9, 3),
                    price: 250m),

             new Book
                    (iSBN: "ISBN3",
                    title: "Book3",
                    authors: new string[] { "Alaa", "Alaa2" },
                    publicationDate: new DateTime(2009, 3, 7),
                    price: 300m)
            };


            #region a. User Defined Delegate Datatype
            //Console.WriteLine("--------------Titles--------------");
            //LibraryEngine.ProcessBooksUserDefined(books, BookFunctions.GetTitle);
            //Console.WriteLine("--------------Prices--------------");
            //LibraryEngine.ProcessBooksUserDefined(books, BookFunctions.GetPrice);
            //Console.WriteLine("--------------Authors--------------");
            //LibraryEngine.ProcessBooksUserDefined(books, BookFunctions.GetAuthors);
            #endregion

            #region b. BCL Delegates
            Console.WriteLine("--------------Titles--------------");
            LibraryEngine.ProcessBooksFunC(books, BookFunctions.GetTitle);
            Console.WriteLine("--------------Prices--------------");
            LibraryEngine.ProcessBooksFunC(books, BookFunctions.GetPrice);
            Console.WriteLine("--------------Authors--------------");
            LibraryEngine.ProcessBooksFunC(books, BookFunctions.GetAuthors);
            #endregion

            #region c. Anonymous Method (GetISBN)
            var Result = delegate (Book b)
            {
                return b.ISBN;
            };
            Console.WriteLine("--------------ISBNs--------------");
            LibraryEngine.ProcessBooksFunC(books, Result);

                                        
            #endregion


            #region d. Lambda Expression (GetPublicationDate)
            Console.WriteLine("--------------Publication Date--------------");
            Func<Book, string> publicationDate = b => b.PublicationDate.ToString();
            LibraryEngine.ProcessBooksFunC(books, publicationDate);
            #endregion






        }
    }
}
