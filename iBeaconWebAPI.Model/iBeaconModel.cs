namespace iBeaconWebAPI.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class iBeaconModel : DbContext
    {
        public iBeaconModel()
            : base("name=iBeaconContext")
        {
        }

        public virtual DbSet<iBeacon> iBeacon { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
