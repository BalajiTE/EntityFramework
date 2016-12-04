using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class FluentStudentAddress
    {
        public int ID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        //[Key, ForeignKey("FluentStudent")] // For One-to-Zero Relationship
        //[Key] // -- For One-to-One Relationship
        public int FluentStudentId { get; set; }
        public virtual FluentStudent FluentStudent { get; set; }
    }
}