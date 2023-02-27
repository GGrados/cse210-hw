using System;

class Program
{
    static void Main(string[] args)
    {



        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectiongActivity reflectiongActivity = new ReflectiongActivity();
        ListingActivity listingActivity = new ListingActivity();
        activity activity = new activity();



        bool startProgram = true;
        while (startProgram)
        {

            activity.Menu();

            int answer = Convert.ToInt32(Console.ReadLine());

            int timer;

            if (answer == 1)
            {
                breathingActivity.IntroductionAndTime(breathingActivity.GetActivityName(), breathingActivity.GetDescription());
                timer = breathingActivity.HowLong();
                breathingActivity.BreathCicles(timer);
                breathingActivity.FinishMessage(timer, breathingActivity.GetActivityName());

            }

            else if (answer == 2)
            {
                reflectiongActivity.IntroductionAndTime(reflectiongActivity.GetActivityName(), reflectiongActivity.GetDescription());
                timer = reflectiongActivity.HowLong();
                reflectiongActivity.Reflect(timer);
                reflectiongActivity.FinishMessage(timer, reflectiongActivity.GetActivityName());

            }
            else if (answer == 3)
            {
                listingActivity.IntroductionAndTime(listingActivity.GetActivityName(), listingActivity.GetDescription());
                timer = listingActivity.HowLong();
                listingActivity.Enlist(timer);
                listingActivity.FinishMessage(timer, listingActivity.GetActivityName());

            }


        }//While









    }
}