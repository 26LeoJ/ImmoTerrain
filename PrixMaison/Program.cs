﻿using System;

namespace ExemplePOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maison UneMaison = new Maison("11 Rue des Chartreux, 69001 Lyon", 58f, 4, false);
            Maison UneAutreMaison = new Maison("4 place Saint Louis, 22100 Dinan", 86.5f, 5, true);
            Maison UneDerniereMaison = new Maison("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 2, false);

            Terrain UnTerrain = new Terrain("55 route cabossée, 29130 Locmaria-Plouzané", 5000f, 2, true);
            Terrain UnAutreTerrain = new Terrain("102 route des volcans, 63000 Clermont-Ferrand", 1500f, 4, false);

            Bien[] CatalogueBiens = new Bien[] { UneMaison, UneAutreMaison, UneDerniereMaison, UnTerrain, UnAutreTerrain };

            int cpt = 0;
            foreach (Bien M in CatalogueBiens)
            {
                // if terrain -> consolewriteline terrain
                // if maison -> consolewriteline maison
                Console.WriteLine("------ {0} ------", M.GetType().Name);
                Console.WriteLine(M);
            }

            Proprietaire Elodie = new Proprietaire("Martin", "Elodie", new Bien[] { UneMaison, UnTerrain });
            Console.WriteLine(Elodie);

            Proprietaire Marc = new Proprietaire("Dupont", "Marc", new Bien[] { UneAutreMaison, UneDerniereMaison, UnAutreTerrain });
            Console.WriteLine(Marc);

            Proprietaire Leo = new Proprietaire("Marin", "Leo", new Bien[0]);
            Console.WriteLine(Leo);
        }
    }
}