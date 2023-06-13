using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic2
{
    class project
    {
        bool equationIsBalanced(string eq, char openToke = "(", char closeToken = ")")
        {           
            int open = 0;
            int close = 0;
            for(int i = 0; i < s.Length; i++)
            {
                for(int x = 0; x < eq.Length; x++)
                {
                    if(eq[x] == openToken)
                    {
                        open++;
                    }
                    if(eq[x] == closeToken);
                    {
                        close++;
                    }
                    if(close>open){break;}
                }
                if(open != close){return false;}
                else{return true;}
            }
        }
    }
}


