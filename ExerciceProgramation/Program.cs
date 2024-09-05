
#region 1. FizzBuzz  
//int[] nombre = new int[100];


//var i = 0;
//do
//{
//    nombre[i] = i + 1;
//    i++;
//} while (i < 100);

//foreach (var item in nombre)
//{
//    if (item % 5 == 0 && item % 3 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if (item % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if  (item % 5 == 0) 
//    {
//        Console.WriteLine("Buzz"); 
//    }
//   else
//    {  Console.WriteLine(item); }
//}

//27 min 
#endregion

#region 2. Le Plus Grand Nombre 

//using System.Collections;

//List<int> nb = new List<int> { 5, 6, 8,9,15, 2,100, 3 };
//int p = 0;
//foreach (int item in nb)
//{


//    for (int i = 0; i < nb.Count; i++)
//    {
//        if (item <= nb[i])
//        {
//            if (nb[i] > p)
//            {
//                p = nb[i];
//            }
//        }
//    }  

//}
//Console.WriteLine(p);

////45 min
#endregion

#region 3. Nombre Premier
//Console.WriteLine(" veuillez saisir un chiffre");
//var vrai = true;
//int nbsaisie = 0;
//do
//{

//    string? saisie = Console.ReadLine();


//    if (!string.IsNullOrEmpty(saisie))
//    {
//        try
//        {


//            nbsaisie = int.Parse(saisie);
//            vrai = true;


//        }
//        catch (Exception)
//        {

//            Console.WriteLine("votre saisie n'est pas conforme veuillez resaissir un chiffre");
//            vrai = false;
//        }
//    }
//    else
//    {
//        Console.WriteLine("votre saisie n'est pas conforme veuillez resaissir un chiffre");
//        vrai = false;
//    }
//} while (!vrai);
//for (int i = 2; i < nbsaisie; i++)
//{
//    if (nbsaisie % i == 0)
//    {

//        Console.WriteLine($"{nbsaisie} n'est pas nombre premier ");
//        break;
//    }
//    else
//    {
//        Console.WriteLine($"{nbsaisie} est un nombre premier");
//        break;
//    }
//}

//45 minut avec un tchek sur net 
#endregion

#region 4. Suite de Fibonacci

Console.WriteLine(" veuillez saisir un chiffre");
var vrai = true;
int nbsaisie = 0;
while (vrai)
{

    string? saisie = Console.ReadLine();


    if (!string.IsNullOrEmpty(saisie))
    {
        try
        {


            nbsaisie = int.Parse(saisie);
            vrai = false;


        }
        catch (Exception)
        {

            Console.WriteLine("votre saisie n'est pas conforme veuillez resaissir un chiffre");
            vrai = true;
        }
    }
    else
    {
        Console.WriteLine("votre saisie n'est pas conforme veuillez resaissir un chiffre");
        vrai = true;
    }
};


int[] tab = new int[nbsaisie];
foreach (int item in tab)
{
    for (int i = nbsaisie - 1; i > -1; i--)
    {

        tab[i] = i;
    }

    for (int i = 0; i < tab.Length - 2; i++)
    {

        tab[i + 2] = tab[i + 1] + tab[i];

    }

    Console.WriteLine(item);
}

1h15

#endregion