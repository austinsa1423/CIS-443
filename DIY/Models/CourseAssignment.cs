
namespace Diy.Models
{
    public class CourseAssignment
    {
        public int CourseAssignmentID { get; set; }
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
