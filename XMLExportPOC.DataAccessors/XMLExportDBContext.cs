using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLExportPOC.DataAccessors.DataModels;

namespace XMLExportPOC.DataAccessors
{
    public class XmlExportDbContext : DbContext
    {

        public XmlExportDbContext()
            : base("name=XMLExportPOCDbContext") { }

        public virtual DbSet<Agent> Agent { get; set; }

        public virtual DbSet<Carrier> Carrier { get; set; }

        public virtual DbSet<Holding> Holding { get; set; }

        public virtual DbSet<Organization> Organization { get; set; }

        public virtual DbSet<Party> Party { get; set; }

        public virtual DbSet<Person> Person { get; set; }

        public virtual DbSet<Producer> Producer { get; set; }

        public virtual DbSet<TXLifeRequest> TXLifeRequest { get; set; }


    }
}
