using bondinggapmonitoringsystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BondingGapCore.Data.EF
{
    public partial class AppDbMesContext : DbContext
    {
        public AppDbMesContext(DbContextOptions<AppDbMesContext> options) : base(options)
        {

        }
        public virtual DbSet<MesDept> MesDept { get; set; }
        public virtual DbSet<MesMo> MesMo { get; set; }
        public virtual DbSet<MesOrg> MesOrg { get; set; }
        public virtual DbSet<MesYieldLog> MesYieldLog { get; set; }
        public virtual DbSet<MesDefectLog> MesDefectLog { get; set; }

        public virtual DbSet<MesLine> MesLine { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MesLine>().HasKey(e => new { e.Factory_ID, e.Line_ID });
            modelBuilder.Entity<MesLine>().Property(e => e.Factory_ID).IsUnicode(false);

            modelBuilder.Entity<MesDept>().HasKey(e => new { e.Dept_Id, e.Factory_Id });
            modelBuilder.Entity<MesMo>().HasKey(e => new { e.Cycle_No, e.Factory_Id });
            modelBuilder.Entity<MesOrg>().HasNoKey();
            modelBuilder.Entity<MesYieldLog>().HasNoKey();
        }
       
    }
}
