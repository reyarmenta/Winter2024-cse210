using System;
using System.Diagnostics;
using Develop03;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}