using System.Collections.Generic;
/**
* @author Olufemi Isola
*
* @date - 19/08/20 2:17:12 PM 
*/

namespace AssetFinancingStudy_PyramidTraversal
{
    /// <summary>
    /// A Class that models the result of the binary tree traversal
    /// </summary>
    public class MaxSumPathResult
    {
        //The max sum field
        public int maxSum { get; set; }
        //The max sum path
        public List<int> Path { get; set; }

        /// <summary>
        /// Constructor of the result
        /// </summary>
        public MaxSumPathResult()
        {
            Path = new List<int>();
        }


        /// <summary>
        /// Print result to string
        /// </summary>
        /// <returns>string</returns>
        override
        public string ToString()
        {
            return $"Max sum: {maxSum}\nPath: {string.Join(", ", this.Path)}";
        }
    }
}
