using RomanNumeralConverter;

while (1 > 0)
{
    Console.WriteLine("Please enter a whole number between 1 and 2000:");

    var input = Console.ReadLine();
    if (int.TryParse(input, out var result))
    {
        if (result < 1 || result > 2000)
        {
            Console.WriteLine("The number you entered is outside the requested range");
            continue;
        }

        if (result.ToRomanNumeral(out var rnResult))
        {
            Console.WriteLine($"{input} converted to Roman Numerals is: {rnResult}");
            Console.WriteLine("Press enter to convert another number...");
            Console.ReadLine();
        }
        else 
        {
            Console.WriteLine($"Something went wrong while converting {result} to a Roman Numeral");
            continue;
        }
    }
    else
    {
        Console.WriteLine("The value you entered is not an integer");
        continue;
    }
}