using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Borrowing
{
    public int ID { get; set; }   // PK

    [ForeignKey("User")]
    public int UserID { get; set; }   // FK → User
    public User User { get; set; }

    [ForeignKey("Book")]
    public int BookID { get; set; }   // FK => Book
    //public Book Book { get; set; }

    public double? FineAmount { get; set; }

    public DateTime BorrowDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public BorrowingStatus Status { get; set; }
}

public enum BorrowingStatus { Borrowed, Returned, Overdue }
