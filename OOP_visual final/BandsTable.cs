using System.Data;

namespace OPP_project
{
    internal class BandsTable : DataTable
    {

        public List<Band> bands { get; set; }

        private List<Band> bandsSource;

        private List<Band> SearchResults;

        public bool SearchMode
        {
            get
            {
                return _searchMode;
            }
            set
            {
                if (value) bandsSource = SearchResults;
                else bandsSource = bands;
                _searchMode = value;
            }
        }

        private bool _searchMode;

        public int BandCount { get; private set; }

        private int id;

        public BandsTable()
        {
            id = 0;
            bands = new List<Band>();
            bandsSource = bands;
            SearchResults = new List<Band>();
            this.Columns.Add("Id", typeof(int));
            this.Columns.Add("Name", typeof(string));
            this.Columns["Id"].ReadOnly = true;
        }

        public void AddBand(string name, params (string, Object)[] arguments)
        {
            AddBand(new Band(id++, name, arguments));
        }

        public void AddBand(Band band)
        {
            if (bandsSource.Select(x => x.id).Contains(band.id)) band.ChangeId(id++);
            if (bandsSource.Select(x => x.name).Contains(band.name))
            {
                var bandToChange = bandsSource.Where(x => x.name == band.name).First();
                var newElements = band.Items.Select(x => x.Key).Except(bandToChange.Items.Select(x => x.Key));
                if (newElements.Count() == 0)
                {
                    MessageBox.Show($"Record with name: \"{band.name}\" already exists, so it wasn't added.");
                    return;
                }

                foreach (var item in newElements)
                {
                    bandToChange.Items.Add(item, band.Items[item]);
                    this.Columns.Add(item, band.Items[item].GetType());
                }
                RefreshBandTable();
                return;
            }
            bandsSource.Add(band);
            BandCount++;
            var columnNames = band.Items.Select(v => v.Key).ToArray();
            var columnTypes = band.Items.Select(v => v.Value.GetType()).ToArray();
            UpdateColumns(columnNames, columnTypes);
            RefreshBandTable();
        }

        public void AddBand(DataGridViewRow row)
        {
            var name = row.Cells["Name"].Value.ToString();
            var arguments = new List<(string, Object)>();
            foreach (var cell in row.Cells.Cast<DataGridViewCell>().Skip(2))
            {
                if (string.IsNullOrEmpty(cell.Value.ToString()) != null && cell.Value.ToString() != name)
                {
                    arguments.Add((cell.OwningColumn.Name, cell.Value));
                }
            }
            AddBand(name, arguments.ToArray());
        }

        public void RemoveBand(int id)
        {
            var band = bandsSource.Find(x => x.id == id);
            bandsSource.Remove(band);
            BandCount--;
            RefreshBandTable();
        }

        public void ModifyBand(int id, (string, Object) argument)
        {
            var band = bandsSource.Find(x => x.id == id);
            band.Modify(argument);
            RefreshBandTable();
        }

        public void RefreshBandTable()
        {
            this.Clear();
            foreach (var band in bandsSource)
            {
                DataRow dataRow = this.NewRow();
                dataRow["Id"] = band.id;
                dataRow["Name"] = band.name;
                foreach (var item in band.Items)
                {
                    dataRow[item.Key] = item.Value;
                }
                this.Rows.Add(dataRow);
            }
        }

        public void UpdateColumns(string[] columnNames, Type[] columnTypes)
        {
            (string, Type)[] columns = new (string, Type)[columnNames.Length];
            for (int i = 0; i < columnNames.Length; i++)
            {
                columns[i] = (columnNames[i], columnTypes[i]);
            }
            var existingColumns = this.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            var newColumns = columns.Where(x => !existingColumns.Contains(x.Item1)).ToArray();

            foreach (var column in newColumns)
            {
                this.Columns.Add(column.Item1, column.Item2);
            }
        }

        public void SearchTable(string query)
        {
            SearchResults = new List<Band>();
            if (String.IsNullOrEmpty(query))
            {
                SearchMode = false;
            }
            else
            {
                SearchMode = true;
                var searchResults = bands.AsParallel().Where(x => x.Search(query)).ToList();
                foreach (var band in searchResults)
                {
                    bandsSource.Add(band);
                }
            }
            RefreshBandTable();
        }
    }
}