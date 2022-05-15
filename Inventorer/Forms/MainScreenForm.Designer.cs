namespace Inventorer
{
    partial class MainScreenForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.addPartButton = new System.Windows.Forms.Button();
            this.modPartButton = new System.Windows.Forms.Button();
            this.delPartButton = new System.Windows.Forms.Button();
            this.partsDataGrid = new System.Windows.Forms.DataGridView();
            this.partSearchInput = new System.Windows.Forms.TextBox();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modProductButton = new System.Windows.Forms.Button();
            this.delProductButton = new System.Windows.Forms.Button();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.productSearchInput = new System.Windows.Forms.TextBox();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageLabel1 = new Inventorer.CustomControls.PageLabel();
            this.partsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).BeginInit();
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1028, 521);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(147, 79);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.addPartButton);
            this.partsGroupBox.Controls.Add(this.modPartButton);
            this.partsGroupBox.Controls.Add(this.delPartButton);
            this.partsGroupBox.Controls.Add(this.partsDataGrid);
            this.partsGroupBox.Controls.Add(this.partSearchInput);
            this.partsGroupBox.Controls.Add(this.partsSearchButton);
            this.partsGroupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGroupBox.Location = new System.Drawing.Point(30, 75);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(570, 440);
            this.partsGroupBox.TabIndex = 4;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Parts";
            // 
            // addPartButton
            // 
            this.addPartButton.AutoSize = true;
            this.addPartButton.Location = new System.Drawing.Point(329, 366);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(65, 55);
            this.addPartButton.TabIndex = 5;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // modPartButton
            // 
            this.modPartButton.AutoSize = true;
            this.modPartButton.Location = new System.Drawing.Point(400, 366);
            this.modPartButton.Name = "modPartButton";
            this.modPartButton.Size = new System.Drawing.Size(73, 55);
            this.modPartButton.TabIndex = 6;
            this.modPartButton.Text = "Modify";
            this.modPartButton.UseVisualStyleBackColor = true;
            this.modPartButton.Click += new System.EventHandler(this.modPartButton_Click);
            // 
            // delPartButton
            // 
            this.delPartButton.AutoSize = true;
            this.delPartButton.Location = new System.Drawing.Point(479, 366);
            this.delPartButton.Name = "delPartButton";
            this.delPartButton.Size = new System.Drawing.Size(76, 55);
            this.delPartButton.TabIndex = 7;
            this.delPartButton.Text = "Delete";
            this.delPartButton.UseVisualStyleBackColor = true;
            this.delPartButton.Click += new System.EventHandler(this.delPartButton_Click);
            // 
            // partsDataGrid
            // 
            this.partsDataGrid.AllowUserToAddRows = false;
            this.partsDataGrid.AllowUserToDeleteRows = false;
            this.partsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsDataGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.partsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGrid.Location = new System.Drawing.Point(20, 100);
            this.partsDataGrid.MultiSelect = false;
            this.partsDataGrid.Name = "partsDataGrid";
            this.partsDataGrid.ReadOnly = true;
            this.partsDataGrid.RowHeadersVisible = false;
            this.partsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGrid.ShowEditingIcon = false;
            this.partsDataGrid.Size = new System.Drawing.Size(535, 225);
            this.partsDataGrid.TabIndex = 2;
            this.partsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDataGrid_CellContentClick_1);
            // 
            // partSearchInput
            // 
            this.partSearchInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSearchInput.Location = new System.Drawing.Point(207, 34);
            this.partSearchInput.Name = "partSearchInput";
            this.partSearchInput.Size = new System.Drawing.Size(348, 26);
            this.partSearchInput.TabIndex = 1;
            this.partSearchInput.Text = "Search by Part ID";
            this.partSearchInput.Enter += new System.EventHandler(this.partSearchInput_Enter);
            this.partSearchInput.Leave += new System.EventHandler(this.partSearchInput_Leave);
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.AutoSize = true;
            this.partsSearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchButton.Location = new System.Drawing.Point(126, 30);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(76, 31);
            this.partsSearchButton.TabIndex = 0;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.addProductButton);
            this.productsGroupBox.Controls.Add(this.modProductButton);
            this.productsGroupBox.Controls.Add(this.delProductButton);
            this.productsGroupBox.Controls.Add(this.productsDataGrid);
            this.productsGroupBox.Controls.Add(this.productSearchInput);
            this.productsGroupBox.Controls.Add(this.productSearchButton);
            this.productsGroupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsGroupBox.Location = new System.Drawing.Point(600, 75);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(570, 440);
            this.productsGroupBox.TabIndex = 8;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Products";
            // 
            // addProductButton
            // 
            this.addProductButton.AutoSize = true;
            this.addProductButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(312, 366);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(76, 55);
            this.addProductButton.TabIndex = 5;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modProductButton
            // 
            this.modProductButton.AutoSize = true;
            this.modProductButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductButton.Location = new System.Drawing.Point(394, 366);
            this.modProductButton.Name = "modProductButton";
            this.modProductButton.Size = new System.Drawing.Size(75, 55);
            this.modProductButton.TabIndex = 6;
            this.modProductButton.Text = "Modify";
            this.modProductButton.UseVisualStyleBackColor = true;
            this.modProductButton.Click += new System.EventHandler(this.modProductButton_Click);
            // 
            // delProductButton
            // 
            this.delProductButton.AutoSize = true;
            this.delProductButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delProductButton.Location = new System.Drawing.Point(475, 366);
            this.delProductButton.Name = "delProductButton";
            this.delProductButton.Size = new System.Drawing.Size(80, 55);
            this.delProductButton.TabIndex = 7;
            this.delProductButton.Text = "Delete";
            this.delProductButton.UseVisualStyleBackColor = true;
            this.delProductButton.Click += new System.EventHandler(this.delProductButton_Click);
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productsDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.productsDataGrid.Location = new System.Drawing.Point(20, 100);
            this.productsDataGrid.MultiSelect = false;
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.ReadOnly = true;
            this.productsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGrid.ShowEditingIcon = false;
            this.productsDataGrid.Size = new System.Drawing.Size(535, 225);
            this.productsDataGrid.TabIndex = 2;
            // 
            // productSearchInput
            // 
            this.productSearchInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchInput.Location = new System.Drawing.Point(198, 33);
            this.productSearchInput.Name = "productSearchInput";
            this.productSearchInput.Size = new System.Drawing.Size(366, 26);
            this.productSearchInput.TabIndex = 1;
            this.productSearchInput.Text = "Search by Product ID";
            this.productSearchInput.Enter += new System.EventHandler(this.productSearchInput_Enter);
            this.productSearchInput.Leave += new System.EventHandler(this.productSearchInput_Leave);
            // 
            // productSearchButton
            // 
            this.productSearchButton.AutoSize = true;
            this.productSearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchButton.Location = new System.Drawing.Point(118, 30);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(76, 31);
            this.productSearchButton.TabIndex = 0;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 80;
            // 
            // PriceDataGridViewTextBoxColumn
            // 
            this.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.PriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn";
            this.PriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // pageLabel1
            // 
            this.pageLabel1.AutoSize = true;
            this.pageLabel1.BackColor = System.Drawing.Color.Transparent;
            this.pageLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLabel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pageLabel1.Location = new System.Drawing.Point(70, 28);
            this.pageLabel1.Name = "pageLabel1";
            this.pageLabel1.Size = new System.Drawing.Size(283, 25);
            this.pageLabel1.TabIndex = 0;
            this.pageLabel1.Text = "Inventory Management System";
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1205, 640);
            this.ControlBox = false;
            this.Controls.Add(this.productsGroupBox);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pageLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainScreenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MainScreen";
            this.Activated += new System.EventHandler(this.MainScreenForm_Activated);
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).EndInit();
            this.productsGroupBox.ResumeLayout(false);
            this.productsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.PageLabel pageLabel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modPartButton;
        private System.Windows.Forms.Button delPartButton;
        private System.Windows.Forms.DataGridView partsDataGrid;
        private System.Windows.Forms.TextBox partSearchInput;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modProductButton;
        private System.Windows.Forms.Button delProductButton;
        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.TextBox productSearchInput;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDataGridViewTextBoxColumn;
    }
}