using System;
using System.Collections.Generic;
using System.Text;

namespace workshop2.View
{
    class View
    {

        //a function that create a controller and pass to it the retured string of the input
        public void ihm ()
        {
            Controller.Controller c = new Controller.Controller();
            string msg = getUserInput();
            c.lowerToUper(msg);
        }

        //a function that return the string of the input msg
        public string getUserInput()
        {
            Console.Write("Ecrire un message : ");
            return Console.ReadLine();
        }

    }
}
