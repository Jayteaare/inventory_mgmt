using C968_WGU_TallisJordan.Classes;
using C968_WGU_TallisJordan.Forms;

namespace C968_WGU_TallisJordan
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Inventory.InitializePresetParts();
            Inventory.InitializePresetProducts();

            partGrid.DataSource = new BindingSource { DataSource = Inventory.Parts };
            prodGrid.DataSource = new BindingSource { DataSource = Inventory.Products };
        }

        private void partAddBtn_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
            RefreshGridViews();
        }

        private void partModBtn_Click(object sender, EventArgs e)
        {
            if (partGrid.CurrentRow?.DataBoundItem is Part part)
            {
                if (part is InHousePart inHousePart)
                {
                    new ModifyPart(inHousePart).ShowDialog();
                }
                else if (part is OutsourcedPart outsourcedPart)
                {
                    new ModifyPart(outsourcedPart).ShowDialog();
                }
                RefreshGridViews();
            }
        }

        private void partDelBtn_Click(object sender, EventArgs e)
        {
            if (partGrid.CurrentRow?.DataBoundItem is Part partToDelete)
            {
                bool isPartAssociated = Inventory.Products.Any(product => product.AssociatedParts.Any(part => part.ID == partToDelete.ID));

                if (isPartAssociated)
                {
                    MessageBox.Show("This part is associated with a product and cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Inventory.DeletePart(partToDelete.ID);
                    RefreshGridViews();
                }
            }
        }

        private void partSearchBtn_Click(object sender, EventArgs e)
        {
            partGrid.ClearSelection();

            string searchText = partSearchText.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

            bool matchFound = false;

            int idColumnIndex = partGrid.Columns["ID"].Index;
            int nameColumnIndex = partGrid.Columns["Name"].Index;

            foreach (DataGridViewRow row in partGrid.Rows)
            {
                if (row.Cells[idColumnIndex].Value != null && row.Cells[idColumnIndex].Value.ToString().ToLower().Contains(searchText) ||
                    row.Cells[nameColumnIndex].Value != null && row.Cells[nameColumnIndex].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Selected = true;
                    partGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    matchFound = true;
                    break;
                }
            }

            if (!matchFound)
            {
                MessageBox.Show($"No matches found for '{searchText}'.");
            }
        }

        private void prodAddBtn_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
            RefreshGridViews();
        }

        private void prodModBtn_Click(object sender, EventArgs e)
        {
            if (prodGrid.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                new ModifyProduct(selectedProduct).ShowDialog();
                RefreshGridViews();
            }
        }

        private void prodDelBtn_Click(object sender, EventArgs e)
        {
            if (prodGrid.CurrentRow?.DataBoundItem is Product productToDelete)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && productToDelete.AssociatedParts.Count == 0)
                {
                    Inventory.DeleteProduct(productToDelete.ID);
                    RefreshGridViews();
                }
                else if (productToDelete.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product with associated parts. Please remove parts attached to this product.");
                }
            }
        }

        private void prodSearchBtn_Click(object sender, EventArgs e)
        {
            prodGrid.ClearSelection();

            string searchText = prodSearchText.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

            bool matchFound = false;

            int idColumnIndex = prodGrid.Columns["ID"].Index;
            int nameColumnIndex = prodGrid.Columns["Name"].Index;

            foreach (DataGridViewRow row in prodGrid.Rows)
            {
                if (row.Cells[idColumnIndex].Value != null && row.Cells[idColumnIndex].Value.ToString().ToLower().Contains(searchText) ||
                    row.Cells[nameColumnIndex].Value != null && row.Cells[nameColumnIndex].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Selected = true;
                    prodGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    matchFound = true;
                    break;
                }
            }

            if (!matchFound)
            {
                MessageBox.Show($"No matches found for '{searchText}'.");
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshGridViews()
        {
            partGrid.Refresh();
            prodGrid.Refresh();
        }

        private void SelectRowInGridView(DataGridView gridView, int id)
        {
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if ((row.DataBoundItem as Part)?.ID == id || (row.DataBoundItem as Product)?.ID == id)
                {
                    row.Selected = true;
                    gridView.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
    }
}
