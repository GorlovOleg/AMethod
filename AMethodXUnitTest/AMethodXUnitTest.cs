using System;
using Xunit;

namespace AMethodXUnitTest
{
    public class AMethodXUnitTest
    {
        [Theory]
        [InlineData(true, true, true)]
        //[InlineData(true, true, false)]
        //[InlineData(true, false, false)]
        //[InlineData(false, false, false)]
        //[InlineData(false, true, true)]
        //[InlineData(false, true, false)]
        //[InlineData(false, false, true)]
        //[InlineData(true, false, true)]

        public void AMethodValidValueFirst(bool first, bool second, bool third)
        {

            var result = SmartSystems.Program.AMethod(first, second, third);
            Assert.Equal(1, result);

        }

        [Theory]
        [InlineData(false, true, false)]
        public void AMethodValidValueSecond(bool first, bool second, bool third)
        {

            var result = SmartSystems.Program.AMethod(first, second, third);
            Assert.Equal(1, result);

        }

        [Theory]
        [InlineData(false, false, false)]
        public void AMethodValidValueThird(bool first, bool second, bool third) 
        {

            var result = SmartSystems.Program.AMethod(first, second, third);
            Assert.Equal(1, result);

        }
    }
}
