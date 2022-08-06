using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace BD_Test {
    public partial class Form1 : Form {
        int counter;

        string
            DB_Name,
            table_Name,
            colomns_Name,

            connectString,

            query;

        string[]
            colomns_Arr;

        OleDbConnection myConnection;

        OleDbCommand command;

        OleDbDataReader reader;

        private void SQL_Query_Button_Click(object sender, EventArgs e) {
            Result_Text.Clear();

            DirectoryInfo info = new DirectoryInfo(Directory.GetCurrentDirectory());

            DirectoryInfo db_dir = info.Parent.Parent.Parent;

            DB_Name = DataBase_Name.Text;
            table_Name = Table_Name_text.Text;
            colomns_Name = Colomns_Name_Text.Text;

            counter = colomns_Name.Count(x => x == ',') + 1;

            query = SQL_Text.Text;

            connectString =
                @$"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={DB_Name};";

            NewConnectString:

            myConnection = new OleDbConnection(connectString);

            command = new OleDbCommand(query, myConnection);

            try {
                myConnection.Open();
            }
            catch (OleDbException) {
                if (connectString == @$"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={db_dir}/{DB_Name};") {
                    MessageBox.Show("Make a new DataBase: \"DB_1.mdb\" and retry.", "Error", MessageBoxButtons.OK);

                    return;
                } 
                else {
                    connectString =
                        @$"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={db_dir}/{DB_Name};";

                    goto NewConnectString;
                }
            }

            reader = command.ExecuteReader();
            
            // Check of sql command input.
            /*
            try {
                reader = command.ExecuteReader();
            } 
            catch (OleDbException) {
                myConnection.Close();

                return;
            }
            //*/

            while (reader.Read()) {
                for (int i = 0; i < counter; ++i)
                    Result_Text.Text += $"{reader[i]} ";
                
                Result_Text.Text += "\r\n";
            }
        }
        private void selectToolStripMenuItem_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;
            colomns_Name = Colomns_Name_Text.Text;

            SQL_Text.Text =
                $"SELECT {colomns_Name}\r\n" +
                $"FROM {table_Name}\r\n" +
                "WHERE ()";
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;
            colomns_Name = Colomns_Name_Text.Text;

            SQL_Text.Text = 
                $"INSERT INTO {table_Name}({colomns_Name})\r\n" +
                "VALUES()";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;
            colomns_Name = Colomns_Name_Text.Text;

            SQL_Text.Text =
                $"DELETE {colomns_Name}\r\n" +
                $"FROM {table_Name}\r\n" +
                "WHERE (<condition>)";
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;
            colomns_Name = Colomns_Name_Text.Text;

            colomns_Arr = colomns_Name.Split(", ");

            SQL_Text.Text =
                $"UPDATE {table_Name}\r\n" +
                "SET ";
            
            for (int i = 0; i < colomns_Arr.Length; ++i) {
                SQL_Text.Text += $"{colomns_Arr[i]} = \"\"";

                if (i != colomns_Arr.Length - 1)
                    SQL_Text.Text += ", ";
            }

            SQL_Text.Text +=
                "\r\nWHERE ()";
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;
            colomns_Name = Colomns_Name_Text.Text;

            SQL_Text.Text =
                $"ALTER TABLE {table_Name}\r\n" +
                "ADD <Colomn_Name> <datatype>";
        }

        private void dropToolStripMenuItem2_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;
            colomns_Name = Colomns_Name_Text.Text;

            SQL_Text.Text =
                $"ALTER TABLE {table_Name}\r\n" +
                "DROP <Colomn_Name>";
        }

        private void modifiToolStripMenuItem_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;
            colomns_Name = Colomns_Name_Text.Text;

            SQL_Text.Text =
                $"ALTER TABLE {table_Name}\r\n" +
                $"MODIFY {colomns_Name} <datatype>";
        }

        // Create new Table.
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) {
            SQL_Text.Text = 
                "CREATE TABLE <table_Name>(\r\n" +
                "<colomn_Name> <datatype>\r\n" +
                ")";
        }

        // Drop Table.
        private void dropToolStripMenuItem1_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;

            SQL_Text.Text = 
                $"DROP TABLE {table_Name}";
        }

        //Delete all rows in Table.
        private void rowsToolStripMenuItem_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;

            SQL_Text.Text =
                "DELETE *\r\n" +
                $"FROM {table_Name}";
        }

        //Delete all rows and colomns in Table.
        private void rowsAndColomnsToolStripMenuItem_Click(object sender, EventArgs e) {
            // Next Updates
        }

        private void renameToolStripMenuItem1_Click(object sender, EventArgs e) {
            table_Name = Table_Name_text.Text;

            SQL_Text.Text =
                $"ALTER TABLE {table_Name}\r\n" +
                "RENAME TO <New_Table_Name>";
        }

        // Create new DB.
        private void createToolStripMenuItem_Click(object sender, EventArgs e) {
            // Next Updates.

        }

        //Drop DB
        private void dropToolStripMenuItem_Click(object sender, EventArgs e) {
            // Next Updates.
        }

        //Delete it.
        //Click on: Table -> CLear.
        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            //
        }
        //*/

        public Form1() {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            myConnection.Close();
        }
    }
}