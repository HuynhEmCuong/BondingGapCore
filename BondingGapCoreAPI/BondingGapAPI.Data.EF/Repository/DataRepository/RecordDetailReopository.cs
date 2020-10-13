using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.DataRepository
{
    public class RecordDetailReopository : EFRepository<RecordDetail>, IRecordDetailRepository
    {
        public RecordDetailReopository(AppDbContext context) : base(context)
        {

        }
    }
}
