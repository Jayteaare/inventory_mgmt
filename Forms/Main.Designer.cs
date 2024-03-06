namespace C968_WGU_TallisJordan
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            appLabel = new Label();
            partSearchBtn = new Button();
            partGrid = new DataGridView();
            partSearchText = new TextBox();
            prodGrid = new DataGridView();
            prodSearchText = new TextBox();
            prodSearchBtn = new Button();
            partDelBtn = new Button();
            partModBtn = new Button();
            partAddBtn = new Button();
            prodDelBtn = new Button();
            prodModBtn = new Button();
            prodAddBtn = new Button();
            exitBtn = new Button();
            prodLabel = new Label();
            partLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)partGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodGrid).BeginInit();
            SuspendLayout();
            // 
            // appLabel
            // 
            appLabel.AutoSize = true;
            appLabel.Location = new Point(473, 30);
            appLabel.Name = "appLabel";
            appLabel.Size = new Size(348, 32);
            appLabel.TabIndex = 0;
            appLabel.Text = "Inventory Management System";
            // 
            // partSearchBtn
            // 
            partSearchBtn.Location = new Point(292, 104);
            partSearchBtn.Name = "partSearchBtn";
            partSearchBtn.Size = new Size(150, 46);
            partSearchBtn.TabIndex = 1;
            partSearchBtn.Text = "Search";
            partSearchBtn.UseVisualStyleBackColor = true;
            partSearchBtn.Click += partSearchBtn_Click;
            // 
            // partGrid
            // 
            partGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            partGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partGrid.Location = new Point(12, 153);
            partGrid.MultiSelect = false;
            partGrid.Name = "partGrid";
            partGrid.ReadOnly = true;
            partGrid.RowHeadersVisible = false;
            partGrid.RowHeadersWidth = 82;
            partGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partGrid.Size = new Size(636, 363);
            partGrid.TabIndex = 2;
            // 
            // partSearchText
            // 
            partSearchText.Location = new Point(448, 108);
            partSearchText.Name = "partSearchText";
            partSearchText.Size = new Size(200, 39);
            partSearchText.TabIndex = 3;
            // 
            // prodGrid
            // 
            prodGrid.AllowUserToAddRows = false;
            prodGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            prodGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodGrid.Location = new Point(654, 153);
            prodGrid.MultiSelect = false;
            prodGrid.Name = "prodGrid";
            prodGrid.ReadOnly = true;
            prodGrid.RowHeadersVisible = false;
            prodGrid.RowHeadersWidth = 82;
            prodGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            prodGrid.Size = new Size(636, 363);
            prodGrid.TabIndex = 4;
            // 
            // prodSearchText
            // 
            prodSearchText.Location = new Point(1086, 108);
            prodSearchText.Name = "prodSearchText";
            prodSearchText.Size = new Size(200, 39);
            prodSearchText.TabIndex = 6;
            // 
            // prodSearchBtn
            // 
            prodSearchBtn.Location = new Point(930, 104);
            prodSearchBtn.Name = "prodSearchBtn";
            prodSearchBtn.Size = new Size(150, 46);
            prodSearchBtn.TabIndex = 5;
            prodSearchBtn.Text = "Search";
            prodSearchBtn.UseVisualStyleBackColor = true;
            prodSearchBtn.Click += prodSearchBtn_Click;
            // 
            // partDelBtn
            // 
            partDelBtn.Location = new Point(498, 522);
            partDelBtn.Name = "partDelBtn";
            partDelBtn.Size = new Size(150, 46);
            partDelBtn.TabIndex = 7;
            partDelBtn.Text = "Delete";
            partDelBtn.UseVisualStyleBackColor = true;
            partDelBtn.Click += partDelBtn_Click;
            // 
            // partModBtn
            // 
            partModBtn.Location = new Point(342, 522);
            partModBtn.Name = "partModBtn";
            partModBtn.Size = new Size(150, 46);
            partModBtn.TabIndex = 8;
            partModBtn.Text = "Modify";
            partModBtn.UseVisualStyleBackColor = true;
            partModBtn.Click += partModBtn_Click;
            // 
            // partAddBtn
            // 
            partAddBtn.Location = new Point(186, 522);
            partAddBtn.Name = "partAddBtn";
            partAddBtn.Size = new Size(150, 46);
            partAddBtn.TabIndex = 9;
            partAddBtn.Text = "Add";
            partAddBtn.UseVisualStyleBackColor = true;
            partAddBtn.Click += partAddBtn_Click;
            // 
            // prodDelBtn
            // 
            prodDelBtn.Location = new Point(1140, 522);
            prodDelBtn.Name = "prodDelBtn";
            prodDelBtn.Size = new Size(150, 46);
            prodDelBtn.TabIndex = 10;
            prodDelBtn.Text = "Delete";
            prodDelBtn.UseVisualStyleBackColor = true;
            prodDelBtn.Click += prodDelBtn_Click;
            // 
            // prodModBtn
            // 
            prodModBtn.Location = new Point(984, 522);
            prodModBtn.Name = "prodModBtn";
            prodModBtn.Size = new Size(150, 46);
            prodModBtn.TabIndex = 11;
            prodModBtn.Text = "Modify";
            prodModBtn.UseVisualStyleBackColor = true;
            prodModBtn.Click += prodModBtn_Click;
            // 
            // prodAddBtn
            // 
            prodAddBtn.Location = new Point(828, 522);
            prodAddBtn.Name = "prodAddBtn";
            prodAddBtn.Size = new Size(150, 46);
            prodAddBtn.TabIndex = 12;
            prodAddBtn.Text = "Add";
            prodAddBtn.UseVisualStyleBackColor = true;
            prodAddBtn.Click += prodAddBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(1136, 644);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(150, 46);
            exitBtn.TabIndex = 13;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // prodLabel
            // 
            prodLabel.AutoSize = true;
            prodLabel.Location = new Point(654, 111);
            prodLabel.Name = "prodLabel";
            prodLabel.Size = new Size(106, 32);
            prodLabel.TabIndex = 14;
            prodLabel.Text = "Products";
            // 
            // partLabel
            // 
            partLabel.AutoSize = true;
            partLabel.Location = new Point(12, 111);
            partLabel.Name = "partLabel";
            partLabel.Size = new Size(64, 32);
            partLabel.TabIndex = 15;
            partLabel.Text = "Parts";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 702);
            Controls.Add(partLabel);
            Controls.Add(prodLabel);
            Controls.Add(exitBtn);
            Controls.Add(prodAddBtn);
            Controls.Add(prodModBtn);
            Controls.Add(prodDelBtn);
            Controls.Add(partAddBtn);
            Controls.Add(partModBtn);
            Controls.Add(partDelBtn);
            Controls.Add(prodSearchText);
            Controls.Add(prodSearchBtn);
            Controls.Add(prodGrid);
            Controls.Add(partSearchText);
            Controls.Add(partGrid);
            Controls.Add(partSearchBtn);
            Controls.Add(appLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)partGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appLabel;
        private Button partSearchBtn;
        public DataGridView partGrid;
        private TextBox partSearchText;
        public DataGridView prodGrid;
        private TextBox prodSearchText;
        private Button prodSearchBtn;
        private Button partDelBtn;
        private Button partModBtn;
        private Button partAddBtn;
        private Button prodDelBtn;
        private Button prodModBtn;
        private Button prodAddBtn;
        private Button exitBtn;
        private Label prodLabel;
        private Label partLabel;
    }
}
