using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Biblio.Entities
{
    public class User
    {
        public int ID { get; set; }   

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserRole Role { get; set; }

        public PlanType PlanType { get; set; }

        // Navigation property => User can have many Collections
        public ICollection<Collection> Collections { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Librarian,
        Reader
    }

    public enum PlanType
    {
        Free,
        Library
    }
}
