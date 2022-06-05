using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Block2_3.Tests
{
    [TestClass]
    public class MergeSortTest
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
        public void MergeSortTest1()
        {            
            var merge = new MergeSort<int>();
            merge.Items.AddRange(iarray1);
                        
            merge.Sort();
                        
            for (int i = 0; i < iarray1.Count(); i++)
            {
                Assert.AreEqual(sortediarray1[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest2()
        {            
            var merge = new MergeSort<int>();
            merge.Items.AddRange(iarray2);
                        
            merge.Sort();
                        
            for (int i = 0; i < iarray2.Count(); i++)
            {
                Assert.AreEqual(sortediarray2[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest3()
        {            
            var merge = new MergeSort<int>();
            merge.Items.AddRange(iarray3);
                        
            merge.Sort();
                        
            for (int i = 0; i < iarray3.Count(); i++)
            {
                Assert.AreEqual(sortediarray3[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest4()
        {            
            var merge = new MergeSort<int>();
            merge.Items.AddRange(iarray4);
                        
            merge.Sort();
                        
            for (int i = 0; i < iarray4.Count(); i++)
            {
                Assert.AreEqual(sortediarray4[i], merge.Items[i]);
            }
        }

        // 4 теста для типа данных string
        [TestMethod()]
        public void MergeSortTest5()
        {            
            var merge = new MergeSort<string>();
            merge.Items.AddRange(sarray1);
                        
            merge.Sort();
                        
            for (int i = 0; i < sarray1.Count(); i++)
            {
                Assert.AreEqual(sortedsarray1[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest6()
        {            
            var merge = new MergeSort<string>();
            merge.Items.AddRange(sarray2);
                        
            merge.Sort();
                        
            for (int i = 0; i < sarray2.Count(); i++)
            {
                Assert.AreEqual(sortedsarray2[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest7()
        {            
            var merge = new MergeSort<string>();
            merge.Items.AddRange(sarray3);
                        
            merge.Sort();
                        
            for (int i = 0; i < sarray3.Count(); i++)
            {
                Assert.AreEqual(sortedsarray3[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest8()
        {            
            var merge = new MergeSort<string>();
            merge.Items.AddRange(sarray4);
                        
            merge.Sort();
                        
            for (int i = 0; i < sarray4.Count(); i++)
            {
                Assert.AreEqual(sortedsarray4[i], merge.Items[i]);
            }
        }
    }
}
