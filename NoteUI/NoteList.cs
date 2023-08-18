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
    public struct PassNoteData
    {
        public string noteTitle;
        public bool isEditable;
        public bool isCreator;
    }
    public partial class NoteListForm : Form
    {
        private bool toggle = false;
        private List<NoteModel> noteList = new List<NoteModel>();
        public NoteListForm()
        {
            InitializeComponent();
            this.FormClosing += NoteList_FormClosing;
            showNotesInBox();
            //noteListBox.SelectionMode = SelectionMode.One;
            //TODO show all notes get from mongodb
        }
        private void NoteListForm_Load(object sender, EventArgs e)
        {

        }
        private async void showNotesInBox()
        {
            DB_Connection connection = GlobalConfig.InitializeConnection();
            noteList = await connection.GetAllNotes();
            foreach (var i in noteList)
            {
                noteListBox.Items.Add(i.NoteTitle);
            }
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            string selectedOption;
            selectedOption = noteListBox.SelectedItem.ToString();
            MessageBox.Show(selectedOption);

        }

        private void showBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
