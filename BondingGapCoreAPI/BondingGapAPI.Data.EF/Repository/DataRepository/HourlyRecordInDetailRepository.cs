using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.DataRepository
{
    public class HourlyRecordInDetailRepository : EFRepository<HourlyRecordInDetail>, IHourlyRecordInDetailRepository
    {
        public HourlyRecordInDetailRepository(AppDbContext context) : base(context) { }
    }
}
