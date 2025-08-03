using System;

namespace PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Models
{
    // Represents a single book in the library
    public class Book
    {
        // The title of the book (nullable in case it's missing)
        public string? Title { get; set; }

        // The author of the book, represented by an Author object (nullable)
        public Author? Author { get; set; }

        // The user who borrowed the book; if null, the book is available
        public User? BorrowedBy { get; set; }

        // The date when the book was last returned to the library (nullable)
        public DateTime? DateLastReturned { get; set; }

        // The genre or category the book belongs to (required, not nullable)
        public Genre Genre { get; set; }

        // Computed property that returns true if the book is not borrowed (i.e., available)
        public bool IsAvailable => BorrowedBy == null;
    }

    // Enum that defines possible genres/categories a book can have
    public enum Genre
    {
        Fiction,      
        NonFiction,    
        Mystery,      
        Fantasy,      
        Biography,     
        Science,       
        Romance,       
        Horror,        
        Comedy,        
        Action         
    }
}
