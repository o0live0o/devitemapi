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
            string pattern = @"^(?=(?:\d+)+7$)";
            Regex regex = new Regex(pattern);
            Assert.AreEqual(true,regex.IsMatch("12134a567"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string pattern = @"\d{1,3}(.\d{1,3}){4}";
            Regex regex = new Regex(pattern);
            Assert.AreEqual(true, regex.IsMatch("192.168.2.12"));
        }       
        
        [TestMethod]
        public void TestMethod4()
        {
            string pattern = @"([^c]a)(\d*)(bd)";
            Regex regex = new Regex(pattern);
            var re = regex.Match("da12bka3434bdca4343bdca234bm");
        }
    }
}
