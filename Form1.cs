using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteApp : Form
    {
        public NoteApp()
        {
            InitializeComponent();
        }

        private void textEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void createNote_Click(object sender, EventArgs e)
        {
            string noteEntry = textEntry.Text;
            
            if (noteEntry == "")
            {
                MessageBox.Show("Please Enter Text!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string date = DateTime.Now.ToString();
                listOfNotes.Items.Add(noteEntry + "   " + date);
                textEntry.Text = "";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(listOfNotes.SelectedItem != null)
            {
               listOfNotes.Items.Remove(listOfNotes.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select item first!","Error",MessageBoxButtons.OK);
            }
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
