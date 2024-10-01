double SideA = Convert.ToDouble(Console.ReadLine());
double SideB = Convert.ToDouble(Console.ReadLine());
double SideС = Convert.ToDouble(Console.ReadLine());
double halfPer = (SideA + SideB + SideС) / 2;
double area = Math.Sqrt(halfPer * (halfPer - SideA) * (halfPer - SideB) *
    (halfPer - SideС));
Type areatype = area.GetType();
if (area > 0)
{
    Console.WriteLine("Triangle area with sides {0}, {1}, {2}, is {3}",
    SideA, SideB, SideС, area);
}
else Console.WriteLine("Triangle area with sides {0}, {1}, {2}, is incorrect",
    SideA, SideB, SideС);

if (Math.Pow(SideС, 2) + Math.Pow(SideA, 2) == Math.Pow(SideB, 2) ||
    Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideС, 2) ||
    Math.Pow(SideС, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2))
{
    Console.WriteLine("Triangle is right-angled");
}
else Console.WriteLine("Triangle not right-angled");

