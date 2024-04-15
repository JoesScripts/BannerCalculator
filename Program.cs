using System;

    class BannerCalculator
{
    static void Main()

    {   // Declare your constant variables
        const double smallBannerHeight = 4.0;
        const double mediumBannderHeight = 7.0;
        const double smallFee = 49.95;
        const double mediumFee = 79.99;
        const double largeFee = 129.95;

        // Ask for user input of banner height
        Console.WriteLine("Please enter banner height in feet: ");
        double bannerHeight = Convert.ToDouble(Console.ReadLine());                           

        // declare total amount after calculations
        double totalFee;

        // your if statement will loop until it is executed, or it will transfer over to the else clause in either loop
        if (bannerHeight < smallBannerHeight)
        {
            totalFee = smallFee;
        }
        else
        {
            if (bannerHeight <= mediumBannderHeight)
            {
               totalFee = mediumFee;
            }
            else
            {
                totalFee = largeFee;
            }


        }

        Console.WriteLine($"The fee for a banner of {bannerHeight} feet is: ${totalFee}. ");
    }
}