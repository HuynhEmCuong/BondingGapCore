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
    public class RecordDetailService : IRecordDetailService
    {
        private IRecordDetailRepository _recordDetailRepository;
        private IMapper _mapper;
        private MapperConfiguration _configMapper;

        public RecordDetailService(IRecordDetailRepository recordDetailRepository, IMapper mapper, MapperConfiguration configMapper)
        {
            _recordDetailRepository = recordDetailRepository;
            _mapper = mapper;
            _configMapper = configMapper;
        }

        public void AddListRecord(List<Reason> model,string colorL, string colorR)
        {
            RecordDetailViewModel recordDetailView = new RecordDetailViewModel();
            List<RecordDetailViewModel> listRecordDetailView = new List<RecordDetailViewModel>();
            foreach (var item in model)
            {
                if (item.R1 != "0" || item.R2 != "0" || item.R3 != "0")
                {
                    recordDetailView.LeftRight =  recordDetailView.Attachment_Color = item.LR.IsNullOrEmpty() == false ? item.LR.Trim():"";
                    //recordDetailView.Attachment_Color = item.LR
                }
            }


            var listRecordDetail = _mapper.Map<List<RecordDetail>>(model);
            _recordDetailRepository.AddMultiple(listRecordDetail);
            _recordDetailRepository.SaveAll();
        }


    }
}
