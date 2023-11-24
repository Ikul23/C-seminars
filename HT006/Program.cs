 // Условие задачи: программа на вход принимает координаты точки (X, Y)
// причем X не равно 0, Y не равно 0, и выдает номер четверти координатной плоскости
// в которой находится эта точка

    
        Console.WriteLine("Enter X");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y");
        int y = Convert.ToInt32(Console.ReadLine());

        CoordinatePlane(x, y);
    
    void CoordinatePlane(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("1st coordinate plane");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("2nd coordinate plane");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("3rd coordinate plane");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("4th coordinate plane");
        }
        else
        {
            Console.WriteLine("X = 0; Y = 0");
        }
    }

