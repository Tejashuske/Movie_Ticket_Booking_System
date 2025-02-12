using Microsoft.EntityFrameworkCore;
using Movie_Ticket_Booking_System.Models;

namespace Movie_Ticket_Booking_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CinematicketingdbContext>(options =>
                       options.UseSqlServer(builder.Configuration.GetConnectionString("CinematicketingdbContext")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Bookings}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
