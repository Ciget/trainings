namespace Algo.LinkedListManipulation;
public class MiddleOfLinkedList876
{
    public ListNode MiddleNodeAlternative(ListNode head)
    { 
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}