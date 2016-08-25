using System;

class EnumExample
{

    enum Ages
    {
        oldEnough = 5,
        canDrink = 21,
        tooOld = 90
    }

    public void run() {
        Console.WriteLine("EnumExample start.");
        const int age = 3;

        if  ( age < (int)Ages.oldEnough) {
            Console.WriteLine("Sorry you are too young to play");
        }
    }

}
