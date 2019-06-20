/*Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
Note: You may assume the string contain only lowercase letters.*/

public class Solution {
    public int FirstUniqChar(string str) 
    {
     int NO_OF_CHARS = 256; 
     char []count = new char[NO_OF_CHARS]; 
     int result =-1;
     for(int i =0;i<str.Length;i++)
     {
         count[str[i]]++;
     }
     for(int j=0;j<str.Length;j++)
     {
         if(count[str[j]]==1)
         {
            result =j;
            break;
         }
     }
        return result;
    
    }
}