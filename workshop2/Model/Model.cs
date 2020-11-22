using System;
using System.Collections.Generic;
using System.Text;

namespace workshop2.Model
{
    class Model
    {
        //the model just return the msg passed into its parameter as an exemple for a model 
        //in this case we dont need a model
        //just to show how the data flow works from the view to the controller and then to the model 
        public string str(string lowerMsg) 
        {
            return lowerMsg;
        }
    }
}
