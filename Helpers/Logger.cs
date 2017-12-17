using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDoclerHolding.Helpers
{
    public static class Logger
    {
        private static List<String> Lines = new List<String>();
        private static int LogLevel;

        public static void CreateLogFile(String TestCaseName)
        {
            String LogPath = @"..\..\Logs\.\" + TestCaseName + "_" + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".txt";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(LogPath))
            {
                foreach (String line in Lines)
                {
                   file.WriteLine(line);
                }
                file.Close();
            }
            Lines = new List<String>();
        }

        public static void LogMessage(String message)
        {
            LogNewMessage(message);
        }

        public static void ClickedOn(String element)
        {
            String message = "Clicked on [ " + element + " ].";
            LogNewMessage(message);
        }

        public static void LogException(String exceptionText)
        {
            String message = "ERROR: Exception thrown [ " + exceptionText + " ].";
            LogNewMessage(message);
        }

        public static void AssertEqual(String expected, String actual)
        {
            String message = "";
            if (expected.Equals(actual))
            {
                message = "The element [ " + expected + " ] is equals to [ " + actual + " ].";
            }
            else
            {
                message = "ERROR: The element [ " + expected + " ] is NOT equals to [ " + actual + " ].";
            }

            LogNewMessage(message);
        }

        public static void FilledField(String element, String value)
        {
            String message = "Filled the field [ " + element + " ] with value [ " + value + " ].";
            LogNewMessage(message);
        }

        public static void IsElementActive(String element, bool flag)
        {
            String message = "";
            if (flag == true)
            {
                message = "The element [ " + element + " ] is active.";
            }
            else
            {
                message = "ERROR: The element [ " + element + " ] is NOT active.";
            }
            LogNewMessage(message);
        }

        public static void IncreaseLogLevel()
        {
            LogLevel++;
        }

        public static void DecreaseLogLevel()
        {
            LogLevel--;
        }

        private static String LogLevelString()
        {
            String LogLevelString = " ";

            for (int i = 0; i < LogLevel; i++)
            {
                LogLevelString = LogLevelString + "  ";
            }

            return LogLevelString;
        }

        private static void LogNewMessage(String message)
        {
            if (Lines.Count < 10)
            {
                if(Lines.Count == 9)
                    Lines.Add("0" + (Lines.Count + 1) + LogLevelString() + message);
                else
                    Lines.Add("00" + (Lines.Count + 1) + LogLevelString() + message);
            }
            else if (Lines.Count >= 10 && Lines.Count < 100)
            {
                Lines.Add("0" + (Lines.Count + 1) + LogLevelString() + message);
            }
            else if (Lines.Count >= 100)
            {
                Lines.Add((Lines.Count + 1) + LogLevelString() + message);
            }
        }
    }
}
