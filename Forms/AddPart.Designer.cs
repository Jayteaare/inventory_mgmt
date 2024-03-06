namespace C968_WGU_TallisJordan.Forms
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPart));
            saveBtn = new Button();
            inhouseRdBtn = new RadioButton();
            idLabel = new Label();
            idText = new TextBox();
            outsourceRdBtn = new RadioButton();
            nameText = new TextBox();
            nameLabel = new Label();
            inventoryText = new TextBox();
            inventoryLabel = new Label();
            priceText = new TextBox();
            priceLabel = new Label();
            minText = new TextBox();
            minLabel = new Label();
            machineText = new TextBox();
            machineLabel = new Label();
            cancelBtn = new Button();
            maxText = new TextBox();
            maxLabel = new Label();
            formLabel = new Label();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(247, 392);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(150, 46);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // inhouseRdBtn
            // 
            inhouseRdBtn.AutoSize = true;
            inhouseRdBtn.Checked = true;
            inhouseRdBtn.Location = new Point(238, 40);
            inhouseRdBtn.Name = "inhouseRdBtn";
            inhouseRdBtn.Size = new Size(143, 36);
            inhouseRdBtn.TabIndex = 1;
            inhouseRdBtn.TabStop = true;
            inhouseRdBtn.Text = "In-House";
            inhouseRdBtn.UseVisualStyleBackColor = true;
            inhouseRdBtn.Click += inhouseRdBtn_CheckedChanged;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(301, 110);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(37, 32);
            idLabel.TabIndex = 2;
            idLabel.Text = "ID";
            // 
            // idText
            // 
            idText.BackColor = SystemColors.InactiveCaption;
            idText.Location = new Point(344, 107);
            idText.Name = "idText";
            idText.ReadOnly = true;
            idText.Size = new Size(200, 39);
            idText.TabIndex = 3;
            idText.TabStop = false;
            // 
            // outsourceRdBtn
            // 
            outsourceRdBtn.AutoSize = true;
            outsourceRdBtn.Location = new Point(394, 40);
            outsourceRdBtn.Name = "outsourceRdBtn";
            outsourceRdBtn.Size = new Size(169, 36);
            outsourceRdBtn.TabIndex = 4;
            outsourceRdBtn.Text = "Outsourced";
            outsourceRdBtn.UseVisualStyleBackColor = true;
            outsourceRdBtn.Click += outsourcedRdBtn_CheckedChanged;
            // 
            // nameText
            // 
            nameText.Location = new Point(344, 152);
            nameText.Name = "nameText";
            nameText.Size = new Size(200, 39);
            nameText.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(260, 155);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            // 
            // inventoryText
            // 
            inventoryText.Location = new Point(344, 197);
            inventoryText.Name = "inventoryText";
            inventoryText.Size = new Size(200, 39);
            inventoryText.TabIndex = 8;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new Point(223, 200);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(115, 32);
            inventoryLabel.TabIndex = 7;
            inventoryLabel.Text = "Inventory";
            // 
            // priceText
            // 
            priceText.Location = new Point(344, 242);
            priceText.Name = "priceText";
            priceText.Size = new Size(200, 39);
            priceText.TabIndex = 10;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(203, 245);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(135, 32);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price / Cost";
            // 
            // minText
            // 
            minText.Location = new Point(344, 287);
            minText.Name = "minText";
            minText.Size = new Size(91, 39);
            minText.TabIndex = 12;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(282, 290);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(56, 32);
            minLabel.TabIndex = 11;
            minLabel.Text = "Min";
            // 
            // machineText
            // 
            machineText.Location = new Point(344, 332);
            machineText.Name = "machineText";
            machineText.Size = new Size(200, 39);
            machineText.TabIndex = 14;
            // 
            // machineLabel
            // 
            machineLabel.AutoSize = true;
            machineLabel.Location = new Point(202, 335);
            machineLabel.Name = "machineLabel";
            machineLabel.Size = new Size(136, 32);
            machineLabel.TabIndex = 13;
            machineLabel.Text = "Machine ID";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(403, 392);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 46);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // maxText
            // 
            maxText.Location = new Point(506, 287);
            maxText.Name = "maxText";
            maxText.Size = new Size(91, 39);
            maxText.TabIndex = 16;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(441, 290);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(59, 32);
            maxLabel.TabIndex = 17;
            maxLabel.Text = "Max";
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Location = new Point(344, 5);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(104, 32);
            formLabel.TabIndex = 18;
            formLabel.Text = "Add Part";
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formLabel);
            Controls.Add(maxLabel);
            Controls.Add(maxText);
            Controls.Add(cancelBtn);
            Controls.Add(machineText);
            Controls.Add(machineLabel);
            Controls.Add(minText);
            Controls.Add(minLabel);
            Controls.Add(priceText);
            Controls.Add(priceLabel);
            Controls.Add(inventoryText);
            Controls.Add(inventoryLabel);
            Controls.Add(nameText);
            Controls.Add(nameLabel);
            Controls.Add(outsourceRdBtn);
            Controls.Add(idText);
            Controls.Add(idLabel);
            Controls.Add(inhouseRdBtn);
            Controls.Add(saveBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddPart";
            Text = "Add Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private RadioButton inhouseRdBtn;
        private Label idLabel;
        private TextBox idText;
        private RadioButton outsourceRdBtn;
        private TextBox nameText;
        private Label nameLabel;
        private TextBox inventoryText;
        private Label inventoryLabel;
        private TextBox priceText;
        private Label priceLabel;
        private TextBox minText;
        private Label minLabel;
        private TextBox machineText;
        private Label machineLabel;
        private Button cancelBtn;
        private TextBox maxText;
        private Label maxLabel;
        private Label formLabel;
    }
}