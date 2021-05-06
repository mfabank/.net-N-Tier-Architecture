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
    
    class BooksDetailsBLL
    {
        private BooksDetailsDAO _booksDetailsDAO;

        public BooksDetailsBLL() {
            _booksDetailsDAO = new BooksDetailsDAO();
        }

        public BooksDetailsPOCO bookDetailRegister(string booksDetailsID, string authorName, string bookDetails)
        {

            BooksDetailsPOCO detailsBookRegister = new BooksDetailsPOCO();
            DataTable dataTable = new DataTable();

            _booksDetailsDAO.insertBooksDetails(booksDetailsID, authorName, bookDetails);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = detailsBookRegister.detailID;
                dr["authorName"] = detailsBookRegister.authorName;
                dr["bookDetails"] = detailsBookRegister.bookDetails;

            }

            return detailsBookRegister;
        }

        public BooksDetailsPOCO bookDetailUpdate(string booksDetailsID, string authorName, string bookDetails)
        {

            BooksDetailsPOCO detailsBookUpdate = new BooksDetailsPOCO();
            DataTable dataTable = new DataTable();

            _booksDetailsDAO.updateBooksDetails(booksDetailsID, authorName, bookDetails);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = detailsBookUpdate.detailID;
                dr["authorName"] = detailsBookUpdate.authorName;
                dr["bookDetails"] = detailsBookUpdate.bookDetails;

            }

            return detailsBookUpdate;
        }

        public BooksDetailsPOCO deleteBook(string bookDetailsID)
        {

            BooksDetailsPOCO bookDetailsDelete = new BooksDetailsPOCO();
            DataTable dataTable = new DataTable();

            _booksDetailsDAO.deleteBookDetails(Convert.ToString(bookDetailsID));

            return bookDetailsDelete;


        }

    }


}
