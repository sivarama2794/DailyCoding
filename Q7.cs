/*Q:You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point. 
Check if these points make a straight line in the XY plane.

Input1 : coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
Output: true
Input2: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
Output: false*/
public class Solution {
    public bool CheckStraightLine(int[][] coordinates) 
    {
         double x1,y1,x2,y2,slope=0;
         for(int i=0;i<coordinates.Count()-1;i++)
         {
             x1 = coordinates[i][0];
             y1 = coordinates[i][1];
             x2 = coordinates[i+1][0];
             y2 = coordinates[i+1][1];
             double currSlope=((y2-y1)/(x2-x1));      
             if ( i != 0 ) 
             {
                if (currSlope != slope)
                {
                    return false;
                }
             }
             else
             {
                 slope = currSlope;
             }
         }
        return true;
    }
}