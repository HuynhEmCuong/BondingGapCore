using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.DataRepository
{
   public class SettingCountTotalPairsTimeRange :EFRepository<Setting_Count_Total_Pairs_Time_Range> , ISettingCountTotalPairsTimeRange
    {
        public SettingCountTotalPairsTimeRange(AppDbContext context ):base(context) { }
    }
}
