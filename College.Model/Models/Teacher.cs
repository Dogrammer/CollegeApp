namespace College.Model.Models
{
    public class Teacher : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}