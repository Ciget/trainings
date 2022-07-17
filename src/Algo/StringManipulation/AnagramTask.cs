using System.Collections;

namespace Algo.StringManipulation;

public class AnagramTask
{
    public bool IsAnagram(string s, string t)
    {
        var i = s.ToCharArray();
        Array.Sort(i);
        
        var j = t.ToCharArray();
        Array.Sort(j);

        IStructuralEquatable r1 = i;
        IStructuralEquatable r2 = j;
        return r1.Equals(r2, StructuralComparisons.StructuralEqualityComparer);
    }
}