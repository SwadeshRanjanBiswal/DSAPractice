// C# code to find
// duplicates in O(n) time
using System;
using System.Linq;
using System.Collections.Generic;
class Leet442
{
	public static void Main(String[] args)
	{
		solution solution = new solution();
        //solution.Search(new int[] {-1,0,3,5,9,12}, 30);
        solution.FindTargetNumber(new int[] {-1, 0, 3, 5, 9, 12}, 30);
        Console.ReadKey();
    }
    public class solution
    {
        public int Search(int[] nums, int target)
        {
            var res = nums.Distinct().ToList().FindIndex(x => x == target);
            return res;
        }

        public int[] FindTargetNumber(int[] numbers, int target)
        {
            numbers = new int[] {2,7,11,15 };
            target = 9;
            for (int i = 0; i < numbers.Length; i++)
            {
                var firstnum = numbers[i];
                var matchingnum = numbers.Skip(0).ToList().Find(x => target - x == firstnum);
                if (matchingnum > 0)
                {
                    numbers = new int[] { i+1, numbers.ToList().FindIndex(x => x== matchingnum)+1 };
                    break;
                }                    
            }
            return numbers;
        }
        public void FindDuplicate()
        {
            int[] numRay = { 0, 4, 3, 2, 7, 8, 2, 3, 1 };
            int[] values = new[] { 1, 2, 3, 4, 5, 4, 4, 3 };

            //var groups = values.GroupBy(v => v);
            //foreach (var group in groups)
            //{
            //	if(group.Count() > 1)
            //	Console.WriteLine("Value {0} has {1} items", group.Key, group.Count());
            //}
            int[] array = { 10, 5, 10, 5, 6 };
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                // When the key is not found, "count" will be initialized to 0
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
        }
    }
}
