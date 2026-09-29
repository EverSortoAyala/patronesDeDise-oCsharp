using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PatronesDeDiseño.TheadSafe
{
    public class SingletonMultiHilo
    {
        private static SingletonMultiHilo instance;
        private static readonly object llave = new object();

        private SingletonMultiHilo()
        {

        }

        public static SingletonMultiHilo GetInstance() {
            if (instance == null ) {
                lock (llave) {
                    if (instance == null) {
                        instance = new SingletonMultiHilo();
                    }
                }
            }
        return instance;
        }
    }
}
