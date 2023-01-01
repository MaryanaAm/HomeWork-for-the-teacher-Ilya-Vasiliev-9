



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NumberList(int number)
{
    if(number == 0) return;
        Console.Write(number + " ");
        NumberList(number - 1);
            
}

NumberList(number);

