var alphabet = new List<string>
{
    "a",
    "b",
    "c",
    "d",
    "e",
    "f",
    "g",
    "h",
    "i",
    "j",
    "k",
    "l",
    "m",
    "n",
    "o",
    "p",
    "q",
    "r",
    "s",
    "t",
    "u",
    "v",
    "w",
    "x",
    "y",
    "z"
};

Random randomGenerator = new Random();
var randomHolger = randomGenerator.Next(39 * 39);

var runnedCount = 0; 
for (int j = 0; j < 40; j++)
{
    for (int i = 0; i < 40; i++)
    {
        runnedCount++;
        if (runnedCount == randomHolger)
        {
            Console.Write("@");
        }
        else
        {
            int randomNumber = randomGenerator.Next(alphabet.Count);
            Console.Write(alphabet[randomNumber]);
        }
            Console.Write(" ");


    }
    Console.WriteLine();
}

