string[] arrayBefore = { "Hello", "2", "world", ":-)" };
//string[] arrayBefore = { "Russia", "Denmark", "Kazan" };

string[] NewArray(string[] arrBefore)
{
    string[] arrAfter = new string[arrBefore.Length];
    int count = 0;

    for (int i = 0; i < arrBefore.Length; i++)
    {
        if (arrBefore[i].Length < 4)
        {
            arrAfter[count] = arrBefore[i];
            count++;
        }
    }
    Array.Resize(ref arrAfter, count);
    return arrAfter;
}

Console.WriteLine("[" + String.Join(", ", NewArray(arrayBefore)) + "]");