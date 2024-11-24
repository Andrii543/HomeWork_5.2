
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.WriteLine("Введіть число");
        string userInput = Console.ReadLine();

        // double parse
        try
        {
            double parseDouble = double.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в double {parseDouble}");

            //char parseChar = char.Parse(userInput);
            //Console.WriteLine($"Успішно перетворено в char {parseChar}");     
           

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }

        // float parse
        try
        {
            float parseFloat  = float.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в float {parseFloat}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }

        // decimal parse
        try
        {
            decimal parseDecimal = decimal.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в decimal {parseDecimal}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }

        // int parse
        try
        {
            int parseInt = int.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в int {parseInt}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }

        // byte parse
        try
        {
            byte parseByte = byte.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в byte {parseByte}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }

        //short parse 
        try
        {
            short parseShort = short.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в short {parseShort}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }

        //long parse
        try
        {
            long parseLong = long.Parse(userInput);
            Console.WriteLine($"Успішно перетворено в long {parseLong}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }

        try
        {
            char parseChar = char.Parse(userInput);

            if(userInput.Length == 1)
            {
                Console.WriteLine($"Успішно перетворено в char {parseChar}");
            }
            else
            {
                Console.WriteLine("Не вдалося перетворити в char. Рядок має містити лише один символ");
            }

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException - {ex}");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException - {ex}");
        }



    }
}