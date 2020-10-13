using AutoMapper;
using BondingGapAPI.Application.Dtos;
using BondingGapAPI.Application.Interfaces;
using BondingGapAPI.Application.ViewModels;
using BondingGapAPI.Data.IRepository;
using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapAPI.Data.IRepository.IRepositoryMes;
using BondingGapAPI.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BondingGapAPI.Application.Implementation
{
    public class MesService : IMesService
    {
        //private IMapper _mapper;
        //private MapperConfiguration _configMapper;
        private IMesLineRepository _mesLineRepository;
        private IMesOrgRepository _mesOrgRepository;
        private IMesDeptRepository _mesDeptRepository;
        private ISettingArticleDateTimeRangeRepository _iSettingTimeRepository;
        private IMesMoRepository _mesMoRepository;
     
        private IRecordService _iRecordService;
        private IRecordDetailService _iRecordDetailService;

        public MesService(IMesLineRepository meslineRepository, IMesOrgRepository mesOrgRepository, IMesDeptRepository mesDeptRepository, ISettingArticleDateTimeRangeRepository iSettingTimeRepository, IMesMoRepository mesMoRepository, IRecordService iRecordService, IRecordDetailService iRecordDetailService)
        {
            _mesLineRepository = meslineRepository;
            _mesDeptRepository = mesDeptRepository;
            _mesOrgRepository = mesOrgRepository;
            _iSettingTimeRepository = iSettingTimeRepository;
            _mesMoRepository = mesMoRepository;
            _iRecordService = iRecordService;
            _iRecordDetailService = iRecordDetailService;
        }

        public async Task<object> GetAllLine()
        {
            var queryMesline = _mesLineRepository.FindAll();
            var queryMesDept = _mesDeptRepository.FindAll();
            var queryMesOrg = _mesOrgRepository.FindAll();

            var data = await (queryMesOrg.Join(queryMesDept, x => x.Dept_Id, y => y.Dept_Id, (x, y) => new
            {
                x.Line_Id,
                y.Dept_Id,
                y.Work_Center
            }).Where(y => y.Work_Center == "5").Join(queryMesline, z => z.Line_Id, l => l.Line_ID, (z, l) => new
            {
                LineName = z.Line_Id
            })).OrderBy(z => z.LineName).ToListAsync();

            return data;
        }

        public async Task<List<string>> GetAllArticle(string cellSelected)
        {
            var settingArticle = await _iSettingTimeRepository.FindAll().ToListAsync();

            var after7day = DateTime.Now.AddDays(Convert.ToInt32(settingArticle.LastOrDefault().After_3_Days)).Date;
            var before7day = DateTime.Now.AddDays(Convert.ToInt32(settingArticle.LastOrDefault().Before_3_Days)).Date;

            var listArtcile = await  _mesMoRepository.FindAll().Select(x => x.Color_No.Trim()).Distinct().ToListAsync();

            return listArtcile;
        }

        public async Task<object> GetModelArticleDetail(string colorNo)
        {
            var settingArticle = await _iSettingTimeRepository.FindAll().ToListAsync();
            var after7days = DateTime.Now.AddDays(Convert.ToInt32(settingArticle.LastOrDefault().After_3_Days)).Date;
            var before7days = DateTime.Now.AddDays(Convert.ToInt32(settingArticle.LastOrDefault().Before_3_Days)).Date;

            var data = await _mesMoRepository.FindAll(x => x.Color_No == colorNo)
                .Select(x => new
                {
                    styleName = x.Style_Name.Trim(),
                    styleNo = x.Style_No.Trim()
                }).FirstOrDefaultAsync();

            return data;
        }


        public void CollectNeedPreparingDatta(NeedPrepaingDataDto needPrepaing)
        {
            _iRecordService.AddRecord(needPrepaing.RecordDto);
            //_iRecordDetailService.AddListRecord(needPrepaing.RecordDetail,needPrepaing.ColorL,needPrepaing.ColorR);
        }


    }
}
