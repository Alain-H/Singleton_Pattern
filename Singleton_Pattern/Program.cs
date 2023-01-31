using Singleton_Pattern;

Ork_General King = Ork_General.getInstance();
King.setName("Ludwig-XIV");
Console.WriteLine(King.AngrifsBefehl());


Ork_General King2 = Ork_General.getInstance();
King2.setName("Max XIII");
Console.WriteLine(King2.Rueckzugsbefehl());
Console.WriteLine(King.AngrifsBefehl());  //zum veranschaulichen dass King nicht mehr existiert in der Konsole kommt wieder King2 mit dem Angriffsbefehl
                                           // da die Instanz von King beendet wurde.

Console.ReadKey();
