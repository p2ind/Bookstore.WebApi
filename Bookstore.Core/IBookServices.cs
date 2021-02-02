using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Core
{
    public interface IBookServices
    {
        List<Book> GetBooks();
    }
}
