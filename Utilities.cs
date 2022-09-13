namespace ProgrammersHandbook;

public static class Utilities
{
    public static int[] GenerateArray(int length, bool duplicates = false)
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

