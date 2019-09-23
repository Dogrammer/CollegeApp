namespace College.Model.Models
{
    public class City : BaseModel
    {
        public string Name { get; set; }
        public string Zip { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
}