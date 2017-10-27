using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCC_Auto
{
    public class Business
    {
        private string location;
        private string manager;

        public Business()
        {

        }
        
        public string getLocation()
        {
            return location;
        }

        public string getManager()
        {
            return manager;
        }

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
