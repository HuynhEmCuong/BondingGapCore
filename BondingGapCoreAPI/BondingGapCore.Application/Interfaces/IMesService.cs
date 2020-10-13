using BondingGapAPI.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BondingGapAPI.Application.Interfaces
{
   public interface IMesService
    {
        Task<object> GetAllLine();

        Task<List<string>> GetAllArticle(string cellSelected);

        Task<object> GetModelArticleDetail(string colorNo);

        void CollectNeedPreparingDatta(NeedPrepaingDataDto needPrepaing);
    }
}
