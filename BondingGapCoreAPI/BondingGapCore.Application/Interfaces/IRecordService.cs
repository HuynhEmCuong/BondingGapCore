using BondingGapAPI.Application.Dtos;
using BondingGapAPI.Application.ViewModels;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Application.Interfaces
{
    public interface IRecordService
    {
        void AddRecord(RecordDto model);
    }
}
