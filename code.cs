using System;

namespace Calculator
{
   class calc
    {
        int A;
        int B;

       int main()
        {
            bool stop = false;
            string input;
            while (stop = true)
            {
                input = console.ReadLine();
                step2 (input);
            }


            string step2 (string input)
            {

                getAandB();
                switch (input)
                {
                    case "+":
                        getPlus ();
                        break;

                    case "-":
                        getMinus () ;
                        break;

                    case "*":
                        getUmn () ;
                        break;
                    
                    case "/":
                        getDel () ;
                        break;


                }
            }

             void getAandB()
            {
                console.WriteLine("Text the A number");
                A = console.ReadLine();
                console.WriteLine("Text the A number");
                B = console.ReadLine();
            }
           
            void getPlus()
            {
                int result = A + B;
                console.WriteLine(result);
            }
        
            void getMinus()
            {

            }
            void getUmn()
            {

            }
            void getDel()
            {

            }
        
        }


}