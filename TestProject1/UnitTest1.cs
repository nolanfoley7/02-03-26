using NF_Basic_App_GitHub;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            Class1 tp = new Class1();

            var result = tp.Name;

            Assert.Equal("[Nolan Foley] - The Code Master", result);
        }
    }
}