using System;

namespace PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Models
{
    public class Book
    {
        public string? Title { get; set; }            
        public Author? Author { get; set; }           
        public User? BorrowedBy { get; set; }         
        public DateTime? DateLastReturned { get; set; }
        public Genre Genre { get; set; }

        public bool IsAvailable => BorrowedBy == null;
    }

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
