using System.ComponentModel.DataAnnotations;

namespace CPW219_MVC_Core_CRUD_WithBugs.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [StringLength(25)]
        public required string FirstName { get; set; }

        [StringLength(30)]
        public required string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }
    }
}
