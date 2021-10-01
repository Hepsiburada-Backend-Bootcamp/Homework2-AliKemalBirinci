using AutoMapper.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CampaignApi.Models.Context
{
    public class DapperContext : DbContext
    {
        public DapperContext() { }
        public DapperContext(DbContextOptions<DapperContext> options) : base(options) { }
    }
}
