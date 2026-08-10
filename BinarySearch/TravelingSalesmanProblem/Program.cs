    public class Program
    {
        public const int Count = 5;
        public static void Main()
        {
            //The problem has been solved for a small dataset, 5 place; example of the algorithm. Exact answer.
            Random random = new Random();
            int[,] places = new int[Count, Count];
            for(int i = 0; i < Count; i++)
            {
                for (int i1 = 0; i1 < Count; i1++)
                {
                    places[i, i1] = random.Next(1, 10);
                }
            }

            int[] allLength = new int[5 * 4 * 3 * 2 * 1];
            int currentIndex = 0;       
            for (int i = 0; i < Count; i++)
            {
                int lengthOne = 0, lengthTwo = 0, lengthThree = 0;
                for (int i1 = 0; i1 < Count; i1++)
                {
                    if (i1 == i)
                    {
                        continue;
                    }
                    lengthOne = places[i, i1];
                    for (int i2 = 0; i2 < Count; i2++)
                    {
                        if (i2 == i1 || i2 == i)
                        {
                            continue;
                        }
                        lengthTwo = lengthOne + places[i1, i2];
                        for (int i3 = 0; i3 < Count; i3++)
                        {
                            if (i3 == i1 || i3 == i || i3 == i2)
                            {
                                continue;
                            }
                            lengthThree = lengthTwo + places[i2, i3];
                            for (int i4 = 0; i4 < Count; i4++)
                            {
                                if (i4 == i1 || i4 == i || i4 == i2 || i4 == i3)
                                {
                                    continue;
                                }
                                allLength[currentIndex] = lengthThree + places[i3, i4] + places[i4, i]; 
                                currentIndex++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(allLength.Min());
        }
    }