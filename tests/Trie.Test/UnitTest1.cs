namespace Trie.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var trie = new TrieNode();
        trie.Insert("apple");
        Assert.True(trie.Search("apple"));   // returns true
        Assert.False(trie.Search("app"));     // returns false
        Assert.True(trie.StartsWith("app")); // returns true
        trie.Insert("app");
        Assert.True(trie.Search("app"));     // returns true
    }
}