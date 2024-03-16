namespace Testek
{
    using Beadando202403;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSize()
        {
            LinkedArray la = new LinkedArray(3);
            Assert.AreEqual(3, la.Size);
        }

        [TestMethod]
        public void TestGetElement()
        {
            LinkedArray la = new LinkedArray(3);
            la.SetElement(0,123);
            la.SetElement(1,"Hello");
            la.SetElement(2,true);
            Assert.AreEqual(123,la.GetElement(0));
            Assert.AreEqual("Hello",la.GetElement(1));
            Assert.AreEqual(true,la.GetElement(2));
        }

        [TestMethod]
        public void TestTotalSize()
        {
            LinkedArray la = new LinkedArray(5);
            Assert.AreEqual(5,la.TotalSize());
        }

        [TestMethod]
        public void TestSetZero()
        {
            LinkedArray la = new LinkedArray(2);
            Assert.AreEqual(2,la.TotalSize());
            la.SetZero();
            Assert.AreEqual(0, la.TotalSize());
        }

    }
}