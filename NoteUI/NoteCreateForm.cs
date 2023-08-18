using NoteLibrary;
using System.Diagnostics;

namespace NoteUI
{
    public partial class NoteCreateForm : Form
    {
        NoteListForm original;
        /*
        public enum NoteType
        {
            ShoppingList,
            Meeting,
            TodoList,
            Miscellaneous,
        }
         */
        public NoteCreateForm(NoteListForm original, PassNoteData noteData)
        {
            InitializeComponent();
            this.original = original;
            this.FormClosed += NoteCreateFormClosed;
            noteTypeComboBox.Items.Add("Shopping List");
            noteTypeComboBox.Items.Add("Meeting");
            noteTypeComboBox.Items.Add("Todo List");
            noteTypeComboBox.Items.Add("Miscellaneous");
            noteTypeComboBox.SelectedIndex = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        private void NoteCreateFormClosed(object sender, EventArgs e)
        {
            this.Hide();
            original.Show();
        }

        private void noteTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            bool isCreateSuccess = false;
            string? noteTypeStr = noteTypeComboBox.Items[noteTypeComboBox.SelectedIndex].ToString();
            string creatorName = creatorTxtBox.Text;
            string creatorEmail = emailTxtBox.Text;
            string noteTitle = noteTitleTxtBox.Text;
            string noteContent = noteTxtBox.Text;
            bool isAllowedCoEdit = coeditCheckBox.Checked;
            try
            {
                DB_Connection connection = GlobalConfig.InitializeConnection();
                CreatorModel creator = new CreatorModel(creatorName, creatorEmail);
                NoteModel note = new NoteModel(creator, noteContent, noteTitle);
                //creator.CreateNote(note);
                await connection.InsertCreator(creator);
                await connection.InsertNote(note);
                isCreateSuccess = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            //TODO check creator is in the database?

            if (isCreateSuccess)
            {
                this.Hide();
                original.Show();
            }
        }

        private void NoteCreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}