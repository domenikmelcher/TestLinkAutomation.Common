using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plossum.CommandLine;

namespace TestLinkAutomation.Common.CommandLine
{
    [CommandLineManager()]
    public class CommandLineOptionsBase
    {
        [CommandLineOption(Description = "Displays this help text")]
        public bool Help = false;

        [CommandLineOption(Description = "Specifies the output file path")]
        public string output_path
        {
            get { return output_string; }
            set
            {
                output_string = value;
            }
        }

        private string output_string;        
    }
}
