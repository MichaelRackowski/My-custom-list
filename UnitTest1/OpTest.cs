using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;
namespace UnitTest1

{
    [TestClass]
    public class OpTest
    {
        [TestMethod]
        public void Op_TwoStringLists_Added()
        {
            CustomList<string> num = new CustomList<string>() { "Cook", "Cobb", "Bobby" };
            CustomList<string> numb = new CustomList<string>() { "Nelson", "Randle", "James" };
            CustomList<string> expectedResult = new CustomList<string>() { "Cook", "Cobb", "Bobby", "Nelson", "Randle", "James"};
            CustomList<string> actualReuslt;

            actualReuslt = num + numb;

            Assert.AreEqual(expectedResult.ToString(), actualReuslt.ToString());
        }
        [TestMethod]
        public void Op_TwoIntLists_Added()
        {
            CustomList<int> nub = new CustomList<int>() { 2, 3, 1 };
            CustomList<int> nume = new CustomList<int>() { 7, 4, 9 };
            CustomList<int> expectedResult = new CustomList<int>() { 2, 3, 1, 7, 4, 9 };
                CustomList<int> actualResult;

            actualResult = nub + nume;

            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
        [TestMethod]
        public void Op_OneIntListAndOneEmptyList_Added()
        {
            CustomList<int> numm = new CustomList<int>() { };
            CustomList<int> numbr = new CustomList<int>() { 7, 8, 9 };
            CustomList<int> expectedResult = new CustomList<int>() { 7, 8, 9 };
                CustomList<int> actualResult;

            actualResult = numm + numbr;

            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
        [TestMethod]
        public void Op_TwoEmptyLists_Added()
        {
            CustomList<int> number = new CustomList<int>() { };
            CustomList<int> nus = new CustomList<int>() { };
            CustomList<int> expectedResult = new CustomList<int>() { };
            CustomList<int> actualResult;

            actualResult = number + nus;
       

            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
    }
}



    