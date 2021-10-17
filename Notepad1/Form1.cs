using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string c = "";

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.DefaultExt = "*.rtf";
            s.Filter = "RTF Files|*.rtf";

            if (s.ShowDialog() == DialogResult.OK && s.FileName.Length > 0)
            {
                richTextBox1.SaveFile(s.FileName);
                lblStatus1.Text = "Save File: " + s.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.DefaultExt = "*.rtf";
            o.Filter = "RTF Files|*.rtf";

            if (o.ShowDialog() == DialogResult.OK && o.FileName.Length > 0)
            {
                richTextBox1.LoadFile(o.FileName);
                lblStatus1.Text = "Open File: " + o.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Do You Want To Exit Notepad?", "Notepad Alert", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                DialogResult d = MessageBox.Show("Do You Want To Save The Program?", "Notepad Alert", MessageBoxButtons.YesNoCancel);

                if (d == DialogResult.Yes)
                {
                    SaveFileDialog s = new SaveFileDialog();
                    s.DefaultExt = "*.rtf";
                    s.Filter = "RTF Files|*.rtf";

                    if (s.ShowDialog() == DialogResult.OK && s.FileName.Length > 0)
                    {
                        richTextBox1.SaveFile(s.FileName);
                        lblStatus1.Text = "Save File: " + s.FileName;
                        richTextBox1.Clear();
                        richTextBox1.Focus();
                    }
                }
                else if (d == DialogResult.No)
                {
                    richTextBox1.Clear();
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = f.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = f.Color;
            }
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rigthToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;
        }

        private void leftToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.No;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In This Program You\n\nCan Easily Modify Or\n\nCreate Text Files","Notepad About");
        }

        private void persianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("در این برنامه شما به\n\nراحتی می توانید فایل های\n\nنوشتاری را تغییر یا ایجاد کنید", "Notepad About");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (c != "")
            {
                richTextBox1.LoadFile(c);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Do You Want To Exit Notepad?", "Notepad Alert", MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
            {
                e.Cancel=true;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}