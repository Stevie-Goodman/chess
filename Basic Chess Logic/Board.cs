namespace Basic_Chess_Logic;

public class Board
{
    private int[,] _board = new int[8, 8];

    public Board()
    {
        InitializeBoard();
        //Set the size of the board. 
        SetStartingPieces();
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
    private void SetStartingPieces()
    {
        Piece p = null;
        //Setting all pawns 
        for (int i = 0; i < 8; i++)
        {
            _board[1, i] = 6;
            _board[6, i] = -6;
            p = new Piece("Pawn", "blue", i, 1);
            //TODO - make all of the p's stay. Instead of being written over.... consider not looping?
        }

        p.PrintPiece();

        //Setting all other pieces
        _board[0, 0] = 3;
        _board[0, 1] = 5;
        _board[0, 2] = 4;
        _board[0, 3] = 1;
        _board[0, 4] = 2;
        _board[0, 5] = 4;
        _board[0, 6] = 5;
        _board[0, 7] = 3;
        _board[7, 0] = -3;
        _board[7, 1] = -5;
        _board[7, 2] = -4; 
        _board[7, 3] = -1; 
        _board[7, 4] = -2;
        _board[7, 5] = -4;
        _board[7, 6] = -5;
        _board[7, 7] = -3;
    }
    public void PrintBoard()
    {
        int rowLength = _board.GetLength(0);
        int colLength = _board.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (_board[i, j] < 0)
                {
                    Console.Write(" " + _board[i, j] + " ");
                }
                else
                {
                    Console.Write("  " + _board[i, j] + " ");
                }
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }
}