List<int> myIntList = new List<int> { 1, 5, 3 };
List<int> myIntList2 = new List<int> { 9, 7, 3, -2 };
List<int> myIntList3 = new List<int> { 2, 1, 2 };

int GetHighestValueInList(List<int> intList)
{
    int highest = intList[0];
    for (int i = 1; i < intList.Count; i++)
    {
        if (intList[i] > highest)
        {
            highest = intList[i];
        }
    }
    return highest;
}

List<int> MaxNumbersInLists()
{
    List<int> highestInts = new List<int> { };
    highestInts.Add(GetHighestValueInList(myIntList));
    highestInts.Add(GetHighestValueInList(myIntList2));
    highestInts.Add(GetHighestValueInList(myIntList3));

    Console.WriteLine($"List 1 has a maximum of {GetHighestValueInList(myIntList)}. List 2 has a maximum of {GetHighestValueInList(myIntList2)}." +
        $" List 3 has a maximum of {GetHighestValueInList(myIntList3)}");
    return highestInts;
};

MaxNumbersInLists();

List<int> class1 = new List<int> { 85, 92, 67, 94, 94 };
List<int> class2 = new List<int> { 50, 60, 57, 99 };
List<int> class3 = new List<int> { 95 };

String HighestGrade()
{
    List<int> highGrades = new List<int> { };
    highGrades.Add(GetHighestValueInList(class1));
    highGrades.Add(GetHighestValueInList(class2));
    highGrades.Add(GetHighestValueInList(class3));
    int highestGrade = GetHighestValueInList(highGrades);
    int highest = highGrades[0];
    int classNum = 0;
    for (int i = 1; i < highGrades.Count; i++)
    {
        if (highGrades[i] > highest)
        {
            highest = highGrades[i];
            classNum = i;
        }
    }
    Console.WriteLine($"The highest grade is {highest}. This grade was found in class(es) {classNum}");
    return $"The highest grade is {highest}. This grade was found in class(es) {classNum}";
}

HighestGrade();
Console.WriteLine("Sample WriteLine");

