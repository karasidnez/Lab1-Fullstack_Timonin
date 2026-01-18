string[] days = { "Воскресенье", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
        
        while (true)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nПривет, {name}!");
            Console.WriteLine($"Сегодня: {days[(int)DateTime.Now.DayOfWeek]}");
            
            Console.Write("\nХотите продолжить? (y/n): ");
            if (Console.ReadLine().ToLower() != "y") break;
            
            Console.WriteLine();
        }
        
        Console.WriteLine("Программа завершена!");