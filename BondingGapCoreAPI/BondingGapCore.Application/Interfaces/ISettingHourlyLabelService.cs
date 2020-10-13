using BondingGapAPI.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BondingGapAPI.Application.Interfaces
{
    public interface ISettingHourlyLabelService
    {
        Task<SettingHourlyLableViewModel> GetSettingHourly();
    }
}
