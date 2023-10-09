namespace Todo_List
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.titleLayout = new System.Windows.Forms.FlowLayoutPanel();
      this.Title = new System.Windows.Forms.Label();
      this.textInput = new System.Windows.Forms.TextBox();
      this.submitButton = new System.Windows.Forms.Button();
      this.listBox = new System.Windows.Forms.ListBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.titleLayout.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.Controls.Add(this.titleLayout, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.textInput, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.submitButton, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.listBox, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(50);
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 527);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // titleLayout
      // 
      this.titleLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.titleLayout, 2);
      this.titleLayout.Controls.Add(this.Title);
      this.titleLayout.Location = new System.Drawing.Point(53, 53);
      this.titleLayout.Name = "titleLayout";
      this.titleLayout.Size = new System.Drawing.Size(671, 45);
      this.titleLayout.TabIndex = 0;
      this.titleLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.titleLayout_Paint);
      // 
      // Title
      // 
      this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Title.AutoSize = true;
      this.Title.BackColor = System.Drawing.SystemColors.Control;
      this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(3, 0);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(135, 22);
      this.Title.TabIndex = 0;
      this.Title.Text = "Add your todo";
      this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.Title.Click += new System.EventHandler(this.Title_Click);
      // 
      // textInput
      // 
      this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textInput.Location = new System.Drawing.Point(53, 104);
      this.textInput.MaximumSize = new System.Drawing.Size(570, 60);
      this.textInput.Multiline = true;
      this.textInput.Name = "textInput";
      this.textInput.Size = new System.Drawing.Size(569, 28);
      this.textInput.TabIndex = 3;
      // 
      // submitButton
      // 
      this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.submitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.submitButton.Location = new System.Drawing.Point(628, 104);
      this.submitButton.Name = "submitButton";
      this.submitButton.Size = new System.Drawing.Size(96, 28);
      this.submitButton.TabIndex = 4;
      this.submitButton.Text = "Add todo";
      this.submitButton.UseVisualStyleBackColor = false;
      this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
      // 
      // listBox
      // 
      this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.listBox, 2);
      this.listBox.FormattingEnabled = true;
      this.listBox.ItemHeight = 16;
      this.listBox.Location = new System.Drawing.Point(53, 155);
      this.listBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
      this.listBox.Name = "listBox";
      this.listBox.Size = new System.Drawing.Size(671, 308);
      this.listBox.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(777, 527);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Todo List";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.titleLayout.ResumeLayout(false);
      this.titleLayout.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label Title;
    private System.Windows.Forms.Button submitButton;
    private System.Windows.Forms.TextBox textInput;
    private System.Windows.Forms.FlowLayoutPanel titleLayout;
    private System.Windows.Forms.ListBox listBox;
  }
}

