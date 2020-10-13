using BondingGapAPI.Application.Dtos;
using BondingGapAPI.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Application.Interfaces
{
    public interface IRecordDetailService
    {
        void AddListRecord(List<Reason> model, string colorL, string colorR);
    }
}
