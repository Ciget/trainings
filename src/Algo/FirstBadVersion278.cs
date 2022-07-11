namespace Algo;

public class FirstBadVersion278: VersionControl {
    public int FirstBadVersion(int n)
    {
        //1, 2, 3, 4, 5
        //1, 2
        int lastGoodVersion=1, lastBadVersion=n;

        while (lastGoodVersion<lastBadVersion)
        {
            var pivot=lastGoodVersion + (lastBadVersion - lastGoodVersion)/2;
            if (IsBadVersion(pivot))
            {
                lastBadVersion = pivot;
            }
            else
            {
                lastGoodVersion = pivot;
            }
        }

        return lastBadVersion;
    }
}

public class VersionControl
{
    protected bool IsBadVersion(int version)
    {
        return false;
    }
}