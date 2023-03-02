int[] get_random(int n)
{
    int[] result = new int [n];
    for(int i = 0; i < n; i++)
    {
    result[i] = new Random(). Next (0, 100);
    }
    return result;
}

int[] array = get_random(6);
    int j = 0;
    int max = array[j];
    int min = array[j];
    
    foreach(int el in array)
    {
        while(el > max ) 
        {
            max = el;
            j ++;
            
        }
        if(el < min)
            {
                min = el;
                
            j ++;
             }
                
    }
  

  
Console.WriteLine($"[{String.Join(", ", array)},] -->  {max - min}");