using System.Collections.Generic;

namespace College.Model.Models
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int DivisionId { get; set; }
        public Division Division { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}