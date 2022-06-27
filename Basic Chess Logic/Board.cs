namespace Basic_Chess_Logic;

public class Board
{
    private int[,] _board = new int[8, 8];

    public Board()
    {
        InitializeBoard();
        //Set the size of the board. 
        PrintBoard();
    }
    public void InitializeBoard()
    {
        //Initialize the board
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                _board[i, j] = 0;
            }
        }
    }
    
    public void PrintBoard()
    {
        int rowLength = _board.GetLength(0);
        int colLength = _board.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write("{0}    ", _board[i, j]);
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }
}