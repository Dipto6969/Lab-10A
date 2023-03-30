using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_A
{
    public class Book : Item
    {
        private string _isbn;
        private int _numPages;

        public Book(string id, string title, string author, string category, bool isAvailable, string isbn, int numPages) : base(id, title, author, category, isAvailable)
        {
            this._isbn = isbn;
            this._numPages = numPages;
        }

        public string isbn { get; set; }
        public int numPages { get; set; }

        public override bool IsAvailable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
