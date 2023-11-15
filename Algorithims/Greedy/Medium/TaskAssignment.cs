using System.Collections.Generic;


namespace Algorithms.Greedy.Medium
{
    public class TaskAssignment
    {
        //O(n log n) time | O(n) space
        public static List<List<int>> AssignTasks(int k, List<int> tasks) 
        {
            var resultList = new List<List<int>>();
            Dictionary<int, Stack<int>> taskIndices = BuildTaskIndice(tasks);

            tasks.Sort();

            int leftIndex  = 0,  rightIndex = tasks.Count - 1;

            while (leftIndex < rightIndex) {
                int firstDuration = tasks[leftIndex];
                var pair1Stack = taskIndices[firstDuration];
                int firstIndex = pair1Stack.Pop();

                int secondDuration = tasks[rightIndex];
                var pair2Stack = taskIndices[secondDuration];
                int secondIndex = pair2Stack.Pop();

                resultList.Add(new List<int>() { firstIndex, secondIndex });
                leftIndex++;
                rightIndex--;
            }

            return resultList;
        }

        private static Dictionary<int, Stack<int>> BuildTaskIndice(List<int> tasks)
        {
           var taskIndices = new Dictionary<int, Stack<int>>();
            for (int index = 0; index < tasks.Count; index++)
            {
                if (taskIndices.ContainsKey(tasks[index]))
                    taskIndices[tasks[index]].Push(index);
                else 
                { 
                    taskIndices.Add(tasks[index], new Stack<int>());
                    taskIndices[tasks[index]].Push(index);
                }
            }
            return taskIndices;
        }
    }
}
