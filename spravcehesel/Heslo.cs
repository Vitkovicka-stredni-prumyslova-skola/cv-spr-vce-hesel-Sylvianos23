using System.Reflection.Metadata.Ecma335;

namespace SpravceHesel
{
    interface IHeslo
    {
        int DelkaHesla();
        int MaxDelkaHesla();
        int MinDelkaHesla();
    }

    class Heslo : IHeslo
    {
        private string heslo;
        public static int maxDelkaHesla =  20;
        private static int minDelkaHesla = 8;

        int DelkaHesla()
        {
            return 0;
        }


        int MinDelkaHesla()
        {
            return minDelkaHesla;

        }
           
    
        int MaxDelkaHesla()
        {
            return maxDelkaHesla;

        }
           
        
    }
}