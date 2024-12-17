// Start  Note  Input  Project// MENU ://  0 Permet  de quitter//  1 Permet de saisir  les  notes//  2 Permet  d'afficher la plus  grandes notes//  3 Permet  d'afficher la plus petite notes//  4 Permet  d'afficher la moyenne  des notes//  999 Permet de sortir de la saisie des notesstring input_user(string message){    Console.WriteLine(message);    return Console.ReadLine();}int input_user_int(string message){    return int.Parse(input_user(message));}double input_user_double(string message){    return double.Parse(input_user(message));}void InterfaceNote(){
    double?[] listeNotes;
    double? max_notes;
    double? min_notes;
    double? moyenne_notes;
    int? option_select;

    do
    {
        Console.WriteLine("--- Gestion des notes avec menu ---");
        Console.WriteLine("1---Saisir les notes");
        Console.WriteLine("2---La plus grande note");
        Console.WriteLine("3---la plus petite note");
        Console.WriteLine("4---la moyenne des notes");
        Console.WriteLine("0--- quitter le programme");
        option_select = input_user_int("Faites votre choix");
        switch(option_select)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                do
                {

                } while(true);
        }
        
    }while (true);

}