using BondingGapAPI.Data.IRepository.IRepositoryMes;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.MesRepository
{
    public class MesOrgRepository :EFRepositoryMes<MesOrg>,IMesOrgRepository
    {
        public MesOrgRepository(AppDbMesContext context) : base(context) { }
    }
}
