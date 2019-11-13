/**Reverse a singly linked list.

Example:

Input: 1->2->3->4->5->NULL
Output: 5->4->3->2->1->NULL
Follow up:

A linked list can be reversed either iteratively or recursively. Could you implement both?*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        ListNode prevHead = null;
        while (head != null) 
        {
        ListNode recordNext = head.next;
        head.next = prevHead;
        prevHead = head;
        head = recordNext;
    }
    return prevHead;
    }
}