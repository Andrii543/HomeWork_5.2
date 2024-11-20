
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.WriteLine("Введіть число");
        string userInput = Console.ReadLine();

        try
        {
            double parseDouble = double.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в double {parseDouble}");

            float parseFloat  = float.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в float {parseFloat}");

            decimal parseDecimal = decimal.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в decimal {parseDecimal}");

            int parseInt = int.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в інт {parseInt}");

            byte parseByte = byte.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в інт {parseByte}");

            short parseShort = short.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в інт {parseShort}");

            long parseLong = long.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в long {parseLong}");

            char parseChar = char.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в char {parseChar}");     
           

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Щось пішло не так {ex}");
        }


    }
}