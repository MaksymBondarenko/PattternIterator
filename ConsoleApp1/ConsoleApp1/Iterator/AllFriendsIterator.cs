using ConsoleApp1.Social;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Iterator
{
    public class AllFriendsIterator : iIterator
    {
        public object getNext()
        {
            return friends[position++];
        }

        public bool HasMore()
        {
            if (position >= friends.Count || friends[position] == null) return false;
            return true;
        }

        List<Human> friends = null;
        int position = 0;
        public AllFriendsIterator(List<Human> human)
        {
            this.friends = human;
        }
    }
}
