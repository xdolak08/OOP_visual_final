namespace OPP_project
{
    partial class AddColumnDialog
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
            ColumnNameTB = new TextBox();
            DataTypeRBString = new RadioButton();
            DataTypeRBInt = new RadioButton();
            DataTypeRBBool = new RadioButton();
            CancelButton = new Button();
            OKButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DefaultValueTB = new TextBox();
            DefaultValueCB = new CheckBox();
            DataTypeRBfloat = new RadioButton();
            SuspendLayout();
            // 
            // ColumnNameTB
            // 
            ColumnNameTB.Location = new Point(160, 33);
            ColumnNameTB.Name = "ColumnNameTB";
            ColumnNameTB.Size = new Size(133, 23);
            ColumnNameTB.TabIndex = 0;
            // 
            // DataTypeRBString
            // 
            DataTypeRBString.AutoSize = true;
            DataTypeRBString.Checked = true;
            DataTypeRBString.Location = new Point(160, 73);
            DataTypeRBString.Name = "DataTypeRBString";
            DataTypeRBString.Size = new Size(55, 19);
            DataTypeRBString.TabIndex = 1;
            DataTypeRBString.TabStop = true;
            DataTypeRBString.Text = "string";
            DataTypeRBString.UseVisualStyleBackColor = true;
            DataTypeRBString.CheckedChanged += radioButton_CheckedChanged;
            // 
            // DataTypeRBInt
            // 
            DataTypeRBInt.AutoSize = true;
            DataTypeRBInt.Location = new Point(160, 98);
            DataTypeRBInt.Name = "DataTypeRBInt";
            DataTypeRBInt.Size = new Size(39, 19);
            DataTypeRBInt.TabIndex = 2;
            DataTypeRBInt.Text = "int";
            DataTypeRBInt.UseVisualStyleBackColor = true;
            DataTypeRBInt.CheckedChanged += radioButton_CheckedChanged;
            // 
            // DataTypeRBBool
            // 
            DataTypeRBBool.AutoSize = true;
            DataTypeRBBool.Location = new Point(160, 148);
            DataTypeRBBool.Name = "DataTypeRBBool";
            DataTypeRBBool.Size = new Size(49, 19);
            DataTypeRBBool.TabIndex = 3;
            DataTypeRBBool.Text = "bool";
            DataTypeRBBool.UseVisualStyleBackColor = true;
            DataTypeRBBool.CheckedChanged += radioButton_CheckedChanged;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(40, 249);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(67, 32);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(226, 249);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(67, 32);
            OKButton.TabIndex = 5;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 75);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 6;
            label1.Text = "Column data type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 36);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 7;
            label2.Text = "Column name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 176);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 9;
            label3.Text = "Default Value:";
            // 
            // DefaultValueTB
            // 
            DefaultValueTB.Location = new Point(160, 173);
            DefaultValueTB.Name = "DefaultValueTB";
            DefaultValueTB.Size = new Size(133, 23);
            DefaultValueTB.TabIndex = 8;
            DefaultValueTB.TextChanged += DefaultValueTB_TextChanged;
            // 
            // DefaultValueCB
            // 
            DefaultValueCB.AutoSize = true;
            DefaultValueCB.Enabled = false;
            DefaultValueCB.Location = new Point(160, 213);
            DefaultValueCB.Name = "DefaultValueCB";
            DefaultValueCB.Size = new Size(50, 19);
            DefaultValueCB.TabIndex = 10;
            DefaultValueCB.Text = "false";
            DefaultValueCB.UseVisualStyleBackColor = true;
            DefaultValueCB.CheckedChanged += DefaultValueCB_CheckedChanged;
            // 
            // DataTypeRBfloat
            // 
            DataTypeRBfloat.AutoSize = true;
            DataTypeRBfloat.Location = new Point(160, 123);
            DataTypeRBfloat.Name = "DataTypeRBfloat";
            DataTypeRBfloat.Size = new Size(49, 19);
            DataTypeRBfloat.TabIndex = 11;
            DataTypeRBfloat.Text = "float";
            DataTypeRBfloat.UseVisualStyleBackColor = true;
            DataTypeRBfloat.CheckedChanged += radioButton_CheckedChanged;
            // 
            // AddColumnDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 301);
            Controls.Add(DataTypeRBfloat);
            Controls.Add(DefaultValueCB);
            Controls.Add(label3);
            Controls.Add(DefaultValueTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OKButton);
            Controls.Add(CancelButton);
            Controls.Add(DataTypeRBBool);
            Controls.Add(DataTypeRBInt);
            Controls.Add(DataTypeRBString);
            Controls.Add(ColumnNameTB);
            Name = "AddColumnDialog";
            Text = "AddColumnDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ColumnNameTB;
        private RadioButton DataTypeRBString;
        private RadioButton DataTypeRBInt;
        private RadioButton DataTypeRBBool;
        private Button CancelButton;
        private Button OKButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DefaultValueTB;
        private CheckBox DefaultValueCB;
        private RadioButton DataTypeRBfloat;
    }
}