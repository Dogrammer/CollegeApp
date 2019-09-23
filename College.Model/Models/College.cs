namespace College.Model.Models
{
    public class CollegeInstitution : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }  

    }
}