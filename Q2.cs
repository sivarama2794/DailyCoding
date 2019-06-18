/*The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

Given two integers x and y, calculate the Hamming distance.

Note:
0 ≤ x, y < 231.

Example:

Input: x = 1, y = 4

Output: 2

Explanation:
1   (0 0 0 1)
4   (0 1 0 0)
       ↑   ↑

The above arrows point to positions where the corresponding bits are different.*/

public class Solution {
    public int HammingDistance(int x, int y) {
        int z = 0,count =0;
		//Find the XOR to get the different bit from two numbers
        z = x^y;
		//Convert the bits into String
        string binary = Convert.ToString(z, 2);
        for(int i =0;i<binary.Length;++i)
        {
			//Count the number of '1' to get the difference count
            if(binary[i]=='1')
            {
                count++;
            }
        }
        return count;
    }
}
