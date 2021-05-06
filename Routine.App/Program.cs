using SpeechLib;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routine.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SpVoice sp = new SpVoice();
            sp.Speak("Good morning sir!");

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    sp.Speak("Today is Monday.");
                    Opener(@"C:\SOFTWARE", @"C:\Program Files\Google\Chrome\Application\chrome.exe");
                    break;
                case DayOfWeek.Tuesday:
                    sp.Speak("Today is Tuesday.");
                    Opener(@"C:\SOFTWARE", @"C:\Program Files\Google\Chrome\Application\chrome.exe");
                    break;
                case DayOfWeek.Wednesday:
                    sp.Speak("Today is Wednesday.");
                    Opener(@"C:\SOFTWARE", @"C:\Program Files\Google\Chrome\Application\chrome.exe");
                    break;
                case DayOfWeek.Thursday:
                    sp.Speak("Today is Thursday.");
                    Opener(@"C:\SOFTWARE", @"C:\Program Files\Google\Chrome\Application\chrome.exe");
                    break;
                case DayOfWeek.Friday:
                    sp.Speak("Today is Friday.");
                    Opener(@"C:\SOFTWARE", @"C:\Program Files\Google\Chrome\Application\chrome.exe");
                    break;
                default:
                    Opener(@"C:\Oyun");
                    break;
            }

            sp.Speak("Daily routine files opened, have a nice day sir.");
        }

        public static void Opener(string way1)
        {
            Process.Start(way1);
        }
        public static void Opener(string way1, string way2)
        {
            Process.Start(way1);
            Process.Start(way2);
        }

    }
}
