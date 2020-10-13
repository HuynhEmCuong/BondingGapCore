using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.DataRepository
{
    public class SettingArticleDateTimeRangeRepository : EFRepository<Setting_Article_DateTime_Range>, ISettingArticleDateTimeRangeRepository
    {
        public SettingArticleDateTimeRangeRepository(AppDbContext context) : base(context) { }
    }
}
