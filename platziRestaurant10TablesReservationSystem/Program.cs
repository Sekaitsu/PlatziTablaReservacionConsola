namespace platziRestaurant10TablesReservationSystem
{
    /*
     * 1 Validar si es usuario exitente o si se debe registrar
     * 2 El programa debe ser capaz de darle bienbenida a el usuario si existe
     * 3 El programa debe repetirse hasta que se registren las 10 personas
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] {"a", "b", "c", "d", "fer", "gabi", "heli", "isa", "juan", ""};
            int arrayCurrentIndex = 9;
            bool userType;

            Console.WriteLine("Welcome to the best app in the world ");
            while (arrayCurrentIndex < 10) 
                //(true)
                {
                    //if(arrayCurrentIndex == 10) //cantidad de registros disponibles
                    //{
                    //    Console.WriteLine("The app is full, try again later");
                    //    Environment.Exit(0); //terminar de ejecurarse, se puede optimizar
                    //}
                    Console.WriteLine("\n \n Are you registered user? : writhe true or false to register");
                    userType = Convert.ToBoolean(Console.ReadLine());
                    if (userType == true)
                    {
                        Console.WriteLine("Hello, you are a registered user, plase enter your user name.");
                        string userToSearch = Console.ReadLine(); /**/
                        Console.WriteLine("The user you searched is {0}", userToSearch);

                        //se crea una nueva variable tipo index
                        //el metodo IndexOf se encarga de buscar un dato dentro de un array y te dice en que indice está 
                        int index = Array.IndexOf(userNames, userToSearch); //("en donde vas a buscar","que vas a buscar en el método") y lo arroja en la variable index 
                        if (index == -1)
                        {
                            Console.WriteLine("User not found, try again or register");
                        }
                        else
                        {
                            Console.WriteLine("Welcome {0}", userNames[index]);
                        }
                    }
                    else if (userType == false)
                    {
                        Console.WriteLine("Please write and remember your user name");
                        userNames[arrayCurrentIndex] = Console.ReadLine();

                        Console.WriteLine("Your user has been saved sucessfully \n" +
                            "Your user name is> {0}", userNames[arrayCurrentIndex]);
                        arrayCurrentIndex++; //incrementa en 1 el valor de arraycurrent
                    }
                }

            Console.WriteLine("The app is full, try again the next year \n There are the guests to the app: ");
            int auxIndex = 0;
            foreach (string element in userNames) //por cada cadena de elementos que estan en userNames hacer lo sig
            {
                Console.WriteLine("User number: {0} and user name: {1}", auxIndex+1 /*no inicia desde 0, sino en 1*/, userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}