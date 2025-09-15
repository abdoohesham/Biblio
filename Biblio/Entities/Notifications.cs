using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Notification
{
    public int NotificationID { get; set; }   // PK

    
    [ForeignKey("Visitor")]
    public int VisitorID { get; set; }   // FK => Visitor table
    //public Visitor Visitor { get; set; }

    public string Message { get; set; }

    public DateTime Date { get; set; }

    public NotificationStatus Status { get; set; }
    public NotificationType Type { get; set; }
}

public enum NotificationType
{
    Reminder,
    Overdue,
    General
}
public enum NotificationStatus
{
    Unread,
    Read
}
