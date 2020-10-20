using System;

namespace HerosLib
{
    public class Hero
    {
        // int id; // value type => System.Int32
        // public int Id{
        //     get{
        //         return id;
        //     }
        //     set{
        //         id = value;
        //     }
        // }
        public int Id{get;set;}
        string name; // reference type => System.String
        // Constructor
        public Hero() {
            Id = 1;
            name = "Dr. Strange";
        }
        // snippet: ctor + <tab>
        public Hero(int id, string name)
        {
            this.Id = id;
            this.name = name;
        }

    }
}
