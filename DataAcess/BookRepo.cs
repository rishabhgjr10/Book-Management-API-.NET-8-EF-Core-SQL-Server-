using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class BookRepo : IBookRepo
    {
        //private BookDbContext _dbContext;

        private readonly BookDbContext _dbContext;

        public BookRepo(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddBook(BookDetail bookDetail)
        {
            if (bookDetail == null) return false;

            try
            {
                _dbContext.Books.Add(bookDetail);
                _dbContext.SaveChanges();
                return true;

            }
            catch {
                return false;
            }
        }

        public bool DeleteBook(int id)
        {
            BookDetail bookDetail = _dbContext.Books.Find(id);
            if (bookDetail == null) return false;
            try
            {                
                _dbContext.Books.Remove(bookDetail);
                _dbContext.SaveChanges();
                return true;
            }
            catch { 
                return false;
            }
            
        }

        public List<BookDetail> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public BookDetail GetBookDetail(int id)
        {
            BookDetail bookDetail = null; 

            try
            {
                bookDetail = _dbContext.Books.Find(id);
            }
            catch {
                return null;
            }
            return bookDetail;
        }


        public bool UpdateBook(BookDetail bookDetailInfo)
        {
            BookDetail bookDetail1 = _dbContext.Books.Find(bookDetailInfo.ID);
            if (bookDetail1 == null) return false;

            try
            {
                bookDetail1.BookName=bookDetailInfo.BookName;
                bookDetail1.Genre=bookDetailInfo.Genre;
                bookDetail1.Availability=bookDetailInfo.Availability;
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
