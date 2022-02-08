using System;

namespace PetitProg
{
    class Program
    //tri un tableau par ordre croissant et decroissant
    {


        private delegate void Delegate(int[] tableau);
       

        private void TriCroissant(int[] tableau)
           //Tri du plus petit au plus grand
        {
            Array.Sort(tableau);
        }

        private void TriDecroissant(int[] tableau)
        //Tri du plus grand au plus petit
        {
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }

        
        private void Addition(int[] tableau)
        //Addtionne les elements du tableau et affiche la somme 
        {
            int som = 0;
            foreach (int i in tableau)
            {
                
                som += i;
            }
            Console.WriteLine($"La somme des elements du tableau est: {som}");
        }

        private void Multiplie(int[] tableau)
        //multiplie les elements du tableau et affiche le produit
        {
            int prod = 1;
          
                foreach (int i in tableau)
                {

                    prod *= i;
                }
           
            Console.WriteLine($"Le produit des elements du tableau est: {prod}");
        }

        public void DemoTri(int[] tableau)
            //Tri dans l'ordre croissant ensuite decroissant
            //et affiche le resultat
        {
            TrierCalculerEtAfficher(tableau, TriCroissant, Addition);
            Console.WriteLine();
            TrierCalculerEtAfficher(tableau, TriDecroissant, Multiplie);
        }


        private void TrierCalculerEtAfficher(int[] tableau, Delegate methodeDeTri, Delegate methodeDeCalcul)
        {
            //Trie puis affiche les elements...
            

            methodeDeTri(tableau);
            methodeDeCalcul(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
            
        }



     
        // Methode d'execution


        public static void Main(string[] args)
        {
            int[] tableau = new int[] { 4, 1, 6, 10, 8, 5 };
            new Program().DemoTri(tableau);
        }




    }
}
