using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Chirica_Demetra_Bianca_Rp.Models;

namespace Asp_Chirica_Demetra_Bianca_Rp.Data
{
    public class Asp_Chirica_Demetra_Bianca_RpContext : DbContext
    {
        public Asp_Chirica_Demetra_Bianca_RpContext (DbContextOptions<Asp_Chirica_Demetra_Bianca_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Chirica_Demetra_Bianca_Rp.Models.Movie> Movie { get; set; }
    }
}
