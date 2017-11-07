using System;
using System.Collections.Generic;
using System.Text;

namespace TowerOfHanoi
{
    class Tower
    {
        Stack<Disk> Left = new Stack<Disk>();
        Stack<Disk> Mid = new Stack<Disk>();
        Stack<Disk> Right = new Stack<Disk>();

        public Tower(int n)
        {
            for (int i=1; i<=n; i++)
            {
                Left.Push(new Disk(i));

            }
            if (n %2 == 0 )
            {
                MoveEven();
            }
            else
            {
                MoveOdd();
            }
        }

        private void MoveOdd()
        {
            while(Left != null & Mid != null)
            {
                Right.Push(Left.Pop());
                if((Left != null & Right != null) & Mid == null)
                {
                    Mid.Push(Left.Pop());
                }
                if(Left > Mid & Right == null)
                {
                    Right.Push(Left.Pop());
                }
                if(Left > Mid & Left > Right)
                {
                    Mid.Push(Right.Pop());
                }
                if(Left = null & Mid < Right)
                {
                    Left.Push(Mid.Pop());
                }
                if(Mid > Right)
                {
                    Right.Push(Mid.Pop());
                }
                if(Left < Right)
                {
                    Right.Push(Left.Pop());
                }
                
            }
        }
        private void MoveEven()
        {

        }

    }

    class Disk
    {
        int value;
        public Disk(int newValue)
        {
            value = newValue;
        }
    }
}
