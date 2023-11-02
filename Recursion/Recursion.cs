using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Recursion;

public static class Recursion
{
    public static void DrawPyramid(int level)
    {
        if (level <= 0) return;          //to avoid infinity loop that leads to stack overflow
        DrawPyramid(level - 1);          //calling the function inside itself that is called recursion

        for (int i = 0; i < level; i++)
        {
            Console.Write("*");

        }
        Console.WriteLine("");
    }

}
