/*
string[] creatArray()
{
    string help = string.Empty;




    string[] array = help.Split(" ");
    return array;
}
*/
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
    help = help.Remove(help.Length - 1, "|").Insert(help.Length - 1, "");
    string[] result = help.Split(" ");
    return result;
}

string Print(string[] array)
{
    string forPrint = string.Empty;
    forPrint += "[";
    if (0 == array.Length)
    {
      forPrint += " Array is empty ";
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                forPrint += array[i];
            }
            else
            {
                forPrint += array[i] + " ";
            }
        }

    }
    forPrint += "]";
    return forPrint;

}



string[] arr = { "asd", "asdf", "1344", "adjksh", "2534", "aggg" };
Console.WriteLine(Print(solveEx(arr)));

