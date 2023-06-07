namespace DeliveryMental.Domain.Models.PatientAggregate
{
    public interface IPatientRepository
    {

        Task Add(PatientViewModel patient);

        Task<PatientViewModel?> Get(long id);

        Task<List<PatientViewModel>> GetAll(int pageNumber, int pageSize);

        Task<bool> Put(long id, PatientViewModel patient);

        Task Delete(long id);
    }
}
