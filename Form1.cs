using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity9Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateItemFromUI(Inventory Item)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please input inventory id.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Please input inventory name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please input inventory price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCount.Text == "")
            {
                MessageBox.Show("Please input inventory quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDesc.Text == "")
            {
                MessageBox.Show("Please input inventory descryption.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Item.Id = Convert.ToInt32(txtId.Text);
            Item.Name = txtName.Text;
            Item.Price = Convert.ToInt32(txtPrice.Text);
            Item.Quantity = Convert.ToInt32(txtCount.Text);
            Item.Description = txtDesc.Text;
        }

        private void ClearUI()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtCount.Text = "";
            txtDesc.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            // Create Inventory object.
            Inventory item = new Inventory();
            UpdateItemFromUI(item);

            int count = listItems.Items.Count;
            listItems.Items.Add(item.Id.ToString());
            listItems.Items[count].SubItems.Add(item.Name);
            listItems.Items[count].SubItems.Add(item.Price.ToString());
            listItems.Items[count].SubItems.Add(item.Quantity.ToString());
            listItems.Items[count].SubItems.Add(item.Description);

            ClearUI();
        }
    }
}
