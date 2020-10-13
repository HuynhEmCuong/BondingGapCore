using BondingGapAPI.Application.Interfaces;
using BondingGapAPI.Application.ViewModels;
using BondingGapAPI.Data.IRepository.IRepositoryData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BondingGapAPI.Application.Implementation
{
    public class SettingHourlyLabelService : ISettingHourlyLabelService
    {
        private ISettingHourlyLabelRepository _setingHourly;
        public SettingHourlyLabelService(ISettingHourlyLabelRepository setingHourly)
        {
            _setingHourly = setingHourly;
        }


        // Lấy khung giờ cho thời gian hiện tại
        public async Task<SettingHourlyLableViewModel> GetSettingHourly()
        {
            DateTime startTime, endTime;
            DateTime timeNow = DateTime.Now;
            SettingHourlyLableViewModel data = new SettingHourlyLableViewModel();
            var listSettingHourl = await _setingHourly.FindAll().ToListAsync();
            foreach (var item in listSettingHourl)
            {
                startTime = new DateTime(timeNow.Year, timeNow.Month, timeNow.Day, Convert.ToInt32(item.Start_Hour), Convert.ToInt32(item.Start_Minute), Convert.ToInt32(item.Start_Minute));
                endTime = new DateTime(timeNow.Year, timeNow.Month, timeNow.Day, Convert.ToInt32(item.End_Hour), Convert.ToInt32(item.End_Minute), Convert.ToInt32(item.End_Minute));

                if (timeNow.Subtract(startTime) > TimeSpan.Zero && endTime.Subtract(timeNow) > TimeSpan.Zero)
                {
                    

                    data.start = startTime;
                    data.end = endTime;
                    data.label = Convert.ToInt32(item.Hourly_Label);
                }
            }
            return data;
        }
    }
}
