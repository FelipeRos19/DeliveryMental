using DeliveryMental.Domain.Models.AppointmentAggregate;
using DeliveryMental.Domain.Models.PatientAggregate;
using DeliveryMental.Domain.Models.PsicologistAggregate;
using DeliveryMental.Domain.Models.TagsAggregate;
using DeliveryMental.Infrastructure.Repositories;

namespace DeliveryMental
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddTransient<IAppointmentRepository, AppointmentRepository>();

            builder.Services.AddTransient<IPatientRepository, PatientRepository>();

            builder.Services.AddTransient<IPsicologistRepository, PsicologistRepository>();

            builder.Services.AddTransient<ITagsRepository, TagsRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");

            app.MapRazorPages();

            app.Run();
        }
    }
}