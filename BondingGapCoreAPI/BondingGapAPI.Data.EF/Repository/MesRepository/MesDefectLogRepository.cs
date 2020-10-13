using BondingGapAPI.Data.IRepository.IRepositoryMes;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.MesRepository
{
    public class MesDefectLogRepository : EFRepositoryMes<MesDefectLog>, IMesDefectLogRepository
    {
        public MesDefectLogRepository(AppDbMesContext context) : base(context)
        {

        }
    }
}
