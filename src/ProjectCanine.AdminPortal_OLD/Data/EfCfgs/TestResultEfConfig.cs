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


namespace ProjectCanine.AdminPortal_OLD.Data.EfCfgs
{
    using ProjectCanine.AdminPortal_OLD.Data;
    using ProjectCanine.AdminPortal_OLD.Data.Entities;

    // TestResults
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public class TestResultEfConfig : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TestResult>
    {
        public TestResultEfConfig()
            : this("dbo")
        {
        }

        public TestResultEfConfig(string schema)
        {
            Property(x => x.PassedTest).IsOptional();
            Property(x => x.ReasonForFailure).IsOptional().IsUnicode(false);
            Property(x => x.Notes).IsOptional().IsUnicode(false);
            Property(x => x.ShadowVisitRequirement).IsOptional();
            Property(x => x.CertificationType).IsOptional();
            Property(x => x.EquipmentRestrictions).IsOptional();
            Property(x => x.OtherRestrictions).IsOptional().IsUnicode(false);
            Property(x => x.ScoringExaminerSignature).IsOptional();
            Property(x => x.HandsOnSignature).IsOptional();
            Property(x => x.HandlerSignature).IsOptional();

        }
    }

}
// </auto-generated>