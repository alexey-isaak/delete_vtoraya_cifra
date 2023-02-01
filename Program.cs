using System;
 
namespace delete_vtoraya_cifra
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите трехзначное число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            string chislo_string = Convert.ToString(chislo);
            string new_chislo = chislo_string.Remove(1,1);
            Console.WriteLine("Удаление второй цифры: " + new_chislo);
        }
    }
}
