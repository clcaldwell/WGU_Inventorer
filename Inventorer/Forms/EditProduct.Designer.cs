namespace Inventorer
{
    partial class EditProduct
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
            this.partSearchInput = new System.Windows.Forms.TextBox();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.allPartsListDataGrid = new System.Windows.Forms.DataGridView();
            this.addPartButton = new System.Windows.Forms.Button();
            this.associatedPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.delPartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(900, 460);
            // 
            // partSearchInput
            // 
            this.partSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.partSearchInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSearchInput.Location = new System.Drawing.Point(915, 25);
            this.partSearchInput.Name = "PartSearchInput";
            this.partSearchInput.Size = new System.Drawing.Size(170, 25);
            this.partSearchInput.TabIndex = 32;
            this.partSearchInput.Text = "Search by Part ID";
            this.partSearchInput.Enter += new System.EventHandler(this.PartSearchInput_Enter);
            this.partSearchInput.Leave += new System.EventHandler(this.PartSearchInput_Leave);
            // 
            // PartSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(825, 25);
            this.partSearchButton.Name = "PartSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(85, 25);
            this.partSearchButton.TabIndex = 33;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            this.partSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // allPartsListDataGrid
            // 
            this.allPartsListDataGrid.AllowUserToAddRows = false;
            this.allPartsListDataGrid.AllowUserToDeleteRows = false;
            this.allPartsListDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allPartsListDataGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.allPartsListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsListDataGrid.Location = new System.Drawing.Point(495, 70);
            this.allPartsListDataGrid.MultiSelect = false;
            this.allPartsListDataGrid.Name = "allPartsListDataGrid";
            this.allPartsListDataGrid.ReadOnly = true;
            this.allPartsListDataGrid.RowHeadersVisible = false;
            this.allPartsListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsListDataGrid.Size = new System.Drawing.Size(590, 140);
            this.allPartsListDataGrid.TabIndex = 34;
            // 
            // AddPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(1000, 220);
            this.addPartButton.Name = "AddPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 25);
            this.addPartButton.TabIndex = 35;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // associatedPartsDataGrid
            // 
            this.associatedPartsDataGrid.AllowUserToAddRows = false;
            this.associatedPartsDataGrid.AllowUserToDeleteRows = false;
            this.associatedPartsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsDataGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.associatedPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDataGrid.Location = new System.Drawing.Point(490, 265);
            this.associatedPartsDataGrid.MultiSelect = false;
            this.associatedPartsDataGrid.Name = "associatedPartsDataGrid";
            this.associatedPartsDataGrid.ReadOnly = true;
            this.associatedPartsDataGrid.RowHeadersVisible = false;
            this.associatedPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataGrid.Size = new System.Drawing.Size(590, 140);
            this.associatedPartsDataGrid.TabIndex = 36;
            // 
            // delPartButton
            // 
            this.delPartButton.Location = new System.Drawing.Point(1000, 415);
            this.delPartButton.Name = "DeletePartButton";
            this.delPartButton.Size = new System.Drawing.Size(75, 25);
            this.delPartButton.TabIndex = 37;
            this.delPartButton.Text = "Delete";
            this.delPartButton.UseVisualStyleBackColor = true;
            this.delPartButton.Click += new System.EventHandler(this.DelPartButton_Click);
             // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1105, 540);
            this.Controls.Add(this.delPartButton);
            this.Controls.Add(this.associatedPartsDataGrid);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.allPartsListDataGrid);
            this.Controls.Add(this.partSearchButton);
            this.Controls.Add(this.partSearchInput);
            this.Name = "EditProduct";
            this.Text = "Product";
            this.Controls.SetChildIndex(this.EditPageLabel, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.partSearchInput, 0);
            this.Controls.SetChildIndex(this.partSearchButton, 0);
            this.Controls.SetChildIndex(this.allPartsListDataGrid, 0);
            this.Controls.SetChildIndex(this.addPartButton, 0);
            this.Controls.SetChildIndex(this.associatedPartsDataGrid, 0);
            this.Controls.SetChildIndex(this.delPartButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.allPartsListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button delPartButton;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.TextBox partSearchInput;
        private System.Windows.Forms.DataGridView allPartsListDataGrid;
        private System.Windows.Forms.DataGridView associatedPartsDataGrid;
        
    }
}