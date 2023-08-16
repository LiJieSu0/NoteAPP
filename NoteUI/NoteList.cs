using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NoteUI
{
    public partial class NoteListForm : Form
    {
        private bool toggle=false;
        public NoteListForm()
        {
            InitializeComponent();
            
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            toggle = !toggle;
            if(toggle)
            {
                myLabel.Text = "true";
            }
            else
            {
                myLabel.Text="false";
            }   
        }
    }
}
