using System;
using System.Collections.Generic;
using System.Text;

namespace workshop2.Controller
{
    class Controller
    {

        //a function that Uper strings passed into parameters 
        // and save the string input to the model 
        // and then display to the console the value of the new msg , the updated msg as response from the model 
        //if the string pass the condition
        public void lowerToUper(string msg)
        {

            if (msg.Length <= 8 && msg.Length >= 1 )
            {
                Model.Model m = new Model.Model();
                string newString = m.str(msg);
                Console.WriteLine(newString.ToUpper());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("BAD INPUT");
            }
        }

    }
}
