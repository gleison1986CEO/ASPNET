using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste_.Models;

namespace teste_.Models
{
    public class BancoDB : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //ACESSO WEB //optionsBuilder.UseSqlServer(connectionString: @"Data Source = dbdev9.curitiba.pr.gov.br\dev2014; Initial Catalog = provacandidato; User ID = provacandidato; Password = desenvolvimento");
            //ACESSO LOCALHOST
            optionsBuilder.UseSqlServer(connectionString: "Data Source=DELL-1\\SQLEXPRESS;Initial Catalog = provacandidato; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
