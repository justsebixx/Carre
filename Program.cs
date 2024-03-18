/* Sous-programme Carre : calcul le carré du paramètre
   Paramètre d'entrée :
   - i : entier dont on souhaite le carré (entrée)
    Valeur de retour : le carée de i */

int carre(int i){
    return i * i;
}
Console.WriteLine("Saisir un entier");
int val = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(carre(val));
