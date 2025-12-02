using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            var item = listView1.SelectedItems[0];
            txtLastName.Text = item.Text;
            txtFirstName.Text = item.SubItems.Count > 1 ? item.SubItems[1].Text : string.Empty;
            txtPhone.Text = item.SubItems.Count > 2 ? item.SubItems[2].Text : string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var last = txtLastName.Text.Trim();
            var first = txtFirstName.Text.Trim();
            var phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(last))
            {
                MessageBox.Show("Please enter a last name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            var item = new ListViewItem(new[] { last, first, phone });
            listView1.Items.Add(item);

           
            item.Selected = true;
            listView1.EnsureVisible(listView1.Items.Count - 1);

            
            txtLastName.Text = txtFirstName.Text = txtPhone.Text = string.Empty;
            txtLastName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
