using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                checkedListBox1.Items.RemoveAt(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i= checkedListBox1.Items.Count - 1;i >= 0; i--)
            {
                if (!checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
    }
}