namespace College.Model.Models
{
    public class Division : BaseModel
    {
        public string Name { get; set; }
        public int CollegeInstitutionId { get; set; }
        public CollegeInstitution CollegeInstitution { get; set; }
    }
}