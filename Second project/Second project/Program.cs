
/*Console multiplication application(Made with conditional and iterations)
*/
while(true){
    Console.WriteLine("Input the number of multiplication table to be printed(nubmers below 100 only apply)");
    int input = int.Parse(Console.ReadLine());
    if (input <= 10)
    {
        for (int i = 1; i <= input; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("{0}x{1} = {2}", i, j, i * j);
            }
            Console.WriteLine("====================");
        }
    }

    else
    {
        Console.WriteLine("Number must be below 100");
    }

    Console.ReadKey();
}

