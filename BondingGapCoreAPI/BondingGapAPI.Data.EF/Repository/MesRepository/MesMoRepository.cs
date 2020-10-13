using BondingGapAPI.Data.IRepository;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository.MesRepository
{
  public  class MesMoRepository:EFRepositoryMes<MesMo>,IMesMoRepository
    {
        public MesMoRepository (AppDbMesContext context ) :base(context)
        {

        }
    }
}
