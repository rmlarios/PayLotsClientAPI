using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    public partial class PayLotsDBContext : IdentityDbContext<AppUser>
    {
        public PayLotsDBContext()
        {
        }

        public PayLotsDBContext(DbContextOptions<PayLotsDBContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=MEM-INFO-10\\LOCALSQL2016;Database=PayLots;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
        }

       
    }
}
