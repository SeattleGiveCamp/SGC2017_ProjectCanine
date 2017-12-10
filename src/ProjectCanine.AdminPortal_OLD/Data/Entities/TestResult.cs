// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCanine.AdminPortal_OLD.Data.Entities
{
    using Newtonsoft.Json;

    // TestResults
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public class TestResult
    {
        [Column(@"Id", Order = 1, TypeName = "uniqueidentifier")]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public System.Guid Id { get; set; } // Id (Primary key)

        [Required]
        [Display(Name = "Test")]
        public System.Guid Test { get; set; } // Test

        [Required]
        [Display(Name = "Handler")]
        public System.Guid Handler { get; set; } // Handler

        [Required]
        [Display(Name = "Dog")]
        public System.Guid Dog { get; set; } // Dog

        [Display(Name = "Passed test")]
        public bool? PassedTest { get; set; } // PassedTest

        [MaxLength(5000)]
        [StringLength(5000)]
        [Display(Name = "Reason for failure")]
        public string ReasonForFailure { get; set; } // ReasonForFailure (length: 5000)

        [MaxLength(5000)]
        [StringLength(5000)]
        [Display(Name = "Notes")]
        public string Notes { get; set; } // Notes (length: 5000)

        [Required]
        [Display(Name = "Passed connecting canines")]
        public bool PassedConnectingCanines { get; set; } = false; // PassedConnectingCanines

        [Display(Name = "Shadow visit requirement")]
        public bool? ShadowVisitRequirement { get; set; } // ShadowVisitRequirement

        [Required]
        [Display(Name = "Eligible to retest")]
        public bool EligibleToRetest { get; set; } = false; // EligibleToRetest

        [Required]
        [Display(Name = "Test date")]
        public System.DateTime TestDate { get; set; } // TestDate

        [Required]
        [Display(Name = "Scoring examiner")]
        public System.Guid ScoringExaminer { get; set; } // ScoringExaminer

        [Required]
        [Display(Name = "Hands on examiner")]
        public System.Guid HandsOnExaminer { get; set; } // HandsOnExaminer

        [Display(Name = "Certification type")]
        public System.Guid? CertificationType { get; set; } // CertificationType

        [Display(Name = "Equipment restrictions")]
        public System.Guid? EquipmentRestrictions { get; set; } // EquipmentRestrictions

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Other restrictions")]
        public string OtherRestrictions { get; set; } // OtherRestrictions (length: 300)

        [Required]
        [Display(Name = "Practice lab requirement")]
        public bool PracticeLabRequirement { get; set; } = false; // PracticeLabRequirement

        [Display(Name = "Scoring examiner signature")]
        public byte[] ScoringExaminerSignature { get; set; } // ScoringExaminerSignature

        [Display(Name = "Hands on signature")]
        public byte[] HandsOnSignature { get; set; } // HandsOnSignature

        [Display(Name = "Handler signature")]
        public byte[] HandlerSignature { get; set; } // HandlerSignature

        // Foreign keys

        /// <summary>
        /// Parent CertificationType pointed by [TestResults].([CertificationType]) (FKTestResults_CertificationTypes)
        /// </summary>
        [JsonIgnore]
        public CertificationType CertificationType_CertificationType { get; set; } // FKTestResults_CertificationTypes

        /// <summary>
        /// Parent Dog pointed by [TestResults].([Dog]) (FKTestResults_Dogs)
        /// </summary>
        [JsonIgnore]
        public Dog Dog_Dog { get; set; } // FKTestResults_Dogs

        /// <summary>
        /// Parent EquipmentRestriction pointed by [TestResults].([EquipmentRestrictions]) (FKTestResultsEquipmentRestrictions)
        /// </summary>
        [JsonIgnore]
        public EquipmentRestriction EquipmentRestriction { get; set; } // FKTestResultsEquipmentRestrictions

        /// <summary>
        /// Parent Examiner pointed by [TestResults].([HandsOnExaminer]) (FKTestResults_Examiners_HandsOn)
        /// </summary>
        [JsonIgnore]
        public Examiner Examiner_HandsOnExaminer { get; set; } // FKTestResults_Examiners_HandsOn

        /// <summary>
        /// Parent Examiner pointed by [TestResults].([ScoringExaminer]) (FKTestResults_Examiners_Scoring)
        /// </summary>
        [JsonIgnore]
        public Examiner Examiner_ScoringExaminer { get; set; } // FKTestResults_Examiners_Scoring

        /// <summary>
        /// Parent Test pointed by [TestResults].([Test]) (FKTestResults_Tests)
        /// </summary>
        [JsonIgnore]
        public Test Test_Test { get; set; } // FKTestResults_Tests
    }

}
// </auto-generated>