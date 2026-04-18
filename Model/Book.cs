using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSession1Task.Model
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public DateTime PublishedYear { get; set; }
    }
}
