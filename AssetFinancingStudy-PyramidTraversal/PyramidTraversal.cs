using System;
using System.Collections.Generic;

/**
* @author Olufemi Isola
*
* @date - 19/08/20 2:20:27 PM 
*/

namespace AssetFinancingStudy_PyramidTraversal
{
    /// <summary>
    /// Binary tree traversal class
    /// </summary>
    public class PyramidTraversal
    {
        /// <summary>
        /// This method constructs a binary tree from two dimensional list of nodes from the input.
        /// </summary>
        /// <param name="pyramid">The two dimensional list of nodes</param>
        /// <param name="start">Index of each List</param>
        /// <param name="end">Index of the value in each list</param>
        /// <returns>BinaryTreeNode</returns>
        public static BinaryTreeNode ConstructTreeFromPyramid(List<List<int>> pyramid, int start, int end)
        {
            //Empty two dimesional List or we have arrived at the end of the list of lists
            if (pyramid == null || pyramid.Count == 0 || start > pyramid.Count - 1) return null;

            //initiate the current root
            BinaryTreeNode root = new BinaryTreeNode(pyramid[start][end]);

            //Recursively perform the function to set the left node 
            root.Left = ConstructTreeFromPyramid(pyramid, start + 1, end);
            //Recursively perform the function to set the right node 
            root.Right = ConstructTreeFromPyramid(pyramid, start + 1, end + 1);

            return root;
        }

        /// <summary>
        /// This method traverses a binary tree srating from the root and output the maximum
        /// sum in the tree as well as the path to the maximum sum.
        /// </summary>
        /// <param name="root">The root of the binary tree to be traversed</param>
        /// <param name="runningSum">The running sum to store cumulative sum per valid node</param>
        /// <param name="runningPath">The running path to the running sum</param>
        /// <param name="result">The result object for the traversal</param>
        /// <returns>MaxSumPathResult</returns>
        public static MaxSumPathResult GetMaxSumPath(BinaryTreeNode root, int runningSum, List<int> runningPath, MaxSumPathResult result)
        {
            //Null root passed as parameter
            if (root == null) return null;

            // Calculates the running sum and its path in the binary tree
            runningSum += root.Value;
            runningPath.Add(root.Value);

            //We have arrived at most bottom node for this path (base case)
            if (root.Left == null && root.Left == null)
            {
                //set the maxSum if the new sum is more than the existing maxSum
                result.maxSum = Math.Max(result.maxSum, runningSum);
                if (result.maxSum == runningSum)
                {
                    //Set the path pf the current maxSum
                    result.Path = runningPath;
                }
                return result;
            }

            //Create a list for each node of the root
            List<int> pathLeft = new List<int>(runningPath);
            List<int> pathRight = new List<int>(runningPath);

            //check if root's value is even
            if (root.Value % 2 == 0)
            {
                //root's value is even  here


                if (root.Left.Value % 2 != 0)
                {
                    // Recursively Perform this funtion on the left odd node
                    GetMaxSumPath(root.Left, runningSum, pathLeft, result);
                }
                if (root.Right.Value % 2 != 0)
                {
                    // Recursively Perform this funtion on the right odd node
                    GetMaxSumPath(root.Right, runningSum, pathRight, result);
                }
            }
            else
            {
                //root's value is odd here


                if (root.Left.Value % 2 == 0)
                {
                    //Recursively Perform this funtion on the left even node
                    GetMaxSumPath(root.Left, runningSum, pathLeft, result);
                }
                if (root.Right.Value % 2 == 0)
                {
                    //Recursively Perform this funtion on the right even node 
                    GetMaxSumPath(root.Right, runningSum, pathRight, result);
                }
            }
            return result;
        }
    }
}
