namespace Algo.LinkedListManipulation;

public class RemoveNthFromEnd19
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int lenght = 0;
        ListNode node = head;
        while (node != null)
        {
            lenght++;
            node = node.next;
        }

        if (lenght == n) return head.next;

        node = head;
        lenght -= n;
        while (lenght > 0)
        {
            lenght--;
            node = node.next;
        }

        node.next = node.next.next;
        return head;
    }
}