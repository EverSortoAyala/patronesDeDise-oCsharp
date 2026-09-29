using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDeDiseño.SingletonID
{
    public  class SingletonID
    {
      private static SingletonID instance;
        public  Guid Id { get; set; }

        private SingletonID()
        {
            Id = Guid.NewGuid();
        }

        public static SingletonID getIsntacia() {
            if ( instance == null) {
                instance = new SingletonID();            
            }
        return instance;
        }
    }
}
