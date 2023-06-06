using DeliveryMental.Domain.Models.PatientAggregate;
using DeliveryMental.Domain.Models.PsicologistAggregate;

namespace DeliveryMental.Domain.Models.AppointmentAggregate
{
    public class AppointmentViewModel
    {
        public string LongId { get; set; }

        public string LongIdPat { get; set; }

        public PatientViewModel PatientViewModel { get; set; }

        public string LongIdPsi { get; set; }

        public PsicologistViewModel PsicologistViewModel { get; set; }

        public DateTime? Agenda { get; set; }
    }
}
