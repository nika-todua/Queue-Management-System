using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba
{
    internal class Client
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Client(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Client {Id}: {Name}";
        }

    }
}
