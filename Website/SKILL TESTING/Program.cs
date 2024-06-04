using System.ComponentModel.Design;
using System.Runtime.InteropServices;
Console.WriteLine("type yes TO GAMBLE!!!!!!!");
string goku =Console.ReadLine();
while (goku == "yes")
{
    Random rnd = new Random();
    int Gambling = rnd.Next(000, 999);
    Console.WriteLine(Gambling);
    if (Gambling == 111 || Gambling == 222 || Gambling == 333 || Gambling == 444 || Gambling == 555 || Gambling == 666 || Gambling == 777 || Gambling == 888 || Gambling == 999)
    {
        Console.WriteLine("You win!"); 
        Console.WriteLine("try again?");
        goku = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("you got so close!");
        Console.WriteLine("try again?");
        goku = Console.ReadLine();
    }
}
