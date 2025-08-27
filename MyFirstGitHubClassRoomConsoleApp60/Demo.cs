using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Demo
    {
        public string Navn { get; set; }
        public int Id { get; set; }

        public Demo(string navn, int id)
        {
            Navn = navn;
            Id = id;
        }

        public override string ToString()
        {
            return "Demonavn: " + Navn + "og ID:" + Id;
        }
    }
}
