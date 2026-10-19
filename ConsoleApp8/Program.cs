   
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.Write("Исходный массив: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        int[] reversed = new int[numbers.Length];

        // Заполняем в обратном порядке
        for (int i = 0; i < numbers.Length; i++)
        {
            reversed[i] = numbers[numbers.Length - 1 - i];
        }

        Console.Write("Перевернутый массив: ");
        for (int i = 0; i < reversed.Length; i++)
        {
            Console.Write(reversed[i] + " ");
        }

        Console.ReadKey();
    
