int[] get_random(int n)
{
    int[] result = new int [n];
    for(int i = 0; i < n; i++)
    {
    result[i] = new Random(). Next (-20, 20);
    }
    return result;
}


int[] array = get_random(6);
    int sum = 0;
    int i = 1;
    for(; i <= array.Length; i = i + 2)
    {
        sum += array[i];
    }
  
Console.WriteLine($"[{String.Join(", ", array)},] -->  {sum}");





