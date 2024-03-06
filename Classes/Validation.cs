using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_WGU_TallisJordan.Classes
{
    public static class Validation
    {
        public delegate void OnChangeHandler();

        public static void ValidateTextInput(object sender, EventArgs e, OnChangeHandler onChange)
        {
            if (sender is TextBox textBox)
            {
                var originalColor = textBox.BackColor;
                textBox.BackColor = string.IsNullOrWhiteSpace(textBox.Text) ? System.Drawing.Color.LightCoral : System.Drawing.SystemColors.Window;
                if (textBox.BackColor != originalColor)
                {
                    onChange?.Invoke();
                }
            }
        }

        public static void ValidateIntegerInput(object sender, EventArgs e, OnChangeHandler onChange)
        {
            if (sender is TextBox textBox)
            {
                bool isValidInteger = int.TryParse(textBox.Text, out int parsedValue);

                textBox.BackColor = isValidInteger && parsedValue >= 0 ? System.Drawing.SystemColors.Window : System.Drawing.Color.LightCoral;

                if (textBox.BackColor != textBox.Tag as System.Drawing.Color?)
                {
                    textBox.Tag = textBox.BackColor;
                    onChange?.Invoke();
                }
            }
        }

        public static void ValidateDecimalInput(object sender, EventArgs e, OnChangeHandler onChange)
        {
            if (sender is TextBox textBox)
            {
                bool isValidDecimal = decimal.TryParse(textBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal parsedValue) && parsedValue >= 0;

                textBox.BackColor = isValidDecimal ? System.Drawing.SystemColors.Window : System.Drawing.Color.LightCoral;

                if (textBox.BackColor != textBox.Tag as System.Drawing.Color?)
                {
                    textBox.Tag = textBox.BackColor;
                    onChange?.Invoke();
                }
            }
        }
    }
}
