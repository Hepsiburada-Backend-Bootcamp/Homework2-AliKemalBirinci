using CampaignApi.Models.Dtos;
using CampaignApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampaignApi.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDto>> GetAllAsync();
        public Task<ProductDto> GetByIdAsync(int id);
    }
}
