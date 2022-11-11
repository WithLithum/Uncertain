namespace Uncertain.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uncertain.Properties;

public partial class AboutWindow : Form
{
    public AboutWindow()
    {
        InitializeComponent();
    }

    private void AboutWindow_Load(object sender, EventArgs e)
    {
        var version = Assembly.GetExecutingAssembly()?.GetName()?.Version?.ToString();

        if (version != null)
        {
            label1.Text = $"UNCERTAIN Software, version {version}";
        }

        textDetails.Text = Resources.CopyrightStuff;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}
