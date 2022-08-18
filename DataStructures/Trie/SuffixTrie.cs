using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trie
{
    public class SuffixTrie
    {
        public TrieNode root = new TrieNode();
        public char endSymbol = '*';

        public SuffixTrie(string str)
        {
            PopulateSuffixTrieFrom(str);
        }

        public void PopulateSuffixTrieFrom(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                InsertIntoTrie(i, str);
            }
        }

        private void InsertIntoTrie(int index, string str)
        {
            var currentNode = root;
            for (int i= index; i < str.Length; i++)
            {
                char letter = str[i];
                if (!currentNode.Children.ContainsKey(letter))
                    currentNode.Children.Add(letter, new TrieNode());

                currentNode = currentNode.Children[letter];      
            }

            currentNode.Children.Add(endSymbol, null);
        }

        public bool Contains(string str)
        {
            var currentNode = root;
            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];
                if (!currentNode.Children.ContainsKey(letter))
                    return false;

              
                currentNode = currentNode.Children[letter];
            }
            // Write your code here.
            return currentNode.Children.ContainsKey(endSymbol);
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = 
            new Dictionary<char, TrieNode>();
        public string FullString { get; private set; }
        public TrieNode(string value="")
        {
            FullString = value;
        }
    }
}
