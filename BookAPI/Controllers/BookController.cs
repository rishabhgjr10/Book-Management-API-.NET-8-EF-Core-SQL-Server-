using DataAcess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private IBookRepo _bookRepo;
        public BookController(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;

        }

        // GET: BookController
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(_bookRepo.GetAllBooks());
        }

        // GET: BookController/Details/5
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            var book = _bookRepo.GetBookDetail(id);
            if (book == null) {
                return NotFound();
            }

            return Ok(book);
        }

        // POST: BookController/Create
        [HttpPost]

        public ActionResult Create([FromBody] BookDetail bookDetail)
        {
            _bookRepo.AddBook(bookDetail);
            return Ok();
        }

        // POST: BookController/Edit
        [HttpPut]
        public ActionResult Edit([FromBody]BookDetail bookDetail)
        {
            _bookRepo.UpdateBook(bookDetail);
            return Ok();


        }

        // POST: BookController/Delete/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_bookRepo.DeleteBook(id));
        }
    }
}
