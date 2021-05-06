using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFABooks.PocosLayer
{
    class BooksDetailsPOCO
    {
        private string _detailID { get; set; }
        private string _authorName { get; set; }
        private string _bookDetails { get; set; }

        public BooksDetailsPOCO() { }

        public string detailID
        {
            get
            {
                return _detailID;
            }

            set
            {
                _detailID = value;
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

        public string bookDetails
        {
            get
            {
                return _bookDetails;
            }

            set
            {
                _bookDetails = value;
            }
        }

    }

}
