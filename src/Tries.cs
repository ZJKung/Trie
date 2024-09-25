namespace Trie;

public class TrieNode
{
    public TrieNode()
    {
    }
    public TrieNode[] Child { get; set; } = new TrieNode[26];
    public bool WordEnd { get; set; } = false;

    public void Insert(string word)
    {
        TrieNode node = this;
        foreach (var c in word)
        {
            if (node.Child[c - 'a'] == null)
                node.Child[c - 'a'] = new TrieNode();
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
        for (int i = 0; i < 26; i++)
        {
            if (Child[i] != null)
            {
                Console.WriteLine((char)(i + 'a') + "->" + $"{(Child[i].WordEnd ? "End" : "")}");
                Child[i].PrintTrie();
            }
        }
    }

}
