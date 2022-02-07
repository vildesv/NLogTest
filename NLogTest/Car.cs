using NLog;

namespace NLogTest
{
    class Car
    {
        // create a static logger field
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public string Model { get; set; }
        public int YearReleased { get; set; }
        public Person Owner { get; set; }

        public Car(string model, int yearReleased, Person owner)
        {
            Model = model;
            YearReleased = yearReleased;
            Owner = owner;

            logger.Debug("Created a car {@person} at {now}", this, DateTime.Now);
        }
    }
}
