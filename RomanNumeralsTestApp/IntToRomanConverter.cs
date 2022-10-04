namespace RomanNumeralsTestApp;

public class IntToRomanConverter
{
    private const int MinIntRange = 1;
    private const int MaxIntRange = 2000;

    public string Convert(int number)
    {
        Dictionary<string, int> romanNumbersDictionary = new()
        {
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000}
        };

        if (number > MinIntRange && number < MaxIntRange)
        {
            string romanRepresentation = "";
            foreach (var item in romanNumbersDictionary.Reverse())
            {
                while (number >= item.Value)
                {
                    romanRepresentation += item.Key;
                    number -= item.Value;
                }
            }
            return romanRepresentation;
        }

        throw new Exception("Invalid input");
    }
}

