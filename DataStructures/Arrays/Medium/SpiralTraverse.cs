using System;
using System.Collections.Generic;
using Common;


namespace DataStructures.Arrays.Medium
{
    public static class SpiralTraverse
    {
        public static void Run() {

            var array = new int[,] { { 1, 2, 3}, { 12, 13, 4}, {11, 14, 5}, {10, 15, 6 }, {9, 8, 7 } };
         

            

            Util.PrintList(Traverse(array));

        }

        public static List<int> Traverse(int[,] array) {

            int startRow=  0,  startColumn = 0;
            int endRow = array.GetLength(0) - 1;
            int endColumn = array.GetLength(1) - 1;
            var resultList = new List<int>();

            while (startRow <= endRow & startColumn <= endColumn) {

                int rowPointer = startRow;
                int columnPointer = startColumn;

                while (rowPointer <= endRow) {
                    resultList.Add(array[rowPointer, columnPointer]);

                    if (rowPointer == endRow & columnPointer == endColumn)
                        break;

                    if (columnPointer < endColumn)
                        columnPointer++;
                    else if (columnPointer == endColumn)
                        rowPointer++;
                    
                }



                if (startColumn == endColumn)
                {
                    break;
                }

                startRow++;
                columnPointer--;

                                              
                while (rowPointer >= startRow) {
                    resultList.Add(array[rowPointer, columnPointer]);
                    if (columnPointer > startColumn)
                        columnPointer--;
                    else if (columnPointer == startColumn)
                        rowPointer--;                  
                }

                startColumn++;
                endRow--;
                endColumn--;

            }

            return resultList;

        }

    }
}
