namespace College.Model.Models
{
    public class Executor : BaseModel
    {
        public string Description { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}