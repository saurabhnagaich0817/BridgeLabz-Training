public class Solution {
   public ListNode ReverseList(ListNode head)
{
    ListNode resultNode = null;
    while(head != null)
    {
        resultNode = new ListNode(head.val, resultNode);
        head = head.next;
    }
    return resultNode;
}
}