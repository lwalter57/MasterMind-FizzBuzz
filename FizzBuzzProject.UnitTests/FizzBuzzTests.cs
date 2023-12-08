
namespace FizzBuzzProject.UnitTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(12)]
        public void GetOutput_ParameterIsMultipleOf3_ReturnFizz(int parameter)
        {
            //Arrange & Act
            var result = FizzBuzz.GetOutput(parameter);

            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        [DataRow(10)]
        [DataRow(5)]
        [DataRow(20)]
        public void GetOutput_ParameterIsMultipleOf5_ReturnBuzz(int parameter)
        {
            //Arrange & Act
            var result = FizzBuzz.GetOutput(parameter);

            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(45)]
        public void GetOutput_ParameterIsMultipleOf3and5_ReturnFizzBuzz(int parameter)
        {
            //Arrange & Act
            var result = FizzBuzz.GetOutput(parameter);

            //Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        [DataRow(4)]
        [DataRow(8)]
        [DataRow(1)]
        public void GetOutput_ParameterIsntExpectedMultiple_ReturnNothing(int parameter)
        {
            //Arrange & Act
            var result = FizzBuzz.GetOutput(parameter);

            //Assert
            Assert.AreEqual(parameter.ToString(), result);
        }

        [TestMethod]
        [DataRow(-4)]
        [DataRow(-8)]
        [DataRow(-1)]
        public void GetOutput_ParameterIsNegative_ThrowArgumentOutOfRangeExcpetion(int parameter)
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => FizzBuzz.GetOutput(parameter));
        }
    }
}