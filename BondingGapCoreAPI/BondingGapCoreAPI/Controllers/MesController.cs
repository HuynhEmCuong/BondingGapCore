using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BondingGapAPI.Application.Dtos;
using BondingGapAPI.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BondingGapCoreAPI.Controllers
{
    public class MesController : ApiController
    {
        private IMesService _mesService;
        private ISettingHourlyLabelService _settingHourlyService;

        public MesController(IMesService mesService , ISettingHourlyLabelService settingHourlyService)
        {
            _mesService = mesService;
            _settingHourlyService = settingHourlyService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllLine()
        {
            var data = await _mesService.GetAllLine();
            return new OkObjectResult(data);
        }

        [HttpGet("GetArticle")]
        public async Task<ActionResult> GetAllArticle(string cellSelected)
        {
            var data = await _mesService.GetAllArticle(cellSelected);
            return new OkObjectResult(data);
        }

        [HttpGet("GetModel")]
        public async Task<ActionResult> GetModelArticleDetail(string colorNo)
        {
            var data = await _mesService.GetModelArticleDetail(colorNo);
            return new OkObjectResult(data);
        }


        [HttpPost]
        public  ActionResult NeedPearingData([FromBody] NeedPrepaingDataDto model)
        {
             _mesService.CollectNeedPreparingDatta(model);
            return Ok();
        }

    }
}