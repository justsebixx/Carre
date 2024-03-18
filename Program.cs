int carre(int i){
    return i * i;
}
Console.WriteLine("Saisir un entier");
int val = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(carre(val));
