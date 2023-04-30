namespace Project_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            importButton = new Button();
            saveButton = new Button();
            addColumnButton = new Button();
            panelName = new Panel();
            label2 = new Label();
            searchTB = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            bandsDGW = new DataGridView();
            panelMenu.SuspendLayout();
            panelName.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bandsDGW).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkCyan;
            panelMenu.Controls.Add(importButton);
            panelMenu.Controls.Add(saveButton);
            panelMenu.Controls.Add(addColumnButton);
            panelMenu.Controls.Add(panelName);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(175, 422);
            panelMenu.TabIndex = 0;
            // 
            // importButton
            // 
            importButton.DialogResult = DialogResult.Cancel;
            importButton.Dock = DockStyle.Top;
            importButton.FlatAppearance.BorderSize = 0;
            importButton.FlatStyle = FlatStyle.Flat;
            importButton.ForeColor = Color.White;
            importButton.Location = new Point(0, 176);
            importButton.Name = "importButton";
            importButton.Size = new Size(175, 41);
            importButton.TabIndex = 3;
            importButton.Text = "Import from file";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // saveButton
            // 
            saveButton.DialogResult = DialogResult.Cancel;
            saveButton.Dock = DockStyle.Top;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(0, 135);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(175, 41);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save to file";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addColumnButton
            // 
            addColumnButton.DialogResult = DialogResult.Cancel;
            addColumnButton.Dock = DockStyle.Top;
            addColumnButton.FlatAppearance.BorderSize = 0;
            addColumnButton.FlatStyle = FlatStyle.Flat;
            addColumnButton.ForeColor = Color.Snow;
            addColumnButton.Location = new Point(0, 94);
            addColumnButton.Name = "addColumnButton";
            addColumnButton.Size = new Size(175, 41);
            addColumnButton.TabIndex = 1;
            addColumnButton.Text = "Add Column";
            addColumnButton.UseVisualStyleBackColor = true;
            addColumnButton.Click += addColumnButton_Click;
            // 
            // panelName
            // 
            panelName.BackColor = Color.DarkSlateGray;
            panelName.Controls.Add(label2);
            panelName.Controls.Add(searchTB);
            panelName.Dock = DockStyle.Top;
            panelName.Location = new Point(0, 0);
            panelName.Name = "panelName";
            panelName.Size = new Size(175, 94);
            panelName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 32);
            label2.Name = "label2";
            label2.Size = new Size(75, 27);
            label2.TabIndex = 1;
            label2.Text = "Search: ";
            // 
            // searchTB
            // 
            searchTB.BackColor = Color.DarkCyan;
            searchTB.BorderStyle = BorderStyle.FixedSingle;
            searchTB.Cursor = Cursors.IBeam;
            searchTB.Location = new Point(75, 32);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(94, 23);
            searchTB.TabIndex = 0;
            searchTB.KeyUp += searchTB_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(219, 34);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Database of Bands";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(175, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 94);
            panel1.TabIndex = 1;
            // 
            // bandsDGW
            // 
            bandsDGW.AllowUserToDeleteRows = false;
            bandsDGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bandsDGW.Dock = DockStyle.Fill;
            bandsDGW.Location = new Point(175, 94);
            bandsDGW.Name = "bandsDGW";
            bandsDGW.RowHeadersWidth = 51;
            bandsDGW.RowTemplate.Height = 24;
            bandsDGW.Size = new Size(981, 328);
            bandsDGW.TabIndex = 2;
            bandsDGW.CellEndEdit += bandsDGW_CellEndEdit;
            bandsDGW.KeyDown += bandsDGW_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 422);
            Controls.Add(bandsDGW);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            panelMenu.ResumeLayout(false);
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bandsDGW).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addColumnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bandsDGW;
        private TextBox searchTB;
        private Label label2;
    }
}

