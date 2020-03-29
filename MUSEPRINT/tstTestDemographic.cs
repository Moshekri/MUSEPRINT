namespace MUSEPRINT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tstTestDemographic: IComparable<tstTestDemographic>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TestID { get; set; }

        public int TocIndex { get; set; }

        public byte? TestType { get; set; }

        public int? Site { get; set; }

        [StringLength(5)]
        public string AcquisitionDevice { get; set; }

        public byte? TestStatus { get; set; }

        public byte? Priority { get; set; }

        public int? Location { get; set; }

        [StringLength(32)]
        public string RoomID { get; set; }

        public DateTime? AcquisitionDateTime_DT { get; set; }

        public byte? AcquisitionDateTime_DF { get; set; }

        public int? CartNumber { get; set; }

        [StringLength(9)]
        public string AcquisitionSoftwareVersion { get; set; }

        [StringLength(9)]
        public string AnalysisSoftwareVersion { get; set; }

        [StringLength(22)]
        public string OrderNumber { get; set; }

        [StringLength(10)]
        public string UserDefined { get; set; }

        public int? OptionNumber { get; set; }

        public byte? ReportSubtype { get; set; }

        public byte? ReportFormat { get; set; }

        public int? MfrOption3 { get; set; }

        public int? MfrOption4 { get; set; }

        public byte? MfrOption5 { get; set; }

        public byte? TestTypeQualifier { get; set; }

        public int? MfrOption6 { get; set; }

        public int? MfrOption7 { get; set; }

        public DateTime? EditDateTime_DT { get; set; }

        public byte? EditDateTime_DF { get; set; }

        public int? OrderingMDID { get; set; }

        [StringLength(40)]
        public string OrderingMD_FullName__Last { get; set; }

        [StringLength(20)]
        public string OrderingMD_FullName__First { get; set; }

        public int? ReferringMDID { get; set; }

        [StringLength(40)]
        public string ReferringMD_FullName__Last { get; set; }

        [StringLength(20)]
        public string ReferringMD_FullName__First { get; set; }

        public int? OverreaderID { get; set; }

        [StringLength(40)]
        public string Overreader_FullName__Last { get; set; }

        [StringLength(20)]
        public string Overreader_FullName__First { get; set; }

        public int? FellowID { get; set; }

        [StringLength(40)]
        public string Fellow_FullName__Last { get; set; }

        [StringLength(20)]
        public string Fellow_FullName__First { get; set; }

        public int? AcquisitionTechID { get; set; }

        [StringLength(40)]
        public string AcquisitionTech_FullName__Last { get; set; }

        [StringLength(20)]
        public string AcquisitionTech_FullName__First { get; set; }

        public int? EditorID { get; set; }

        [StringLength(40)]
        public string Editor_FullName__Last { get; set; }

        [StringLength(20)]
        public string Editor_FullName__First { get; set; }

        public int? DemographicsEditorID { get; set; }

        [StringLength(40)]
        public string DemographicsEditor_FullName__Last { get; set; }

        [StringLength(20)]
        public string DemographicsEditor_FullName__First { get; set; }

        [StringLength(24)]
        public string TestTypeString { get; set; }

        [StringLength(80)]
        public string TestReason { get; set; }

        public int? TestReasonId { get; set; }

        [StringLength(16)]
        public string SecondaryId { get; set; }

        public byte? HIS_Status { get; set; }

        public int BaseTestStatusID { get; set; }

        public int FullTestStatusID { get; set; }

        public int EditListTestStatusID { get; set; }

        [StringLength(20)]
        public string VisitNumber { get; set; }

        public int? OrderingMD_PersonID { get; set; }

        public int? ReferringMD_PersonID { get; set; }

        public int? OverreadingMD_PersonID { get; set; }

        public int? Fellow_PersonID { get; set; }

        public int? AcqTech_PersonID { get; set; }

        public int? Editor_PersonID { get; set; }

        public int? DemoEditor_PersonID { get; set; }

        public DateTime? DemoCompleteDateTime_DT { get; set; }

        public byte? DemoCompleteDateTime_DF { get; set; }

        public DateTime? DiagCompleteDateTime_DT { get; set; }

        public byte? DiagCompleteDateTime_DF { get; set; }

        public DateTime? FellowConfirmDateTime_DT { get; set; }

        public byte? FellowConfirmDateTime_DF { get; set; }

        public DateTime? ConfirmDateTime_DT { get; set; }

        public byte? ConfirmDateTime_DF { get; set; }

        public DateTime? UnconfirmedDateTime_DT { get; set; }

        public byte? UnconfirmedDateTime_DF { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Billed_Unconfirmed { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Billed_DemoComplete { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Billed_Confirmed { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Resulted_Confirmed { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? DoNotBill { get; set; }

        public int? ReanalysisAlgorithmID { get; set; }

        public int? ReanalysisOptions { get; set; }

        public int? ReanalysisBaseTestID { get; set; }

        
        public int CompareTo(tstTestDemographic other)
        {
            if (this.AcquisitionDateTime_DT == other.AcquisitionDateTime_DT)
            {
                return 0;
            }
            else if (this.AcquisitionDateTime_DT > other.AcquisitionDateTime_DT)
            {
                return -1;
            }
            else
                return 1;
        }
    }
}
