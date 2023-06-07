namespace DeliveryMental.Domain.Models.PatientAggregate
{
    public class PatientViewModel
    {

        //TODO: Revisar o Tipo que deve ser utilizado para o ID (Alterado de String para Long)
        public long Id { get; set; }

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
