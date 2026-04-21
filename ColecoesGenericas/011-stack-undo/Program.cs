Console.WriteLine("## Undo Stack ##");

EditorTexto editor = new();
Console.WriteLine("\nDigitando\n");
editor.DigitarChar('S');
editor.DigitarChar('T');
editor.DigitarChar('A');
editor.DigitarChar('C');
editor.DigitarChar('Q');

Console.WriteLine("\nFazendo o undo...\n");
editor.Undo();
editor.Undo();

Console.WriteLine("\nRedigitando...\n");
editor.DigitarChar('C');
editor.DigitarChar('K');
editor.DigitarChar('!');


Console.ReadKey();


public class EditorTexto
{
    private Stack<char> undoStack = new();
    private string texto = "";

    public void DigitarChar(char c)
    {
        texto += c;
        undoStack.Push(c);
        Console.WriteLine($"Texto: {texto}");
    }

    public void Undo()
    {
        if( undoStack.Count > 0 )
        {
            char ultimoChar = undoStack.Pop();
            texto = texto.Substring(0, texto.Length - 1);
            Console.WriteLine($"Texto: {texto}");
        }
    }

}
