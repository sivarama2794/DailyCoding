/*Given a list of non negative integers, arrange them such that they form the largest number.

Example 1:

Input: [10,2]
Output: "210"
Example 2:

Input: [3,30,34,5,9]
Output: "9534330"
Note: The result may be very large, so you need to return a string instead of an integer.*/

public class Solution {
 public string LargestNumber(int[] nums) {
  string result = "";
  List < int > inputList = nums.OfType < int > ().ToList();
  List < string > newList = inputList.ConvertAll < string >
   (delegate(int i) { return i.ToString();});


  newList.Sort(getLargest);

  for (int i = 0; i < newList.Count; i++) 
  {
   result += newList[i];
  }
  
  if (result[0] == '0') {
   result = "0";
  }
  return result;
 }
 public int getLargest(string X, string Y) {
  // first append Y at the end of X  
  string XY = X + Y;

  // then append X at the end of Y  
  string YX = Y + X;

  // Now see which of the two formed numbers is greater  
  return XY.CompareTo(YX) > 0 ? -1 : 1;
 }
}