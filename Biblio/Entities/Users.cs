using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class User
{
    public int ID { get; set; }   // PK

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public UserRole Role { get; set; }

    public PlanType PlanType { get; set; }

    // Navigation property => A User can have many Borrowings
    public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

    // Navigation property => A User can have many Notifications
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}

public enum UserRole { Admin, Librarian, Reader }
public enum PlanType { Free, Library }
