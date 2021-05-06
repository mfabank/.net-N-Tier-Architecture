using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFABooks.PocosLayer
{
    class BooksPOCO
    {
        private string _bookID { get; set; }
        private string _authorName { get; set; }
        private string _nameOfBook { get; set; }
        private string _pageCount { get; set; }
        private string _typeOfBook { get; set; }

        public BooksPOCO()
        {

        }

        public string bookID
        {
            get
            {
                return _bookID;
            }

            set
            {
                _bookID = value;
            }
        }
        public string authorName
        {
            get
            {
                return _authorName;
            }

            set
            {
                _authorName = value;
            }
        }
        public string nameOfBook
        {
            get
            {
                return _nameOfBook;
            }

            set
            {
                _nameOfBook = value;
            }
        }

        public string pageCount
        {
            get
            {
                return _pageCount;
            }

            set
            {
                _pageCount = value;
            }
        }

        public string typeOfBook
        {
            get
            {
                return _typeOfBook;
            }

            set
            {
                _typeOfBook = value;
            }
        }


    }
}
