namespace WebAPIUnitTesting
{
    using WebAPI.Models;
    using WebAPI.Services;

    public class MontyHallServiceTest
    {
        public static List<MontyHall> MontyHallSimsTest;

        [SetUp]
        public void Setup()
        {
            MontyHallSimsTest = new List<MontyHall>();
        }

        [Test]
        [Order(0)]
        public void TestGetSims_ForValueTrue()
        {
            // assign
            int expectedSize = 5;

            // act
            MontyHallSimsTest = MontyHallService.GetSims(expectedSize, true);
            int listSize = MontyHallSimsTest.Count;

            // assert
            Assert.IsNotNull(MontyHallSimsTest);
            Assert.That(listSize, Is.EqualTo(expectedSize));
        }

        [Test]
        [Order(1)]
        public void TestGetSims_ForValueFalse()
        {
            // assign
            int expectedSize = 5;

            // act
            MontyHallSimsTest = MontyHallService.GetSims(expectedSize, false);
            int listSize = MontyHallSimsTest.Count;

            // assert
            Assert.IsNotNull(MontyHallSimsTest);
            Assert.That(listSize, Is.EqualTo(expectedSize));
        }

        [Test]
        [Order(2)]
        public void TestGetSimsChangedDoorValue_ForTrue()
        {
            // act
            MontyHallSimsTest = MontyHallService.GetSims(1, true);

            MontyHall sim = MontyHallSimsTest[0];
            int changedDoorValue = sim.changedDoor;
            int choosedDoorValue = sim.choosedDoor;
            int openedDoorValue = sim.moneyDoor;

            // assert
            Assert.IsNotNull(changedDoorValue);
            Assert.That(changedDoorValue, Is.Not.EqualTo(-1)); // if door is changed, value for changedDoor should not be -1
            Assert.That(changedDoorValue, Is.GreaterThanOrEqualTo(0)); // value for changedDoor should be greater than -1            
            Assert.That(changedDoorValue, Is.LessThan(3)); // value for changedDoor should be less than 3
           }

        [Test]
        [Order(3)]
        public void TestGetSimsChangedDoorValue_ForFalse()
        {
            // act
            MontyHallSimsTest = MontyHallService.GetSims(5, false);

            MontyHallSimsTest.ForEach(sim => {

                int changedDoorValue = sim.changedDoor;

                // assert
                Assert.IsNotNull(changedDoorValue);
                Assert.That(changedDoorValue, Is.EqualTo(-1)); // if door is not changed, value for changedDoor should be -1

            });
        }
    }
}