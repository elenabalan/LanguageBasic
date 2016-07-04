using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasic
{
    class Program
    {
        
        struct Coordonates 
        {
            public int x { get; set; }
            public int y;
            public int DoublingY(int y)
            {
                y *= 2;
                return y;
            }
        }

        static void DoublingX(ref Coordonates coor)
        {
            coor.x *= 2;
        }

        static void OperationOutTest(out int outT)
        {
            //Some logic
            outT = 777;
           
        }
        
        static void Main(string[] args)
        {

            // ----   REFERINTE Ex. Class   ------  STATIC   -------
            Console.WriteLine("**************REFERINTE**********************");
            Console.WriteLine();
            Console.WriteLine("LA INCEPUTUL RULARII APLICATIEI");
            Console.WriteLine("Nr de instante a clasei Experiment {0}", Experiment.count);
            Console.WriteLine("Suma totala a valorilor instantelor ale clasei Experiment {0}", Experiment.total);
            Console.WriteLine();

            Experiment inst1 = new Experiment(10,5);
            Experiment inst2 = new Experiment(15,7);

            Experiment inst3 = inst2;  //s-a creat copia a referintei, nu si instanta.

            inst2.Plus10Test();
            Console.WriteLine("Modificam instanta cu ajutorul referintei inst2 => modificarile se reflecta si prin inst3");
            Console.WriteLine("inst2.intTest = {0}, inst3.intTest = {1}", inst2.intTest, inst3.intTest);
            Console.WriteLine();

            Console.WriteLine("Folosirea field-urilor si metodelor STATICE");
            Console.WriteLine("Nr de instante a clasei Experiment {0}", Experiment.count);
            Console.WriteLine("Suma totala a valorilor instantelor clasei Experiment {0}", Experiment.total);
            Console.WriteLine("Valoarea medie a valorilor instantelor clasei Experiment {0}", Experiment.Media());
            Console.WriteLine();


            //-----   VALUE TYPE   -------  STRUCTURILE -----
            
            Coordonates k = new Coordonates();
            k.x = 10;
            k.y = 20;

            //Cream o structura prin copierea unei existente
            Coordonates k1 = k;
            if (k1.x == k.x && k1.y == k.y)
                Console.WriteLine("Instantele structurilor k si k1 sunt EGALE");
            else Console.WriteLine("Instantele structurilor k si k1 sunt DIFERITE");

            k1.x = 50;
            if ((k1.x == k.x) & (k1.y == k.y))
                Console.WriteLine("Instantele structurilor k si k1 sunt EGALE");
            else Console.WriteLine("Instantele structurilor k si k1 sunt DIFERITE");
            Console.WriteLine();

            Console.WriteLine("**************PARAMETER MODIFIER**********************");
            //   -----    PARAMETER MODIFIER   REF  -------   
            Console.WriteLine("PARAMETER MODIFIER REF");
            Coordonates d = new Coordonates();
            d.x = 100;
            d.y = 1000;
            Console.WriteLine("d.x = {0}, d.y = {1}", d.x, d.y);

            DoublingX(ref d);  //la intrare in functie nu se face copia a instantei. Modificarile se aplica chiar in instanta existenta
            Console.WriteLine("d.x = {0}, d.y = {1}", d.x, d.y);
            Console.WriteLine();

            //   -----    PARAMETER MODIFIER   OUT  -------   
            Console.WriteLine("PARAMETER MODIFIER OUT");

            int outTest;
            //Console.WriteLine("outTest = {0}", outTest);  //Da error, pentru ca variabila outTest nu este initializata

            OperationOutTest(out outTest);
            Console.WriteLine("outTest = {0}", outTest);
            Console.WriteLine();

            //   -----    PASSING ARGUMENTS BY VALUE  -------   
            Console.WriteLine("PASSING ARGUMENTS BY VALUE");
            Console.WriteLine("DoublingY() = {0}", d.DoublingY(d.y));
            Console.WriteLine("d.y = {0}", d.y);
            Console.WriteLine();

            Console.WriteLine("**************   BOXING   **********************");

            Console.WriteLine("Cind are loc boxing, atunci se face o copie a instantei");
            short b = 33;
            //int b = 33;
            object ob = b;
            b = 555;
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("ob = {0}, valoarea obiectului a ramas cea atribuita in momentului copierii", ob);
            Console.WriteLine();

            //  ------------- UNBOXING  ---------------
            Console.WriteLine("**************   UNBOXING   **********************");
            int j = 0;
            try
              {
                  j = (int) ob;  // attempt to unbox

                  Console.WriteLine("Unboxing OK.");
              }
              catch (InvalidCastException e)
              {
                  Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
              }
            Console.WriteLine("j = {0}", j);

            Console.ReadKey();


           
        }

        
    }
}
