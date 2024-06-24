using System.Numerics;
using WebAppBuild.Modules;

namespace WebTest
{
    public class WebTest
    {
        [Fact]
        public void Webtest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "Value should be equal to 1");
        }

        [Fact]

        public void CheckAddFunction()
        {
            Functions func = new Functions();
            int y = func.Add(7, 7);

            bool result = false;

            if (y == 14) result = true;
            Assert.True(result, "Value should be equal to 14");


        }
    }
}