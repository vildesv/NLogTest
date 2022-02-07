// See https://aka.ms/new-console-template for more information
using NLog;

namespace NLogTest
{
    class Program
    {
        // create a static logger field
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            // create 2 persons
            var person1 = new Person("John", "Gold");
            var person2 = new Person("James", "Miller");
            // added a new person
            var person3 = new Person("Vilde", "Svenkesen");

            // create 2 cars
            var car1 = new Car("Tesla Model S", 2020, person1);
            var car2 = new Car("Tesla Model X", 2020, person2);
            // added a new car
            var car3 = new Car("Volvo S40", 1999, person3);

            // logging
            logger.Trace("Some verbose log");                                                                       // Trace - the noisiest level, used for tracing the code
            logger.Debug("Some debug log");                                                                         // Debug - used for debugging messages with extended information about application processing.
            logger.Info("Person1: {@person}", person1);                                                             // Info - used for informative messages highlighting the progress of the application for sysadmins and end users.
            logger.Info("Car2: {@car}", car2);                                                                      // Info - used for informative messages highlighting the progress of the application for sysadmins and end users.
            logger.Info("Person3: {person}", person3);                                                              // Info - used for informative messages highlighting the progress of the application for sysadmins and end users.
            logger.Warn("Warning accured at {now}", DateTime.Now);                                                  // Warn - used for reporting non-critical unusual behaviour.
            logger.Error("Error accured at {now}", DateTime.Now);                                                   // Error - used for logging serious problems occurring during execution of the program.
            logger.Fatal("Serious problem with car {@car} accured at {now}", car1, DateTime.Now);                   // Fatal - used for reporting about errors that are forcing shutdown of the application.
        }
    }
}


/*
 
    How to start logging with NLog 
    (https://betterstack.com/community/guides/logging/net/how-to-start-logging-with-nlog/)

    Step 1 - Creating a Project             // Made a project named NLogTest
    Step 2 - Installing Dependencies        // Done with the Package Manager Console. Commands in use: Install-Package NLog.Extensions.Logging (root package of NLog)
    Step 3 - Creating a Logger              // Added comments in the code at Program.cs.
    Step 4 - Configuring the Logger         // Configuring the Logger using the nlog.config file (set the file's Copy to Output Directory property to Copy Always). The config is written in the XML language. (https://www.w3schools.com/xml/default.asp)
    Step 5 - Creating Extra Classes         // Created a Person class and a Car class.
    Step 6 - Logging                        // Logging some simple messages, at least one of each level. NLog logger provides 6 methods for logging - these are commented in the code above.
 
 
*/
