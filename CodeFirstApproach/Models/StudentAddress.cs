using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class StudentAddress
    {
        public int ID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        // Creating One-to-One Relationship using annotations
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}