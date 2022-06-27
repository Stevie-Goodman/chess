namespace Basic_Chess_Logic;

public class Piece
{
    //Attributes
    private string _name;
    private string _color;
    private int _x;
    private int _y;
    
    //Creating a new piece
    public Piece(string name, string color, int x, int y)
    {
        _name = name;
        _color = color;
        _x = x;
        _y = y;
    }

    public void PrintPiece()
    {
        Console.WriteLine($"X = {_x} Y = {_y} Name = {_name} Color = {_color}");
    }
}