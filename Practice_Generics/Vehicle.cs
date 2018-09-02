using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Gen
{
    /// <summary>
    /// A vehicle class that takes two generics
    /// </summary>
    /// <typeparam name="K">Can be an int or double</typeparam>
    /// <typeparam name="V">Can be a DateTime or an int</typeparam>
    class Vehicle<K, V>
    {

        // Propfull
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        // Propfull
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // Propfull
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        // Propfull
        private K mpg;

        public K MPG
        {
            get { return mpg; }
            set { mpg = value; }
        }

        // Propfull
        private V vehicleAquiredDate;

        public V VehicleAquiredDate
        {
            get { return vehicleAquiredDate; }
            set { vehicleAquiredDate = value; }
        }

    }
}
