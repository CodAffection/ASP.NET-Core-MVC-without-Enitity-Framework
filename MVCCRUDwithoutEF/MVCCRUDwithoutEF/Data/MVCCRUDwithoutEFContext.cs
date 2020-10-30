using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCRUDwithoutEF.Models;

namespace MVCCRUDwithoutEF.Data
{
    public class MVCCRUDwithoutEFContext : DbContext
    {
        public MVCCRUDwithoutEFContext (DbContextOptions<MVCCRUDwithoutEFContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCRUDwithoutEF.Models.BookViewModel> BookViewModel { get; set; }
    }
}
