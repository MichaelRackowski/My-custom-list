using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace UnitTest1
{
    [TestClass] 
    public class OpTestSub
    {
        [TestMethod]
        public void Op_TwoStringLists_Compared()
        {
            CustomList<string> num = new CustomList<string>() { "Cook", "Cobb", "Bobby" };
            CustomList<string> numb = new CustomList<string>() { "Nelson", "Cobb", "Bobby" };
            CustomList<string> expectedResult = new CustomList<string>() { "Cook" };
            CustomList<string> actualReuslt;

            actualReuslt = num - numb;

            Assert.AreEqual(expectedResult.ToString(), actualReuslt.ToString());
        }
        [TestMethod]
        public void Op_TwoIntLists_Compared()
        {
            CustomList<int> num = new CustomList<int>() { 7, 8, 9 };
            CustomList<int> numb = new CustomList<int>() { 7, 5, 6 };
            CustomList<int> expectedResult = new CustomList<int>() { 8, 9 };
            CustomList<int> actualReuslt;

            actualReuslt = num - numb;

            Assert.AreEqual(expectedResult.ToString(), actualReuslt.ToString());
        }
        [TestMethod]
        public void Op_OneEmptyListAndOneIntList_Compare()
        {
            CustomList<int> num = new CustomList<int>()  { };
            CustomList<int> numb = new CustomList<int>() { 2, 1, 8 };
            CustomList<int> expectedResult = new CustomList<int>() { };
            CustomList<int> actualReuslt;

            actualReuslt = num - numb;

            Assert.AreEqual(expectedResult.ToString(), actualReuslt.ToString());
        }
        [TestMethod]
        public void Op_OneStringAndOneEmptyString_Compared()
        {
            CustomList<int> num = new CustomList<int>() {4,3,2 };
            CustomList<int> numb = new CustomList<int>() { };
            CustomList<int> expectedResult = new CustomList<int>() {4,3,2};
            CustomList<int> actualReuslt;

            actualReuslt = num - numb;

            Assert.AreEqual(expectedResult.ToString(), actualReuslt.ToString());
        }

    }
}
      








  

