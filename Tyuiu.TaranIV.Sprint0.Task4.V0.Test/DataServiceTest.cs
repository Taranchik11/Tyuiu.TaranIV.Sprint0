using Tyuiu.TaranIV.Sprint0.Task4.V0.Lib;

namespace Tyuiu.TaranIV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalVallid()
        {
            Assert.AreEqual(10, DataService.Additional(5, 5));
        }

        public void CheckedSubtractionVallid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        public void CheckedMultiplicationVallid()
        {
            Assert.AreEqual(50, DataService.Subtraction(10, 5));
        }

        public void CheckedDivisionVallid()
        {
            Assert.AreEqual(3, DataService.Subtraction(9, 3));
        }
    }
}
