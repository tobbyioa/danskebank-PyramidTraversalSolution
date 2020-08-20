
/**
* @author Olufemi Isola
*
* @date - 19/08/20 2:18:43 PM 
*/

namespace AssetFinancingStudy_PyramidTraversal
{
    /// <summary>
    /// The Class that models the Binary Tree Node
    /// It is used to create a binary tree node object
    /// </summary>
    public class BinaryTreeNode
    {
        // Value of the node
        public int Value { get; set; }

        //Left Child of the node
        public BinaryTreeNode Left { get; set; }

        //Right child of the node
        public BinaryTreeNode Right { get; set; }

        /// <summary>
        /// Constructor of the Binary tree 
        /// </summary>
        /// <param name="val"></param>
        public BinaryTreeNode(int val)
        {
            this.Value = val;
        }
    }
}
