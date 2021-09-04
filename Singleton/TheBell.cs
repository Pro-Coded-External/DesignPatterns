using System;

namespace Singleton
{
    /// <summary>
    ///     Singleton
    /// </summary>
    public sealed class TheBell
    {
        private static TheBell bellConnection;
        private static readonly object syncRoot = new();

        private TheBell()
        {
        }

        /// <summary>
        ///     We implement this method to ensure thread safety for our singleton.
        /// </summary>
        public static TheBell Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (bellConnection == null) bellConnection = new TheBell();
                }

                return bellConnection;
            }
        }

        public void Ring()
        {
            Console.WriteLine("Ding! Order up!");
        }
    }
}