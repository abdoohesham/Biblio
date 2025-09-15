using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Borrowing
{
    public int ID { get; set; }   // PK

    [ForeignKey("Book")]
    public int BookID { get; set; }   // FK => Book table
    //public Book Book { get; set; }

    [ForeignKey("Visitor")]
    public int VisitorID { get; set; }   // FK => Visitor table
    //public Visitor Visitor { get; set; }

    public double? FineAmount { get; set; }

    public DateTime BorrowDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public BorrowingStatus Status { get; set; }
}

public enum BorrowingStatus
{
    Borrowed,
    Returned,
    Overdue
}
