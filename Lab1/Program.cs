int arrayLength;

int GetNumberInput()
{

    Console.WriteLine("How many words are you entering?");
    arrayLength = Convert.ToInt32(Console.ReadLine());
    return arrayLength;
}

string[] PopulateWordArray()
{
    string[] wordsArray = new string[GetNumberInput()];
    Console.WriteLine("Please enter " + arrayLength + " random words");
    for (int i = 0; i < wordsArray.Length; i++)
    {
        wordsArray[i] = Console.ReadLine();
    }
    return wordsArray;
}

int CountCharacters(string[] wordsArray, char inputChar)
{
  
    int counter = 0;
    for (int i = 0; i < wordsArray.Length; i++)
    {
        for (int j = 0; j < wordsArray[i].Length; j++)
        {
            if (inputChar == wordsArray[i][j])
                {
                    counter++;
                }
            }
        }
    Console.WriteLine("The letter " + inputChar + " appears " + counter + " times in the array.");
    return counter;
}

void Main()
{
    string[] wordsArray = PopulateWordArray();
    Console.WriteLine("Please enter a character");
    CountCharacters(wordsArray, Convert.ToChar(Console.ReadLine()));
   
}
Main();
