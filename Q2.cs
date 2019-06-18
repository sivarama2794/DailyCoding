
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