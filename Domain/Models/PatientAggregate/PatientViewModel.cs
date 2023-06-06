namespace DeliveryMental.Domain.Models.PatientAggregate
{
    public class PatientViewModel
    {

        public string LongId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public string ProfileImage { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public PatientViewModel() { }

    }
}
