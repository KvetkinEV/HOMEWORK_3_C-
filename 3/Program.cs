Console.Write("Введите число: ");
            int cube = Convert.ToInt32(Console.ReadLine());

            void Cube(int[] Caube)
            {
                int schetchik = 0;
                int length = Caube.Length;
                while (schetchik < length)
                {
                    Caube[schetchik] = Convert.ToInt32(Math.Pow(schetchik, 3));
                    schetchik++;
                }
            }

            void Vivod(int[] coll)
            {
                int count = coll.Length;
                int index = 0;
                while (index < count)
                {
                    Console.Write(coll[index] + " ");
                    index++;
                }
            }

            int[] massivChisel = new int[cube + 1];
            Cube(massivChisel);
            Vivod(massivChisel);
            Console.ReadLine();  

