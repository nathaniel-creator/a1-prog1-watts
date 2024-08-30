// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
const double ORDINATEUR_CONSOMMATION = 150;
const double COUTS_WATTS = 0.15 / 100;

double heures;
double watts;
double argent;

Console.WriteLine("Veuillez rentrez le nombre d'heure");

heures = Convert.ToDouble(Console.Readline());

watts = heures * ORDINATEUR_CONSOMMATION;
argent = nombrewatts * COUTS_WATTS;

Console.Writeline($"coût total:{argent}")





