using System;
using System.Collections.Generic;
using System.Text;

namespace PathSumIII
{
    class Solution
    {
        int PathSum_A(TreeNode root, int sum)
        {
            if (root == null) return 0;
            int res = 0;
            if (root.val == sum) res++;
            res += PathSum_A(root.left, sum - root.val);
            res += PathSum_A(root.right, sum - root.val);
            return res;
        }

        public int PathSum(TreeNode root, int sum)
        {
            if (root == null) return 0;
            return PathSum(root.left, sum) + PathSum_A(root, sum) + PathSum(root.right, sum);
        }
    }
}
