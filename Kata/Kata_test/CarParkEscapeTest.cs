using Codewars;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class CarParkEscapeTest
    {
        private CarParkEscape _car;

        [SetUp]
        public void SetUp()
        {
            _car = new CarParkEscape();
        }

        [Test]
        public void EscapeTwoFloors()
        {
            int[,] carpark = { { 1, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "L4", "D1", "R4" };
            Assert.AreEqual(result, _car.Escape(carpark));
        }

        [Test]
        public void HasTwoContinuousStairs()
        {
            int[,] carpark = { { 2, 0, 0, 1, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "R3", "D2", "R1" };
            Assert.AreEqual(result, _car.Escape(carpark));
        }

        [Test]
        public void HasThreeContinuousStairs()
        {
            int[,] carpark = { { 0, 2, 0, 0, 1 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "R3", "D3" };
            Assert.AreEqual(result, _car.Escape(carpark));
        }

        [Test]
        public void StairsFarWawy()
        {
            int[,] carpark = { { 1, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };
            Assert.AreEqual(result, _car.Escape(carpark));
        }

        [Test]
        public void AtExit()
        {
            int[,] carpark = { { 0, 0, 0, 0, 2 } };
            string[] result = { };
            Assert.AreEqual(result, _car.Escape(carpark));
        }
    }
}