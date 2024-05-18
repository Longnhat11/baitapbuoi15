using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManager.Controllers
{
    public class BookController: Controller
    {
        private EbookDbcontext db = new EbookDbcontext();

        // Hiển thị danh sách sách
        public ActionResult Index()
        {
            var books = db.Books.ToList();
            return View(books);
        }
        public ActionResult AddNewBook()
        {
            return View();
        }
        // Thêm sách mới
        [HttpPost]
        // POST: Book/AddNewBook
        [ValidateAntiForgeryToken]
        public ActionResult AddNewBook(Book book)
        {
            if (book == null)
            {
                return RedirectToAction("lỗi dữ liệu không hợp lệ!");
            }
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("thêm sách thành công!");
            }
            return View(book);
        }
    }
}