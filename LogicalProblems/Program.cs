using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms;

internal class ProgramsList
{
    // Ensures user inputs a +ve integer
    public static int GetPositiveInt(string message)
    {
        int n;
        string input;
        bool IS_INT32;
        do
        {
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
                IS_INT32 = Int32.TryParse(input, out n);
            } while (IS_INT32 is false);
            n = Convert.ToInt32(input);
        } while (n < 0);
        return n;
    }

    
}







