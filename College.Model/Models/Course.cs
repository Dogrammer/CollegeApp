using System.Collections.Generic;

namespace College.Model.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public int DivisionId { get; set; }
        public Division Division { get; set; }
        public ICollection<Executor> Executors { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}