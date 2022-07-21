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

    public void UpdateBoard(int[,] allLocations)
    {
        
        // Update the board using all locations passed through. 

        for(int i = 0; i < 32; i++)
        {
            Console.WriteLine(allLocations[i,0]);
            
            _board[allLocations[i, 2], allLocations[i, 1]] = allLocations[i, 0];
        }
       
        
        // public Pawn PawnBlack3 = new Pawn( "black", new[] { 7, 6 });
        // Incoming data Format = { PawnBlack8._name, PawnBlack8.Position[0], PawnBlack8.Position[1] }
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