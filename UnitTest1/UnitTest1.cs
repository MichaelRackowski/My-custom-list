using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_2_CountIncrease()
        {
            //arrange
            CustomList<int> nums = new CustomList<int>();
            int expectedResult = 2;
            int actualResult;

            //act
            nums.Add(8);
            nums.Add(7);
            actualResult = nums.Count;

            //assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_StringName()
        {
            CustomList<string> name = new CustomList<string>();
            string exceptedResult = "Cook";
            string actualResult;

            name.Add("Rodgers");
            name.Add("Wilson");
            name.Add("Brady");
            name.Add("Vick");
            name.Add("Cook");
            actualResult = name[4];


            Assert.AreEqual(exceptedResult, actualResult);
        }
        [TestMethod]
        public void Add_8_CountIncrease()
        {
            CustomList<int> numbers = new CustomList<int>();
            int exceptedResult = 8;
            int actualResult;

            numbers.Add(20);
            numbers.Add(2);
            numbers.Add(0);
            numbers.Add(6);
            numbers.Add(17);
            numbers.Add(29);
            numbers.Add(30);
            numbers.Add(54);
            actualResult = numbers.Count;

            Assert.AreEqual(exceptedResult, actualResult);
        }
        [TestMethod]
        public void aAdd_StringName()
        {
            CustomList<string> allstar = new CustomList<string>();
            string exceptedResult = "Giannis";
            string actualResult;

            allstar.Add("Curry");
            allstar.Add("Harden");
            allstar.Add("Griffen");
            allstar.Add("Green");
            allstar.Add("James");
            allstar.Add("Giannis");
            allstar.Add("Leanord");
            allstar.Add("Irving");
            allstar.Add("Wade");
            actualResult = allstar[5];


            Assert.AreEqual(exceptedResult, actualResult);
        }

        [TestMethod]
        public void Add_1_CoutnIncrease()
        {
            CustomList<int> numb = new CustomList<int>();
            int expectedResult = 1;
            int actualResult;

            numb.Add(1);
            actualResult = numb.Count;

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void Remove_Zero_AfterNotAddingCountDecrese()
        {
            CustomList<int> number = new CustomList<int>();
            int expectedResult = 0;
            int actualResult;


           
            number.Remove(3);
            actualResult = number.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_RemovingOneIntAfterAddingOne_OneInts()
        {
            CustomList<int> number = new CustomList<int>();
            int expectedResult = 1;
            int actualResult;
            number.Add(1);
             /// remove in act move add to arrange  make tests different
            

            number.Remove(5);
            
            
            actualResult = number.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_StringName()
        {
            CustomList<string> allstar = new CustomList<string>();
            string exceptedResult = "Giannis";
            string actualResult;

            allstar.Add("Curry");
            allstar.Add("Harden");
            allstar.Add("Griffen");
            allstar.Add("Green");
            allstar.Add("James");
            allstar.Add("Ball");
            allstar.Add("Bronny");
            allstar.Add("Giannis");
            allstar.Add("Leanord");
            allstar.Add("Irving");
            allstar.Add("Wade");
            allstar.Remove("Bronny");
            allstar.Remove("Ball");
            actualResult = allstar[5];


            Assert.AreEqual(exceptedResult, actualResult);
        }
        [TestMethod]
        public void Remove_RemovingThreeStringItemsAfterAddingEight_EigthItemBecomesFifth()
        {
            CustomList<string> name = new CustomList<string>();
            string exceptedResult = "Cook";
            string actualResult;

            name.Add("Rodgers");
            name.Add("Wilson");
            name.Add("Brady");
            name.Add("Vick");
            name.Add("Farve");
            name.Add("Starr");
            name.Add("McNabb");
            name.Add("Cook");

            name.Remove("Farve");
            name.Remove("Starr");
            name.Remove("McNabb");

            actualResult = name[4];


            Assert.AreEqual(exceptedResult, actualResult);
        }




    }
}

