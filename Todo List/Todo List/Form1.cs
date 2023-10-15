using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Title_Click(object sender, EventArgs e)
    {

    }

    private void titleLayout_Paint(object sender, PaintEventArgs e)
    {

    }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
            {
                listBox.Items.Add(textInput.Text);
                textInput.Clear();
                textInput.Focus();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }
    }
}
