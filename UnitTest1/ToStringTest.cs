using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace UnitTest1
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ToString_Return_String()
        {
            CustomList<int> numb = new CustomList<int>();
            string expectedResult = "3, 1, 2";
            string actualResult;

            numb.Add(3);
            numb.Add(1);
            numb.Add(2);
            actualResult = numb.ToString();

            Assert.AreEqual(expectedResult, actualResult);


        }
        [TestMethod]
        public void ToString_Return_EmptyString()
        {
            CustomList<string> numbe = new CustomList<string>();
            string expectedResult = "";
            string actualResult;

          
            actualResult = numbe.ToString();

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void ToStringTestMethod3()
        {
            CustomList<string> number = new CustomList<string>();
            string expectedResult = "Cool, Hot, Windy, Breezy, Weezy, Fisforfinisher";
            string actualResult;

            number.Add("Cool");
            number.Add("Hot");
            number.Add("Windy");
            number.Add("Breezy");
            number.Add("Weezy");
            number.Add("Fisforfinisher");
            actualResult = number.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }      
    }
}