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


namespace ProjectCanine.AdminPortal.Data.EfCfgs
{
    using ProjectCanine.AdminPortal.Data;
    using ProjectCanine.AdminPortal.Data.Entities;

    // Tests
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public class TestEfConfig : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Test>
    {
        public TestEfConfig()
            : this("dbo")
        {
        }

        public TestEfConfig(string schema)
        {
            Property(x => x.ShortName).IsUnicode(false);
            Property(x => x.Name).IsUnicode(false);

        }
    }

}
// </auto-generated>