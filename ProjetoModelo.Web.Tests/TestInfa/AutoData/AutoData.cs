using ProjetoModelo.Web.Tests.TestInfa.AutoData;

namespace ProjetoModelo.Web.Tests.TestInfa.Attributes
{
    internal class AutoDataAttribute : AutoFixture.Xunit2.AutoDataAttribute
    {
        public AutoDataAttribute() : base(FixtureFactory.BuildFixture)
        {
        }
    }
}
