using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trie
{
    /**
    public class PrefixTrie
    {
        private TrieNode root { get;  set; }
        private readonly char EndSymbol = '*';
        public PrefixTrie()
        {
            root = new();
        }

        public void Insert(string word)
        {
            var currentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (!currentNode.Children.ContainsKey(letter))
                    currentNode.Children.Add(letter, new TrieNode());

                currentNode = currentNode.Children[letter];
            }

            if(!currentNode.Children.ContainsKey(EndSymbol))
                  currentNode.Children.Add(EndSymbol, null);
        }

       

        public bool Search(string word)
        {
            var curretNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (!curretNode.Children.ContainsKey(letter))
                    return false;

                curretNode = curretNode.Children[letter];
            }

            return curretNode.Children.ContainsKey(EndSymbol);
        }

        public bool StartsWith(string prefix)
        {
            var curretNode = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                char letter = prefix[i];
                if (!curretNode.Children.ContainsKey(letter))
                    return false;

                curretNode = curretNode.Children[letter];
            }

            return true;
        }
    }

    **/



    
    public class PrefixTrie
    {
        private TrieNode root { get;  set; }
        private readonly char EndSymbol = '#';
        public PrefixTrie()
        {
            root = new();
        }

        public void Insert(string word)
        {
            var currentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (!currentNode.Children.ContainsKey(letter))
                    currentNode.Children.Add(letter, new TrieNode());

                currentNode = currentNode.Children[letter];
            }

            if(!currentNode.Children.ContainsKey(EndSymbol))
                  currentNode.Children.Add(EndSymbol, new TrieNode(word));
        }

       

        public List<string> Search(string word)
        {
            var result = new List<string>();
            SearchHelper(word, this.root, result);
            return result;
        }

        private void SearchHelper(string word, TrieNode node, List<string> result)
        {
            var currentNode = node;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (!currentNode.Children.ContainsKey(letter))
                    return;

                currentNode = currentNode.Children[letter];
            }

            foreach (var key in currentNode.Children.Keys)
            {
                if (key == '#')
                {
                    result.Add(currentNode.Children[key].FullString);
                }
                else
                    SearchHelper("", currentNode.Children[key], result);
            }
        }

        public bool StartsWith(string prefix)
        {
            var curretNode = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                char letter = prefix[i];
                if (!curretNode.Children.ContainsKey(letter))
                    return false;

                curretNode = curretNode.Children[letter];
            }

            return true;
        }
    }

    

}

