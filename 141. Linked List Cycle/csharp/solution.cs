/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        //version1
        // ListNode curr = head;
        // List<ListNode> list = new List<ListNode>();
        // while (curr != null)
        // {
        //     if (list.Contains(curr))
        //     {
        //         return true;
        //     }
        //     list.Add(curr);
        //     curr = curr.next;
        // }
        // return false;

        //ver2
        ListNode fast = head;
        ListNode slow = head;
        while (fast!= null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if(fast == slow)
                return true;
            
        }
        return false;
    }
}