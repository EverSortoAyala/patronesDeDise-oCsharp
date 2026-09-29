
using PatronesDeDiseño.EvenLoggerSingleton;
using PatronesDeDiseño.PSingleton;
using PatronesDeDiseño.SingletonID;

//public Singleton unico = new Singleton();
//  como es una clase estatica pudo elemento staticos enellos

//Singleton singular1 = Singleton.objetoSingleton();
//Console.WriteLine(singular1.GetType());

//Console.WriteLine("iniciando la instancia" );
//SingletonID instancia1 = SingletonID.getIsntacia();
//SingletonID instancia2 = SingletonID.getIsntacia();
//SingletonID instancia3 = SingletonID.getIsntacia();

//Console.WriteLine(instancia1.Id);
//Console.WriteLine(instancia2.Id);
//Console.WriteLine(instancia3.Id);

EventLoggerSingleton evento =  EventLoggerSingleton.getInstance();
evento.LogEvent("inicio");
evento.LogEvent("final");

evento.MostrarLogs();

