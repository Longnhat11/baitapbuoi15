using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookManager
{
    public class EbookDbcontext:DbContext
    {
            public DbSet<Book> Books { get; set; }
    }
}