using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculosAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace VeiculosAPI.Data
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions<VeiculoContext> opt) : base(opt)
        { }

        public DbSet<Veiculo> Veiculo { get; set; }
    }
}
