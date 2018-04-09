using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppTb01Lab1_Ighor_Moura.Models
{
    public class WebAppTb01Lab1_Ighor_Moura_automovelContext : DbContext
    {
        public WebAppTb01Lab1_Ighor_Moura_automovelContext (DbContextOptions<WebAppTb01Lab1_Ighor_Moura_automovelContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppTb01Lab1_Ighor_Moura.Models.Automovel> Automovel { get; set; }
    }
}
