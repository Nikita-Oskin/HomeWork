using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Block2_3.Tests
{
    [TestClass]
    public class SelectionSortTest
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
        [TestMethod]
        public void SelectionSortTest1()
        {
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(iarray1);


            selection.Sort();


            for (int i = 0; i < iarray1.Count(); i++)
            {
                Assert.AreEqual(sortediarray1[i], selection.Items[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest2()
        {            
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(iarray2);

            
            selection.Sort();

            
            for (int i = 0; i < iarray2.Count(); i++)
            {
                Assert.AreEqual(sortediarray2[i], selection.Items[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest3()
        {
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(iarray3);


            selection.Sort();


            for (int i = 0; i < iarray3.Count(); i++)
            {
                Assert.AreEqual(sortediarray3[i], selection.Items[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest4()
        {
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(iarray4);


            selection.Sort();


            for (int i = 0; i < iarray4.Count(); i++)
            {
                Assert.AreEqual(sortediarray4[i], selection.Items[i]);
            }
        }

        // 4 теста для типа данных string
        [TestMethod]
        public void SelectionSortTest5()
        {
            var selection = new SelectionSort<string>();
            selection.Items.AddRange(sarray1);


            selection.Sort();


            for (int i = 0; i < sarray1.Count(); i++)
            {
                Assert.AreEqual(sortedsarray1[i], selection.Items[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest6()
        {
            var selection = new SelectionSort<string>();
            selection.Items.AddRange(sarray2);


            selection.Sort();


            for (int i = 0; i < sarray2.Count(); i++)
            {
                Assert.AreEqual(sortedsarray2[i], selection.Items[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest7()
        {
            var selection = new SelectionSort<string>();
            selection.Items.AddRange(sarray3);


            selection.Sort();


            for (int i = 0; i < sarray3.Count(); i++)
            {
                Assert.AreEqual(sortedsarray3[i], selection.Items[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest8()
        {
            var selection = new SelectionSort<string>();
            selection.Items.AddRange(sarray4);


            selection.Sort();


            for (int i = 0; i < sarray4.Count(); i++)
            {
                Assert.AreEqual(sortedsarray4[i], selection.Items[i]);
            }
        }
    }
}
