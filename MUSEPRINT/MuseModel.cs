namespace MUSEPRINT
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MuseModel : DbContext
    {
        public MuseModel()
            : base("name=MuseModel")
        {
        }

        public virtual DbSet<patPatient> patPatients { get; set; }
        public virtual DbSet<tstPatientDemographic> tstPatientDemographics { get; set; }
        public virtual DbSet<tstTestDemographic> tstTestDemographics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
