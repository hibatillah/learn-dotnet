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

    private Panel Task()
    {
      var task = new FlowLayoutPanel { Dock = DockStyle.Fill };
      task.BorderStyle = BorderStyle.Fixed3D;

      var clearButton = new Button();
      clearButton.Text = "Clear Todo";

      return task;
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
      var task = new FlowLayoutPanel { Dock = DockStyle.Fill };
      task.BorderStyle = BorderStyle.Fixed3D;

      var clearButton = new Button { BackColor = Color.Red, ForeColor = Color.LightSlateGray };
      clearButton.Text = "Clear Todo";

      var content = new Label();
      content.Text = textInput.Text;

      task.Controls.Add(content);
      task.Controls.Add(clearButton);

      listBox.Items.Add(task);
      textInput.Text = null;
    }

  }
}
