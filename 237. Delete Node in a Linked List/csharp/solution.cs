/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        ListNode nextNode = node.next;
        node.val = node.next.val;
        node.next = node.next.next;
        nextNode.next = null;
    }
}