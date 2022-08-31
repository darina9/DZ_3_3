Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
 if ((num/10000 == num%10) && ((num/1000)%10 == (num%100)/10))
 {
    Console.WriteLine("Это число палиндром");
 }
 else{
    Console.WriteLine("Это число не палиндром");
 }
