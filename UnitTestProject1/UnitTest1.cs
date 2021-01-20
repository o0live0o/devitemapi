using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStack.Redis;
using System;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime ow1 = DateTime.Now;
            DateTime weekStartDay = ow1.AddDays(-(int)ow1.DayOfWeek + 1);

            string patern = @"^[a-zA-Z]{1}[a-zA-Z0-9]{5,19}$";
            patern = @"^[0-9]+$|^[a-z]+$|^[A-Z]+$";
            patern = @"^[^\s].*[^\s].*$";
            Regex regex = new Regex(patern);

            Assert.AreEqual(false, regex.IsMatch(""));
            Assert.AreEqual(false, regex.IsMatch(" "));
            Assert.AreEqual(false, regex.IsMatch(" 123"));
            Assert.AreEqual(true, regex.IsMatch("aaaaa"));
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
            Assert.AreEqual(true, regex.IsMatch("12134a567"));
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

        [TestMethod]
        public void TestMothod5()
        {
            RedisClient redisClient = new RedisClient("127.0.0.1", 6379);
            redisClient.Set("100", "10001");

            //var res = @"^(?!.*\s)(?!^[\u4e00-\u9fa5]+$)(?!^[0-9]+$)(?!^[A-z]+$)(?!^[^A-z0-9]+$)^.{8,16}$";

            //string regex = @"^$";

            var s = redisClient.Get<string>("100");
        }

        [TestMethod]
        public void TestMothod6()
        {
            // var regex1 = @"^(?!)$";
        }

        //0、1、1、2、3、5、8、13、21、34
        private void CalArr()
        {

        }

        [TestMethod]
        public void TestStr()
        {
            TStr();
        }

        public async void TStr()
        {
            try
            {
                string url = "https://jx3.seasunwbl.com/buyer?t=coin";
                HttpClient http = new HttpClient();
                var response = await http.GetAsync(url);
                Console.Write(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception)
            {
                throw;
            }

        }

        [TestMethod]
        public void SnowflakeTest()
        {
            var t = -1L ^ (-1L << 12);
            var t1 = 4095L & t;
            var t2 = 4096L & t;
            var t3 = 4097L & t;
            var t4 = 4098L & t;
            var t5 = 4099L & t;
            // var t1 = DateTime.Now.ToLongTimeString();
            // var t2 = (DateTime.Now - (new DateTime(1970, 1, 1, 0, 0, 0))).TotalMilliseconds;
            // var t3 = (long)(DateTime.Now - (new DateTime(1970, 1, 1, 0, 0, 0))).TotalMilliseconds;
            // var t4 = -1L << 5;
        }
    }
}
