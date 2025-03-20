using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_1
{
    internal class Engine
    {
        private bool _isEngineOn = false; // Attribut, privat, flyttet fra klassen Car.

        public bool IsEngineOn
        {
            get { return _isEngineOn; }
            set { _isEngineOn = value; }
        }
    }
} 
