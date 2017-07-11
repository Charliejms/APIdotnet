using System;
namespace APIdotNet.V2.Models
{
    public class Movie
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public String Category { get; set; }

        //Contructor 
        public Movie()
        {
        }
    }
}
