
namespace AggregateMethodsExample
{
    public class CustomAggregate
    {
        public int Sum(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
                sum += number;

            return sum;
        }

        public int Average(int[] array)
        {
            int sum = Sum(array);
            return sum / array.Length;
        }

        public int Max(int[] array)
        {
            if (array.Length == 0) return 0;

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }

            return max;
        }

        public int Min(int[] array)
        {
            if (array.Length == 0) return 0;

            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }

            return min;
        }
    }
}
