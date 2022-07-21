namespace Basic_Chess_Logic;

/* The Piece class is a blueprint for creating a chess piece */
public class Piece
{
    public King KingWhite = new King( "White", new[] { 4, 7 });
    public King KingBlack = new King( "Black", new[]{ 4, 0 });
    public Queen QueenWhite = new Queen("White",new[] { 3, 7 });
    public Queen QueenBlack = new Queen("black", new []{3, 0});
    public Rook RookWhite1 = new Rook("White", new[] { 7, 7 });
    public Rook RookBlack1 = new Rook("black", new[] { 0, 0 });
    public Rook RookWhite2 = new Rook("White", new[] { 7, 7 });
    public Rook RookBlack2 = new Rook("black", new[] { 7, 0 });
    public Bishop BishopWhite1 = new Bishop( "White", new[] { 2, 7});
    public Bishop BishopBlack1 = new Bishop( "black", new[] { 2, 0 });
    public Bishop BishopWhite2 = new Bishop( "White", new[] { 5, 7 });
    public Bishop BishopBlack2 = new Bishop( "black", new[] { 5, 0 });
    public Knight KnightWhite1 = new Knight( "White", new[] { 1, 7 });
    public Knight KnightBlack1 = new Knight( "black", new[] { 1, 0 });
    public Knight KnightWhite2 = new Knight( "White", new[] { 6, 7 });
    public Knight KnightBlack2 = new Knight( "black", new[] { 6, 0 });
    public Pawn PawnWhite1 = new Pawn( "White", new[] { 0, 6 });
    public Pawn PawnBlack1 = new Pawn( "black", new[] { 0, 1 });
    public Pawn PawnWhite2 = new Pawn( "White", new[] { 1, 6 });
    public Pawn PawnBlack2 = new Pawn( "black", new[] { 1, 1 });
    public Pawn PawnWhite3 = new Pawn( "White", new[] { 2, 6 });
    public Pawn PawnBlack3 = new Pawn( "black", new[] { 2, 1 });
    public Pawn PawnWhite4 = new Pawn( "White", new[] { 3, 6 });
    public Pawn PawnBlack4 = new Pawn( "black", new[] { 3, 1 });
    public Pawn PawnWhite5 = new Pawn( "White", new[] { 4, 6 }); 
    public Pawn PawnBlack5 = new Pawn( "black", new[] { 4, 1 });
    public Pawn PawnWhite6 = new Pawn( "White", new[] { 5, 6 });
    public Pawn PawnBlack6 = new Pawn( "black", new[] { 5, 1 });
    public Pawn PawnWhite7 = new Pawn( "White", new[] { 6, 6 });
    public Pawn PawnBlack7 = new Pawn( "black", new[] { 6, 1 });
    public Pawn PawnWhite8 = new Pawn( "White", new[] { 7, 6 });
    public Pawn PawnBlack8 = new Pawn( "black", new[] { 7, 1 });
    
    //TODO -  Might use later...
    // public Piece[] pieces = new Piece[] { kingWhite, kingBlack, queenWhite, queenBlack, rookWhite, rookBlack, bishopWhite, bishopBlack, knightWhite, knightBlack, pawnWhite1, pawnBlack1, pawnWhite2, pawnBlack2, pawnWhite3, pawnBlack3, pawnWhite4, pawnBlack4 };
    
    public int[,] GetAllLocations()
    {
        int[,] allLocations = new int[,]
        {
            { QueenWhite._name, QueenWhite.Position[0], QueenWhite.Position[1] },
            { QueenBlack._name, QueenBlack.Position[0], QueenBlack.Position[1] },
            { KingWhite._name, KingWhite.Position[0], KingWhite.Position[1] },
            { KingBlack._name, KingBlack.Position[0], KingBlack.Position[1] },
            { RookWhite1._name, RookWhite1.Position[0], RookWhite1.Position[1] },
            { RookBlack1._name, RookBlack1.Position[0], RookBlack1.Position[1] },
            { RookWhite2._name, RookWhite2.Position[0], RookWhite2.Position[1] },
            { RookBlack2._name, RookBlack2.Position[0], RookBlack2.Position[1] },
            { BishopWhite1._name, BishopWhite1.Position[0], BishopWhite1.Position[1] },
            { BishopBlack1._name, BishopBlack1.Position[0], BishopBlack1.Position[1] },
            { BishopWhite2._name, BishopWhite2.Position[0], BishopWhite2.Position[1] },
            { BishopBlack2._name, BishopBlack2.Position[0], BishopBlack2.Position[1] },
            { KnightWhite1._name, KnightWhite1.Position[0], KnightWhite1.Position[1] },
            { KnightBlack1._name, KnightBlack1.Position[0], KnightBlack1.Position[1] },
            { KnightWhite2._name, KnightWhite2.Position[0], KnightWhite2.Position[1] },
            { KnightBlack2._name, KnightBlack2.Position[0], KnightBlack2.Position[1] },
            { PawnWhite1._name, PawnWhite1.Position[0], PawnWhite1.Position[1] },
            { PawnBlack1._name, PawnBlack1.Position[0], PawnBlack1.Position[1] },
            { PawnWhite2._name, PawnWhite2.Position[0], PawnWhite2.Position[1] },
            { PawnBlack2._name, PawnBlack2.Position[0], PawnBlack2.Position[1] },
            { PawnWhite3._name, PawnWhite3.Position[0], PawnWhite3.Position[1] },
            { PawnBlack3._name, PawnBlack3.Position[0], PawnBlack3.Position[1] },
            { PawnWhite4._name, PawnWhite4.Position[0], PawnWhite4.Position[1] },
            { PawnBlack4._name, PawnBlack4.Position[0], PawnBlack4.Position[1] },
            { PawnWhite5._name, PawnWhite5.Position[0], PawnWhite5.Position[1] },
            { PawnBlack5._name, PawnBlack5.Position[0], PawnBlack5.Position[1] },
            { PawnWhite6._name, PawnWhite6.Position[0], PawnWhite6.Position[1] },
            { PawnBlack6._name, PawnBlack6.Position[0], PawnBlack6.Position[1] },
            { PawnWhite7._name, PawnWhite7.Position[0], PawnWhite7.Position[1] },
            { PawnBlack7._name, PawnBlack7.Position[0], PawnBlack7.Position[1] },
            { PawnWhite8._name, PawnWhite8.Position[0], PawnWhite8.Position[1] },
            { PawnBlack8._name, PawnBlack8.Position[0], PawnBlack8.Position[1] }
        };
        return allLocations;
    }
    public class King
    {
        public int[] Position;
        public int _name = 1;
        string _color;
        public King(string colour, int[] location)
        {
            _color = colour;
            Position = location;
        }
        public void Move()
        {
            Console.WriteLine("King can move in any 4 direction - 1 sqre at a time");
        }
        public void PrintKing()
        {
            Console.WriteLine($"Location= {Position}Name = {_name} Color = {_color}");
        }
    }

    public class Queen
    {
        public int[] Position;
        public int _name = 2;
        string _color;
        public Queen(string colour, int[] location)
        {
            _color = colour;
            Position = location;
        }
    
        public void Move()
        {
            Console.WriteLine("Queen can move in any direction as far as possible");
        }
        public void PrintLocation()
        {
            Console.WriteLine($"Location= {Position[0]} {Position[1]}Name = {_name} Color = {_color}");
        }
    }

    public class Rook
    {
        public int[] Position;
        public int _name = 3;
        string _color;
        public Rook(string colour, int[] location)
        {
            _color = colour;
            Position = location;
        }
    
        public void Move()
        {
            Console.WriteLine("Rook can move in any 4 direction - as long as possible");
        }
        public void PrintLocation()
        {
            Console.WriteLine($"Location= {Position[0]} {Position[1]}Name = {_name} Color = {_color}");
        }
    }

    public class Bishop
    {
        public int[] Position;
        public int _name = 4;
        string _color;
        public Bishop(string colour, int[] location)
        {
            _color = colour;
            Position = location;
        }
    
        public void Move()
        {
            Console.WriteLine("Diagonal - as far as possible");
        }
        public void PrintLocation()
        {
            Console.WriteLine($"Location= {Position[0]} {Position[1]}Name = {_name} Color = {_color}");
        }
    }

    public class Knight
    {
        public int[] Position;
        public int _name = 5;
        string _color;
        public Knight(string colour, int[] location)
        {
            _color = colour;
            Position = location;
        }
    
        public void Move()
        {
            Console.WriteLine("2 in one direction, 1 in the other(2 diagonal, 1 vertical");
        }
        public void PrintLocation()
        {
            Console.WriteLine($"Location= {Position[0]} {Position[1]}Name = {_name} Color = {_color}");
        }
    }

    public class Pawn
    {
        public int[] Position;
        public int _name = 6;
        string _color;
        public Pawn(string colour, int[] location)
        {
            _color = colour;
            Position = location;
        }
    
        public void Move()
        {
            Console.WriteLine("move forward 1 sqre, diagonal to capture enemy piece if there is one - can move 2 sqres forward if it is the first move");
        }
        public void PrintLocation()
        {
            Console.WriteLine($"Location= {Position[0]} {Position[1]}Name = {_name} Color = {_color}");
        }
    }
}