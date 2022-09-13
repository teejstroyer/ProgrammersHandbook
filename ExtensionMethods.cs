namespace ProgrammersHandbook;

public static class ExtensionMethods
{
    public static void Print(this int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public static int[] Shuffle(this int[] array, bool reverse)
    {
        if (reverse) return array.Reverse().ToArray();

        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            int j = random.Next(i, array.Length);
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        return array;
    }

    public static int[] GenerateArray(this int _, int length, bool duplicates = false)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i;
        }
        if (duplicates)
        {
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int j = random.Next(0, length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        return array;
    }

}

