using BondingGapAPI.Data.IRepository;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.DataRepository
{
    public class HourlyRecordRepository : EFRepository<HourlyRecord>, IHourlyRecordRepository
    {
        public HourlyRecordRepository(AppDbContext context) : base(context) { }
    }
}
