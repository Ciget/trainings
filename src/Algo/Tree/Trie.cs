namespace Algo.Tree;

public class TrieNode
{
    public TrieNode[] Children;
    public int WordCount = 0;
    public TrieNode()
    {
        Children = new TrieNode[26];
    }
}

public class Trie
{
    private TrieNode _root;
    
    public Trie()
    {
        _root = new TrieNode();
    }
    
    public void Insert(string word)
    {
        var currentNode = _root;
        foreach (var c in word)
        {
            int i = c - 'a';
            if (currentNode.Children[i] == null)
            {
                currentNode.Children[i] = new TrieNode();
            }

            currentNode = currentNode.Children[i];
        }

        currentNode.WordCount++;
    }
    
    public bool Search(string word) {
        var currentNode = _root;
        foreach (var c in word)
        {
            int i = c - 'a';
            if (currentNode.Children[i] == null)
            {
                return false;
            }

            currentNode = currentNode.Children[i];
        }

        return currentNode.WordCount>0;
    }
    
    public bool StartsWith(string prefix) {
        var currentNode = _root;
        foreach (var c in prefix)
        {
            int i = c - 'a';
            if (currentNode.Children[i] == null)
            {
                return false;
            }

            currentNode = currentNode.Children[i];
        }

        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */