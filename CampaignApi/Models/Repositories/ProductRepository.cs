using CampaignApi.Models.Context;
using CampaignApi.Models.Dtos;
using CampaignApi.Models.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CampaignApi.Models.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private string Connectionstring = "DefaultConnection";
        private readonly IConfiguration _config;

        public ProductRepository(DapperContext context, IConfiguration config) : base(context)
        {
            _config = config;
        }

        public async Task<Product> GetByIdWithDapper(int id)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));

            var query = "SELECT * FROM Products WHERE Id = @Id";

            var product = await db.QuerySingleOrDefaultAsync<Product>(query, new { id });

            return product;

        }
    }
}
