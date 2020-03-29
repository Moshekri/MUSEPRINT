namespace MUSEPRINT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class patPatient
    {
        [Key]
        public int InternalPatientID { get; set; }

        [StringLength(16)]
        public string PatientID { get; set; }

        public byte? FamilyRelation { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        public short? PatientAge { get; set; }

        public byte? AgeUnits { get; set; }

        public byte? Supp_Demographics { get; set; }

        public DateTime? DateOfBirth_D { get; set; }

        public byte? DateOfBirth_DF { get; set; }

        public byte? Gender { get; set; }

        public byte? Race { get; set; }

        public int? Height_Inches { get; set; }

        public int? Height_Cm { get; set; }

        public int? Weight_Lbs { get; set; }

        public int? Weight_Kg { get; set; }

        [StringLength(64)]
        public string KanjiName { get; set; }

        [StringLength(32)]
        public string Phone1 { get; set; }

        [StringLength(32)]
        public string Phone2 { get; set; }

        [StringLength(32)]
        public string AddressLine1 { get; set; }

        [StringLength(32)]
        public string AddressLine2 { get; set; }

        [StringLength(32)]
        public string AddressLine3 { get; set; }

        [StringLength(32)]
        public string City { get; set; }

        [StringLength(32)]
        public string State { get; set; }

        [StringLength(32)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Zipcode { get; set; }

        [StringLength(19)]
        public string SSN { get; set; }

        public int? SoundexLastName { get; set; }

        public int? SoundexFirstName { get; set; }

        public int PID_VerificationStatus { get; set; }
    }
}
