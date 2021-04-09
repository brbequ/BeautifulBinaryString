using System;

class Solution
{
    // Alice has a binary string. She thinks a binary
    // string is beautiful if and only if it doesn't
    // contain the substring "010".

    // In one step, Alice can change a 0 to a 1 or vice
    // versa. Count and print the minimum number of steps
    // needed to make Alice see the string as beautiful.

    // Example
    // b = 010
    // She can change any one element and have a beautiful
    // string.

    // Complete the beautifulBinaryString function below.
    static int beautifulBinaryString(string b)
    {
        int changes = 0;

        for (int idx = 0; idx < b.Length - 2; idx++)
        {
            if (b[idx] == '0' && b[idx+1] == '1' && b[idx+2] == '0')
            {
                changes++;
                idx += 2;
            }
        }

        return changes;
    }

    static void Main(string[] args)
    {
        string[] testcases = new string[]
        {
            "01100",        // Expect 0
            "0100101010",   // Expect 3
            "0101010",      // Expect 2
            "0100101010100010110100100110110100011100111110101001011001110111110000101011011111011001111100011101", // Expect 10
        };

        foreach(string testcase in testcases)
        {
            int result = beautifulBinaryString(testcase);

            Console.WriteLine(result);
        }
    }
}
