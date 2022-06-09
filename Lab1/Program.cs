Dictionary<int, string> CarPark = new Dictionary<int, string>();
CarPark.Add(1, "GGG-123");
CarPark.Add(2, "ABC_DEF");
CarPark.Add(3, null);
CarPark.Add(4, "AAA-111");


foreach(KeyValuePair<int, string> value in CarPark)
{
    Console.WriteLine(value);
}


Dictionary<int, string> InitializeCarPark(int capacity)
{
    int counter = 0;
    for(int i = CarPark.Count + 1; counter < capacity; i++)
    {
        CarPark.Add(i, null);
        counter++;
        Console.WriteLine(i.ToString(), counter);
    }
    
    return CarPark;
    
}

InitializeCarPark(3);

int AddVehicle(string licence)
{
    int parkingSlot = 0;
    foreach (KeyValuePair<int, string> slot in CarPark)
    {
        if(slot.Value.Equals(null))
        {
            Console.WriteLine(slot.Key);
            parkingSlot = slot.Key;
            CarPark[slot.Key] = licence;
            Console.WriteLine(slot.Key);
            Console.WriteLine(slot.Value);
        }
        break;
    }
    Console.WriteLine(parkingSlot);
    return parkingSlot;
}

AddVehicle("NDL-8349");
