using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsH7.Views;

public partial class MainView : Form
{
    private bool isBold = false;
    private bool isUnderlined = false;
    private bool isItalic = false;

    public MainView()
    {
        InitializeComponent();
    }

    private void MainView_Load(object sender, EventArgs e)
    {
        InstalledFontCollection fonts = new InstalledFontCollection();
        try
        {
            foreach (FontFamily font in fonts.Families)
            {
                cBoxFontStyle.Items.Add(font.Name);
            }
        }
        catch
        {

        }

        for (int i = 9; i < 73; i++)
            cBoxFontSize.Items.Add(i);

        cBoxFontSize.SelectedIndex = 0;


        cBoxColor.DataSource = Enum.GetValues(typeof(KnownColor));
        cBoxColor.SelectedIndex = -1;

        richTextBox1.ForeColor = Color.Black;
    }

    private void cBoxFont_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cBoxFontStyle.Text))
            return;

        if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
        {
            richTextBox1.SelectionFont = new Font(cBoxFontStyle.SelectedItem.ToString()!, float.Parse(cBoxFontSize.Text));
            return;
        }

        richTextBox1.Font = new Font(cBoxFontStyle.SelectedItem.ToString()!, float.Parse(cBoxFontSize.Text));
    }

    private void cBoxColor_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(cBoxColor.Text))
            return;

        if (!Enum.TryParse<KnownColor>(cBoxColor.SelectedValue.ToString(), out KnownColor color))
            return;

        if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
        {
            richTextBox1.SelectionColor = Color.FromKnownColor(color);
            return;
        }

        richTextBox1.ForeColor = Color.FromKnownColor(color);
    }

    private void btnBold_Click(object sender, EventArgs e)
    {
        var btnFont = sender as Button;


        switch (btnFont!.Text)
        {

            case "B":
                isBold = !isBold;
                break;

            case "U":
                isUnderlined = !isUnderlined;
                break;

            case "I":
                isItalic = !isItalic;
                break;

        }


        FontStyle newFontStyle = FontStyle.Regular;

        if (isBold)
            newFontStyle |= FontStyle.Bold;
        if (isUnderlined)
            newFontStyle |= FontStyle.Underline;
        if (isItalic)
            newFontStyle |= FontStyle.Italic;


        if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newFontStyle);
            return;
        }

        richTextBox1.Font = new Font(richTextBox1.Font, newFontStyle);
    }

    private void btnAlignment_Click(object sender, EventArgs e)
    {
        var btnAlignment = sender as Button;

        switch (btnAlignment!.Text)
        {
            case "L":
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                break;

            case "C":
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                break;

            case "R":
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                break;
        }
    }



    private void btnFontDialog_Click(object sender, EventArgs e)
    {

        if (fontDialog1.ShowDialog() == DialogResult.OK)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                return;
            }

            richTextBox1.Font = fontDialog1.Font;
        }
    }

    private void btnOpenColorMenu_Click(object sender, EventArgs e)
    {
        colorDialog1.FullOpen = true;

        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                return;
            }

            richTextBox1.ForeColor = colorDialog1.Color;
        }
    }

    private void btnLoadFile_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtFileLoad.Text))
        {
            MessageBox.Show("Please enter File name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!File.Exists(txtFileLoad.Text))
        {
            MessageBox.Show("File Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using StreamReader sr = new(txtFileLoad.Text);

        richTextBox1.Text = sr.ReadToEnd();
    }

    private void btnSaveFile_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtFileSave.Text))
        {
            MessageBox.Show("Please enter File name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        File.WriteAllText($@"{Environment.GetFolderPath(0)}\{txtFileSave.Text}.txt", richTextBox1.Text);
    }

    private void btnLoadMenu_Click(object sender, EventArgs e)
    {
        openFileDialog1.Filter = "Text|*.txt";

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            using StreamReader streamReader = new(openFileDialog1.FileName);
            richTextBox1.Text = streamReader.ReadToEnd();
        }
    }

    private void btnSaveMenu_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = "Text Files|*.txt";

        if(saveFileDialog1.ShowDialog()==DialogResult.OK)
        {
            using StreamWriter streamWriter = new(saveFileDialog1.FileName);
            streamWriter.Write(richTextBox1.Text);
        }
    }
}
