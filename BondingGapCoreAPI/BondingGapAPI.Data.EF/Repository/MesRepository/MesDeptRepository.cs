using BondingGapAPI.Data.IRepository;
using BondingGapCore.Data.EF;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BondingGapAPI.Data.EF.Repository
{
    public class MesDeptRepository : EFRepositoryMes<MesDept>, IMesDeptRepository
    {
        public MesDeptRepository(AppDbMesContext context) : base(context)
        {

        }
    }
}
