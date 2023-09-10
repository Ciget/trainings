namespace Algo.LinkedListManipulation;

public class DeleteMiddleNode
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head == null || head.next==null) return null;
        int count = 0;
        ListNode currentNode = head;
        while (currentNode != null)
        {
            count++;
            currentNode = currentNode.next;
        }

        int targetIndex = count / 2;
        
        currentNode = head;
        count = 1;
        while (currentNode != null)
        {
            if (count == targetIndex)
            {
                currentNode.next = currentNode.next.next;
                return head;
            }
            count++;
            currentNode = currentNode.next;
        }
        return head;
    }
}