using NLog;

namespace NLogTest
{
    class Person
    {
        // create a static logger field
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;

            logger.Info("Created a person {@person} at {now}", this, DateTime.Now);
        }
    }
}
