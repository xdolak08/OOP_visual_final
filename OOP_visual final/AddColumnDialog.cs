namespace OPP_project
{
    public partial class AddColumnDialog : Form
    {

        public string ColumnName { get; set; }

        public object DefaultValue { get; set; }

        public Type ColumnType { get; set; }

        public AddColumnDialog()
        {
            InitializeComponent();
            ColumnType = typeof(string);
            DefaultValue = null;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ColumnName = ColumnNameTB.Text;
            if (ColumnNameTB.Text.Length == 0)
            {
                MessageBox.Show("Column name cannot be empty");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var changed = sender as RadioButton;
            DefaultValueCB.Enabled = false;
            DefaultValueTB.Enabled = true;
            switch (changed.Text)
            {
                case "string":
                    ColumnType = typeof(string);
                    break;
                case "int":
                    ColumnType = typeof(int);
                    break;
                case "float":
                    ColumnType = typeof(float);
                    break;
                case "bool":
                    ColumnType = typeof(bool);
                    DefaultValueCB.Enabled = true;
                    DefaultValueTB.Enabled = false;
                    break;
            }
            DefaultValue = null;
        }

        private void DefaultValueCB_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            checkBox.Text = checkBox.Checked ? "true" : "false";
            DefaultValue = checkBox.Checked;
        }

        private void DefaultValueTB_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            switch (ColumnType.ToString())
            {
                case "System.String":
                    DefaultValue = textBox.Text;
                    break;
                case "System.Int32":
                    bool isInt = int.TryParse(textBox.Text, out int resultInt);
                    if (isInt) DefaultValue = resultInt;
                    else MessageBox.Show("Invalid input");
                    break;
                case "System.Single":
                    bool isFloat = float.TryParse(textBox.Text, out float resultFloat);
                    if (isFloat) DefaultValue = resultFloat;
                    else MessageBox.Show("Invalid input");
                    break;
            }
        }
    }
}
