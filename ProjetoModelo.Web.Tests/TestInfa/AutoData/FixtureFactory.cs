using AutoFixture;
using AutoFixture.AutoNSubstitute;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoModelo.Web.Tests.TestInfa.AutoData
{
    internal static class FixtureFactory
    {
        public static IFixture BuildFixture()
        {
            var fixture = new Fixture();
            fixture.Customize(new AutoNSubstituteCustomization()
            {
                ConfigureMembers = true
            });

            fixture.Customize<ControllerContext>(o => o.OmitAutoProperties());
            return fixture;
        }
    }
}
