using Microsoft.VisualStudio.TestTools.UnitTesting;
using Block2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_1.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void LinkedListTest1()
        {
            // arrange
            string[] city = { "Amsterdam", "Bangkok", "Barcelona","Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul",
                                "Jakarta", "London", "Los Angeles", "Moscow", "Paris", "Tashkent", "Tokyo", "Washington"};
            int i = 0;


            // act
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);


            // assert
            Assert.AreEqual(city.Count(), doublylinkedlist.Count);
            foreach (var item in doublylinkedlist)
            {
                Assert.AreEqual(city[i], item);
                i++;
            }

        }

        [TestMethod()]
        public void AddLastTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            doublylinkedlist.AddLast("Tashkent");


            // assert
            Assert.AreEqual("Tashkent", doublylinkedlist.Last());
        }

        [TestMethod()]
        public void AddLastTest1()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            Node<string> last = new Node<string>("New York");

            // act
            doublylinkedlist.AddLast(last);


            // assert
            Assert.AreEqual("New York", doublylinkedlist.Last());
        }

        [TestMethod()]
        public void AddFisrtTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            doublylinkedlist.AddFisrt("Tashkent");


            // assert
            Assert.AreEqual("Tashkent", doublylinkedlist.First());
        }

        [TestMethod()]
        public void AddFirstTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            Node<string> first = new Node<string>("New York");

            // act
            doublylinkedlist.AddFirst(first);


            // assert
            Assert.AreEqual("New York", doublylinkedlist.First());
        }

        [TestMethod()]
        public void AddAfterTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            Node<string> current = doublylinkedlist.First;

            // act
            doublylinkedlist.AddAfter(current, "Tashkent");


            // assert
            Assert.AreEqual("Tashkent", doublylinkedlist.ElementAt(1));
        }

        [TestMethod()]
        public void AddAfterTest1()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            Node<string> current = doublylinkedlist.First;
            Node<string> first = new Node<string>("New York");

            // act
            doublylinkedlist.AddAfter(current, first);


            // assert
            Assert.AreEqual("New York", doublylinkedlist.ElementAt(1));
        }

        [TestMethod()]
        public void AddBeforeTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            Node<string> current = doublylinkedlist.Last;

            // act
            doublylinkedlist.AddBefore(current, "Tashkent");


            // assert
            Assert.AreEqual("Tashkent", doublylinkedlist.ElementAt(5));
        }

        [TestMethod()]
        public void AddBeforeTest1()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            Node<string> current = doublylinkedlist.Last;
            Node<string> first = new Node<string>("New York");

            // act
            doublylinkedlist.AddBefore(current, first);


            // assert
            Assert.AreEqual("New York", doublylinkedlist.ElementAt(5));
        }

        [TestMethod()]
        public void FindTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            Node<string> Found = doublylinkedlist.Find("Tokyo");

            // assert
            Assert.AreEqual(doublylinkedlist.Find("Tokyo"), Found);
        }

        [TestMethod()]
        public void FindLastTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Berlin", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            Node<string> Found = doublylinkedlist.Find("Berlin");

            // assert
            Assert.AreEqual(doublylinkedlist.Find("Berlin"), Found);
        }

        [TestMethod()]
        public void RemoveFirstTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            doublylinkedlist.RemoveFirst();

            // assert
            Assert.AreEqual("Berlin", doublylinkedlist.First());
        }

        [TestMethod()]
        public void RemoveLastTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            doublylinkedlist.RemoveLast();

            // assert
            Assert.AreEqual("Tokyo", doublylinkedlist.Last());
        }

        [TestMethod()]
        public void RemoveTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            doublylinkedlist.Remove("Instanbul");

            // assert
            Assert.IsFalse(doublylinkedlist.Constains("Instanbul"));
        }

        [TestMethod()]
        public void RemoveTest1()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            Node<string> delete = new Node<string>("London");


            // act
            doublylinkedlist.Remove(delete);

            // assert
            Assert.IsFalse(doublylinkedlist.Contains("London"));
        }

        [TestMethod()]
        public void ClearTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            doublylinkedlist.Clear();

            // assert
            Assert.IsTrue(doublylinkedlist.Count == 0);
        }

        [TestMethod()]
        public void CopyToTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            string[] arr = new string[10];

            // act
            doublylinkedlist.CopyTo(arr, 0);

            // assert
            Assert.IsTrue(arr.Any());


        }

        [TestMethod()]
        public void ConstainsTest()
        {
            // arrange
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            // act
            bool Found = doublylinkedlist.Constains("Tokyo");

            // assert
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void EqualsTest()
        {
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            LinkedList<string> doublylinkedlist1 = new LinkedList<string>();

            bool equals = doublylinkedlist.Equals(doublylinkedlist1);

            Assert.IsFalse(equals);
        }

    }
}