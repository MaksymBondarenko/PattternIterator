using ConsoleApp1.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.Social
{
  public  class SocialSpammer
    {
        Facebook facebook = null;
        public SocialSpammer(Facebook facebook)
        {
            this.facebook = facebook;
        }

        public void Send()
        {
            iIterator iterator_all = facebook.CreateAllFriendIterator();
            iIterator iterator_col = facebook.CreateCollegiumIterator();
            SendView(iterator_all);
            SendView(iterator_col);
        }

        public void SendView(iIterator it)
        {
            WriteLine(it.GetType().Name);
            WriteLine();
            while (it.HasMore())
            {
                Human human = it.getNext() as Human;
                if (human != null)
                {
                    Console.WriteLine(human.ToString());
                }
            }
        }
    }
}

