
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventorer
{
    public partial class MainScreenForm : Form
    {
        // This BindingSource binds the list to the DataGridView control.  
        public static BindingSource partsBindingSource = new BindingSource();
        public static BindingList<Part> partsBindingList = new BindingList<Part>(Inventory.AllParts);
        public static BindingSource productsBindingSource = new BindingSource();
        public static BindingList<Product> productsBindingList = new BindingList<Product>(Inventory.Products);

        public MainScreenForm()
        {
            InitializeComponent();
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            // Parts
            Inventory.AddPart(new Inhouse("Wheel", 12.11, 15, 5, 25, 1));
            Inventory.AddPart(new Inhouse("Pedal", 8.22, 11, 5, 25, 2));
            Inventory.AddPart(new Outsourced("Chain", 8.33, 12, 5, 25, "WGU Supplies"));
            Inventory.AddPart(new Outsourced("Seat", 4.55, 8, 2, 15, "WGU Supplies"));

            // Products
            Inventory.AddProduct(new Product("Red Bicycle", 11.44, 15, 1, 25, new ArrayList()));
            Inventory.AddProduct(new Product("Yellow Bicycle", 9.66, 19, 1, 25, new ArrayList()));
            Inventory.AddProduct(new Product("Blue Bicycle", 12.77, 5, 1, 25, new ArrayList()));

            Inventory.FindProduct(0).AddAssociatedPart(Inventory.FindPart(0));
            Inventory.FindProduct(0).AddAssociatedPart(Inventory.FindPart(1));
            Inventory.FindProduct(1).AddAssociatedPart(Inventory.FindPart(1));
            Inventory.FindProduct(1).AddAssociatedPart(Inventory.FindPart(2));
            Inventory.FindProduct(2).AddAssociatedPart(Inventory.FindPart(3));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            EditPart partForm = new EditPart()
            {
                MdiParent = this.MdiParent
            };

            partForm.Show();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            EditProduct productForm = new EditProduct()
            {
                MdiParent = this.MdiParent
            };
            productForm.Show();
        }

        private void partsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {



            // Bind dataview to AllParts list

            partsBindingSource.DataSource = partsBindingList;
            partsDataGrid.DataSource = partsBindingSource;


            partsDataGrid.Columns["Price"].DefaultCellStyle.Format = "c";
            partsDataGrid.Columns["Price"].HeaderText = "Price";
            partsDataGrid.Columns["PartID"].HeaderText = "Part ID";
            partsDataGrid.Columns["CompanyName"].Visible = false;
            partsDataGrid.Columns["MachineID"].Visible = false;
            partsDataGrid.Columns["Min"].Visible = false;
            partsDataGrid.Columns["Max"].Visible = false;
            partsDataGrid.RowHeadersVisible = false;


            // Bind dataview to Product list

            productsBindingSource.DataSource = productsBindingList;
            productsDataGrid.DataSource = productsBindingSource;

            productsDataGrid.Columns["Price"].DefaultCellStyle.Format = "c";
            productsDataGrid.Columns["Price"].HeaderText = "Price";
            productsDataGrid.Columns["Min"].Visible = true;
            productsDataGrid.Columns["Max"].Visible = true;
            productsDataGrid.RowHeadersVisible = false;

        }

        //private DataGridViewRow selectedRow;
        private void modPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = partsDataGrid.SelectedRows[0];
                var idVal = selectedRow.Cells["PartID"].Value;

                if (idVal.Equals(null))
                {
                    throw new NullReferenceException("partID is null");
                }
                int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                Part part = Inventory.FindPart(partID);

                EditPart partForm = new EditPart(part)
                {
                    MdiParent = this.MdiParent
                };
                partForm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("partID is null", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("partID is invalid", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void modProductButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = productsDataGrid.SelectedRows[0];

            int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
            Product product = Inventory.FindProduct(productID);

            EditProduct productForm = new EditProduct(product)
            {
                MdiParent = this.MdiParent
            };
            productForm.Show();
        }

        private void MainScreenForm_Refresh(object sender, EventArgs e)
        {
            partsDataGrid.Invalidate();
            productsDataGrid.Invalidate();
            productsBindingSource.ResetBindings(true);
            partsBindingSource.ResetBindings(true);
        }

        private void DebugParts_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            foreach (Part part in Inventory.AllParts)
            {
                message.AppendLine($"{part.GetName()}");
            }
            MessageBox.Show(message.ToString());
        }

        private void delPartButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = partsDataGrid.SelectedRows[0];
            int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
            Part partToDelete = Inventory.FindPart(partID);

            if (MessageBox.Show(
                "Are you sure you want to remove this part?\n" +
                "\nPartID: " + partID + "\nName: " + selectedRow.Cells["Name"].Value,
                "Remove Product",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    Inventory.DelPart(partToDelete);
                    RefreshDataGridViews();
                }
                catch
                {
                    MessageBox.Show("Unable to delete selected part", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RefreshDataGridViews()
        {
            partsBindingSource.ResetBindings(true);
            modPartButton.Enabled = Inventory.AllParts.Count().Equals(0) ? false : true;
            productsBindingSource.ResetBindings(true);
            modProductButton.Enabled = Inventory.Products.Count().Equals(0) ? false : true;
        }

        private void MainScreenForm_Activated(object sender, EventArgs e)
        {
            RefreshDataGridViews();
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (!int.TryParse(partSearchInput.Text, out int searchID))
            {
                MessageBox.Show("Must be a number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in partsDataGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == searchID)
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }
            if (!found) { MessageBox.Show("Part ID not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (!int.TryParse(productSearchInput.Text, out int searchID))
            {
                MessageBox.Show("Must be a number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in productsDataGrid.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if (product.GetProductID() == searchID)
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }
            if (!found) { MessageBox.Show("ProductID not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void partSearchInput_Enter(object sender, EventArgs e)
        {
            partSearchInput.Text = (partSearchInput.Text == "Search by Part ID") ? "" : partSearchInput.Text;
        }

        private void productSearchInput_Enter(object sender, EventArgs e)
        {
            productSearchInput.Text = (productSearchInput.Text == "Search by Product ID") ? "" : productSearchInput.Text;
        }

        private void partSearchInput_Leave(object sender, EventArgs e)
        {
            partSearchInput.Text = (partSearchInput.Text == "") ? "Search by Part ID" : partSearchInput.Text;
        }

        private void productSearchInput_Leave(object sender, EventArgs e)
        {
            productSearchInput.Text = (productSearchInput.Text == "") ? "Search by Product ID" : productSearchInput.Text;
        }

        private void delProductButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = productsDataGrid.SelectedRows[0];
            int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
            Product productToDelete = Inventory.FindProduct(productID);

            if (MessageBox.Show(
                    "Are you sure you want to remove this product?\n" +
                    "\nProductID: " + productID + "\nName: " + selectedRow.Cells["Name"].Value,
                    "Remove Product",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    if (productToDelete.GetAssociatedParts().Count > 0)
                    {
                        throw new Exception();
                    }
                    Inventory.DelProduct(productID);
                    RefreshDataGridViews();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to delepte products with parts associated", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Inventory.DelProduct(productID);
                RefreshDataGridViews();
            }
        }

        private void partsDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}