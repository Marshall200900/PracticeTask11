using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task11;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string actual = Encrypter.Encrypt("ааа", 1);
            Assert.AreEqual("ббб", actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string actual = Encrypter.Encrypt("ааа", 2);
            Assert.AreEqual("ввв", actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string actual = Encrypter.Encrypt("dаааddd", 1);
            Assert.AreEqual("dбббddd", actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string actual = Encrypter.Encrypt("абв", 1);
            Assert.AreEqual("бвг", actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string actual = Encrypter.Decrypt("ааа", 1);
            Assert.AreEqual("яяя", actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string actual = Encrypter.Decrypt("ааа", 2);
            Assert.AreEqual("ююю", actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string actual = Encrypter.Decrypt("dаааddd", 1);
            Assert.AreEqual("dяяяddd", actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            string actual = Encrypter.Decrypt("абв", 1);
            Assert.AreEqual("яаб", actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string actual = Encrypter.Encrypt("яяя", 1);
            Assert.AreEqual("ааа", actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string actual = Encrypter.Encrypt("ЯЯЯ", 1);
            Assert.AreEqual("ААА", actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string actual = Encrypter.Decrypt("ААА", 1);
            Assert.AreEqual("ЯЯЯ", actual);
        }
    }
}
