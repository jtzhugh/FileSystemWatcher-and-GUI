using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Hugh, John Tyger
 * This page handles the queries and displays them in a data grid
 * 
 * */
namespace hughtCSCD371MidQuarterProject
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {

            InitializeComponent();
            
        }
        public void LaunchQuery(string filter, MainWindow mainWin)
        {
            
            string DBName = "fcslog.sqlite3";
            SQLiteConnection DB = new SQLiteConnection("Data Source =" + DBName + ";Version=3;");
            //Starting the SQLiteDataReader
            DB.Open();
            if (filter == ".*")
                filter = ".%";
            SQLiteCommand SQC = new SQLiteCommand();
            string SQL = "SELECT * FROM eventTable WHERE name LIKE '%" + filter +"';";
            mainWin.textBox1.AppendText(SQL + Environment.NewLine);
            SQC = new SQLiteCommand(SQL, DB);

            //Initializing the two most important pieces of the read and add
            SQLiteDataReader r = SQC.ExecuteReader();
            dataGrid.Rows.Clear();

            while (r.Read())
            {
                string name = r[0].ToString();
                string absPath = r[1].ToString();
                string eventType = r[2].ToString();
                string dateTime = r[3].ToString();
                string ext = r[4].ToString();

                string[] resultsAr = new string[] { name, absPath, eventType, dateTime, ext };
                dataGrid.Rows.Add(resultsAr);

            }
            DB.Close();

        }
    }
}
