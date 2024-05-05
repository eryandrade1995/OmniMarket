using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OmniMarket.Infrastructure.Persistence
{
    public class OmniMarketDbContext : DbContext
    {
        public OmniMarketDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}