using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_STP
{
    class Book
    {
        protected string name, author, year;
        protected bool inlib;

        public virtual void StatusChange()
        { }
    }

    class Library : Book
    {
        protected enum TypeSearch : int {name=1, aythor, year, inlib};
        private static int count = 0; 
        public Library()
        {}

        public Library (string name, string author, string year)
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.inlib = true;
        }
        public override void StatusChange()
        {
            this.inlib = !this.inlib;

        }

        //public string  Search_Code(string Unicode)
        //{
        //    for (int i = 0; i< CodeBook.Length; i++)
        //    {
        //        string err = "НЕ НАЙДЕНО";
        //        if (CodeBook[i] == Unicode)
        //            return Unicode;
        //        else return err;
                  
        //    }
        //}
        //public string Search_Name(string Name)
        //{
        //    for (int i = 0; i < NameBook.Length; i++)
        //    {
        //        string err = "НЕ НАЙДЕНО";
        //        if (NameBook[i] == Name)
        //            return Name;
        //        else return err;

        //    }
        //} 
        //public void Data()
        //{

        //} 
        //public void changeStatus()
        //{
        //    InLib = !InLib;
        //}
        //public string getName()
        //{
        //    return name;
        //}
        //public bool getInLib()
        //{
        //    return InLib;
        //}
    }

    class SchoolLib : Library
    {
        protected List<Book> book;
        protected List<Book> tmp;
        
        void AddBook(string n, string a, string y)
        {
            book.Add(new Library(n, a, y));
        }

        void FindBook(string s, TypeSearch t)
        {
            foreach (SchoolLib l in book)
            {
                switch (t)
                {
                    //case 1:

                    //break;
                }
            }
        }
    }
}
