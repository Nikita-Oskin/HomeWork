﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using Devart.Common;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pcshop
{
    public class CRUD
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public static string sql = string.Empty;

        SqlDataAdapter adprt;
        DataSet dset;
        public DataTable dt;
        static string getmessage { get; set; }

        public CRUD()
        {
            conn = new SqlConnection(webconfig.constring);
            cmd = new SqlCommand();
            adprt = new SqlDataAdapter();
            dset = new DataSet();
            dt = new DataTable();
        }
        
        public void Read_data(string query)
        {
            dt.Clear();
            string select = query;
            adprt = new SqlDataAdapter(select, conn);
            adprt.Fill(dset);
            dt = dset.Tables[0];
        }

        public bool Connect()
        {
            try
            {
                conn.Open();
                getmessage = "Connected";
                return true;
            }
            catch (Exception ex)
            {
                getmessage = "бд не подключился";
                return false;
            }
        }

        public bool Disconnect()
        {
            try
            {
                conn.Close();
                getmessage = "Close";
                return true;
            }
            catch (Exception ex)
            {
                getmessage = "бд не отключился";
                return false;
            }
        }
        

        public string custominsertupdatedelete(SqlCommand cmd2parameterizednoconnectionNeeded)
        {
            string ret = "";
            string allqueries = cmd2parameterizednoconnectionNeeded.CommandText;
            try
            {
                cmd2parameterizednoconnectionNeeded.Connection = conn;
                Connect();

                cmd2parameterizednoconnectionNeeded.ExecuteNonQuery();
                if (allqueries.Contains("INSERT INTO "))
                {
                    ret = getmessage = "Добавлено";
                }
                else if (allqueries.Contains("DELETE FROM "))
                {
                    ret = getmessage = "Удалено";
                }
                else if (allqueries.Contains("UPDATE "))
                {
                    ret = getmessage = "Изменено";
                }
            }
            catch (Exception ex)
            {
                ret = getmessage = "Failed to execute " + cmd2parameterizednoconnectionNeeded.CommandText + "\n Reason: " + ex.Message;
            }
            finally { Disconnect(); }
            return ret;
        }

    }
    class webconfig
    {
        private static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\BLOCK3\Block3_WF\pcshop_wpf\Database1.mdf;Integrated Security=True";
        public static string constring { get { return cs; } }
    }

}
