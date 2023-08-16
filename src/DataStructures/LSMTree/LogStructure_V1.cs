using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LSMTree
{
    public class LogStructure_V1
    {
        private IList<(int key, string value)> _items;
        const int COMPACTION_LIMIT = 50;
        public LogStructure_V1()
        {
            _items = new List<(int key, string value)>();
        }

        public void Add(int key, string value)
        {
            _items.Add((key, value));
            if (_items.Count < COMPACTION_LIMIT)
            {
                return;
            }
            PerformCompaction();
        }

        private void PerformCompaction()
        {
            var lookup = ConvertToLookup();
            _items.Clear();
            foreach (var item in lookup)
            {
                _items.Add((item.Key, item.Value));
            }
        }

        private IDictionary<int, string> ConvertToLookup()
        {
            var lookup = new Dictionary<int, string>();
            foreach (var (key, value) in _items)
            {
                if (!lookup.ContainsKey(key))
                {
                    lookup.Add(key, value);
                    continue;
                }
                lookup[key] = value;
            }
            return lookup;
        }

        public IList<(int key, string value)> GetData() => _items;
    }
}
