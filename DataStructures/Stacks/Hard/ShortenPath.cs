using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.Hard
{
    public class ShortenPath
    {
        public static string Shorten(string path)
        {
            var splitted = path.Split('/');
            var stack = new List<string>();

            if (path.StartsWith("/"))
                stack.Add("/");

            foreach (var item in splitted)
            {
                if (stack.Count > 0 && stack[stack.Count - 1] == "/" && item.Equals(".."))
                    continue;

                if (stack.Count > 0 && stack[stack.Count - 1] != ".." && item.Equals(".."))
                {
                    stack.RemoveAt(stack.Count - 1);
                    continue;
                }


                if (item.Equals(".") || string.IsNullOrEmpty(item))
                    continue;

                stack.Add(item);              
            }

            var result = new StringBuilder();
          
           // if (path.StartsWith("/"))
               // result.Append("/");
            

           for(int index = 0; index < stack.Count; index++)
            {

                if (index == stack.Count - 1)
                    result.Append(stack[index]);
                else if (stack[index] == "/")
                {
                    result.Append(stack[index]);
                   // result.Append("/");

                }
                else
                {
                    result.Append(stack[index]);
                    result.Append("/");
                }
            }

            return result.ToString();
        }

        public static string Shorten2(string path)
        {
            var splitted = path.Split('/');
            var stack = new List<string>();

            if (path.StartsWith("/"))
                stack.Add("");

            var filteredList = splitted
                                .Where(x => (x.Count() > 0 && x != "."))              
                                .ToList();

            foreach (var item in filteredList)
            {
                if (stack.Count > 0 && stack[stack.Count - 1] == "" && item.Equals(".."))
                    continue;

                if (stack.Count > 0 && stack[stack.Count - 1] != ".." && item.Equals(".."))
                {
                    stack.RemoveAt(stack.Count - 1);
                    continue;
                }

                stack.Add(item);

            }

            if (stack.Count == 1 && stack[0] == "")
                return "/";

            return string.Join('/', stack);         
        }
    }


}
