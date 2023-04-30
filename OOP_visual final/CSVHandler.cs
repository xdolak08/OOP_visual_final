using System.Text;

namespace OPP_project
{
    internal class CSVHandler
    {
        public string FilePath { get; private set; }

        public CSVHandler(string filePath)
        {
            if (!checkExtension(filePath.ToLower())) throw new Exception("File has wrong extension!");
            FilePath = filePath;
        }

        private bool checkExtension(string path) => path.EndsWith(".csv");

        public void SaveBands(Band[] bands, string[] columnNames, Type[] columnTypes)
        {
            var typeStrings = columnTypes.Select(x => x.ToString());
            StringBuilder sb = new();
            foreach (var name in columnNames)
            {
                if (!name.Contains(',')) sb.Append($"{name},");
                else sb.Append($"\"{name}\",");
            }
            sb.AppendLine();
            foreach (var type in typeStrings)
            {
                sb.Append($"{type},");
            }
            sb.AppendLine();
            foreach (Band band in bands)
            {
                sb.Append($"{band.id},{band.name},");
                foreach (var column in columnNames.Skip(2))
                {
                    if (!band.Items.Keys.Contains(column)) sb.Append($",");
                    else sb.Append($"{band.Items[column]},");
                }
                sb.AppendLine();
            }
            var saveFile = File.CreateText(FilePath);
            saveFile.Write(sb.ToString());
            saveFile.Flush();
            saveFile.Close();
        }

        public Band[] ImportBands()
        {
            var inputFile = File.OpenText(FilePath);
            var line = inputFile.ReadLine();
            var columnNames = line.Remove(line.Length - 1).Split(',');
            line = inputFile.ReadLine();
            var types = line.Remove(line.Length - 1).Split(',').Select(x => StrToType(x)).ToArray();
            var columns = new (string, Type)[columnNames.Length];
            var output = new List<Band>();

            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = (columnNames[i], types[i]);
            }
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] cells = line.Remove(line.Length - 1).Split(',');
                var items = ParseToItems(cells, types, columnNames).Skip(2).ToArray();
                int id = int.Parse(cells[0]);
                string name = cells[1];
                output.Add(new(id, name, items));
            }
            return output.ToArray();
        }

        public static Type StrToType(string str)
        {
            switch (str)
            {
                case "System.Int32":
                    return typeof(int);
                case "System.String":
                    return typeof(string);
                case "System.Boolean":
                    return typeof(bool);
                case "System.Single":
                    return typeof(float);
                default:
                    return typeof(string);
            }
        }

        private (string, object)[] ParseToItems(string[] cellsStr, Type[] types, string[] names)
        {
            if (cellsStr.Length != types.Length) throw new Exception("Wrong input format!");

            var output = new List<(string, object)>();
            for (int i = 0; i < cellsStr.Length; i++)
            {
                if (String.IsNullOrEmpty(cellsStr[i])) continue;
                output.Add((names[i], FormatToType(cellsStr[i], types[i])));
            }
            return output.ToArray();
        }

        public static object FormatToType(string valueStr, Type type)
        {
            switch (type.ToString())
            {
                case "System.Single":
                    return float.Parse(valueStr);
                case "System.Boolean":
                    return bool.Parse(valueStr);
                case "System.Int32":
                    return int.Parse(valueStr);
                default:
                    return valueStr;
            }
        }

    }
}