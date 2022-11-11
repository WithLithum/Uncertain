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

public partial class TheoryWindow : Form
{
    public string Title => textTitle.Text;
    public string Content => textContent.Text;

    public TheoryWindow(Theory theory) : this()
    {
        textTitle.Text = theory.Name;
        textContent.Text = theory.Description;

        textTitle.ReadOnly = true;
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
}
