using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTester
{
    public partial class frmTester : Form
    {
        OleDbConnection conn;

        public frmTester()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = null;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable table = new DataTable();

            try
            {
                cmd = new OleDbCommand(txtCommand.Text, conn);
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                grdRecords.DataSource = table;
                lblCount.Text = table.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmd.Dispose();
            adapter.Dispose();
            table.Dispose();
        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            bool openFileDialogOpen = true;
            bool chooseDB = true;

            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }

            do
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    openFileDialogOpen = false;
                    chooseDB = false;

                    btnExecute.Enabled = false;
                    txtCommand.Enabled = false;
                    continue;
                }

                if (System.IO.Path.GetExtension(openFileDialog.FileName) == ".accdb")
                {
                    openFileDialogOpen = false;
                }
                else
                {
                    MessageBox.Show("You are choose wrong file type.\nTryAgain!", "Wrong type...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } while (openFileDialogOpen);
            
            if(chooseDB)
            {
                var connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog.FileName +
                ";Persist Security Info=False;";

                conn = new OleDbConnection(connString);
                conn.Open();

                btnExecute.Enabled = true;
                txtCommand.Enabled = true;
            }
        }
    }
}
