using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime activityDate = DateTime.Now;
        RunningActivity runningActivity = new RunningActivity(activityDate, 30, 4.8);
        StationaryBicycleActivity stationaryBicycleActivity = new StationaryBicycleActivity(activityDate, 10, 50);
        SwimmingActivity swimmingActivity = new SwimmingActivity(activityDate, 60, 20);
        Activity[] activities = [runningActivity, stationaryBicycleActivity, swimmingActivity];
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

    }
}