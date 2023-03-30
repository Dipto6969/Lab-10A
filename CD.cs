using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_A
{
    public class CD : Item

       
    {
        public CD(string id, string title, string author, string category, bool isAvailable, string Artists, int numTracks ) : base(id, title, author, category, isAvailable)
        {
            this._Artists = Artists;
           this. _numTracks = numTracks;
        }

        public override bool IsAvailable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string _Artists;

        public int _numTracks { get; }
    }
}
