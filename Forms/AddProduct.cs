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
    public partial class AddProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();

        public AddProduct()
        {
            InitializeComponent();

            idText.Text = Inventory.GetNextProductId().ToString();

            candGrid.DataSource = new BindingSource { DataSource = Inventory.Parts };
            assocGrid.DataSource = new BindingSource { DataSource = addedParts };

            nameText.TextChanged += (sender, e) => Validation.ValidateTextInput(sender, e, MarkAsChanged);
            inventoryText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            priceText.TextChanged += (sender, e) => Validation.ValidateDecimalInput(sender, e, MarkAsChanged);
            minText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            maxText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
        }

        private bool unsavedChanges = false;

        private void MarkAsChanged() => unsavedChanges = true;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(minText.Text, out int min) ||
                !int.TryParse(maxText.Text, out int max) ||
                !int.TryParse(inventoryText.Text, out int inventory) ||
                min < 0 || max < 0 || inventory < 0)
            {
                MessageBox.Show("Error: Inventory, Max, and Min must be numeric and non-negative values.");
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

            if (addedParts.Count == 0)
            {
                MessageBox.Show("At least one part must be associated with a product.");
                return;
            }

            int prodId = int.Parse(idText.Text);

            Product product = new Product(prodId, name, inventory, price, min, max);
            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }

            Inventory.AddProduct(product);
            Close();
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
            if (assocGrid.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Part partToRemove = (Part)assocGrid.CurrentRow.DataBoundItem;
                    addedParts.Remove(partToRemove);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var searchText = this.searchText.Text.ToLower().Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

            int idColumnIndex = candGrid.Columns["ID"].Index;
            int nameColumnIndex = candGrid.Columns["Name"].Index;

            var matchingRow = candGrid.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row =>
                    (row.Cells[idColumnIndex].Value?.ToString().ToLower().Contains(searchText) == true) ||
                    (row.Cells[nameColumnIndex].Value?.ToString().ToLower().Contains(searchText) == true));

            if (matchingRow != null)
            {
                candGrid.ClearSelection();
                matchingRow.Selected = true;
                candGrid.FirstDisplayedScrollingRowIndex = matchingRow.Index;
            }
            else
            {
                MessageBox.Show("No matching parts found.");
            }
        }
    }
}
