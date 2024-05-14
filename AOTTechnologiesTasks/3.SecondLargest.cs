namespace AOTTechnologiesTasks
{
    public static class SecondLargest
    {
        public static int Find(List<int> numbers) // better array
        {
            int n = numbers.Count;
            if (n <= 1)
                return -1;

            int firstLargest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                firstLargest = Math.Max(firstLargest, numbers[i]);
            }

            bool firstFound = false;
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] != firstLargest)
                    secondLargest = Math.Max(secondLargest, numbers[i]);
                else
                {
                    if (firstFound)
                    {
                        return numbers[i]; // For the case we have several max
                    }
                    else
                    {
                        firstFound = true;
                    }
                }

            }

            return secondLargest;
        }
    }
}
