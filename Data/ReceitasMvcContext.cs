using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReceitasMvc.Models;

namespace ReceitasMvc.Data
{
    public class ReceitasMvcContext : DbContext
    {
        public ReceitasMvcContext (DbContextOptions<ReceitasMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ReceitasMvc.Models.Receita> Receita { get; set; }
    }
}
