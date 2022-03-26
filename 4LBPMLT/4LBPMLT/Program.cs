
﻿double a, b;
Console.WriteLine("Vvedite a");
a = Convert.ToDouble(Console.ReadLine());
﻿Console.WriteLine("Vvedite b");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("+ 1; - 2; * 3; / 4; q 5");
﻿if (Console.ReadLine() == "1")
{
    Console.WriteLine(a + b);
}
﻿if (Console.ReadLine() == "2")
{
    Console.WriteLine(a - b);
}
﻿if (Console.ReadLine() == "3")
{
    Console.WriteLine(a * b);
}
