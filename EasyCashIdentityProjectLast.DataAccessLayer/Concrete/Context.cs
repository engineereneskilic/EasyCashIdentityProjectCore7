using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EasyCashIdentityProjectLast.DataAccessLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EasyCashIdentityProjectLast.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HDU6E5A;initial catalog=EasyCashDB;integrated Security=true;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
      
        public DbSet<CustomerAccount> CustomerAccounts { get; set; } // ismi sql tarafındaki tablo ismi
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }


    }
}
