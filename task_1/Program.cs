int[] get_random(int n)
{
    int[] result = new int [n];
    for(int i = 0; i < n; i++)
    {
    result[i] = new Random(). Next (99, 1000);
    }
    return result;
}


int[] array = get_random(6);
    int count = 0;
    foreach(int el in array)
    {
        if(el % 2 == 0) 
        {
            count ++;
        }
    }
   
Console.WriteLine($"[{String.Join(", ", array)},] -->  {count}");

