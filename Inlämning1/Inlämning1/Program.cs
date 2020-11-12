using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gav restart värde y
            char restart = 'y';
            //gjorde en whileloop för att kunna startaom programmet senare
            while (true)
            {



                //gav result1 och 2 värde 0;
                double result1 = 0;
                double result2 = 0;

                //En while loop ifall man skriver fel operator så ska man börja om 
                while (true)
                {

                    


                    // Angett vart första talet ska sättas in
                    Console.WriteLine("Ange första talet och tryck enter: ");
                    string input1 = Console.ReadLine();

                  


                    // Angett var firsta operatoren ska sättas in
                    Console.WriteLine("Ange en operation(+ , - , * , /): ");
                    char action1 = Console.ReadKey().KeyChar;




                    //gjorde en if sats ifall man skriver fel operation så får man ett felmedelande 
                    if (action1 == '*' || action1 == '-' || action1 == '+' || action1 == '/' )
                    {
                        Console.WriteLine();   
                    }
                    else

                    {
                        Console.WriteLine("\nKan ändast använda( + , - , *, / ) BÖRJA OM OCH FÖRSÖK IGEN! ");
                        break;
                    }

                    // Angett var andra talet ska sättas in
                    Console.WriteLine("Ange andra talet och tryck enter:");
                    string input2 = Console.ReadLine();


                    // Angett var andra operatoren ska sättas in
                    Console.WriteLine("Ange en ny operation(+ , - , * , /): ");
                    char action2 = Console.ReadKey().KeyChar;

                    //gjorde en if sats ifall man skriver fel operation så får man ett felmedelande 
                    if (action2 == '*' || action2 == '-' || action2 == '+' || action2 == '/')
                    {
                        Console.WriteLine();
                    }
                    else if (action2 != '*' || action2 != '-' || action2 != '+' || action2 != '/')
                    {
                        Console.WriteLine("Kan ändast använda operatorerna ( + , - , *, / ) BÖRJA OM OCH FÖRSÖK IGEN! ");
                        break;
                    }


                    // Angett var tredje talet ska sättas in
                    Console.WriteLine("\nAnge ett tredje tal och tryck enter");
                    string input3 = Console.ReadLine();

                    
                    

                    




                        //gjorde en if(om) 
                        // action1 är + så ska programmet göra vad som står under
                    if (action1 == '+')
                    {
                        //Omvandlar input1 och input2 till double och adderar ihop dem
                        Console.WriteLine(input1 + '+' + input2);
                        
                        result1 = Convert.ToDouble(input1) + Convert.ToDouble(input2);
                    }
                    //sätter en else if(eller om)
                    //action1 är - så ska  man göra det som står under
                    else if (action1 == '-')
                    {
                        //Omvandlar input1 och input2 till double och subtraherar dem
                        Console.WriteLine(input1 + '-' + input2);
                        result1 = Convert.ToDouble(input1) - Convert.ToDouble(input2);
                    }
                    //sätter en else if(eller om)
                    //action1 är * så ska  man göra det som står under
                    else if (action1 == '*')
                    {
                        //Omvandlar input1 och input2 till double och multiplicerar ihop dem
                        Console.WriteLine(input1 + '*' + input2);
                        result1 = Convert.ToDouble(input1) * Convert.ToDouble(input2);
                    }
                    //sätter en else if(eller om)
                    //action1 är / så ska  man göra det som står under
                    else if (action1 == '/')
                    {
                        //Omvandlar input1 och input2 till double och dividerar dem
                        Console.WriteLine(input1 + '/' + input2);
                        result1 = Convert.ToDouble(input1) / Convert.ToDouble(input2);
                    }



                    //sätter en if(om) 
                    // Action2 är + så ska  man göra det som står under
                    if (action2 == '+')
                    {
                        //omvandlar input3 till double och adderar på resultatet ifrån input 1 och 2
                        Console.WriteLine(result1.ToString() + '+' + input3);
                        result2 = result1 + Convert.ToDouble(input3);
                    }
                    //sätter en else if(eller om)
                    //  Action2 är - så ska  man göra det som står under
                    else if (action2 == '-')
                    {
                        //omvandlar input3 till double och subtraherar resultatet ifrån input 1 och 2
                        Console.WriteLine(result1.ToString() + '-' + input3);
                        result2 = result1 - Convert.ToDouble(input3);
                    }
                    //sätter en else if(eller om)
                    //  Action2 är * så ska  man göra det som står under
                    else if (action2 == '*')
                    {
                        //omvandlar input3 till double och multiplicerar med input2 så att datorn prioriterar * i ekvationen
                        Console.WriteLine(result1.ToString() + '*' + input3);
                        result2 = Convert.ToDouble(input3) * result1 ;
                    }
                    //sätter en else if(eller om)
                    //  Action2 är / så ska  man göra det som står under
                    else if (action2 == '/')
                    {
                        //omvandlar input3 till double och dividerar resultatet ifrån input 1 och 2
                        Console.WriteLine(result1.ToString() + '/' + input3);
                        result2 = result1 / Convert.ToDouble(input3);

                    }




                    // Visar i vilken årdning där resultatet ska skrivas ut
                    Console.WriteLine(input1 + action1 + input2 + action2 + input3 + " = " + result2);

                    //Ger två valmöjligheter att startaomprogrammet eller avluta
                    Console.WriteLine("Om du vill köra om programmet tryck ( y ) för att avlsluta tryck ( n )");
                    restart = Console.ReadKey().KeyChar;


                    //Gör en if( om ) man trycker på n ska programmet avslutas
                    if (restart == 'n')
                    {
                        Environment.Exit(0);
                    }

                }
            }

        }
    }
}
