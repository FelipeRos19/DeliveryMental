using DeliveryMental.Data;
using DeliveryMental.Domain.Models.PatientAggregate;
using Microsoft.AspNet.Identity;
using System.Data.Entity;

namespace DeliveryMental.Infrastructure.Repositories
{
    //TODO: trabalhar as exceptions
    public class PatientRepository : IPatientRepository
    {
        private readonly ConnectionContext connection = new();

        public async Task Add(PatientViewModel patient) 
        {
            try 
            { 
                await connection.Patient.AddAsync(patient);
                await connection.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PatientViewModel?> Get(long id) 
        {
            if (id <= 0) throw new Exception("deu algum erro!");

            try {
                return await connection.Patient.FindAsync(id) ?? throw new Exception("deu algum erro!");
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public async Task<List<PatientViewModel>> GetAll(int pageNumber, int pageSise)
        {
            if (pageNumber <= 0) throw new Exception("O número de páginas não pode ser menor ou igual a zero!");
            if (pageSise <= 0) throw new Exception("O número de itens por página não pode ser menor ou igual a zero!");

            try
            {
                return await connection.Patient
                    .Skip((pageNumber -1) * pageSise)
                    .Take(pageSise)
                    .ToListAsync();
            } 
            catch (Exception ex) 
            { 
                throw new Exception(ex.Message);
            }
        }

        //TODO: REVISAR REGRAS DE NEGÓCIO!
        public async Task<bool> Put(long id, PatientViewModel patient) 
        {
            if (id <= 0) throw new Exception("");

            try
            {
                var existingPatient = await connection.Patient.FirstOrDefaultAsync(p => p.Id == id) ?? throw new Exception("deu algum erro!");

                if (existingPatient != null)
                {
                    //TODO: ADICIONAR OS CAMPOS DO UPDATE!
                    var entry = connection.Patient.Update(existingPatient);
                    await connection.SaveChangesAsync();

                    /*
                    var affectedRows = entry.State == EntityState.Modified ? 1 : 0;

                    if (affectedRows == 0)
                        throw new ResourceNotFoundException(id);

                     */
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(long id) 
        {
            if (id <= 0) throw new Exception("deu algum erro!");

            try
            {
                var patient = await connection.Patient.FirstOrDefaultAsync(p => p.Id == id) ?? throw new Exception("deu algum erro!");
                connection.Patient.RemoveRange(patient);
                var affectedRows = await connection.SaveChangesAsync();

                if (affectedRows == 0)
                    throw new Exception("deu algum erro!");
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
