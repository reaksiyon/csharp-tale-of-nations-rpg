using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   public class oyuncu
    {
       public int exp = 0;
        public int attack;
        public int level = 1;
        public int gold = 0;
        public int levelhasar = 0;
        public bool isFirst = false;
        public int Level
        {
             get
            {
                return level;
            }   
         
        }

        public oyuncu()
        {
            Random rnd = new Random();
            attack = rnd.Next(1, 15) + 15 + levelhasar;
        }
    }
}
