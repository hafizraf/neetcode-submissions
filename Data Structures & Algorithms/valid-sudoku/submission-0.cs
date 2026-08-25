public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rowSet = new HashSet<char>[9];
        HashSet<char>[] colSet = new HashSet<char>[9];
        HashSet<char>[] sqSet = new HashSet<char>[9];
        for (int i = 0; i < 9; i++)
        {
            rowSet[i] = new HashSet<char>();
            colSet[i] = new HashSet<char>();
            sqSet[i] = new HashSet<char>();
        }
        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j< 9; j++)
            {
                if(board[i][j] == '.')
                {
                    continue;
                }
                if(rowSet[i].Contains(board[i][j]))
                {
                    return false;
                }
                if(colSet[j].Contains(board[i][j]))
                {
                    return false;
                }
                int k = GetSquare(i,j);
                if(sqSet[k].Contains(board[i][j]))
                {
                    return false;
                }
                rowSet[i].Add(board[i][j]);
                colSet[j].Add(board[i][j]);
                sqSet[k].Add(board[i][j]);
           }
        }
        return true;
    }
    private int GetSquare(int i, int j)
    {
        if(i < 3)
        {
            if(j<3)
            {
                return 0;
            }
            else if(j < 6)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        else if( i < 6)
        {
            if(j<3)
            {
                return 3;
            }
            else if(j < 6)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
        else
        {
            if(j<3)
            {
                return 6;
            }
            else if(j < 6)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }
    }
}
