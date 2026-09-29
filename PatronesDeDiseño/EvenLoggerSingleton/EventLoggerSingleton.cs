using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PatronesDeDiseño.EvenLoggerSingleton
{
    public class EventLoggerSingleton
    {
        private static EventLoggerSingleton instance;
        private static List<string> _events;

        private EventLoggerSingleton()
        {
            _events = new List<string>();
        }
        public static EventLoggerSingleton getInstance() {

            if (instance == null) {
                instance = new EventLoggerSingleton();
            }
        return instance;
        }


        public void LogEvent( string eventMessage)
        {
            string horaRegistro = DateTime.Now.ToString(
                "01-08-2026 12:20:55"
                );
            _events.Add( horaRegistro  + eventMessage);
        }

        public void MostrarLogs() {
            foreach (var log in _events) {
                Console.WriteLine(log);
            }
        }
    }
}
#region
    //*
    // el foreach va a salar en el
    // objeto iterable  hasta que se indique que ternno el 
    // ultimo iten de la listam atteglo .....
    //*/
#endregion