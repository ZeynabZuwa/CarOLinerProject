using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Services.Features.Seeding
{
    public interface ISeedService
    {
        Task SeedDatabaseAsync();
    }
}
