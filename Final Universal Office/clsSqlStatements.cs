using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace Ribbonpad
{
    class clsSqlStatements
    {
        public static string connectionString = "";
        //string connectionString = "";
         
        string Condition = "";
        
        public int rowAffect = 0;
        public int counter = 0;

        public string getconnectionString()
        {
            return connectionString;
        }

        public void setConnectionString()
        {
            try
            {
                connectionString = @"" + File.ReadAllText("constring.ini");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load database");
            }
        }

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader rd = null;

        public int maxID(string tableName)
        {
            int maxId = 0;

            con = new SqlConnection(connectionString);
            con.Open();
            try
            {

                cmd = new SqlCommand("Select max(Id) from " + tableName, con);
                rd = cmd.ExecuteReader();
                try
                {
                    if (rd.Read())
                    {
                        maxId = int.Parse("" + rd[0]);
                    }
                }
                catch (Exception ex)
                {
                }
                maxId++;
            }
            catch (Exception ex)
            {
                return -1;
            }

            finally
            {
                if (con != null)
                    con.Close();
            }
            return maxId;
        }

        public int getRecordID(string tableName, string conditon)
        {
            if (conditon != "")
                Condition = " where " + conditon;

            int recordId = 0;

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("Select Id from " + tableName + " " + Condition, con);
                rd = cmd.ExecuteReader();
                try
                {
                    if (rd.Read())
                    {
                        recordId = int.Parse("" + rd[0]);
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

            finally
            {
                if (con != null)
                    con.Close();
            }
            return
                recordId;
        }

        public string getRecord(string tableName,string field, string conditon)
        {
            if (conditon != "")
                Condition = " where " + conditon;
            string selectedValue = "";
            con = new SqlConnection(connectionString);
            con.Open();
            try
            {

                cmd = new SqlCommand("Select " + field + " from " + tableName + " " + Condition, con);
                rd = cmd.ExecuteReader();
                try
                {
                    if (rd.Read())
                    {
                        selectedValue = "" + rd[0];
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                selectedValue = "";
            }

            finally
            {
                if (con != null)
                    con.Close();
            }
            return
                selectedValue;
        }
        
        public int insertRecord(string tableName,string columns,string values,Boolean showMessage)
        {
            rowAffect = 0;
            if (columns != "")
                columns = "(" + columns + ")";
            try
            {
                if (con == null)
                    con = new SqlConnection(connectionString);
                con.Open();
                try
                {
                    cmd = new SqlCommand("Insert into " + tableName + " " + columns + " values (" + values + ")", con);
                    rowAffect = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while inserting record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }
                if (rowAffect > 0)
                {
                    if (showMessage)
                        MessageBox.Show("New record added","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            { }
            return rowAffect;
        }

        public int updateRecord(string tableName, string values,string condition,Boolean showMessage)
        {
            Condition = "";
            if (condition != "")
                Condition = "where "+condition;
            rowAffect = 0;
            try
            {
                if (con == null)
                    con = new SqlConnection(connectionString);
                con.Open();
                try
                {
                    cmd = new SqlCommand("Update " + tableName + " set " + values + " " + Condition, con);
                    rowAffect = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }
                if (rowAffect > 0)
                {
                    if (showMessage)
                        MessageBox.Show("Record updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
            return rowAffect;
        }

        public int deleteRecord(string tableName, string condition,Boolean showDialog)
        {
            Condition = "";
            if (condition != "")
                Condition = "where "+condition;

            rowAffect = 0;
            try
            {
                if (con == null)
                    con = new SqlConnection(connectionString);
                con.Open();
                try
                {
                    cmd = new SqlCommand("delete from " + tableName + " " + Condition + ";", con);
                    rowAffect = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }
                if (showDialog)
                {
                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Record deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rowAffect;
        }

        public void fillCombo(ComboBox combobox, string tableName, string values, string condition,Boolean clearData)
        {
            if (clearData)
            {
                combobox.Items.Clear();
            }
            Condition = "";
            if (condition != "")
                Condition = "where " + condition;
            try
            {
                if (con == null)
                    con = new SqlConnection(connectionString);
                con.Open();
                try
                {
                    cmd = new SqlCommand("select distinct("+values+") from " + tableName + " " + Condition + ";", con);
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        combobox.Items.Add("" + rd[0]);
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
