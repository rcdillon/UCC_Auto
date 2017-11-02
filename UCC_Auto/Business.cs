using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCC_Auto
{
    public class Business
    {
        //Data members
        private string location;
        private string manager;

        //Default Construtor
        public Business()
        {

        }
        
        //Getter methods
        public string getLocation()
        {
            return location;
        }

        public string getManager()
        {
            return manager;
        }


        //Setter methods
        public void setLocation(string location)
        {
            this.location = location;
        }

        public void setManager(string manager)
        {
            this.manager = manager;
        }
        

    }
}
