namespace Algo.LinkedListManipulation;

//2130. Maximum Twin Sum of a Linked List
public class MaxTwinSum
{
    //4-2-2-3. max - 7
    public int PairSum(ListNode head)
    {
        ListNode currentNode = head;
        List<int> val = new List<int>();
       
        //sum count of nodes
        while (currentNode != null)
        {
            val.Add(currentNode.val);
            currentNode = currentNode.next;
        }

        int i = 0, j = val.Count - 1;
        int maxValue = 0;
        // sum up numbers for twin1 and twin2.
        while (i<j)
        {
            maxValue = Math.Max(maxValue, val[i] + val[j]);
            i++;
            j--;
        }

        return maxValue;
    }
}