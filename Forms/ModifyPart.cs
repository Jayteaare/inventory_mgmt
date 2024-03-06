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
    public partial class ModifyPart : Form
    {
        Main MainWindow = (Main)Application.OpenForms["Main"];

        public ModifyPart(InHousePart inPart)
        {
            InitializeComponent();
            SetupEventHandlers();
            LoadPartData(inPart.ID, inPart.Name, inPart.Inventory, inPart.Price, inPart.Min, inPart.Max);
            machineText.Text = inPart.MachineID.ToString();
            inhouseRdBtn.Checked = true;
        }

        public ModifyPart(OutsourcedPart outPart)
        {
            InitializeComponent();
            SetupEventHandlers();
            LoadPartData(outPart.ID, outPart.Name, outPart.Inventory, outPart.Price, outPart.Min, outPart.Max);
            machineText.Text = outPart.CompName;
            outsourceRdBtn.Checked = true;
        }

        private void SetupEventHandlers()
        {
            nameText.TextChanged += (sender, e) => Validation.ValidateTextInput(sender, e, MarkAsChanged);
            inventoryText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            priceText.TextChanged += (sender, e) => Validation.ValidateDecimalInput(sender, e, MarkAsChanged);
            minText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            maxText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);

            inhouseRdBtn.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            outsourceRdBtn.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            RadioButton_CheckedChanged(null, EventArgs.Empty);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            machineText.TextChanged -= (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            machineText.TextChanged -= (sender, e) => Validation.ValidateTextInput(sender, e, MarkAsChanged);

            if (inhouseRdBtn.Checked)
            {
                machineText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
                machineLabel.Text = "Machine ID";
            }
            else if (outsourceRdBtn.Checked)
            {
                machineText.TextChanged += (sender, e) => Validation.ValidateTextInput(sender, e, MarkAsChanged);
                machineLabel.Text = "Company Name";
            }

            AlignLabelWithTextbox(machineLabel, machineText.Location.X);
        }

        private void LoadPartData(int id, string name, int inventory, decimal price, int min, int max)
        {
            idText.Text = id.ToString();
            nameText.Text = name;
            inventoryText.Text = inventory.ToString();
            priceText.Text = price.ToString("C");
            minText.Text = min.ToString();
            maxText.Text = max.ToString();
        }

        private bool unsavedChanges = false;

        private void MarkAsChanged() => unsavedChanges = true;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(minText.Text, out int minStock) ||
                !int.TryParse(maxText.Text, out int maxStock) ||
                !int.TryParse(inventoryText.Text, out int invInStock) ||
                minStock < 0 || maxStock < 0 || invInStock < 0)
            {
                MessageBox.Show("Error: Inventory, Min, and Max must be non-negative numeric values.");
                return;
            }

            if (!decimal.TryParse(priceText.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal price) || price < 0)
            {
                MessageBox.Show("Error: Price must be a valid, non-negative decimal value.");
                return;
            }

            priceText.Text = price.ToString("F2");

            string name = nameText.Text;

            if (minStock > maxStock)
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: Inventory must be between the Min and Max values.");
                return;
            }

            int id = int.Parse(idText.Text);
            Part updatedPart;

            if (inhouseRdBtn.Checked)
            {
                if (!int.TryParse(machineText.Text, out int machineId) || machineId < 0)
                {
                    MessageBox.Show("Error: Machine ID must be a non-negative numeric value.");
                    return;
                }
                updatedPart = new InHousePart(id, name, invInStock, price, minStock, maxStock, machineId);
            }
            else
            {
                updatedPart = new OutsourcedPart(id, name, invInStock, price, minStock, maxStock, machineText.Text);
            }

            Inventory.UpdatePart(id, updatedPart);
            Close();

            MainWindow.partGrid.Update();
            MainWindow.partGrid.Refresh();
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

        private void AlignLabelWithTextbox(Label label, int textBoxX)
        {
            int labelWidth = label.Width;
            label.Location = new Point(textBoxX - labelWidth, label.Location.Y);
        }

    }
}
