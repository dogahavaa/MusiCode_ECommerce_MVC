using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MusiCodeWebApp.Models
{
    public partial class MusiCodeDbModel : DbContext
    {
        public MusiCodeDbModel()
            : base("name=MusiCodeDbModel")
        {
        }

        public DbSet<ManagerRole> ManagerRoles { get; set; }
        public DbSet<Manager> Managers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
