using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.DataRepository
{
    public class RecordRepository : EFRepository<Record>, IRecordRepository
    {
        public RecordRepository( AppDbContext context ) : base(context) { }
    }
}
