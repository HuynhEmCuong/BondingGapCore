using AutoMapper;
using BondingGapAPI.Application.Dtos;
using BondingGapAPI.Application.Interfaces;
using BondingGapAPI.Application.ViewModels;
using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapAPI.Utilities;
using bondinggapmonitoringsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapAPI.Application.Implementation
{
    public class RecordService : IRecordService
    {
        private IRecordRepository _recordRepository;
        private ISettingHourlyLabelService _iSettingService;
        private IMesService _iMesService;
        private IMapper _mapper;
        private MapperConfiguration _configMapper;
        public RecordService(IRecordRepository recordRepository, ISettingHourlyLabelService iSettingService, IMapper mapper, MapperConfiguration configMapper, IMesService iMesService)
        {
            _recordRepository = recordRepository;
            _iSettingService = iSettingService;
            _iMesService = iMesService;
            _mapper = mapper;
            _configMapper = configMapper;

        }



        public async void AddRecord(RecordDto model)
        {
            //Get timing
            var currenLabel = await _iSettingService.GetSettingHourly();

            RecordViewModel record = new RecordViewModel();
            record.Date_Time = DateTime.Now;
            record.Hourly_Label = "";
            record.Worker_ID_Collect_Data = model.Operator != null ? model.Operator.Trim() : "";
            record.Model_Name = model.Name != null ? model.Name.Trim() : "";
            record.Model_Number = model.Num != null ? model.Num.Trim() : "";
            record.Hourly_Label = currenLabel.label.ToString();
            if (!model.C.IsNullOrEmpty() && !model.A.IsNullOrEmpty())
            {
                record.Prod_Cell = model.C != null ? model.C.Trim() : "";
                record.Article_Number = model.A != null ? model.A.Trim() : "";
                record.Prod_Cell_Main =  _iMesService.GetAllArticle(model.C).Result.Find(x => x.Trim() == model.A) == null ? model.CO : "";
            }
            var recordData = _mapper.Map<Record>(record);
            _recordRepository.Add(recordData);
            await _recordRepository.SaveAll();
        }
    }
}
