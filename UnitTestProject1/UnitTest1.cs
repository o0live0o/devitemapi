using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string patern = @"^[a-zA-Z]{1}[a-zA-Z0-9]{5,19}$";
            patern = @"^[0-9]+$|^[a-z]+$|^[A-Z]+$";
            patern = @"^[^\s].*[^\s].*$";
            Regex regex = new Regex(patern);

           Assert.AreEqual(false,regex.IsMatch(""));
           Assert.AreEqual(false,regex.IsMatch(" "));
           Assert.AreEqual(false,regex.IsMatch(" 123"));
           Assert.AreEqual(true,regex.IsMatch("aaaaa"));
           Assert.AreEqual(true, regex.IsMatch("1abic121"));
           Assert.AreEqual(true, regex.IsMatch("A2isax"));            
           Assert.AreEqual(true, regex.IsMatch("A2isax3456789121120912901212121"));            
           Assert.AreEqual(true, regex.IsMatch("A2isax 219sa"));            
           Assert.AreEqual(true, regex.IsMatch("A2isaxAAAA221"));            
           Assert.AreEqual(true, regex.IsMatch("A2isaxAAAA221 "));            
        }

        [TestMethod]
        public void TestMethod2()
        {
            string pattern = @"^(?=\d+$)";
            Regex regex = new Regex(pattern);
            Assert.AreEqual(true,regex.IsMatch("1234567"));
        }
    }
}
