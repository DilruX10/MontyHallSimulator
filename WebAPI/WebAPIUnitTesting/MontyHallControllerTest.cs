namespace WebAPIUnitTesting
{
    using WebAPI.Models;
    using WebAPI.Controllers;
    using Microsoft.AspNetCore.Mvc;

    public class MontyHallControllerTest
    {
        public MontyHallController MontyHallControl;

        [SetUp]
        public void Setup()
        {
            MontyHallControl = new MontyHallController();
        }

        [Test]
        [Order(0)]
        public void TestGetSimsController_ForValueTrue()
        {
            // assign
            int expectedSize = 5;

            // act
            List<MontyHall> MontyHallSimsTest = MontyHallControl.GetSims(expectedSize, "true").Value;
            int listSize = MontyHallSimsTest.Count;

            // assert
            Assert.IsNotNull(MontyHallSimsTest);
            Assert.That(listSize, Is.EqualTo(expectedSize));
        }

        [Test]
        [Order(1)]
        public void TestGetSimsController_ForValueFalse()
        {
            // assign
            int expectedSize = 5;

            // act
            List<MontyHall> MontyHallSimsTest = MontyHallControl.GetSims(expectedSize, "true").Value;
            int listSize = MontyHallSimsTest.Count;

            // assert
            Assert.IsNotNull(MontyHallSimsTest);
            Assert.That(listSize, Is.EqualTo(expectedSize));
        }
    }


}
