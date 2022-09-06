Console.WriteLine("Введите пятизначное число:");
int x = Convert.ToInt32(Console.ReadLine());

if(x < 10000 || x > 99999){
    Console.WriteLine("Вы ввели неверные данные"); 
}
else if(x % 10 ==  x / 10000 && x % 100 / 10 == x / 1000 % 10){

    Console.WriteLine("Палиндром");
}
else{
     Console.WriteLine("Не палиндром");
}
    
