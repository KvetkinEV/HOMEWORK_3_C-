int x1 = Coordinate("x", "A");
            int y1 = Coordinate("y", "A");
            int z1 = Coordinate("z", "A");
            int x2 = Coordinate("x", "B");
            int y2 = Coordinate("y", "B");
            int z2 = Coordinate("z", "B");

            int Coordinate(string Coordinata, string Tochka)
            {

                Console.Write($"Введите координату " + Coordinata + " точки - "  + Tochka + ": ");
                return Convert.ToInt16(Console.ReadLine());
            }

            double Rasstoyanie3D(double X1, double X2,double Y1, double Y2,double Z1, double Z2)
            {
                return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
            }

            double rasstoyanieITOG = Math.Round(Rasstoyanie3D(x1, x2, y1, y2, z1, z2), 2);

            Console.WriteLine("Длина отрезка =  "  + rasstoyanieITOG);
            Console.ReadLine();
