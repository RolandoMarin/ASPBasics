using System.ComponentModel.DataAnnotations;

namespace ASPBasics.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string  Professor{ get; set; }
        public DateTime Time { get; set; }
    }
}
