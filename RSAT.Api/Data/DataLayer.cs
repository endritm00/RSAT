using Microsoft.EntityFrameworkCore;
using NovusConsulting.Data.Models;

namespace RSAT.Api.Data
{
    public class DataLayer : NovusConsulting.Data.SqlServer.DataLayer
    {
        public DataLayer(DbContext dbContext, ConfigurationModel configuration) : base(dbContext, configuration) { }
    }
}
