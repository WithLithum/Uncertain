namespace Uncertain.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uncertain.Models;
using Uncertain.Properties;

public partial class TheoryWindow : Form
{
    public string Title => textTitle.Text;
    public string Content => textContent.Rtf;

    public TheoryWindow(Theory theory) : this()
    {
        textTitle.Text = theory.Name;
        try
        {
            textContent.Rtf = theory.Description;
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show($"Unable to open theory {theory.Name} as rich format: {ex.Message}{Environment.NewLine}Opening as plain text.");
            textContent.Text = theory.Description;
        }
    }

    public TheoryWindow()
    {
        InitializeComponent();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textTitle.Text))
        {
            MessageBox.Show("Theories must have a title.");
            return;
        }

        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void TheoryWindow_Load(object sender, EventArgs e)
    {
        this.Size = Settings.Default.TheoryWindowSize;
    }

    private void TheoryWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
        Settings.Default.TheoryWindowSize = this.Size;
        Settings.Default.Save();
    }

    private void UpdateFont()
    {
        var style = FontStyle.Regular;

        if (checkBold.Checked)
        {
            style |= FontStyle.Bold;
        }

        if (checkItalic.Checked)
        {
            style |= FontStyle.Italic;
        }

        if (checkUnderline.Checked)
        {
            style |= FontStyle.Underline;
        }

        textContent.SelectionFont = new Font(textContent.SelectionFont, style);
    }

    private void checkBold_CheckedChanged(object sender, EventArgs e)
    {
        UpdateFont();
    }

    private void checkItalic_CheckedChanged(object sender, EventArgs e)
    {
        UpdateFont();
    }

    private void textContent_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control)
        {
            switch (e.KeyCode)
            {
                case Keys.B:
                    checkBold.Checked = !checkBold.Checked;
                    break;

                case Keys.I:
                    checkItalic.Checked = !checkItalic.Checked;
                    break;

                case Keys.U:
                    checkUnderline.Checked = !checkUnderline.Checked;
                    break;
            }
        }
    }
}
