using System.Collections.Generic;

namespace PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Models
{
    // This class represents a user 
    public class User
    {
        // Name of the user; it is nullable
        public string? Name { get; set; }

        // A list that stores all the books borrowed by the user
        // It's initialized with an empty list to avoid null reference errors
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }
}
