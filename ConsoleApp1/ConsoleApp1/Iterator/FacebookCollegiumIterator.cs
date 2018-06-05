using ConsoleApp1.Social;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Iterator
{
    public class FacebookCollegiumIterator : iIterator
    {
        public object getNext()
        {
            if (friends[position].isCollegia) return friends[position++];
            this.position++;
            return null;
        }

        public bool HasMore()
        {
            if (position >= friends.Count || friends[position] == null) return false;
            return true;
        }

        List<Human> friends = null;
        int position = 0;
        public FacebookCollegiumIterator(List<Human> human)
        {
            this.friends = human;
        }
    }
}
