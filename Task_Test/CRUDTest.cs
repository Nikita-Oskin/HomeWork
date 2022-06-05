using NUnit.Framework;
using System.Data.SqlClient;
using System;


namespace pcshop.Tests
{
    public class CRUDTest
    {
        // Для теста у нас есть тестовая таблица в БД (TestTable)
        // Все наши запросы добавления, изменения и удаления проверяем в тестовой таблице чтобы не испортить нужные
        // Работы с тестовой таблицой и остальными одинаково.

        // Используем один тестовый проект, так как логика для всех 3х приложении одинокова

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


        // Проверка подключения
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

        // Проверка отключения
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


        // Проверяем добавляется ли данные в талицу, если успешно то результатом будет вывод сообщения "Добавлено"
        [Test]
        public void InsertTest()
        {
            string query = "INSERT INTO TestTable(TestFirstName, TestLastName, TestAge) VALUES ('Doctor', 'Strange', 46)";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            string ret = dl.custominsertupdatedelete(cmd);

            Assert.AreEqual("Добавлено", ret);
        }

        // Првоеряем изменяется ли данные в таблице, если успешно то результатом будет вывод сообщения "Изменено"
        [Test]
        public void UpdateTest()
        {
            string query = "UPDATE TestTable SET TestFirstName = 'Tony', TestLastName = 'Stark' WHERE id=4";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            string ret = dl.custominsertupdatedelete(cmd);

            Assert.AreEqual("Изменено", ret);
        }


        // Проверяем удаляется ли данные в таблице, если успешно то результатом будет вывод сообщения "Удалено"
        [Test]
        public void DeleteTest()
        {
            string query = "DELETE FROM TestTable WHERE id=2";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            string ret = dl.custominsertupdatedelete(cmd);

            Assert.AreEqual("Удалено", ret);
        }
    }
}