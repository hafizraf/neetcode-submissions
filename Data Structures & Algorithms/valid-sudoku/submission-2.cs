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
                int k = (3*(i/3)) + (j/3);
                if(!rowSet[i].Add(board[i][j]) ||
                !colSet[j].Add(board[i][j]) ||
                !sqSet[k].Add(board[i][j]))
                {
                    return false;
                }
           }
        }
        return true;
    }
}
