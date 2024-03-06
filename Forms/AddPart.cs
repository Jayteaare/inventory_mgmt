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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_WGU_TallisJordan.Forms
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();

            idText.Text = Inventory.GetNextPartId().ToString();

            nameText.TextChanged += (sender, e) => Validation.ValidateTextInput(sender, e, MarkAsChanged);
            inventoryText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            priceText.TextChanged += (sender, e) => Validation.ValidateDecimalInput(sender, e, MarkAsChanged);
            minText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            maxText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);

            inhouseRdBtn.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            outsourceRdBtn.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            RadioButton_CheckedChanged(null, EventArgs.Empty);
        }

        private bool unsavedChanges = false;

        private void MarkAsChanged() => unsavedChanges = true;

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            machineText.TextChanged -= (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
            machineText.TextChanged -= (sender, e) => Validation.ValidateTextInput(sender, e, MarkAsChanged);

            if (inhouseRdBtn.Checked)
            {
                machineText.TextChanged += (sender, e) => Validation.ValidateIntegerInput(sender, e, MarkAsChanged);
                machineLabel.Text = "Machine ID";
            }
            else
            {
                machineText.TextChanged += (sender, e) => Validation.ValidateTextInput(sender, e, MarkAsChanged);
                machineLabel.Text = "Company Name";
            }

            AlignLabelWithTextbox(machineLabel, machineText);
        }

        private void inhouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (inhouseRdBtn.Checked)
            {
                machineLabel.Text = "Machine ID";
                AlignLabelWithTextbox(machineLabel, machineText);
            }
        }

        private void outsourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourceRdBtn.Checked)
            {
                machineLabel.Text = "Company Name";
                AlignLabelWithTextbox(machineLabel, machineText);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(minText.Text, out int minStock) ||
                !int.TryParse(maxText.Text, out int maxStock) ||
                !int.TryParse(inventoryText.Text, out int invInStock) ||
                minStock < 0 || maxStock < 0 || invInStock < 0)
            {
                MessageBox.Show("Error: Inventory, Max, and Min text fields must be numeric and non-negative values.");
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
                MessageBox.Show("Error: Max must be greater than min.");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: Inventory must be between the Min and Max values.");
                return;
            }

            int partId = int.Parse(idText.Text);
            Part newPart;

            if (inhouseRdBtn.Checked)
            {
                if (!int.TryParse(machineText.Text, out int machineId) || machineId < 0)
                {
                    MessageBox.Show("Error: Machine ID must be a non-negative numeric value.");
                    return;
                }
                newPart = new InHousePart(partId, name, invInStock, price, minStock, maxStock, machineId);
            }
            else
            {
                newPart = new OutsourcedPart(partId, name, invInStock, price, minStock, maxStock, machineText.Text);
            }

            Inventory.AddPart(newPart);
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

        private void AlignLabelWithTextbox(Label label, Control machineText)
        {
            int labelXPosition = machineText.Location.X - label.Width - 6;
            label.Location = new Point(labelXPosition, machineText.Location.Y);
        }

    }
}
