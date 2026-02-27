using System.Linq;
using FinERP.Data;
using FinERP.Models;

public static class DataSeeder
{
    public static void SeedUsers(AppDbContext context)
    {
        if (!context.Users.Any(u => u.Email == "admin@erp.com"))
        {
            var user = new User
            {
                Email = "admin@erp.com",
                PasswordHash = "", // temporary 
                Role = "Admin"
            };

            var passwordService = new PasswordService();
            user.PasswordHash = passwordService.HashPassword(user, "password");

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}