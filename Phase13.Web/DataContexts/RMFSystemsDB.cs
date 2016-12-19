using RMF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Phase13.Web.DataContexts
{
    public class RMFSystemsDB : DbContext
    {
        public RMFSystemsDB()
            : base("DefaultConnection")
        {

        }
        public DbSet<RMFSystem> RMFSystems { get; set; }
        public DbSet<SAP> SAPs { get; set; }

        public DbSet<Artifact> Artifacts { get; set; }

        public DbSet<Control> Controls { get; set; }
        public DbSet<ControlItem> ControlItems { get; set; }

        public DbSet<FamilyControl> FamilyControls { get; set; }

        public DbSet<FileTemplate> FileTemplates { get; set; }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Package> Packages { get; set; }

        public DbSet<SystemControl> SystemControls { get; set; }

        //  public DbSet<Artifact> Artifacts { get; set; }
        public DbSet<POAM> POAMs { get; set; }
        public DbSet<POAMItem> POAMItems { get; set; }

        public System.Data.Entity.DbSet<RMF.Entities.User> Users { get; set; }
    }
}