using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.DataRepository
{
    public class SettingHourlyLabelRepository : EFRepository<Setting_HourlyLabel>, ISettingHourlyLabelRepository
    {
        public SettingHourlyLabelRepository(AppDbContext context) : base(context) { }
    }
}
