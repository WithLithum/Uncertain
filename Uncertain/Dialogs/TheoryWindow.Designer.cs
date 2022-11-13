namespace Uncertain.Dialogs;

partial class TheoryWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoryWindow));
            this.textTitle = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRich = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBold = new System.Windows.Forms.CheckBox();
            this.checkItalic = new System.Windows.Forms.CheckBox();
            this.checkUnderline = new System.Windows.Forms.CheckBox();
            this.textContent = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowRich.SuspendLayout();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.Color.Black;
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTitle.ForeColor = System.Drawing.Color.White;
            this.textTitle.Location = new System.Drawing.Point(3, 3);
            this.textTitle.Name = "textTitle";
            this.textTitle.PlaceholderText = "Theory Title....";
            this.textTitle.Size = new System.Drawing.Size(650, 25);
            this.textTitle.TabIndex = 0;
            this.textTitle.Text = "Unnamed Theory";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(553, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(453, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowRich, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textContent, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 424);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 387);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(650, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowRich
            // 
            this.flowRich.Controls.Add(this.checkBold);
            this.flowRich.Controls.Add(this.checkItalic);
            this.flowRich.Controls.Add(this.checkUnderline);
            this.flowRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowRich.Location = new System.Drawing.Point(3, 29);
            this.flowRich.Name = "flowRich";
            this.flowRich.Size = new System.Drawing.Size(650, 20);
            this.flowRich.TabIndex = 3;
            // 
            // checkBold
            // 
            this.checkBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBold.BackColor = System.Drawing.Color.White;
            this.checkBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBold.Image = ((System.Drawing.Image)(resources.GetObject("checkBold.Image")));
            this.checkBold.Location = new System.Drawing.Point(3, 3);
            this.checkBold.Name = "checkBold";
            this.checkBold.Size = new System.Drawing.Size(17, 17);
            this.checkBold.TabIndex = 0;
            this.checkBold.UseVisualStyleBackColor = false;
            this.checkBold.CheckedChanged += new System.EventHandler(this.checkBold_CheckedChanged);
            // 
            // checkItalic
            // 
            this.checkItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkItalic.BackColor = System.Drawing.Color.White;
            this.checkItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkItalic.Image = ((System.Drawing.Image)(resources.GetObject("checkItalic.Image")));
            this.checkItalic.Location = new System.Drawing.Point(26, 3);
            this.checkItalic.Name = "checkItalic";
            this.checkItalic.Size = new System.Drawing.Size(17, 17);
            this.checkItalic.TabIndex = 1;
            this.checkItalic.UseVisualStyleBackColor = false;
            this.checkItalic.CheckedChanged += new System.EventHandler(this.checkItalic_CheckedChanged);
            // 
            // checkUnderline
            // 
            this.checkUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkUnderline.BackColor = System.Drawing.Color.White;
            this.checkUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkUnderline.Image = ((System.Drawing.Image)(resources.GetObject("checkUnderline.Image")));
            this.checkUnderline.Location = new System.Drawing.Point(49, 3);
            this.checkUnderline.Name = "checkUnderline";
            this.checkUnderline.Size = new System.Drawing.Size(17, 17);
            this.checkUnderline.TabIndex = 2;
            this.checkUnderline.UseVisualStyleBackColor = false;
            // 
            // textContent
            // 
            this.textContent.BackColor = System.Drawing.Color.Black;
            this.textContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textContent.ForeColor = System.Drawing.Color.White;
            this.textContent.Location = new System.Drawing.Point(3, 55);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(650, 326);
            this.textContent.TabIndex = 4;
            this.textContent.Text = "";
            this.textContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textContent_KeyDown);
            // 
            // TheoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(656, 424);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(479, 264);
            this.Name = "TheoryWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Theory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheoryWindow_FormClosing);
            this.Load += new System.EventHandler(this.TheoryWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowRich.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private TextBox textTitle;
    private Button buttonSave;
    private Button buttonCancel;
    private TableLayoutPanel tableLayoutPanel1;
    private FlowLayoutPanel flowLayoutPanel1;
    private FlowLayoutPanel flowRich;
    private RichTextBox textContent;
    private CheckBox checkBold;
    private CheckBox checkItalic;
    private CheckBox checkUnderline;
}