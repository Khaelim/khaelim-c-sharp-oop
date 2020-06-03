using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryMaintence
{
    public partial class Form1 : Form
    {
        private List<Product> productList = new List<Product>
        {
            new Product("5432", "YourProduct", 700.40m ),
            new Product("1234", "MyProduct", 23.40m )
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (var addFrm = new AddItemForm())
            {
                var result = addFrm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (addFrm.Pro != null)
                    {
                        productList.Add(addFrm.Pro);
                    }
                }
            }
            fillList();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (listBoxProduct.SelectedIndex >= 0)
            {
                productList.RemoveAt(listBoxProduct.SelectedIndex);
                fillList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillList()
        {
            listBoxProduct.Items.Clear();
            foreach (Product p in productList)
            {
                if (p != null)
                {
                    listBoxProduct.Items.Add(p.getDisplayText());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillList();
        }
    }
}
