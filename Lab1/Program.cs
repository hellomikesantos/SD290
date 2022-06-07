bool IsPalindrome(string testString)
{
    int boolChecker = 0;
    for (int i = 0; i < testString.Length; i++)
    {
        foreach (char c in testString)
        {
            if(c == ' ')
            {
                break;
            }
        }
        for(int j = testString.Length - 1; j > (testString.Length - 1) / 2; j--)
        {
  
            if(testString[j] == testString[i])
            {
                Console.WriteLine(boolChecker);
                boolChecker++;
            }

        }   
    }
    return boolChecker == (testString.Length - 1);
}

Console.WriteLine("Enter a word / phrase");

if(IsPalindrome(Console.ReadLine()))
{
    Console.WriteLine("This is Palindrome");
};


char[] DuplicateCharacters(string testString)
{
    char[] duplicatedChars = new char[testString.Length];
    List<char> charList = duplicatedChars.ToList();
    for (int i = 0; i < testString.Length; i++)
    {
        for(int j = 1; j < testString.Length; j++)
        {
            if (testString[i] == testString[j])
            {

                charList.Add(testString[j]);
            };
        };
    };
    Console.WriteLine(charList);
    return duplicatedChars;
};

DuplicateCharacters(Console.ReadLine());
