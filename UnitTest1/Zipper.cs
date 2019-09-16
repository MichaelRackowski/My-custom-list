using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace UnitTest1
{
    [TestClass]
    public class Zipper
    {
        [TestMethod]
        public void Zip_TwoIntList_Zipped()
        {
            CustomList<int> num = new CustomList<int>() { 8, 9, 0 };
            CustomList<int> numb = new CustomList<int>() { 2, 3 };
            CustomList<int> expectedResult = new CustomList<int>() { 8, 2, 9, 3, 0 };
            CustomList<int> actualReuslt;


            actualReuslt = num.Zipper(numb);

            Assert.AreEqual(expectedResult.ToString(), actualReuslt.ToString());
        }

    
       
            [TestMethod]
            public void Zip_OneEmptyListAndOneIntList_Zipped()
            {
                CustomList<int> num = new CustomList<int>() { };
                CustomList<int> numb = new CustomList<int>() { 4, 6, 3};
                CustomList<int> expectedResult = new CustomList<int>() { 4, 6, 3 };
                CustomList<int> actualReuslt;


                actualReuslt = num.Zipper(numb);

                Assert.AreEqual(expectedResult.ToString(), actualReuslt.ToString());
            }

        [TestMethod]
        public void ZipTwoStringLists_Zipped()
        {
            CustomList<string> num = new CustomList<string>() { "Mark", "Max", "Mike" };
            CustomList<string> numb = new CustomList<string>() {"Bob", "Bill", "Brooke" };
            CustomList<string> expectedResult = new CustomList<string>() { "Mark","Bob","Max","Bill","Mike","Brooke" };
            CustomList<string> actualReuslt;


            actualReuslt = num.Zipper(numb);

            Assert.AreEqual(expectedResult.ToString(), actualReuslt.ToString());
           
        }

    }
}
