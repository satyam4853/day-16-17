namespace PrimeNumber
{
    internal class CheckPrimenumberBase
    {
        public int b;
        public int a;

        public void Check()
        {
            for (int i = a; i <= b; i++)
            {

                // Skip 0 and 1 as they are
                // neither prime nor composite
                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell
                // if i is prime or not
                int flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                    System.Console.WriteLine(i);
            }
        }
    }
}