using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public interface IBookRepo
    {
        public bool AddBook(BookDetail bookDetail);
        public bool UpdateBook(BookDetail bookDetailInfo);
        public bool DeleteBook(int id);

        public BookDetail GetBookDetail(int id);

        public List<BookDetail> GetAllBooks();

    }
}
