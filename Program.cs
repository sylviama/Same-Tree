using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TreeNode node1=new TreeNode(2);
            TreeNode node2=new TreeNode(1);
            node1.left=node2;
            TreeNode node3=new TreeNode(3);
            node1.right=node3;
            TreeNode node4=new TreeNode(4);
            node2.right=node4;
            
            TreeNode node5=new TreeNode(2);
            TreeNode node6=new TreeNode(1);
            node5.left=node6;
            TreeNode node7=new TreeNode(3);
            node5.right=node7;
            TreeNode node8=new TreeNode(4);
            node6.right=node8;
            
            Solution solu=new Solution();
            bool result=solu.IsSameTree(node1,node5);
            
            Console.WriteLine(result);
        }
    }
    
    
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution {
        public bool IsSameTree(TreeNode p, TreeNode q) {
            
            if(p==null&&q==null)
            {
                return true;
            }else if(p==null||q==null)
            {
                return false;
            }else if(p.val==q.val)
            {
                return IsSameTree(p.left,q.left)&&IsSameTree(p.right,q.right);
            }else
            {
                return false;
            }
            
        }
    }       
}
