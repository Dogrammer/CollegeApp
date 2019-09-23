namespace College.Model.Models
{
    public class Grade : BaseModel
    {
        public string ExamTime { get; set; }
        public int Mark { get; set; }
        
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}