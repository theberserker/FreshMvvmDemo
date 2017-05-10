namespace FreshMvvmDemo.Models
{
    public class Participant
    {
        public Participant(int id, string name, string companyName)
        {
            Id = id;
            Name = name;
            CompanyName = companyName;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string CompanyName { get; set; }
    }
}
