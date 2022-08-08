// 7. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear();

int a = new Random().Next(10, 100);
int Max = 0;

int MaxDigit()
{
    int One = a / 10;
    int Two = a % 10;
    if (One > Two) Max = One;
    else Max = Two;
}