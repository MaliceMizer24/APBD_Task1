namespace APBD_Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter numbers in the format a,b,c : ");
            string numbers = Console.ReadLine();
        }
        public static int CalculateAvg(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum / nums.Length;
        }
        
        public static int CalculateMax(int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }

            return max;
        }
    }
}