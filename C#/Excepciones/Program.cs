using System.IO;

try
{
    //the @ ignores the \ backslashes
    string content = File.ReadAllText(@"D:\auvm\Documents\How_to_KeyGen.txt");
    //writes the content of the file
    Console.WriteLine(content);
}catch(FileNotFoundException ex)
{
    //👆👆👆 this is kind of especifies the exception
    //writes the message if the file does not exist
    Console.WriteLine("No se encuentra el archivo.");
}catch(Exception ex)
{
    //👆👆👆 this is kind of generalize whatever exception that could happen
    Console.WriteLine(ex.Message);
    Console.WriteLine("Otra cosa salió mal.");
}
finally
{
    Console.WriteLine("Esto se ejecuta SIEMPRE, ocurra o no ocurra excepción.");
}

Console.WriteLine("Aquí podría continuar el código seguro.");

