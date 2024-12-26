using Projet_de_POO;

LaPioche P1 = new LaPioche();
P1.CreerToutesLesCarte();

foreach(Cartes carte in P1.toutesLesCartes)
{
    carte.Afficher();
}
Console.WriteLine("******************************************************************************");
Console.WriteLine(P1.toutesLesCartes.Count);
Console.WriteLine("******************************************************************************");
P1.MelangerCartes();
foreach (Cartes carte in P1.toutesLesCartes)
{
    carte.Afficher();
}
Console.WriteLine("******************************************************************************");
Console.WriteLine(P1.toutesLesCartes.Count);

/*
            do { 
            Console.WriteLine("Veuillez entrer le nombre de joueur\n 3 Joueurs minimum");
            nbrJoueurs =int.Parse(Console.ReadLine());
            }while(nbrJoueurs < 3);
*/