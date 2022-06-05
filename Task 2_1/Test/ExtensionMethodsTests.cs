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
    public class ExtensionMethodsTests
    {
        [TestMethod()]
        public void AllTest()
        {

            string[] city = { "Amsterdam", "Bangkok", "Barcelona","Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul",
                                "Jakarta", "London", "Los Angeles", "Moscow", "Paris", "Tashkent", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);




            bool all = doublylinkedlist.All(s => s.StartsWith("A"));



            Assert.IsFalse(all);

        }

        [TestMethod()]
        public void AnyTest()
        {
            string[] city = { "Amsterdam", "Bangkok", "Barcelona","Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul",
                                "Jakarta", "London", "Los Angeles", "Moscow", "Paris", "Tashkent", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);




            bool all = doublylinkedlist.Any();



            Assert.IsTrue(all);
        }

        [TestMethod()]
        public void AnyTest1()
        {

            string[] city = { "Amsterdam", "Bangkok", "Barcelona","Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul",
                                "Jakarta", "London", "Los Angeles", "Moscow", "Paris", "Tashkent", "Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);



            bool all = doublylinkedlist.Any(s => s.StartsWith("A"));



            Assert.IsTrue(all);
        }

        [TestMethod()]
        public void ConcatTest()
        {

            string[] city0 = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul" };
            string[] city1 = { "Jakarta", "London", "Los Angeles", "Moscow", "Paris", "Tashkent", "Tokyo", "Washington" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city0);
            int i = 0;


            IEnumerable<string> city = doublylinkedlist.Concat(city1);
            string[] citytest = { "Amsterdam", "Bangkok", "Barcelona","Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul",
                                "Jakarta", "London", "Los Angeles", "Moscow", "Paris", "Tashkent", "Tokyo", "Washington"};



            Assert.AreEqual(citytest.Count(), city.Count());
            foreach (var item in doublylinkedlist)
            {
                Assert.AreEqual(citytest[i], item);
                i++;
            }

        }

        [TestMethod()]
        public void ContainsTest()
        {

            string[] city = { "Jakarta", "London", "Los Angeles", "Moscow", "Paris", "Tashkent", "Tokyo", "Washington" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);


            bool contains = doublylinkedlist.Contains("London");


            Assert.IsTrue(contains);

        }

        [TestMethod()]
        public void AppendTest()
        {

            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);


            doublylinkedlist.Append("Tashkent");



            Assert.AreEqual("Tashkent", doublylinkedlist.Last());
        }

        [TestMethod()]
        public void CountTest()
        {

            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);


            int count = doublylinkedlist.Count();


            Assert.AreEqual(count, 6);
        }

        [TestMethod()]
        public void CountTest1()
        {

            string[] city = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);


            int count = doublylinkedlist.Count(s => s.StartsWith("B"));


            Assert.AreEqual(count, 3);
        }

        [TestMethod()]
        public void DistinctTest()
        {

            string[] city1 = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul" };
            string[] city = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Barcelona", "Berlin", "Cairo", "Chicago", "Dubai", "Chicago", "Hong Kong", "Tokyo", "Instanbul" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            int i = 0;


            IEnumerable<string> distinct = doublylinkedlist.Distinct();


            Assert.AreEqual(city1.Count(), distinct.Count());
            foreach (var item in distinct)
            {
                Assert.AreEqual(city1[i], item);
                i++;
            }

        }

        [TestMethod()]
        public void ElementAtTest()
        {

            string[] city = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Barcelona", "Berlin", "Cairo", "Chicago", "Dubai", "Chicago", "Hong Kong", "Tokyo", "Instanbul" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            string elementat;


            elementat = doublylinkedlist.ElementAt(0);


            Assert.AreEqual(elementat, doublylinkedlist.First());
        }

        [TestMethod()]
        public void ElementAtOrDefaultTest()
        {

            LinkedList<string> doublylinkedlist = new LinkedList<string>();
            string elementat;


            elementat = doublylinkedlist.ElementAtOrDefault(0);


            Assert.IsNull(elementat);
        }

        [TestMethod()]
        public void ExceptTest()
        {
            string[] city1 = { "Amsterdam", "Bangkok" };
            string[] city = { "Amsterdam" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            LinkedList<string> doublylinkedlist1 = new LinkedList<string>(city1);

            IEnumerable<string> query = doublylinkedlist1.Except(doublylinkedlist);

            using (var iterator = query.GetEnumerator())
            {
                Assert.IsTrue(iterator.MoveNext());
                Assert.AreEqual("Bangkok", iterator.Current);
            }
        }

        [TestMethod()]
        public void FirstTest()
        {

            string[] city = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Barcelona", "Berlin", "Cairo", "Chicago", "Dubai", "Chicago", "Hong Kong", "Tokyo", "Instanbul" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            string first;


            first = doublylinkedlist.First();


            Assert.AreEqual(first, "Amsterdam");
        }

        [TestMethod()]
        public void FirstOrDefaultTest()
        {

            LinkedList<string> doublylinkedlist = new LinkedList<string>();
            string first;


            first = doublylinkedlist.FirstOrDefault();


            Assert.IsNull(first);
        }

        [TestMethod()]
        public void IntersectTest()
        {
            string[] city1 = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul" };
            string[] city = { "Amsterdam" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            LinkedList<string> doublylinkedlist1 = new LinkedList<string>(city1);

            IEnumerable<string> query = doublylinkedlist.Intersect(doublylinkedlist1);

            using (var iterator = query.GetEnumerator())
            {
                Assert.IsTrue(iterator.MoveNext());
                Assert.AreEqual("Amsterdam", iterator.Current);
            }
        }

        [TestMethod()]
        public void LastTest()
        {

            string[] city = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Barcelona", "Berlin", "Cairo", "Chicago", "Dubai", "Chicago", "Hong Kong", "Tokyo", "Instanbul" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            string last;


            last = doublylinkedlist.Last();


            Assert.AreEqual(last, "Instanbul");
        }

        [TestMethod()]
        public void LastOrDefaultTest()
        {

            LinkedList<string> doublylinkedlist = new LinkedList<string>();
            string last;


            last = doublylinkedlist.FirstOrDefault();


            Assert.IsNull(last);
        }

        [TestMethod()]
        public void LongCountTest()
        {

            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);


            long count = doublylinkedlist.LongCount();


            Assert.AreEqual(count, 6);
        }

        [TestMethod()]
        public void MaxTest()
        {

            int[] source = { 5, 10, 6, 2, 13, 8 };
            LinkedList<int> doublylinkedlist = new LinkedList<int>(source);
            Assert.AreEqual(13, doublylinkedlist.Max());
        }

        [TestMethod()]
        public void MinTest()
        {
            int[] source = { 5, 10, 6, 2, 13, 8 };
            LinkedList<int> doublylinkedlist = new LinkedList<int>(source);
            Assert.AreEqual(2, doublylinkedlist.Min());
        }

        [TestMethod()]
        public void ReverseTest()
        {
            int[] numbers = { 5, 6, 7, 8, 9 };
            int[] numbers1 = { 9, 8, 7, 6, 5 };
            int i = 0;

            LinkedList<int> source = new LinkedList<int>(numbers);
            IEnumerable<int> query = source.Reverse();

            Assert.AreEqual(query.Count(), numbers1.Count());
            foreach (var item in query)
            {
                Assert.AreEqual(item, numbers1[i]);
                i++;
            }
        }

        [TestMethod()]
        public void SequenceEqualTest()
        {
            string[] city0 = { "Amsterdam", "Bangkok", "Barcelona", "Tokyo", "Berlin", "Cairo", "Chicago", "Dubai", "Hong Kong", "Instanbul" };
            string[] city1 = { "Jakarta", "London", "Los Angeles", "Moscow", "Paris", "Tashkent", "Tokyo", "Washington" };
            LinkedList<string> doublylinkedlist0 = new LinkedList<string>(city0);
            LinkedList<string> doublylinkedlist1 = new LinkedList<string>(city1);


            bool sequenceequals = doublylinkedlist0.SequenceEqual(doublylinkedlist1);

            Assert.IsFalse(sequenceequals);
        }

        [TestMethod()]
        public void SingleTest()
        {
            string[] city = { "Amsterdam" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            Assert.AreEqual("Amsterdam", doublylinkedlist.Single());
        }

        [TestMethod()]
        public void SingleOrDefaultTest()
        {
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            Assert.AreEqual(null, doublylinkedlist.SingleOrDefault());
        }

        [TestMethod()]
        public void TakeTest()
        {
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            string[] city1 = { "Amsterdam", "Berlin", "Instanbul" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            int i = 0;

            IEnumerable<string> query = doublylinkedlist.Take(3);

            Assert.AreEqual(city1.Count(), query.Count());
            foreach (var item in query)
            {
                Assert.AreEqual(item, city1[i]);
                i++;
            }
        }

        [TestMethod()]
        public void UnionTest()
        {
            string[] city0 = { "London", "Tokyo", "Washington" };
            string[] city1 = { "Amsterdam", "Berlin", "Instanbul" };
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            int i = 0;
            LinkedList<string> doublylinkedlist0 = new LinkedList<string>(city0);
            LinkedList<string> doublylinkedlist1 = new LinkedList<string>(city1);


            IEnumerable<string> union = doublylinkedlist1.Union(doublylinkedlist0);

            Assert.AreEqual(city.Count(), union.Count());
            foreach (var item in union)
            {
                Assert.AreEqual(item, city[i]);
                i++;
            }

        }

        [TestMethod()]
        public void TakeLastTest()
        {
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            string[] city1 = { "London", "Tokyo", "Washington" };
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);
            int i = 0;

            IEnumerable<string> query = doublylinkedlist.TakeLast(3);

            Assert.AreEqual(city1.Count(), query.Count());
            foreach (var item in query)
            {
                Assert.AreEqual(item, city1[i]);
                i++;
            }
        }

        [TestMethod()]
        public void OrderByTest()
        {
            string[] city = { "Tokyo", "Amsterdam","Instanbul",
                                "Berlin", "London", "Washington"};
            string[] city0 = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            int i = 0, count = 0;
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            var query = doublylinkedlist.OrderBy(s => { count++; return s; });

            foreach (var item in query)
            {
                Assert.AreEqual(item, city0[i]);
                i++;
            }

        }

        [TestMethod()]
        public void OrderByTest1()
        {
            string[] city = { "Tokyo", "Amsterdam","Instanbul",
                                "Berlin", "London", "Washington"};
            string[] city0 = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            int i = 0, count = 0;
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            var query = doublylinkedlist.OrderBy(s => { count++; return s; }, StringComparer.Ordinal);

            foreach (var item in query)
            {
                Assert.AreEqual(item, city0[i]);
                i++;
            }
        }

        [TestMethod()]
        public void OrderByDescendingTest()
        {
            string[] city = { "Tokyo", "Amsterdam","Instanbul",
                                "Berlin", "London", "Washington"};
            string[] city0 = {"Washington", "Tokyo", "London",
                                "Instanbul", "Berlin", "Amsterdam"};
            int i = 0, count = 0;
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            var query = doublylinkedlist.OrderByDescending(s => { count++; return s; });

            foreach (var item in query)
            {
                Assert.AreEqual(item, city0[i]);
                i++;
            }
        }

        [TestMethod()]
        public void OrderByDescendingTest1()
        {
            string[] city = { "Tokyo", "Amsterdam","Instanbul",
                                "Berlin", "London", "Washington"};
            string[] city0 = {"Washington", "Tokyo", "London",
                                "Instanbul", "Berlin", "Amsterdam"};
            int i = 0, count = 0;
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            var query = doublylinkedlist.OrderByDescending(s => { count++; return s; }, StringComparer.Ordinal);

            foreach (var item in query)
            {
                Assert.AreEqual(item, city0[i]);
                i++;
            }
        }

        [TestMethod()]
        public void PrependTest()
        {
            string[] city = { "Amsterdam", "Berlin", "Instanbul",
                                "London","Tokyo", "Washington"};
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);


            doublylinkedlist.Prepend("Tashkent");



            Assert.AreEqual("Tashkent", doublylinkedlist.First());
        }
    }
}