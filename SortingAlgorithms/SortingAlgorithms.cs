using System.Collections.Generic;
using System.Diagnostics;

namespace ProgrammersHandbook.SortingAlgorithms;

public enum SortingAlgorithm
{
    BubbleSort,
    RecursiveBubbleSort,
    InsertionSort,
    RecursiveInsertionSort,
    MergeSort,
    IterativeMergeSort,
    QuickSort,
    IterativeQuickSort,
    HeapSort,
    CountingSort,
    RadixSort,
    BucketSort,
    ShellSort,
    TimSort,
    CombSort,
    PigeonholeSort,
    CycleSort,
    CocktailSort,
    StrandSort,
    All
}


public partial class SortingAlgorithms
{
    public Dictionary<SortingAlgorithm, Func<int[], int[]>> SortingAlgorithmsDictionary = new Dictionary<SortingAlgorithm, Func<int[], int[]>>();

    public partial void GenerateDictionary();

    private readonly int LongestKey;

    public SortingAlgorithms()
    {
        GenerateDictionary();
        LongestKey = SortingAlgorithmsDictionary.Select(i => i.Key.ToString().Length).Max();
    }

    public void Run(SortingAlgorithm algorithm, int length, bool duplicates = false, bool reverse = false, bool print = false, bool time = false, bool verify = false)
    {
        int[] array = Utilities.GenerateArray(length, duplicates).Shuffle(reverse);
        if (print)
        {
            Console.WriteLine("Unsorted array:");
            array.Print();
        }

        SortingAlgorithmsDictionary
          .Where(i => (algorithm == SortingAlgorithm.All) || (i.Key == algorithm))
          .ToList()
          .ForEach(i =>
          {
              int[] unsortedArray = (int[])array.Clone();
              int[] sortedArray = Array.Empty<int>();
              string timeOutput = "NA";
              string verifyOutput = "NA";

              if (time)
              {
                  Stopwatch stopwatch = new Stopwatch();
                  stopwatch.Start();
                  sortedArray = i.Value(unsortedArray);
                  stopwatch.Stop();
                  timeOutput = stopwatch.ElapsedMilliseconds.ToString();
              }
              else
              {
                  sortedArray = i.Value(unsortedArray);
              }

              if (print)
              {
                  Console.WriteLine($"{i.Key} sorted array:");
                  sortedArray.Print();
              }

              verifyOutput = verify ? ValidateSorted(sortedArray).ToString() : "N/A";

              Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId,4:(#)}{i.Key,22} n:{unsortedArray.Length,10}, Time:{timeOutput,5}, Sorted:{verifyOutput,5}, PreReversed:{reverse,5}, Contains duplicates:{duplicates,5}");
          });
    }

    public static bool ValidateSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    private int[] Sort(SortingAlgorithm algorithm, int[] array)
    {
        return SortingAlgorithmsDictionary[algorithm](array);
    }
}


