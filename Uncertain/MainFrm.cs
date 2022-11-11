namespace Uncertain;

using LiteDB;
using Uncertain.Dialogs;
using Uncertain.Models;

public partial class MainFrm : Form
{
    private readonly LiteDatabase _db = new(@"Uncertain.db");
    private const string _dbCollectionName = "uc_theories";

    public MainFrm()
    {
        InitializeComponent();
    }

    private void CreateTheoryViaWindow()
    {
        var window = new TheoryWindow();

        if (window.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        var col = _db.GetCollection<Theory>(_dbCollectionName);

        if (col.FindOne(x => Name == window.Title) != null)
        {
            MessageBox.Show("A theory with that name already exists!");
            return;
        }

        var theory = new Theory
        {
            Description = window.Content,
            Name = window.Title
        };

        col.Insert(theory);
    }

    private void RefreshList()
    {
        listTheory.Items.Clear();
        var col = _db.GetCollection<Theory>(_dbCollectionName);
        var items = col.FindAll();

        foreach (var item in items)
        {
            if (item == null) continue;
            listTheory.Items.Add(item.Name);
        }
    }

    private void buttonCreate_Click(object sender, EventArgs e)
    {
        CreateTheoryViaWindow();
        RefreshList();
    }

    private void MainFrm_Load(object sender, EventArgs e)
    {
        RefreshList();
    }

    private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _db.Dispose();
    }

    private void buttonOpen_Click(object sender, EventArgs e)
    {
        if (!TryGetSelectedTheory(out var item) || item == null)
        {
            return;
        }

        var window = new TheoryWindow(item);
        if (window.ShowDialog() == DialogResult.OK)
        {
            var col = _db.GetCollection<Theory>(_dbCollectionName);
            item.Description = window.Content;
            col.Update(item);
        }
    }

    private bool TryGetSelectedTheory(out Theory? theory)
    {
        var sel = listTheory.SelectedItem?.ToString();

        if (string.IsNullOrWhiteSpace(sel))
        {
            theory = null;
            return false;
        }

        var col = _db.GetCollection<Theory>(_dbCollectionName);
        var item = col.FindOne(x => x.Name == sel);

        if (item == null)
        {
            theory = null;
            MessageBox.Show("Something terrible happened and list does not match database.");
            RefreshList();
            return false;
        }

        theory = item;
        return true;
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (!TryGetSelectedTheory(out var item) || item == null)
        {
            return;
        }

        if (MessageBox.Show("Do you really want to delete this theory? You can't restore this theory!", "Warning", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            var col = _db.GetCollection<Theory>(_dbCollectionName);
            col.Delete(item.Id);
            RefreshList();
        }
    }

    private void listTheory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listTheory.SelectedIndex < 0)
        {
            buttonOpen.Enabled = false;
            buttonDelete.Enabled = false;
        }
        else
        {
            buttonOpen.Enabled = true;
            buttonDelete.Enabled = true;
        }
    }

    private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        new AboutWindow().ShowDialog();
    }
}
