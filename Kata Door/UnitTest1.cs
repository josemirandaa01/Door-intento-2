using NUnit.Framework;

namespace Kata_Door
{
    public class Tests
    {

        [Test]
        public void Test_OpenAndUnlocked()
        {
            (bool,bool) expected = (true,false);
            (bool,bool) result = ClassLibrary1.Door.OpenAndUnlockedDoor();
            Assert.AreEqual(expected,result);

        }

        [Test]
        public void Test_OpenAndLocked()
        {
            (bool,bool) expected = (true,true);
            (bool, bool) result = ClassLibrary1.Door.OpenAndLockedDoor();
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Test_ClosedAndLocked()
        {
            (bool, bool) expected = (false, true);
            (bool, bool) result = ClassLibrary1.Door.ClosedAndLockedDoor();
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Test_ClosedAndUnlocked()
        {
            (bool, bool) expected = (false, false);
            (bool, bool) result = ClassLibrary1.Door.ClosedAndUnlockedDoor();
            Assert.AreEqual(expected, result);

        }



    }
}