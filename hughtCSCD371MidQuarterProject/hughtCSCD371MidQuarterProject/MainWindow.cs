using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using hughtCSCD371MidQuarterProject;
/*
 * Hugh, John Tyger
 * This class handles all the methods and buttons in the main form.
 * I think the only notable thing is how messy this is.
 * 
 * */
namespace hughtCSCD371MidQuarterProject
{
    public delegate void WriteToTextBox(string inp);
    public partial class MainWindow : Form
    {
        //Global FileSystemWatcher so events can interact with it
        Watcher watcher = null;
        SQLRec tracker = null;
        QueryForm subForm;
        HelpForm subHelp;
        public MainWindow()
        {
            InitializeComponent();
            StopWatcher.Enabled = false;
            DataWrite.Enabled = false;
            toolStop.Enabled = false;
            subForm = new QueryForm();
            subHelp = new HelpForm();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (watcher != null)
            {
                watcher.Dispose();
                watcher = null;
            }
            
            try
            {
                tracker = new SQLRec();
                watcher = new Watcher(DirectoryTextBox.Text, comboBox1.Text, this, tracker);
                //If this successfully starts the watcher, then the stop button will be enabled
                this.StopWatcher.Enabled = true;
                toolStop.Enabled = true;

                StartWatcher.Enabled = false;
                toolStop.Enabled = false;
                DataWrite.Enabled = false;
                textBox1.AppendText("Started watching " + watcher.targetDir + " for " + watcher.filter + " @ " + DateTime.Now + Environment.NewLine);
            }
            catch (ArgumentNullException exc)
            {
                MessageBox.Show("One of the input args is null! " + exc);
            }
            catch(ArgumentException exc)
            {
                MessageBox.Show("Please enter a valid path. Empty paths are not valid.");
            }
        }
        private void Stop_Click(Object sender, EventArgs e)
        {
            if(watcher != null)
            {
                watcher.Dispose();
                watcher = null;
            }
            StopWatcher.Enabled = false;
            toolStop.Enabled = false;

            toolGo.Enabled = true;
            StartWatcher.Enabled = true;
            DataWrite.Enabled = true;

        }

        public void AddOutTxt(string inp)
        {
            if (textBox1.InvokeRequired)
            {
                WriteToTextBox w = new WriteToTextBox(AddOutTxt);
                Invoke(w, new object[] { inp });
            }
            else
            {
                textBox1.AppendText(inp + Environment.NewLine);
            }
            
        }
        private void WriteToDatabase(object sender, EventArgs e)
        {

            string DBName = "fcslog.sqlite3";
            string Command;
            //This if structure is gross, but it ended up being necessary
            if (watcher == null)
            {
                if (tracker.getCount() > 0)
                {
                    if (!File.Exists(DBName))
                    {
                        try
                        {
                            SQLiteConnection.CreateFile(DBName);
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Invalid path. Please enter a valid path.");
                        }
                    }
                    //Now we actually connect
                    SQLiteConnection DB = new SQLiteConnection("Data Source =" + DBName + ";Version=3;");
                    SQLiteCommand SQC;

                    //Opening the db
                    DB.Open();
                    SQC = DB.CreateCommand();
                    //Creating the table

                     Command = "CREATE TABLE IF NOT EXISTS eventTable (name varchar(100), absPath varchar(100), eventType varchar(100), time varchar(100), ext varchar(100))";
                     SQC = new SQLiteCommand(Command, DB);
                     SQC.ExecuteNonQuery();

                    foreach (SQLRec.SRec x in tracker.holder)
                    {
                        Command = "INSERT INTO eventTable (name, absPath, eventType, time, ext) VALUES ('" + x.name + "', '" + x.absPath + "', '" + x.eventType + "', '" + x.time + "', '" + x.ext + "');";
                        SQC = new SQLiteCommand(Command, DB);
                        SQC.ExecuteNonQuery();
                    }
                    DB.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DirectoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to write to a database before closing?", "", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                WriteToDatabase(sender, e);
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            if(tracker != null)
                this.tracker.holder.Clear();

            //Clearing the database;
            string DBName = "fcslog.sqlite3";
            SQLiteConnection DB = new SQLiteConnection("Data Source =" + DBName + ";Version=3;");
            //Starting the SQLiteDataReader
            DB.Open();
            SQLiteCommand SQC = new SQLiteCommand();
            string SQL = "DELETE FROM eventTable;";
            SQC = new SQLiteCommand(SQL, DB);
            SQC.ExecuteNonQuery();

            DB.Close();
        }

        private void Query_Click(object sender, EventArgs e)
        {
            subForm.Show();
            subForm.LaunchQuery(QueryCombo.Text, this);
            subForm = new QueryForm();
            
        }

        private void QueryLabel_Click(object sender, EventArgs e)
        {

        }

        private void ToolHelp_Click(object sender, EventArgs e)
        {
            if (subHelp.IsDisposed == true)
            {
                subHelp = new HelpForm();
            }
            subHelp.Show();
        }

        private void ToolQ_Click(object sender, EventArgs e)
        {
            subForm.Show();
            subForm.LaunchQuery(".&", this);
            subForm = new QueryForm();
        }
    }
}
