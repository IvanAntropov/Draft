
string[] creatArray(string description)
{
    
    Console.WriteLine(description);
    string help = string.Empty; 
    help = Console.ReadLine();
    help = string.Join(" ", help.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
    string[] array = help.Split(" ");
    return array;
}

string[] solveEx(string[] array)
{
    string help = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            help += array[i] + " ";
        }
    }
    help = help.TrimEnd(' ');
    string[] result = help.Split(" ");
    return result;
}

string Print(string[] array)
{
    string forPrint = string.Empty;
    forPrint += "[";
    if (array[0] == "")
    {
        forPrint += " Array is empty ";
        
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            forPrint += array[i] + ", ";
        }
        forPrint = forPrint.TrimEnd(',',' ');
    }
    forPrint += "]";
    return forPrint;

}



//string[] arr = { "as", "as", "13f", "adko;ok;", "4o;k;o", "aggf" };
Console.WriteLine(Print(solveEx(creatArray("Введите строки в массив через пробел"))));
