using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfProject
{
    public partial class Form1 : Form
    {
        //connection string
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Golf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        SqlConnection Con = new SqlConnection();
        DataTable GolfTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {

        }

        private void loaddb()
        {
            //load datatable colums
            datatablecolumns();


        }

        private void datatablecolumns()
        {

            //clear the old data
            GolfTable.Clear();
            //add in the column titlees to the datable
            try
            {
                GolfTable.Columns.Add("ID");
                GolfTable.Columns.Add("Title");
                GolfTable.Columns.Add("Firstname");
                GolfTable.Columns.Add("Surname");
                GolfTable.Columns.Add("Gender");
                GolfTable.Columns.Add("DOB");
                GolfTable.Columns.Add("Street");
                GolfTable.Columns.Add("Suburb");
                GolfTable.Columns.Add("City");
                GolfTable.Columns.Add("Availavle week days");
                GolfTable.Columns.Add("Handicap");

            }
            catch (Exception s)
            {
                //MessageBox.Show("Data Table not loading"+ s.Message);
            }
        }


    }
}
