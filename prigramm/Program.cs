// Задаем исходный массив строк
        string[] inputArray = {"123", "abc", "qwerty", "xy", "z"};

        // Создаем новый массив строк
        string[] outputArray = new string[inputArray.Length];

        // Заполняем новый массив только строками, длина которых меньше или равна 3 символам
        int index = 0;
        foreach (string str in inputArray)
 {
            if (str.Length <= 3)
 {
                outputArray[index] = str;
                index++;
            }
        }

        // Выводим новый массив на экран
        Console.WriteLine("Новый массив строк:");
        for (int i = 0; i < index; i++) {
            Console.WriteLine(outputArray[i]);
        }

        Console.ReadKey();
