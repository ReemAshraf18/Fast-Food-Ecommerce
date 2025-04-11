using Azure.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reository
{
    public class DbInitializer : IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDBContext _dBContext;
        public DbInitializer(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager,
            ApplicationDBContext dBContext)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _dBContext = dBContext;
        }
        public void Initialize()
        {
            try
            {
                if (_dBContext.Database.GetPendingMigrations().Count() > 0)
                {
                    _dBContext.Database.Migrate();
                }
            }
            catch
            {
                throw;
            }
            if (_roleManager.Roles.Any(x => x.Name == "Manager")) return;
            _roleManager.CreateAsync(new IdentityRole("Manager")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Customer")).GetAwaiter().GetResult();

            AppUser User = new AppUser
            {
                Id = "1",
                Name = "Admin",
                Email = "admin@gmail.com",

                UserName = "admin@gmail.com",
                City = "Aswan",
                Address = "Elmatar",
                PostalCode = "12345"
            };
            _userManager.CreateAsync(User).GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(User.Id, "Admin").GetAwaiter().GetResult(); 
            
        }

    }
}
