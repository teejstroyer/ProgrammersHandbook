
namespace ProgrammersHandbook.SortingAlgorithms;

public partial class SortingAlgorithms 
{

  public partial void GenerateDictionary()
  {
    SortingAlgorithmsDictionary.Add(SortingAlgorithm.BubbleSort, BubbleSort); 
    SortingAlgorithmsDictionary.Add(SortingAlgorithm.RecursiveBubbleSort, RecursiveBubbleSort); 
  }

  
  /// <summary> 
  /// Sorts an array of integers using the Bubble Sort algorithm.
  /// Time Complexity: O(n^2)
  /// </summary>
  public int [] BubbleSort(int[] array)
  {
    int temp;

    for(int i=0; i<array.Length-1; i++)
    {
      for(int j=0; j<array.Length-1; j++)
      {
        if(array[j] > array[j+1])
        {
          temp = array[j];
          array[j] = array[j+1];
          array[j+1] = temp;
        }
      }
    }
    return array;
  }

  private int[] _RecursiveBubbleSort(int[] array, int n)
  {
    if(n <= 1)
      return array;

    for(int i=0; i<n-1; i++)
    {
      if(array[i] > array[i+1])
      {
        int temp = array[i];
        array[i] = array[i+1];
        array[i+1] = temp;
      }
    }
    return _RecursiveBubbleSort(array, n-1);
  }

  public int[] RecursiveBubbleSort(int[] array)
  {
    return _RecursiveBubbleSort(array, array.Length);
  }


}
