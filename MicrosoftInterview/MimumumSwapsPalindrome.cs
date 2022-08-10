
using Common;

 namespace MicrosoftInterview
{
    public class MimumumSwapsPalindrome
    {
        public static int MinimumSwaps( string str)
        {
            //var stringArray = str.ToArray();
         
            
            int ans1 = MinimumSwapsHelper(str);
           
            var stringArray = str.ToArray();
            Array.Reverse(stringArray);

            str = string.Join("", stringArray);
            int ans2 = MinimumSwapsHelper(str);

            return Math.Max(ans1, ans2);
        }

        private static int MinimumSwapsHelper(string str)
        {
            
            var stringArray1 = str.ToCharArray();
            int n = stringArray1.Length;
            int count = 0;

            for (int i = 0; i < n / 2; i++)
            {
                int left = i;
                int right = n - left - 1;

                while(left < right)
                {
                    if (stringArray1[left] == stringArray1[right])
                        break;
                    else
                        right--;
                }

                if (left == right)
                {
                    Array.Reverse(stringArray1);
                    var st = string.Join("", stringArray1);
                    return count + MinimumSwapsHelper(st);
                }
                else
                 {
                    for (int j = right; j < n - left - 1; j++)
                    {
                        Util.Swap(stringArray1, j, j + 1);
                        count++;

                    }
                }              
            }

            return count;
        }
    }
}
