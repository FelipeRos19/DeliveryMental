using DeliveryMental.Domain.Models.AppointmentAggregate;
using DeliveryMental.Domain.Models.PatientAggregate;
using DeliveryMental.Domain.Models.PsicologistAggregate;
using DeliveryMental.Domain.Models.TagsAggregate;
using Microsoft.EntityFrameworkCore;

namespace DeliveryMental.Data
{
    public class ConnectionContext : DbContext
    {
        public DbSet<AppointmentViewModel> Appointment { get; set; } = default!;

        public DbSet<PatientViewModel> Patient { get; set; } = default!;

        public DbSet<PsicologistViewModel> Psicologist { get; set; } = default!;

        public DbSet<TagsViewModel> Tags { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("");
        }

        public ConnectionContext(){ }
    }
}
