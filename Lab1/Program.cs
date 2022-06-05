string[] myStrings = new string[] { "the", "red", "fox" };

void ProcessWordArray()
{
    int arrayLength;
    
    Console.WriteLine("How many words are you entering?");
    arrayLength = Convert.ToInt32(Console.ReadLine());
    string[] wordsArray = new string[arrayLength];

    Console.WriteLine("Please enter " + arrayLength + " random words");
    for(int i = 0; i < wordsArray.Length; i++)
    {
        wordsArray[i] = Console.ReadLine();
    }
    Console.WriteLine("Please enter a character");
    Char inputChar = Convert.ToChar(Console.ReadLine());
    int counter = 0;
    for (int i = 0; i < wordsArray.Length; i++)
    {
        for (int j = 0; j < wordsArray[i].Length; j++)
        {
                if(inputChar == wordsArray[i][j])
                {
                    counter++;
                }
        }
    }
    Console.WriteLine("The letter " + inputChar + " appears " + counter + " times in the array.");
}

ProcessWordArray();