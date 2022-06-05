using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Block2_3.Tests
{
    [TestClass]
    public class QuickSortTest
    {
        int[] iarray1, iarray2, iarray3, iarray4;
        int[] sortediarray1, sortediarray2, sortediarray3, sortediarray4;

        string[] sarray1, sarray2, sarray3, sarray4;
        string[] sortedsarray1, sortedsarray2, sortedsarray3, sortedsarray4;

        [TestInitialize]
        public void Init2()
        {
            iarray1 = new int[] { 4, 3, 2, 1 };
            sortediarray1 = new int[] { 1, 2, 3, 4 };
            iarray2 = new int[] { 43, 632, 21, 6 };
            sortediarray2 = new int[] { 6, 21, 43, 632 };
            iarray3 = new int[] { 43, 6, 21, -6 };
            sortediarray3 = new int[] { -6, 6, 21, 43 };
            iarray4 = new int[] { 1, 1, 1, 1 };
            sortediarray4 = new int[] { 1, 1, 1, 1 };

            sarray1 = new string[] { "Tokyo", "Amsterdam", "Instanbul", "Berlin", "London", "Washington" };
            sortedsarray1 = new string[] { "Amsterdam", "Berlin", "Instanbul", "London", "Tokyo", "Washington" };
            sarray2 = new string[] { "KRKESKEOLA", "FFPSMTTLFW", "MRHOUJFUHH", "KRKESKEOLB" };
            sortedsarray2 = new string[] { "FFPSMTTLFW", "KRKESKEOLA", "KRKESKEOLB", "MRHOUJFUHH" };
            sarray3 = new string[] { "vohuoqlpto", "ovmgeqbjdb", "knjpiupajx", "ktbqgvzugs" };
            sortedsarray3 = new string[] { "knjpiupajx", "ktbqgvzugs", "ovmgeqbjdb", "vohuoqlpto" };
            sarray4 = new string[] { "tcaH6699RS", "mnkp4979FT", "tcah6699RS", "mnkp3979FT" };
            sortedsarray4 = new string[] { "mnkp3979FT", "mnkp4979FT", "tcah6699RS", "tcaH6699RS" };
        }

        // 4 теста для типа данных integer
        [TestMethod()]
        public void QuickSortTest1()
        {
            // arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(iarray1);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < iarray1.Count(); i++)
            {
                Assert.AreEqual(sortediarray1[i], quick.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest2()
        {
            // arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(iarray2);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < iarray2.Count(); i++)
            {
                Assert.AreEqual(sortediarray2[i], quick.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest3()
        {
            // arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(iarray3);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < iarray3.Count(); i++)
            {
                Assert.AreEqual(sortediarray3[i], quick.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest4()
        {
            // arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(iarray4);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < iarray4.Count(); i++)
            {
                Assert.AreEqual(sortediarray4[i], quick.Items[i]);
            }
        }

        // 4 теста для типа данных string
        [TestMethod()]
        public void QuickSortTest5()
        {
            // arrange
            var quick = new QuickSort<string>();
            quick.Items.AddRange(sarray1);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < sarray1.Count(); i++)
            {
                Assert.AreEqual(sortedsarray1[i], quick.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest6()
        {
            // arrange
            var quick = new QuickSort<string>();
            quick.Items.AddRange(sarray2);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < sarray2.Count(); i++)
            {
                Assert.AreEqual(sortedsarray2[i], quick.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest7()
        {
            // arrange
            var quick = new QuickSort<string>();
            quick.Items.AddRange(sarray3);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < sarray3.Count(); i++)
            {
                Assert.AreEqual(sortedsarray3[i], quick.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest8()
        {
            // arrange
            var quick = new QuickSort<string>();
            quick.Items.AddRange(sarray4);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < sarray4.Count(); i++)
            {
                Assert.AreEqual(sortedsarray4[i], quick.Items[i]);
            }
        }

    }
}
