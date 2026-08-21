public class Programm
{
    public static void Main()
    {
        int[] nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        MergeCorrect(nums1, m, nums2, n);
        foreach (int i in nums1)
        {
            Console.Write(i + " ");
        }
    }
    
    public static void MergeWithArray(int[] nums1, int m, int[] nums2, int n) {
        if (n == 0)
        {
            return;
        }

        int length = m + n, index1 = 0, index2 = 0;
        int[] result = new int[length];
        for (int i = 0; i<length; ++i)
        {
            if (index1 == m)
            {
                result[i] = nums2[index2];
                index2++;
                continue;
            }
            if (index2 == n)
            {
                result[i] = nums1[index1];
                index1++;
                continue;
            }

            if (nums1[index1] < nums2[index2])
            {
                result[i] = nums1[index1];
                index1++;
            }
            else
            {
                result[i] = nums2[index2];
                index2++;
            }
        }
        result.CopyTo(nums1, 0);
    }
    
    public static void MergeCorrect(int[] nums1, int m, int[] nums2, int n) {
        if (n == 0)
        {
            return;
        }

        int length = m + n;
        --m;
        --n;
        for (int i = length-1; i >= 0; --i)
        {
            if (n < 0)
            {
                break;
            }

            if (m < 0)
            {
                nums1[i] = nums2[n];
                n--;
                continue;
            }
            if (nums1[m] > nums2[n])
            {
                nums1[i] = nums1[m];
                m--;
            }
            else
            {
                nums1[i] = nums2[n];
                n--;
            }
        }
    }
}