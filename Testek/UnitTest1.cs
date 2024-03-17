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
        public void TestGetSetElement()
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
            Assert.AreEqual(2,la.Size);
            la.SetZero();
            Assert.AreEqual(0, la.Size);
        }

        [TestMethod]
        public void TestClear()
        {
            LinkedArray la = new LinkedArray(3);
            la.SetElement(0, 123);
            la.SetElement(1, "Hello");
            la.SetElement(2, true);
            Assert.AreEqual(123, la.GetElement(0));
            Assert.AreEqual("Hello", la.GetElement(1));
            Assert.AreEqual(true, la.GetElement(2));
            la.Clear();
            Assert.AreEqual(null, la.GetElement(0));
            Assert.AreEqual(null, la.GetElement(1));
            Assert.AreEqual(null, la.GetElement(2));
        }

        [TestMethod]
        public void TestNewRow()
        {
            LinkedArray la = new LinkedArray(2);
            la.SetElement(0,"a");
            la.SetElement(1,2);
            la.NewRow();
            Assert.AreEqual(null,la.GetElement(0));
            Assert.AreEqual(null,la.GetElement(1));
        }

        [TestMethod]
        public void TestReSize()
        {
            LinkedArray la = new LinkedArray(3);
            la.SetElement(0, 123);
            la.SetElement(1, "Hello");
            la.SetElement(2, true);
            la.ReSize(5);
            Assert.AreEqual(123,la.GetElement(0));
            Assert.AreEqual("Hello", la.GetElement(1));
            Assert.AreEqual(true,la.GetElement(2));
            Assert.AreEqual(null,la.GetElement(3));
            Assert.AreEqual(null,la.GetElement(4));
        }

        [TestMethod]
        public void TestPrintData()
        {
            LinkedArray la = new LinkedArray(3);
            la.SetElement(0, 123);
            la.SetElement(1, "Hello");
            la.SetElement(2, true);
            object[,] test = la.GetData();
            Assert.AreEqual(test[0,0],la.GetElement(0));
            Assert.AreEqual(test[0,1],la.GetElement(1));
            Assert.AreEqual(test[0,2],la.GetElement(2));
        }

        [TestMethod]
        public void TestPopulate()
        {
            LinkedArray la = new LinkedArray(3);
            la.Populate();
            Assert.AreEqual("Data 0",la.GetElement(0));
            Assert.AreEqual("Data 1",la.GetElement(1));
            Assert.AreEqual("Data 2",la.GetElement(2));
        }

        [TestMethod]
        public void TestNewFirstRow()
        {
            LinkedArray la = new LinkedArray(3);
            la.SetElement(0, 123);
            la.SetElement(1, "Hello");
            la.SetElement(2, true);
            la.NewFirstRow();
            Assert.AreEqual(2,la.Count);
            Assert.AreEqual(123,la.GetElement(0));
            Assert.AreEqual("Hello",la.GetElement(1));
            Assert.AreEqual(true,la.GetElement(2));
        }

        [TestMethod]
        public void TestNotNull()
        {
            LinkedArray la = new LinkedArray(5);
            la.SetElement(1, "Test");
            Assert.AreEqual(1,la.NotNull());
        }
    }
}