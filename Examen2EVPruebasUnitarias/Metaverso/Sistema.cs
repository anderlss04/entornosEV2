namespace Metaverso
{
    public class Sistema
    {
        public int num {get;set;}
        public int[] numA {get;set;}

        public Sistema()
        {
            num = 5;
            numA = new int[5] {5 , 3 , 15 , 20 , 9};
        }

        public string Divisible( int num)
        {
            string cadena = "";
            
            if(num % 3 == 0)
            {
                cadena = "Meta";
            }
            else if(num % 5 == 0)
            {
                cadena += "Verso";
            }
            else
            {
                cadena = "" + num;
            }
                
            return cadena;
        }

        public string DivisibleArray(int[] numA)
        {
            string cadena = "";
            
            for(int i = 0; i < 5; i++ )
            {

                if(numA[i] % 3 == 0)
            {
                cadena += "Meta";
            }
            else if(numA[i] % 5 == 0)
            {
                cadena += "Verso";
            }
            
            }

            return cadena;
        }

       
    }
}