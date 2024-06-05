namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzUnitTest
    {
        [TestMethod]
        public void InvalidEntryTest()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("ABC"), "Invalid Item");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc(""), "Invalid Item");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc(null), "Invalid Item");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("12a"), "Invalid Item");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("ZY2"), "Invalid Item");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("ABC 12"), "Invalid Item");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("12 ABC"), "Invalid Item");
        }

        [TestMethod]
        public void FizzTest()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("3"), "Fizz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("9"), "Fizz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("-3"), "Fizz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("03"), "Fizz");
        }

        [TestMethod]
        public void BuzzTest()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("5"), "Buzz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("10"), "Buzz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("-5"), "Buzz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("05"), "Buzz");
        }

        [TestMethod]
        public void FizzBuzzTest()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("15"), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("30"), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("-15"), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("015"), "FizzBuzz");
        }

        [TestMethod]
        public void DivideByTest()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("1"), "Divided 1 by 3" + System.Environment.NewLine + "Divided 1 by 5");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("7"), "Divided 7 by 3" + System.Environment.NewLine + "Divided 7 by 5");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("-7"), "Divided -7 by 3" + System.Environment.NewLine + "Divided -7 by 5");
            Assert.AreEqual(FizzBuzz.FizzBuzzProgram.FizzBuzzCalc("04"), "Divided 04 by 3" + System.Environment.NewLine + "Divided 04 by 5");
        }
    }
}