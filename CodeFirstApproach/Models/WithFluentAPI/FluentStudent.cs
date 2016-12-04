namespace CodeFirstApproach.Models
{
    public class FluentStudent
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual FluentStudentAddress FluentStudentAddress { get; set; }
    }
}