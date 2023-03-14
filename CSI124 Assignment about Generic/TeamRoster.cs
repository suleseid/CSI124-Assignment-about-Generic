using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI124_Assignment_about_Generic
{
    internal class TeamRoster<T> where T : Player
    {
       public List<T> _roaster = new List<T>();  

        //Build a method to Add a player to our roaster

        public void AddPlayer(T player)
        {
            _roaster.Add(player);
        }
        public double TeamSalary()
        {
            double sum=0;
            // foreach (Type itemName in the List)
            foreach (T playerOblect in _roaster)
            {
                sum += playerOblect.Salary;
            }
            return sum;
          
           
        }
    }
}
