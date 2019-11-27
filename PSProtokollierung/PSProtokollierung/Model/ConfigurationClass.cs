using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSProtokollierung.Model
{
    public class ConfigurationClass
    {
        private List<string> _protList = new List<string>();
        private string _praesident;

        public List<string> ProtLost
        {
            get { return _protList; }
            set { this._protList = value; }
        }

        public string Praesident
        {
            get { return _praesident; }
            set { this._praesident = value; }
        }
    }
}
