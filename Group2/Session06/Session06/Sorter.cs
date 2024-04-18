public static class Sorter
{
  
    public static void Sort(int[] data)
    {
        //Sorting By Algorithm A
    }
    

    public static void Sort(SortCallback sorter, int[] data)
    {
        sorter(data);
    }

}