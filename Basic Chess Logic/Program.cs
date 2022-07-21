using Basic_Chess_Logic;

// Chess Pieces translation for grid...
//King = 1
//Queen = 2
//Rook = 3
//Bishop = 4
//Knight = 5
//Pawn = 6
//Empty = 0


// -0 for opponent. 
Board board = new Board();

string? user1 = "";
string? user2 = "";
bool CreatePlayers()
{
    Console.WriteLine("User1: ");
    user1 = Console.ReadLine();
    Console.WriteLine("User2: ");
    user2 = Console.ReadLine();
    return true;
}


Piece piece = new Piece();
piece.GetAllLocations();
// Used to update the board with the new pieces.
board.UpdateBoard(piece.GetAllLocations());
board.PrintBoard();