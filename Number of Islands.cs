public class Solution 
{
    public int NumIslands(char[][] grid) 
    {
        int count = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == '1')
                    
                {
                    count++;
                    CallBFS(grid, i, j);
                }
            }
        }
        return count;
    }
    
    public void CallBFS(char[][] grid, int i, int j)
    {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
        {
            return;
        }
        grid[i][j] = '0';
        CallBFS(grid, i + 1, j);//right
        CallBFS(grid, i - 1, j);//left
        CallBFS(grid, i, j - 1);//up
        CallBFS(grid, i, j + 1);//down
    }
}
