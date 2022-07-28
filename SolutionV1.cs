/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode merged = new ListNode();
        var mergedPointer = merged;
        var list1Pointer = list1;
        var list2Pointer = list2;
        
        while(list1Pointer is not null || list2Pointer is not null)
        {
            if(list1Pointer is null)
            {
                mergedPointer.next = new(list2Pointer.val);
                mergedPointer = mergedPointer.next;
                list2Pointer = list2Pointer.next;
                continue;
            }
            
            if(list2Pointer is null)
            {
                mergedPointer.next = new(list1Pointer.val);
                mergedPointer = mergedPointer.next;
                list1Pointer = list1Pointer.next;
                continue;
            }
            
            if(list1Pointer.val < list2Pointer.val)
            {
                mergedPointer.next = new(list1Pointer.val);
                mergedPointer = mergedPointer.next;
                list1Pointer = list1Pointer.next;                
            } else {
                mergedPointer.next = new(list2Pointer.val);
                mergedPointer = mergedPointer.next;
                list2Pointer = list2Pointer.next;                                
            }
        }
        
        return merged.next;
    }
}
