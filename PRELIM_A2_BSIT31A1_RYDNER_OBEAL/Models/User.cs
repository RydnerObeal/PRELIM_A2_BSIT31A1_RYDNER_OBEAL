using System.Collections.Generic;

namespace PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Models
{
    public class User
    {
        public string? Name { get; set; }

        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }
}
