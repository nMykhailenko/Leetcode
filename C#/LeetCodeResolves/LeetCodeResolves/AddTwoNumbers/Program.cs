using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var fNode = new ListNode
            {
                value = 2,
                next = new ListNode
                {
                    value = 4,
                    next = new ListNode
                    {
                        value = 3,
                        next = null
                    }
                }
            };

            var sNode = new ListNode
            {
                value = 5,
                next = new ListNode
                {
                    value = 6,
                    next = new ListNode
                    {
                        value = 4,
                        next = null
                    }
                }
            };

            var result = AddTwoNumbers(fNode, sNode);

            Console.ReadLine();
        }

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, current = dummyHead;
            var carry = 0;
            while(p != null || q != null)
            {
                var x = p != null ? p.value : 0;
                var y = q != null ? q.value : 0;
                var sum = carry + x + y;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }

            if(carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }
}
