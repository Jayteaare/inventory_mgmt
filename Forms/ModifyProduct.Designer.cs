namespace C968_WGU_TallisJordan.Forms
{
    partial class ModifyProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProduct));
            cancelBtn = new Button();
            saveBtn = new Button();
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
            delBtn = new Button();
            addBtn = new Button();
            label2 = new Label();
            candPartsLabel = new Label();
            searchText = new TextBox();
            searchBtn = new Button();
            assocGrid = new DataGridView();
            candGrid = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)assocGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)candGrid).BeginInit();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(336, 467);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 46);
            cancelBtn.TabIndex = 53;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(180, 467);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(150, 46);
            saveBtn.TabIndex = 52;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(370, 409);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(59, 32);
            maxLabel.TabIndex = 51;
            maxLabel.Text = "Max";
            // 
            // maxText
            // 
            maxText.Location = new Point(435, 406);
            maxText.Name = "maxText";
            maxText.Size = new Size(91, 39);
            maxText.TabIndex = 50;
            // 
            // minText
            // 
            minText.Location = new Point(273, 406);
            minText.Name = "minText";
            minText.Size = new Size(91, 39);
            minText.TabIndex = 49;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(211, 409);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(56, 32);
            minLabel.TabIndex = 48;
            minLabel.Text = "Min";
            // 
            // priceText
            // 
            priceText.Location = new Point(273, 361);
            priceText.Name = "priceText";
            priceText.Size = new Size(200, 39);
            priceText.TabIndex = 47;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(132, 364);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(135, 32);
            priceLabel.TabIndex = 46;
            priceLabel.Text = "Price / Cost";
            // 
            // inventoryText
            // 
            inventoryText.Location = new Point(273, 316);
            inventoryText.Name = "inventoryText";
            inventoryText.Size = new Size(200, 39);
            inventoryText.TabIndex = 45;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new Point(152, 319);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(115, 32);
            inventoryLabel.TabIndex = 44;
            inventoryLabel.Text = "Inventory";
            // 
            // nameText
            // 
            nameText.Location = new Point(273, 271);
            nameText.Name = "nameText";
            nameText.Size = new Size(200, 39);
            nameText.TabIndex = 43;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(189, 274);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 42;
            nameLabel.Text = "Name";
            // 
            // idText
            // 
            idText.BackColor = SystemColors.InactiveCaption;
            idText.Location = new Point(273, 226);
            idText.Name = "idText";
            idText.ReadOnly = true;
            idText.Size = new Size(200, 39);
            idText.TabIndex = 41;
            idText.TabStop = false;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(230, 229);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(37, 32);
            idLabel.TabIndex = 40;
            idLabel.Text = "ID";
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1136, 582);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(150, 46);
            delBtn.TabIndex = 39;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1136, 296);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(150, 46);
            addBtn.TabIndex = 38;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(625, 339);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 37;
            label2.Text = "Associated Parts";
            // 
            // candPartsLabel
            // 
            candPartsLabel.AutoSize = true;
            candPartsLabel.Location = new Point(625, 53);
            candPartsLabel.Name = "candPartsLabel";
            candPartsLabel.Size = new Size(179, 32);
            candPartsLabel.TabIndex = 36;
            candPartsLabel.Text = "Candidate Parts";
            // 
            // searchText
            // 
            searchText.Location = new Point(1088, 43);
            searchText.Name = "searchText";
            searchText.Size = new Size(200, 39);
            searchText.TabIndex = 35;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(932, 39);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(150, 46);
            searchBtn.TabIndex = 34;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // assocGrid
            // 
            assocGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            assocGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assocGrid.Location = new Point(625, 374);
            assocGrid.MultiSelect = false;
            assocGrid.Name = "assocGrid";
            assocGrid.ReadOnly = true;
            assocGrid.RowHeadersVisible = false;
            assocGrid.RowHeadersWidth = 82;
            assocGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            assocGrid.Size = new Size(661, 202);
            assocGrid.TabIndex = 33;
            // 
            // candGrid
            // 
            candGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            candGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candGrid.Location = new Point(625, 88);
            candGrid.MultiSelect = false;
            candGrid.Name = "candGrid";
            candGrid.ReadOnly = true;
            candGrid.RowHeadersVisible = false;
            candGrid.RowHeadersWidth = 82;
            candGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candGrid.Size = new Size(661, 202);
            candGrid.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 172);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 54;
            label1.Text = "Modify Product";
            // 
            // ModifyProduct
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
            Name = "ModifyProduct";
            Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)assocGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)candGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
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
        private Button delBtn;
        private Button addBtn;
        private Label label2;
        private Label candPartsLabel;
        private TextBox searchText;
        private Button searchBtn;
        private DataGridView assocGrid;
        private DataGridView candGrid;
        private Label label1;
    }
}