namespace Algo.LinkedListManipulation;

public class NumbersList
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
    {
        if (l1 == null && l2 == null && carry ==0) return null;
        int val = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
        carry = val / 10;
        return new ListNode(val % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
    }

}