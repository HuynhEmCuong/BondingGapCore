using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.DataRepository
{
    public class SettingDefectReasonRepository:EFRepository<Setting_Defect_Reason>, ISettingDefectReasonRepository
    {
        public SettingDefectReasonRepository(AppDbContext context):base(context) { }
    }
}
