using NoteLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NoteUI
{
    public partial class NoteListForm : Form
    {
        private bool toggle = false;
        public NoteListForm()
        {
            InitializeComponent();
            this.FormClosing += NoteList_FormClosing;
            DB_Connection connection = GlobalConfig.InitializeConnection();
            //TODO show all notes get from mongodb
        }
        private void NoteListForm_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteCreateForm noteCreateForm = new NoteCreateForm(this);
            noteCreateForm.Show();
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(searchTxtBox.Text);
            searchTxtBox.Clear();
        }

        private void NoteList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; // Cancel the closing operation
            }
            
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
