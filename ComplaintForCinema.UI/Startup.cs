using ComplaintForCinema.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComplaintForCinema.Startup))]
namespace ComplaintForCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoleAndUSers();
        }

        private void CreateRoleAndUSers()
        {
            var context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roles = new string[] { "Employee", "Customer" };

            if (!roleManager.RoleExists("Manager"))
            {
                roleManager.Create(new IdentityRole { Name = "Manager" });
                var adminUser = new ApplicationUser
                {
                    Email = "martinez.jastin@hotmail.com",
                    UserName = "martinez.jastin@hotmail.com",
                };

                var UserCreated = UserManager.Create(adminUser, "Admin00v@*");

                if (UserCreated.Succeeded)
                    UserManager.AddToRole(adminUser.Id, "Manager");
            }

            foreach (var role in roles)
            {
                if (!roleManager.RoleExists(role))
                    roleManager.Create(new IdentityRole { Name = role });
            }


        }
    }
}
