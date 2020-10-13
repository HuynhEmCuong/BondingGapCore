using bondinggapmonitoringsystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BondingGapCore.Data.EF
{
    public partial class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Record> Record { get; set; }
        public DbSet<RecordDetail> RecordDetail { get; set; }
        public DbSet<HourlyRecord> HourlyRecord { get; set; }
        public DbSet<HourlyRecordInDetail> HourlyRecordInDetail { get; set; }
        public DbSet<Setting_Article_DateTime_Range> Setting_Article_DateTime_Range { get; set; }
        public DbSet<Setting_Count_Total_Pairs_Time_Range> Setting_Count_Total_Pairs_Time_Range { get; set; }
        public DbSet<Setting_HourlyLabel> Setting_HourlyLabel { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Setting_Defect_Reason> Setting_Defect_Reason { get; set; }
        public DbSet<Setting_MappingLineID> Setting_MappingLineID { get; set; }


    }
}
