using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFABooks.DateAccessObjectLayer;
using MFABooks.PocosLayer;
using System.Data;


namespace MFABooks.BusinessLogicLayer
{
    class BooksBLL
    {
        private BooksDAO _booksDAO;

        public BooksBLL()
        {
            _booksDAO = new BooksDAO();
        }
        public BooksPOCO bookRegister(string bookID, string authorName, string nameOfBook, int pageCount, string typeOfBook)
        {

            BooksPOCO registerBook = new BooksPOCO();
            DataTable dataTable = new DataTable();

            _booksDAO.insertBooks(bookID, authorName, nameOfBook, pageCount, typeOfBook);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = registerBook.bookID;
                dr["author"] = registerBook.authorName;
                dr["nameOfBook"] = registerBook.nameOfBook;
                dr["pageCounts"] = registerBook.pageCount;
                dr["typeOfBook"] = registerBook.typeOfBook;
            }

            return registerBook;
        }

        public BooksPOCO bookUpdate(string bookID, string authorName, string nameOfBook, int pageCount, string typeOfBook)
        {

            BooksPOCO updateBook = new BooksPOCO();
            DataTable dataTable = new DataTable();

            _booksDAO.updateBooks(bookID, authorName, nameOfBook, pageCount, typeOfBook);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = updateBook.bookID;
                dr["author"] = updateBook.authorName;
                dr["nameOfBook"] = updateBook.nameOfBook;
                dr["pageCounts"] = updateBook.pageCount;
                dr["typeOfBook"] = updateBook.typeOfBook;
            }

            return updateBook;
        }


        public BooksPOCO deleteBook(string bookID)
        {

            BooksPOCO bookDelete = new BooksPOCO();
            DataTable dataTable = new DataTable();

            _booksDAO.deleteBook(Convert.ToString(bookID));

            return bookDelete;


        }

    }



}
