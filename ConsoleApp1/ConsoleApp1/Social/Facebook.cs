using ConsoleApp1.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Social
{
  public  class Facebook
    {
        public List<Human> humans = null;
        public Facebook()
        {
            humans = new List<Human>();
            this.ConnectToData();
        }

        public void ConnectToData()
        {
            humans.AddRange(new Human[]
            {
                new Human(30, 1, "Maksym", "Bondarenko", true),
                new Human(20, 2, "Koly", "Grigorenko", false),
                new Human(55, 3, "Petya", "Poroshenko", false),
                new Human(19, 4, "Vlad", "Shapoval", true),
                new Human(25, 5, "Valentin", "Prydko", true),
            });
        }

        public iIterator CreateAllFriendIterator()
        {
            return new AllFriendsIterator(humans);
        }

        public iIterator CreateCollegiumIterator()
        {
            return new FacebookCollegiumIterator(humans);
        }
    }
}

