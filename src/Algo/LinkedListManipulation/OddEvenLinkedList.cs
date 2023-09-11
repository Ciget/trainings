namespace Algo.LinkedListManipulation;

public class OddEvenLinkedList
{
    //328. Odd Even Linked List
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null || head.next == null) return head;
        
        ListNode evenHead = head.next;
        ListNode even = head.next;
        ListNode odd = head;

        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }

        odd.next = evenHead;
        return head;
    }
}