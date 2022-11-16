            string[,] tab = new string[4, 4]
            {
                {"%%%","###","***","+++"},
                {"+++","%%%","###","***"},
                {"***","+++","%%%","###"},
                {"###","***","+++","%%%"},
            };

            int i = 0;

        start:

            Console.Clear();

            for (int n = 0; n < 3; n++)
            {
                Console.WriteLine(tab[i, 1] + tab[i, 0]);
            }
            for (int m = 0; m < 3; m++)
            {
                Console.WriteLine(tab[i, 2] + tab[i, 3]);
            }

            Console.WriteLine("\nCo chcesz zrobić?");

            Console.WriteLine("\n1. Obróć układ w prawo o 90 stopni \n2. Obróć układ w prawo o 180 stopni \n3. Obróć układ w prawo o 270 stopni \n4. Zresetuj układ \n");

            bool czynnosc = int.TryParse(Console.ReadLine(), out int liczba);

            if (czynnosc)
            {

                switch (liczba)
                {
                    case 1:
                        if (i <= 0)
                        {
                            i = 3;
                        }
                        else
                        {
                            i = i - 1;
                        }
                        break;

                    case 2:
                        if (i == 0)
                        {
                            i = 2;
                        }
                        else if (i == 2)
                        {
                            i = 0;
                        }
                        else if (i == 3)
                        {
                            i = 1;
                        }
                        else if (i == 1)
                        {
                            i = 3;
                        }
                        break;

                    case 3:
                        if (i >= 3)
                        {
                            i = 0;
                        }
                        else
                        {
                            i = i + 1;
                        }
                        break;


                    case 4:
                        i = 0;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                goto start;
            }

            goto start;

   