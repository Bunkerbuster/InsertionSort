namespace InsertionSortServices
{
    public class InsertionSortAlgorithm : IInsertionSortAlgorithm
    {
        public InsertionSortAlgorithm() { }

        public int[] SortArray(int[] UnsortedArray)
        {
            int n = UnsortedArray.Length;
            for (int i = 1; i < n; i++)
            {
                int key = UnsortedArray[i];
                int j = i - 1;

                while (j >= 0 && UnsortedArray[j] > key)
                {
                    UnsortedArray[j + 1] = UnsortedArray[j];
                    j--;
                }

                UnsortedArray[j + 1] = key;
            }

            return UnsortedArray;
        }
    }
}
