using NUnit.Framework;
using System.Data.SqlClient;
using System;


namespace pcshop.Tests
{
    public class CRUDTest
    {
        // For the test, we have a test table in the database (TestTable)
        // We check all our add, change, and delete requests in a test table so as not to spoil the necessary
        // Work with the test table and the rest is the same.

        // We use one test project, since the logic for all 3 applications is the same

        pcshop.CRUD dl;
        pcshop_wpf.CRUD dl_wpf;
        pcshop_console.CRUD dl_console;

        [SetUp]
        public void Setup()
        {
            dl = new CRUD();
            dl_console = new pcshop_console.CRUD();
            dl_wpf = new pcshop_wpf.CRUD();
        }


        // connection test
        [Test]
        public void ConnectTest()
        {
            bool IsConnect = dl.Connect();
            bool IsConnect_wpf = dl_wpf.Connect();
            bool IsConnect_console = dl_console.Connect();

            Assert.IsTrue(IsConnect);
            Assert.IsTrue(IsConnect_console);
            Assert.IsTrue(IsConnect_wpf);
        }

        // shutdown test
        [Test]
        public void DisconnectTest()
        {
            bool IsDisconnect = dl.Disconnect();
            bool IsDisconnect_wpf = dl_wpf.Disconnect();
            bool IsDisconnect_console = dl_console.Disconnect();

            Assert.IsTrue(IsDisconnect);
            Assert.IsTrue(IsDisconnect_wpf);
            Assert.IsTrue(IsDisconnect_console);
        }


        // We check whether data is added to the table, if successful, the result will be the output of the message "Added"
        [Test]
        public void InsertTest()
        {
            string query = "INSERT INTO TestTable(TestFirstName, TestLastName, TestAge) VALUES ('Doctor', 'Strange', 46)";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            string ret = dl.custominsertupdatedelete(cmd);

            Assert.AreEqual("Added", ret);
        }

        // We check whether the data in the table changes, if successful, the result will be the output of the message "Changed"
        [Test]
        public void UpdateTest()
        {
            string query = "UPDATE TestTable SET TestFirstName = 'Tony', TestLastName = 'Stark' WHERE id=4";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            string ret = dl.custominsertupdatedelete(cmd);

            Assert.AreEqual("Changed", ret);
        }


        // We check whether the data in the table is deleted, if successful, the result will be the output of the message "Deleted"
        [Test]
        public void DeleteTest()
        {
            string query = "DELETE FROM TestTable WHERE id=2";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            string ret = dl.custominsertupdatedelete(cmd);

            Assert.AreEqual("Deleted", ret);
        }
    }
}
