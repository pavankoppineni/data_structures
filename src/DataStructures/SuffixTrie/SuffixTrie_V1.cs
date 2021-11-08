using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SuffixTrie
{
    /// <summary>
    /// https://www.geeksforgeeks.org/pattern-searching-using-suffix-tree/
    /// </summary>
    public class SuffixTrie_V1
    {
        private string _pattern;
        private readonly TrieNode _trieNode;
        public SuffixTrie_V1(string pattern)
        {
            _pattern = pattern;
            _trieNode = new TrieNode();
        }

        public TrieNode Construct()
        {
            var index = 0;
            while (index < _pattern.Length)
            {
                ConstructTrieNode(index);
                index += 1;
            }
            return _trieNode;
        }

        private void ConstructTrieNode(int index)
        {
            var current = _trieNode;
            while(index < _pattern.Length)
            {
                var nodes = current.Nodes;
                if (nodes.ContainsKey(_pattern[index]))
                {
                    current = nodes[_pattern[index]];
                }
                else
                {
                    var newNode = new TrieNode();
                    nodes.Add(_pattern[index], newNode);
                    current = newNode;
                }
                index += 1;
            }
        }
    }

    public class TrieNode
    {
        public TrieNode()
        {
            Nodes = new Dictionary<char, TrieNode>();
        }

        public IDictionary<char, TrieNode> Nodes { get; set; }
    }
}
