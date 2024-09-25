namespace Trie;

public class TrieNode
{
    public TrieNode()
    {
    }
    public TrieNode(char c)
    {
        Child[c - 'a'] = new TrieNode();
    }
    public TrieNode[] Child { get; set; } = new TrieNode[26];
    public bool WordEnd { get; set; } = false;

    public void Insert(string word)
    {
        TrieNode node = this;
        foreach (var c in word)
        {
            if (node.Child[c - 'a'] == null)
                node.Child[c - 'a'] = new TrieNode(c);
            node = node.Child[c - 'a'];
        }
        node.WordEnd = true;
    }
    public bool Search(string word)
    {
        TrieNode node = this;
        foreach (var c in word)
        {
            if (node.Child[c - 'a'] == null)
                return false;
            node = node.Child[c - 'a'];
        }
        return node.WordEnd;
    }

    public bool StartsWith(string prefix)
    {
        TrieNode node = this;
        foreach (var c in prefix)
        {
            if (node.Child[c - 'a'] == null)
                return false;
            node = node.Child[c - 'a'];
        }
        return true;
    }
    public void PrintTrie()
    {
        TrieNode node = this;
        for (int i = 0; i < 26; i++)
        {
            if (node.Child[i] != null)
            {
                Console.WriteLine((char)(i + 'a') + "->" + $"{(node.Child[i].WordEnd ? "End" : "")}");
                node.Child[i].PrintTrie();
            }
        }
    }
}
