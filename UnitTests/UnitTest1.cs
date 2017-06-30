using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using file_transfer.Infrastructure;
using System.Reflection;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        public Tuple<string, string, string> GetDirectory()
        {
            string disk1 = "", disk2 = "", disk3 = "";
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 1; i < drives.Length; i++)
            {
                if (drives[i].Name != "E:\\")
                {
                    disk1 = drives[0].ToString();
                    disk2 = drives[1].ToString();
                    disk3 = drives[i].ToString();
                }
            }
            return Tuple.Create(disk1, disk2, disk3);
        }

        public enum Headers : byte
        {
            Queue,
            Start,
            Stop,
            Pause,
            Chunk
        }

        public class Listner
        {
            public Listner()
            {

            }
        }

        [TestMethod]
        public void CanGetDirectory()
        {
            var corteg = GetDirectory();
            Assert.IsInstanceOfType(corteg.Item1, typeof(string));
            Assert.IsInstanceOfType(corteg.Item2, typeof(string));
            Assert.IsInstanceOfType(corteg.Item3, typeof(string));
        }

        [TestMethod]
        public void TestHeaders()
        {
            Assert.IsNotInstanceOfType(Headers.Stop, typeof(string));
            Assert.IsNotInstanceOfType(Headers.Chunk, typeof(System.Byte));
            Assert.IsNotInstanceOfType(Headers.Start, typeof(System.Byte));
        }

        [TestMethod]
        public void TestListner()
        {
            Listner list = new Listner();

            Type myType = typeof(Listner);
            Type[] types = new Type[1];
            types[0] = typeof(int);
            ConstructorInfo constructorInfoObj = myType.GetConstructor(types);
            Assert.AreEqual(constructorInfoObj, null);
        }

    }
}
