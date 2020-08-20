using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AssetFinancingStudy_PyramidTraversal
{
    class Program
    {
        /// <summary>
        /// Main method the get the input file. Please place the input file at the same folder as this library.
        /// input file must be named "input.txt"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<List<int>> pyramid = new List<List<int>>();
            var lines = File.ReadLines("input.txt");
            
            foreach (var line in lines)
            {
                pyramid.Add(line.Split(' ').Select(x => Convert.ToInt32(x)).ToList());
            }

            BinaryTreeNode binaryTree = PyramidTraversal.ConstructTreeFromPyramid(pyramid, 0, 0);

            MaxSumPathResult result = PyramidTraversal.GetMaxSumPath(binaryTree, 0, new List<int>(), new MaxSumPathResult());

            Console.WriteLine(result.ToString());

            Console.ReadLine();
        }
    }
}
