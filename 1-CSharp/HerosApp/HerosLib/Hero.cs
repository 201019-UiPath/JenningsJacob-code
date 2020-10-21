using System;
using System.Collections.Generic;

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
        #region arrays
        // public string[] superPowers = new string[10]; // 1D array
        // jagged array
        // public int[][] ja = new int[3][];
        #endregion
        public static Stack<string> superPowers = new Stack<string>();       // Stack -> LIFO

        public static Dictionary<string, string> hideOut = new Dictionary<string, string>();
        public Hero()
        {
            superPowers.Push("Strength");
            superPowers.Push("Fly");
            superPowers.Push("Invisibility");
            superPowers.Push("Telekenisis");

            // hideOut.Add("Batman", "Bat Cave");
            // hideOut.Add("Thor", "Asgard");
            // hideOut.Add("Black Panther", "Wakanda");
        }
        public static IEnumerable<string> GetSuperPowers() {
            return superPowers;
        }

        public static void RemoveSuperPower(){//string superPower){
            // if(superPowers.Contains(superPower))
            //     superPowers.Remove(superPower);
            superPowers.Pop();
        }
        public void AddSuperPower(string superPower){
            if(superPowers != null && superPower != ""){
                superPowers.Push(superPower);
            }
        }
    }
    #endregion
}
