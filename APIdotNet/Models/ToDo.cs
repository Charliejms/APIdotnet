using System;
namespace APIdotNet.Models
{
    public class ToDo
    {
		public long Id { get; set; }
		public string Name { get; set; }
		public bool IsComplete { get; set; }

        //Constuctor 
        public ToDo(){}
    }
}
