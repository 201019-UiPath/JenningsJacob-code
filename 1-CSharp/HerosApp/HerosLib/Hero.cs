using System;

namespace HerosLib
{
    #region old way of creating class members
    // public class Hero
    // {
    //     // int id; // value type => System.Int32
    //     // public int Id{
    //     //     get{
    //     //         return id;
    //     //     }
    //     //     set{
    //     //         id = value;
    //     //     }
    //     // }
    //     public int Id{get;set;} // automatic properties
    //     string name; // reference type => System.String
    //     // Constructor
    //     public Hero() {
    //         Id = 1;
    //         name = "Dr. Strange";
    //     }
    //     // snippet: ctor + <tab>
    //     public Hero(int id, string name)
    //     {
    //         this.Id = id;
    //         this.name = name;
    //     }
    // }
    #endregion
    #region modern way of creating class members
    public class Hero {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] superPowers = new string[10];
        // jagged array
        public int[][] ja = new int[3][];
    }
    #endregion
}
