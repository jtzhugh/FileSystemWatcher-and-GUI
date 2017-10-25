using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Hugh, John Tyger
 * This page exists purely to display the help information
 * 
 * */
namespace hughtCSCD371MidQuarterProject
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            this.textBox1.Text = "This is the help box." + Environment.NewLine + "Extension Filter and Query Filter both accept extensions follow the format .[extensionName], with Extension Filter requiring '*.[extensionName]'." + Environment.NewLine +
                "Write to fcslog.sqlite3 by using the Write To Database button." + Environment.NewLine + "Query takes the selection from Query by Ext and performs a query through the database." + Environment.NewLine +
                "Clear empties the main form's console, the record keeping object, and the database.";
        }
    }
}
