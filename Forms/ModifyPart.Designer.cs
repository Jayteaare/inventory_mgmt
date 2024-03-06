namespace C968_WGU_TallisJordan.Forms
{
    partial class ModifyPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyPart));
            maxLabel = new Label();
            maxText = new TextBox();
            cancelBtn = new Button();
            machineText = new TextBox();
            machineLabel = new Label();
            minText = new TextBox();
            minLabel = new Label();
            priceText = new TextBox();
            priceLabel = new Label();
            inventoryText = new TextBox();
            inventoryLabel = new Label();
            nameText = new TextBox();
            nameLabel = new Label();
            outsourceRdBtn = new RadioButton();
            idText = new TextBox();
            idLabel = new Label();
            inhouseRdBtn = new RadioButton();
            saveBtn = new Button();
            formLabel = new Label();
            SuspendLayout();
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(440, 289);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(59, 32);
            maxLabel.TabIndex = 35;
            maxLabel.Text = "Max";
            // 
            // maxText
            // 
            maxText.Location = new Point(505, 286);
            maxText.Name = "maxText";
            maxText.Size = new Size(91, 39);
            maxText.TabIndex = 34;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(402, 391);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 46);
            cancelBtn.TabIndex = 33;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // machineText
            // 
            machineText.Location = new Point(343, 331);
            machineText.Name = "machineText";
            machineText.Size = new Size(200, 39);
            machineText.TabIndex = 32;
            // 
            // machineLabel
            // 
            machineLabel.AutoSize = true;
            machineLabel.Location = new Point(201, 334);
            machineLabel.Name = "machineLabel";
            machineLabel.Size = new Size(136, 32);
            machineLabel.TabIndex = 31;
            machineLabel.Text = "Machine ID";
            // 
            // minText
            // 
            minText.Location = new Point(343, 286);
            minText.Name = "minText";
            minText.Size = new Size(91, 39);
            minText.TabIndex = 30;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(281, 289);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(56, 32);
            minLabel.TabIndex = 29;
            minLabel.Text = "Min";
            // 
            // priceText
            // 
            priceText.Location = new Point(343, 241);
            priceText.Name = "priceText";
            priceText.Size = new Size(200, 39);
            priceText.TabIndex = 28;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(202, 244);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(135, 32);
            priceLabel.TabIndex = 27;
            priceLabel.Text = "Price / Cost";
            // 
            // inventoryText
            // 
            inventoryText.Location = new Point(343, 196);
            inventoryText.Name = "inventoryText";
            inventoryText.Size = new Size(200, 39);
            inventoryText.TabIndex = 26;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new Point(222, 199);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(115, 32);
            inventoryLabel.TabIndex = 25;
            inventoryLabel.Text = "Inventory";
            // 
            // nameText
            // 
            nameText.Location = new Point(343, 151);
            nameText.Name = "nameText";
            nameText.Size = new Size(200, 39);
            nameText.TabIndex = 24;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(259, 154);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name";
            // 
            // outsourceRdBtn
            // 
            outsourceRdBtn.AutoSize = true;
            outsourceRdBtn.Location = new Point(393, 39);
            outsourceRdBtn.Name = "outsourceRdBtn";
            outsourceRdBtn.Size = new Size(169, 36);
            outsourceRdBtn.TabIndex = 22;
            outsourceRdBtn.TabStop = true;
            outsourceRdBtn.Text = "Outsourced";
            outsourceRdBtn.UseVisualStyleBackColor = true;
            // 
            // idText
            // 
            idText.BackColor = SystemColors.InactiveCaption;
            idText.Location = new Point(343, 106);
            idText.Name = "idText";
            idText.ReadOnly = true;
            idText.Size = new Size(200, 39);
            idText.TabIndex = 21;
            idText.TabStop = false;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(300, 109);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(37, 32);
            idLabel.TabIndex = 20;
            idLabel.Text = "ID";
            // 
            // inhouseRdBtn
            // 
            inhouseRdBtn.AutoSize = true;
            inhouseRdBtn.Location = new Point(237, 39);
            inhouseRdBtn.Name = "inhouseRdBtn";
            inhouseRdBtn.Size = new Size(143, 36);
            inhouseRdBtn.TabIndex = 19;
            inhouseRdBtn.TabStop = true;
            inhouseRdBtn.Text = "In-House";
            inhouseRdBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(246, 391);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(150, 46);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Location = new Point(329, 4);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(137, 32);
            formLabel.TabIndex = 36;
            formLabel.Text = "Modify Part";
            // 
            // ModifyPart
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
            Name = "ModifyPart";
            Text = "Modify Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label maxLabel;
        private TextBox maxText;
        private Button cancelBtn;
        private TextBox machineText;
        private Label machineLabel;
        private TextBox minText;
        private Label minLabel;
        private TextBox priceText;
        private Label priceLabel;
        private TextBox inventoryText;
        private Label inventoryLabel;
        private TextBox nameText;
        private Label nameLabel;
        private RadioButton outsourceRdBtn;
        private TextBox idText;
        private Label idLabel;
        private RadioButton inhouseRdBtn;
        private Button saveBtn;
        private Label formLabel;
    }
}