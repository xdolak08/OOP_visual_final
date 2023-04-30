using OPP_project;
using System.Data;

namespace Project_OOP
{
    public partial class Form1 : Form
    {
        private Button currentButton;

        private BandsTable bt;


        public Form1()
        {
            InitializeComponent();
            bt = new BandsTable();
            bandsDGW.DataSource = bt;

            bt.AddBand("Kabát", ("Žánr", "Rock"), ("Národnost", "Česká"), ("Počet členů", 5), ("Aktivní", true), ("Počet slavíků", 11));
            bt.AddBand("Imagine Dragons", ("Žánr", "Alternative Rock"), ("Národnost", "Americká"), ("Počet členů", 4), ("Aktivní", true));
        }



        private void ActivateButton(object buttonSender)
        {
            if (buttonSender is Button pressedButton)
            {
                if (currentButton == pressedButton) return;

                DisableButton();
                Color color = Color.Red;
                currentButton = pressedButton;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;

            }
        }

        private void DisableButton()
        {
            if (!(currentButton is Button)) return;
            currentButton.BackColor = Color.DarkCyan;
            currentButton.ForeColor = Color.White;
        }

        private void addColumnButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            var dialog = new AddColumnDialog();
            dialog.ShowDialog();
            if (dialog.DialogResult != DialogResult.OK) return;
            bt.UpdateColumns(new string[] { dialog.ColumnName }, new Type[] { dialog.ColumnType });
            if (dialog.DefaultValue == null) return;
            for (int i = 0; i < bt.bands.Count; i++)
            {
                var modifier = (dialog.ColumnName, CSVHandler.FormatToType(dialog.DefaultValue.ToString(), dialog.ColumnType));
                bt.ModifyBand(i, modifier);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            SaveFileDialog saveFile = new();
            saveFile.AddExtension = true;
            saveFile.DefaultExt = ".csv";
            saveFile.ValidateNames = true;
            saveFile.FileName = "bands.csv";
            saveFile.Filter = "Soubor CSV|*.csv";
            saveFile.ShowDialog();

            if (Directory.Exists(saveFile.FileName)) return;

            CSVHandler csvHandler = new(saveFile.FileName);
            var columnNames = bt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            var columnTypes = bt.Columns.Cast<DataColumn>().Select(x => x.DataType).ToArray();
            csvHandler.SaveBands(bt.bands.ToArray(), columnNames, columnTypes);

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            OpenFileDialog openFile = new();
            openFile.Filter = "Soubor CSV|*.csv";
            openFile.FileName = "bands.csv";
            openFile.AddExtension = true;
            openFile.ValidateNames = true;
            openFile.DefaultExt = ".csv";
            openFile.ShowDialog();
            bt.SearchMode = false;

            if (!File.Exists(openFile.FileName)) return;

            CSVHandler csvHandler = new(openFile.FileName);
            var importedBands = csvHandler.ImportBands();
            foreach (var band in importedBands)
            {
                bt.AddBand(band);
            }

        }

        private void bandsDGW_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var columnName = bandsDGW.Columns[e.ColumnIndex].Name;
            var RowIndex = e.RowIndex;
            var Value = bandsDGW.Rows[RowIndex].Cells[columnName].Value;

            if (e.RowIndex < bt.BandCount)
            {
                bt.ModifyBand((int)bt.Rows[e.RowIndex]["Id"], (columnName, Value));
            }
            else if (columnName == "Name" && !String.IsNullOrEmpty(Value.ToString()))
            {
                var Row = bandsDGW.Rows[e.RowIndex];
                bt.AddBand(Row);
            }

        }

        private void searchTB_KeyUp(object sender, KeyEventArgs e)
        {
            var textBox = sender as TextBox;
            var searchQuery = textBox.Text;

            bt.SearchTable(searchQuery);
        }

        private void bandsDGW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;

            var IdsToDelete = bandsDGW.SelectedRows.Cast<DataGridViewRow>().Select(x => int.Parse(x.Cells[0].Value.ToString()));
            foreach (var rowId in IdsToDelete)
            {
                bt.RemoveBand(rowId);
            }
        }

    }
}
