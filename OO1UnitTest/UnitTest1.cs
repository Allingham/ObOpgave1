using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO1Classlibrary;

namespace OO1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameCorrectFormat()
        {
            //arrange
            FanOutput fo = new FanOutput();
            string newName = "Test";

            //act
            fo.Name = newName;

            //assert
            Assert.AreEqual(fo.Name, newName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NameTooShort()
        {
            //arrange
            FanOutput fo = new FanOutput();
            string newName = "T";

            //act
            fo.Name = newName;

            //assert
            //asserting in tag
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NameNull()
        {
            //arrange
            FanOutput fo = new FanOutput();

            //act
            fo.Name = null;

            //assert
            //asserting in tag
        }

        [TestMethod]
        public void TempCorrectFormat()
        {
            //arrange
            FanOutput fo = new FanOutput();
            double newTemp = 15;

            //act
            fo.Temp = newTemp;

            //assert
            Assert.AreEqual(fo.Temp, newTemp);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TempTooLow()
        {
            //arrange
            FanOutput fo = new FanOutput();
            double newTemp = 14.9;

            //act
            fo.Temp = newTemp;

            //assert
            //asserting in tag
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TempTooHigh()
        {
            //arrange
            FanOutput fo = new FanOutput();
            double newTemp = 25.1;

            //act
            fo.Temp = newTemp;

            //assert
            //asserting in tag
        }

        [TestMethod]
        public void SetID()
        {
            //arrange
            FanOutput fo = new FanOutput();
            int newID = 1;

            //act
            fo.ID = newID;

            //assert
            Assert.AreEqual(fo.ID, newID);
        }

        [TestMethod]
        public void HumidCorrectFormat()
        {
            //arrange
            FanOutput fo = new FanOutput();
            double newHumid = 30;

            //act
            fo.Humidity = newHumid;

            //assert
            Assert.AreEqual(fo.Humidity, newHumid);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HumidTooLow()
        {
            //arrange
            FanOutput fo = new FanOutput();
            double newHumid = 29.9;

            //act
            fo.Humidity = newHumid;

            //assert
            //asserting in tag
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HumidTooHigh()
        {
            //arrange
            FanOutput fo = new FanOutput();
            double newHumid = 80.1;

            //act
            fo.Humidity = newHumid;

            //assert
            //asserting in tag
        }

        [TestMethod]
        public void TestContructor()
        {
            //arrange
            int ID = 1;
            string Name = "Test";
            double Temp = 18;
            double Humid = 35;
            //act
            FanOutput fo = new FanOutput(ID, Name, Temp, Humid);

            //assert
            Assert.IsNotNull(fo);
        }

        [TestMethod]
        public void TestToString()
        {
            //arrange
            FanOutput fo = new FanOutput(1,"Test",20,55);

            //act
            string foToString = fo.ToString();
            string expectedResult = "ID: 1, Name: Test, Temp: 20, Humidity: 55";

            //assert
            Assert.AreEqual(foToString, expectedResult);
        }
    }
}
