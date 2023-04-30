using System.Data;
using System.Text;

namespace OPP_project
{
    public class Band
    {
        public int id { get; private set; }
        public string name { get; set; }

        public Dictionary<string, object> Items { get; set; }

        public void Modify((string, Object) toModify)
        {
            if (toModify.Item1 == "Name" && !String.IsNullOrEmpty(toModify.Item2.ToString())) name = toModify.Item2.ToString();
            if (Items.Keys.Contains(toModify.Item1))
                Items[toModify.Item1] = toModify.Item2;
            else
                Items.Add(toModify.Item1, toModify.Item2);
        }

        public bool Search(string query)
        {
            if (name.Contains(query, StringComparison.OrdinalIgnoreCase)) return true;
            if (id.ToString().Contains(query)) return true;
            return Items.Values.AsParallel().Select(x => x.ToString().Contains(query, StringComparison.OrdinalIgnoreCase)).Contains(true);
        }

        public Band(int id, string name, params (string, Object)[] arguments)
        {
            Items = new Dictionary<string, object>();
            foreach (var item in arguments)
            {
                Items.Add(item.Item1, item.Item2);
            }
            this.id = id;
            this.name = name;
        }

        public void ChangeId(int newId) => id = newId;

        public override string ToString()
        {
            var contents = Items.Select(x => x.Value.ToString());
            StringBuilder sb = new();
            sb.Append($"{id.ToString()},");
            if (!name.Contains(',')) sb.Append($"{name},");
            else sb.Append($"\"{name}\",");
            foreach (var item in contents)
            {
                if (!item.Contains(',')) sb.Append($"{item},");
                else sb.Append($"\"{item}\",");
            }
            return sb.ToString();
        }

    }
}