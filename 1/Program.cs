Console.Write("Введите пятизначное число: ");
            string chislo = Console.ReadLine();
            if (chislo.Length == 5)
            {
           

                if (chislo[0] == chislo[4] && chislo[1] == chislo[3])
                {
                    Console.WriteLine("Ваше число: " +  chislo + " = палиндром.");
                }
                else Console.WriteLine("Ваше число: "+ chislo + " не палиндром.");
            }
            else Console.WriteLine("Пожалуйста, введите пятизначное число");

            Console.ReadLine();

