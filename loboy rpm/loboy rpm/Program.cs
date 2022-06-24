using System;
class HelloWorld
{
    static void Main()
    {

        int[] Mass = new int[100];

        for (int i = 0; i < 100; i++) 
            Mass[i] = 0;

        for (int shag = 1; shag <= 100; shag++)
        {
            for (int j = shag; j < 100; j += shag)
            {
                if (Mass[j] == 0)
                {
                    Mass[j] = 1;
                }
                else
                {
                    Mass[j] = 0;
                }
            }
        }
        for (int k = 0; k < 100; k++)
        {
            if (Mass[k] == 1)
            {
                Console.WriteLine(k);
            }
        }
    }
}