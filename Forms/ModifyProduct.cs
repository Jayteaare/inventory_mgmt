using C968_WGU_TallisJordan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_WGU_TallisJordan.Forms
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        Main MainWindow = (Main)Application.OpenForms["Main"];
        Product currentProduct;

        public ModifyProduct(Product prod)
        {
            InitializeComponent();
            currentProduct = prod;

            LoadProductData(prod);

            candGrid.DataSource = new BindingSource { DataSource = Inventory.Parts };
            assocGrid.DataSource = new BindingSource { DataSource = addedParts };

            nameText.TextChanged += (sender, e) => Validation.ValidateTextInput(sender, e, MarkAsChanged);
            inventoryText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            priceText.TextChanged += (sender, e) => Validation.ValidateDecimalInput(sender, e, MarkAsChanged);
            minText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            maxText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
        }

        private void LoadProductData(Product prod)
        {
            idText.Text = prod.ID.ToString();
            nameText.Text = prod.Name;
            inventoryText.Text = prod.Inventory.ToString();
            priceText.Text = prod.Price.ToString("C").Substring(1);
            minText.Text = prod.Min.ToString();
            maxText.Text = prod.Max.ToString();

            addedParts.Clear();
            foreach (Part part in prod.AssociatedParts)
            {
                addedParts.Add(part);
            }
        }

        private bool unsavedChanges = false;

        private void MarkAsChanged() => unsavedChanges = true;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(minText.Text, out int min) || min < 0 ||
                !int.TryParse(maxText.Text, out int max) || max < 0 ||
                !int.TryParse(inventoryText.Text, out int inventory) || inventory < 0)
            {
                MessageBox.Show("Error: Inventory, Min, and Max must be non-negative numeric values.");
                return;
            }

            if (!decimal.TryParse(priceText.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal price) || price < 0)
            {
                MessageBox.Show("Error: Price must be a valid, non-negative decimal value.");
                return;
            }

            string name = nameText.Text;

            if (min > max)
            {
                MessageBox.Show("Error: Min cannot be greater than Max.");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory must be between the Min and Max values.");
                return;
            }

            currentProduct.Name = name;
            currentProduct.Inventory = inventory;
            currentProduct.Price = price;
            currentProduct.Min = min;
            currentProduct.Max = max;

            currentProduct.AssociatedParts.Clear();
            foreach (Part part in addedParts)
            {
                currentProduct.AddAssociatedPart(part);
            }

            Close();
            MainWindow.prodGrid.Update();
            MainWindow.prodGrid.Refresh();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (unsavedChanges)
            {
                var result = MessageBox.Show("You have unsaved changes. Are you sure you want to cancel?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            unsavedChanges = true;

            if (candGrid.CurrentRow?.DataBoundItem is Part partToAdd)
            {
                addedParts.Add(partToAdd);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            unsavedChanges = true;

            if (assocGrid.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Part partToRemove = (Part)assocGrid.CurrentRow.DataBoundItem;
                    addedParts.Remove(partToRemove);
                    assocGrid.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            candGrid.ClearSelection();

            string SearchText = searchText.Text.ToLower();

            if (string.IsNullOrWhiteSpace(SearchText))
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

            bool matchFound = false;

            int idColumnIndex = candGrid.Columns["ID"].Index;
            int nameColumnIndex = candGrid.Columns["Name"].Index;

            foreach (DataGridViewRow row in candGrid.Rows)
            {
                if (row.Cells[idColumnIndex].Value != null && row.Cells[idColumnIndex].Value.ToString().ToLower().Contains(SearchText))
                {
                    row.Selected = true;
                    candGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    matchFound = true;
                    break;
                }
                else if (row.Cells[nameColumnIndex].Value != null && row.Cells[nameColumnIndex].Value.ToString().ToLower().Contains(SearchText))
                {
                    row.Selected = true;
                    candGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    matchFound = true;
                    break;
                }
            }

            if (!matchFound)
            {
                MessageBox.Show("No matching parts found.");
            }
        }
    }
}
