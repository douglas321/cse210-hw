using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string activity, string description)
        {
            _activity = activity;
            _description = description;
        }

    public void StartBreathingActivity()
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            DateTime currentTime = DateTime.Now;
            bool breath = true;
            while(currentTime < futureTime)
            {
                
                if (breath){
                    Console.WriteLine("Breath in...");

                    CountDownAnimation(4);

                    breath = false;
                    currentTime = DateTime.Now;
                }
                else{
                    Console.WriteLine("Breath out...");

                    CountDownAnimation(4);

                    breath = true;
                    currentTime = DateTime.Now;
                }
            }
        }
}

