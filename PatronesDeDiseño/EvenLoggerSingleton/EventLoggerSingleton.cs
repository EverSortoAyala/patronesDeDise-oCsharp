using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDeDiseño.EvenLoggerSingleton
{
    public class EventLoggerSingleton
    {
        private static EventLoggerSingleton instance;
        private static List<string> _events;

        public static EventLoggerSingleton getInstance() {

            if (instance == null) {
                instance = new EventLoggerSingleton();
            }


        return instance;
        }
    }
}
