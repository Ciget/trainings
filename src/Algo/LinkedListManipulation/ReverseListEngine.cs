namespace Algo.LinkedListManipulation;

//206. Reverse Linked List
public class ReverseListEngine
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev=null, current = head;

        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}