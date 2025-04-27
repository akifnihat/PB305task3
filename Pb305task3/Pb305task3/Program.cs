
Console.WriteLine("Hello, World!");
#region task1
//Console.Write("ucreqemli eded daxil edin: ");
//int n = int.Parse(Console.ReadLine());

//int a = n / 100;
//int b = (n / 10) % 10;
//int c = n % 10;

//int hasil = a * b * c;
//Console.WriteLine($"ededlerin hasili: {hasil}");


#endregion

#region task2

//Console.Write("Birinci mehsulun qiymeti: ");
//int a = int.Parse(Console.ReadLine());

//Console.Write("İkinci mehsulun qiymeti: ");
//int b = int.Parse(Console.ReadLine());

//Console.Write("ucuncu mehsulun qiymeti: ");
//int c = int.Parse(Console.ReadLine());

//int sum = 0;

//if (a <= b && a <= c)   sum = b + c;

//else if (b <= a && b <= c)   sum = a + c;

//else if (c <= a && c <= b)   sum = a + b;

//Console.WriteLine(sum);


#endregion

#region task3

//Console.Write("eded daxil edin: ");
//int a = int.Parse(Console.ReadLine());

//if (a % 3 == 0)
//{
//    if (a % 2 == 0)
//        Console.WriteLine("3-e bolunur cutdur");
//    else
//        Console.WriteLine("3-e bolunur tekdir");
//}
//else
//  Console.WriteLine("3-e bolunmur");

#endregion

#region task4

//Console.Write("eded daxil edin: ");
//int n = int.Parse(Console.ReadLine());

//if (n <= 1)
//{
//    Console.WriteLine("Sade eded deyil");
//}
//else
//{
//    bool sade = true;

//    for (int i = 2; i < n; i++)
//    {
//        if (n % i == 0)
//        {
//            sade = false;
//            break;
//        }
//    }

//    if (sade)
//        Console.WriteLine("Sade ededdir");
//    else
//        Console.WriteLine("Murekkeb ededdir");
//}

#endregion

#region task5

//Console.Write("X ededini daxil edin: ");
//int X = Convert.ToInt32(Console.ReadLine());

//Console.Write("Y ededini daxil edin: ");
//int Y = Convert.ToInt32(Console.ReadLine());

//Console.Write("Z ededini daxil edin: ");
//int Z = Convert.ToInt32(Console.ReadLine());

//int minumum = X;

//if (Y < minumum)
//{
//    minumum = Y;
//}

//if (Z < minumum)
//{
//    minumum = Z;
//}

//Console.WriteLine("en kicik eded: " + minumum);
#endregion

#region task6

//Console.Write("N ededini daxil edin: ");
//int N = Convert.ToInt32(Console.ReadLine());


//if (N % 3 == 0 && N % 7 == 0)
//{
//    Console.WriteLine("N ededi həm 3-e, hem de 7-ye bolunur");
//}
//else
//{
//    Console.WriteLine("N ededi həm 3-e, hem de 7-ye bolunmur");
//}

#endregion

#region task7

//Console.Write("Birinci ededi daxil edin: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("İkinci ededi daxil edin: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Ucuncu ededi daxil edin: ");
//int num3 = Convert.ToInt32(Console.ReadLine());

//int musbetCount = 0;

//if (num1 > 0) musbetCount++;
//if (num2 > 0) musbetCount++;
//if (num3 > 0) musbetCount++;

//Console.WriteLine("Musbət ededlerin sayı: " + musbetCount);

#endregion

#region task8

//Console.Write("M ededini daxil edin: ");
//int M = Convert.ToInt32(Console.ReadLine());

//Console.Write("N ededini daxil edin: ");
//int N = Convert.ToInt32(Console.ReadLine());

//int sum = 0;

//for (int i = M + 1; i < N; i++)
//{
//    sum += i;
//}

//Console.WriteLine("M və N ededləri arasında olan ededlərin cemi: " + sum);

#endregion

#region task9

//Console.Write("M ededini daxil edin: ");
//int M = Convert.ToInt32(Console.ReadLine());

//int count = 0;

//for (int i = 1; i <= M; i++)
//{
//    if (i % 15 == 0)
//    {
//        count++;
//    }
//}

//Console.WriteLine("ededlərin sayı: " + count);
#endregion

#region task10

//Console.Write("M ededini daxil edin: ");
//int M = Convert.ToInt32(Console.ReadLine());

//int sum = 0; 
//int count = 0; 

//for (int i = 1; i <= M; i++)
//{
//    if (i % 21 == 0)  
//    {
//        sum += i; 
//        count++;  
//    }
//}


//if (count > 0)
//{
//    double average = sum / count; 
//    Console.WriteLine("ededi orta " + average );
//}
//else
//{
//    Console.WriteLine("1dən M-e qeder olan ededlər arasında 21-e bolunen hec bir eded yoxdur");
//}



#endregion

#region task11
//Console.Write("N ədədini daxil edin: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int sum = 0;

//while (n > 0)
//{
//    sum += n % 10;  
//    n /= 10;         
//}

//// Nəticəni ekrana yazdırırıq
//Console.WriteLine("ededin reqemlerinin cemi: " + sum);


#endregion