using BondingGapAPI.Data.IRepository;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.MesRepository
{
    public class MesLineRepository : EFRepositoryMes<MesLine>, IMesLineRepository
    {
        public MesLineRepository(AppDbMesContext context) : base(context)
        {

        }
    }
}
