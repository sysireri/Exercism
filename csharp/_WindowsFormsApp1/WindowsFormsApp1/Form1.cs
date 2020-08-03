using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strTest = "   eric   ";
            string strResult = strTest.Trim().ToUpper();
            MessageBox.Show(strResult);

            System.Text.StringBuilder objStringBuilder = new StringBuilder("   eric   ");
            MessageBox.Show(objStringBuilder.ToString().Trim().ToUpper());

            DestroyObjects(null,null,null,null,objStringBuilder);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string strPath = "";
            string[] strLsitOfFiles;
            try
            {
                lstFiles.Items.Clear();

                strPath = txtDirectory.Text.Trim().ToUpper();

                if (System.IO.Directory.Exists(strPath))
                {
                    strLsitOfFiles = System.IO.Directory.GetFiles(strPath, "*.*");
                    foreach (string strCurrentFile in strLsitOfFiles)
                    {
                        lstFiles.Items.Add(strCurrentFile.ToUpper());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Stack Trace: " + System.Environment.NewLine  + ex.StackTrace);
            }
            finally
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strExcelFile = "";
            string strConnectionString = "";
            string strFirstSheetName = "";

            System.Data.OleDb.OleDbConnection objOleConnection = new System.Data.OleDb.OleDbConnection();
            System.Data.DataTable objDataTableSheetName = null;
            System.Data.DataTable objDataTableSheetContents = new System.Data.DataTable();
            System.Data.Common.DbCommand objDbCommand = null;
            System.Data.Common.DbDataReader objDbDataReader = null;

            try
            {
                strExcelFile = txtExcelFile.Text.Trim().ToUpper();
                if (System.IO.File.Exists(strExcelFile))
                {
                    //strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strExcelFile + ";Extended Properties=Excel 8.0;HDR=YES";
                    strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strExcelFile + ";Extended Properties='Excel 8.0;HDR=YES'";
                    objOleConnection.ConnectionString = strConnectionString;
                    objOleConnection.Open();

                    objDataTableSheetName = objOleConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);

                    if(objDataTableSheetName != null)
                    {
                        System.Data.DataRow objCurrentRow =  objDataTableSheetName.Rows[0];

                        strFirstSheetName = objCurrentRow.Field<string>("TABLE_NAME");

                        objDbCommand = objOleConnection.CreateCommand();
                        objDbCommand.CommandText = "SELECT * FROM [" + strFirstSheetName + "]";
                        objDbDataReader = objDbCommand.ExecuteReader(CommandBehavior.CloseConnection);

                        objDataTableSheetContents.Load(objDbDataReader);

                        GrdExcel.DataSource = objDataTableSheetContents;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Stack Trace: " + System.Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                DestroyObjects(objOleConnection,objDataTableSheetName,objDbCommand,objDbDataReader,null);
            }
        }

        public void DestroyObjects(System.Data.OleDb.OleDbConnection robjOleConnection =  null,
                                   System.Data.DataTable robjDataTable = null,
                                   System.Data.Common.DbCommand robjDbCommand = null,
                                   System.Data.Common.DbDataReader robjDbDataReader = null,
                                   System.Text.StringBuilder robjStringBuilder = null)
        {
            try
            {
                if(robjStringBuilder != null)
                {
                    robjStringBuilder.Clear();
                    robjStringBuilder = null;
                }
                if(robjDataTable != null)
                {
                    robjDataTable.Clear();
                    robjDataTable.Dispose();
                    robjDataTable = null;
                }
                if(robjDbDataReader != null)
                {
                    robjDbDataReader.Close();
                    robjDbDataReader = null;
                }
                if(robjDbCommand != null)
                {
                    if(robjDbCommand.Parameters != null)
                    {
                        robjDbCommand.Parameters.Clear();
                    }
                    robjDbCommand.Dispose();
                    robjDbCommand = null;
                }

                if(robjOleConnection != null)
                {
                    if(robjOleConnection.State != System.Data.ConnectionState.Closed)
                    {
                        robjOleConnection.Close();
                    }
                    robjOleConnection.Dispose();
                    robjOleConnection = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Stack Trace: " + System.Environment.NewLine + ex.StackTrace);
            }
            finally
            {

            }
        }
    }
}
