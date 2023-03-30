using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_10_A
{
    public class DVD : Item
    {
        private string _director;
        private  int _length;

        public DVD(string id, string title, string author, string category, bool isAvailable, string director, int length) : base(id, title, author, category, isAvailable)
        {
            this._director = director;
            this._length = length;
        }

        public override bool IsAvailable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
