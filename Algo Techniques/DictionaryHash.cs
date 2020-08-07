using System.Collections.Generic;

namespace DSA
{
    public class Duplicates
    {
        public static bool ContainsDupe(params int[] nums)
        {
           var list = new Dictionary<int,int>();
           foreach (var i in nums)
           {
               if (list.ContainsKey(i))
               {
                   list[i]++;
               }
               else
               {
                   list.Add(i, 1);
               }
           }

           foreach (var i in list.Values)
           {
               if (i > 1)
               {
                   return true;
               }
           }
           return false;
        } 
    }
}