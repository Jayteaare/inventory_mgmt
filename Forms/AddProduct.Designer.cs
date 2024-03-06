namespace C968_WGU_TallisJordan.Forms
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            candGrid = new DataGridView();
            assocGrid = new DataGridView();
            searchBtn = new Button();
            searchText = new TextBox();
            candPartsLabel = new Label();
            label2 = new Label();
            addBtn = new Button();
            delBtn = new Button();
            maxLabel = new Label();
            maxText = new TextBox();
            minText = new TextBox();
            minLabel = new Label();
            priceText = new TextBox();
            priceLabel = new Label();
            inventoryText = new TextBox();
            inventoryLabel = new Label();
            nameText = new TextBox();
            nameLabel = new Label();
            idText = new TextBox();
            idLabel = new Label();
            cancelBtn = new Button();
            saveBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)candGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assocGrid).BeginInit();
            SuspendLayout();
            // 
            // candGrid
            // 
            candGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            candGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candGrid.Location = new Point(625, 89);
            candGrid.MultiSelect = false;
            candGrid.Name = "candGrid";
            candGrid.ReadOnly = true;
            candGrid.RowHeadersVisible = false;
            candGrid.RowHeadersWidth = 82;
            candGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candGrid.Size = new Size(661, 202);
            candGrid.TabIndex = 0;
            // 
            // assocGrid
            // 
            assocGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            assocGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assocGrid.Location = new Point(625, 375);
            assocGrid.MultiSelect = false;
            assocGrid.Name = "assocGrid";
            assocGrid.ReadOnly = true;
            assocGrid.RowHeadersVisible = false;
            assocGrid.RowHeadersWidth = 82;
            assocGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            assocGrid.Size = new Size(661, 202);
            assocGrid.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(932, 40);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(150, 46);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchText
            // 
            searchText.Location = new Point(1088, 44);
            searchText.Name = "searchText";
            searchText.Size = new Size(200, 39);
            searchText.TabIndex = 3;
            // 
            // candPartsLabel
            // 
            candPartsLabel.AutoSize = true;
            candPartsLabel.Location = new Point(625, 54);
            candPartsLabel.Name = "candPartsLabel";
            candPartsLabel.Size = new Size(179, 32);
            candPartsLabel.TabIndex = 4;
            candPartsLabel.Text = "Candidate Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(625, 340);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 5;
            label2.Text = "Associated Parts";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1136, 297);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(150, 46);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1136, 583);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(150, 46);
            delBtn.TabIndex = 7;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(370, 410);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(59, 32);
            maxLabel.TabIndex = 29;
            maxLabel.Text = "Max";
            // 
            // maxText
            // 
            maxText.Location = new Point(435, 407);
            maxText.Name = "maxText";
            maxText.Size = new Size(91, 39);
            maxText.TabIndex = 28;
            // 
            // minText
            // 
            minText.Location = new Point(273, 407);
            minText.Name = "minText";
            minText.Size = new Size(91, 39);
            minText.TabIndex = 27;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(211, 410);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(56, 32);
            minLabel.TabIndex = 26;
            minLabel.Text = "Min";
            // 
            // priceText
            // 
            priceText.Location = new Point(273, 362);
            priceText.Name = "priceText";
            priceText.Size = new Size(200, 39);
            priceText.TabIndex = 25;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(132, 365);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(135, 32);
            priceLabel.TabIndex = 24;
            priceLabel.Text = "Price / Cost";
            // 
            // inventoryText
            // 
            inventoryText.Location = new Point(273, 317);
            inventoryText.Name = "inventoryText";
            inventoryText.Size = new Size(200, 39);
            inventoryText.TabIndex = 23;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new Point(152, 320);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(115, 32);
            inventoryLabel.TabIndex = 22;
            inventoryLabel.Text = "Inventory";
            // 
            // nameText
            // 
            nameText.Location = new Point(273, 272);
            nameText.Name = "nameText";
            nameText.Size = new Size(200, 39);
            nameText.TabIndex = 21;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(189, 275);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Name";
            // 
            // idText
            // 
            idText.BackColor = SystemColors.InactiveCaption;
            idText.Location = new Point(273, 227);
            idText.Name = "idText";
            idText.ReadOnly = true;
            idText.Size = new Size(200, 39);
            idText.TabIndex = 19;
            idText.TabStop = false;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(230, 230);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(37, 32);
            idLabel.TabIndex = 18;
            idLabel.Text = "ID";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(336, 468);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 46);
            cancelBtn.TabIndex = 31;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(180, 468);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(150, 46);
            saveBtn.TabIndex = 30;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 172);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 32;
            label1.Text = "Add Product";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 702);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(maxLabel);
            Controls.Add(maxText);
            Controls.Add(minText);
            Controls.Add(minLabel);
            Controls.Add(priceText);
            Controls.Add(priceLabel);
            Controls.Add(inventoryText);
            Controls.Add(inventoryLabel);
            Controls.Add(nameText);
            Controls.Add(nameLabel);
            Controls.Add(idText);
            Controls.Add(idLabel);
            Controls.Add(delBtn);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(candPartsLabel);
            Controls.Add(searchText);
            Controls.Add(searchBtn);
            Controls.Add(assocGrid);
            Controls.Add(candGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProduct";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)candGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)assocGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView candGrid;
        private DataGridView assocGrid;
        private Button searchBtn;
        private TextBox searchText;
        private Label candPartsLabel;
        private Label label2;
        private Button addBtn;
        private Button delBtn;
        private Label maxLabel;
        private TextBox maxText;
        private TextBox minText;
        private Label minLabel;
        private TextBox priceText;
        private Label priceLabel;
        private TextBox inventoryText;
        private Label inventoryLabel;
        private TextBox nameText;
        private Label nameLabel;
        private TextBox idText;
        private Label idLabel;
        private Button cancelBtn;
        private Button saveBtn;
        private Label label1;
    }
}