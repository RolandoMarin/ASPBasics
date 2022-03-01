using System.ComponentModel.DataAnnotations;

namespace ASPBasics.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string  Professor{ get; set; }
        [Required]
        public string Description { get; set; }
        
        public DateTime Time { get; set; }

        
    }
}
