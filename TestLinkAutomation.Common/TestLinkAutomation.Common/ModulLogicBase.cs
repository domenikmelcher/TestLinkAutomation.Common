using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestLinkAutomation.Common.CommandLine;
using Plossum.CommandLine;

namespace TestLinkAutomation.Common
{
    public abstract class ModulLogicBase<T> where T : CommandLineOptionsBase
    {
        protected T CommandLineOptions { get; set; }

        public virtual void InitializeModul()
        {
            InitializeCommandLineOptions();
        }

        public abstract void ExecuteModulLogic();        

        public abstract void Save();

        protected abstract void ExecutePreProcessing();     

        private void InitializeCommandLineOptions()
        {
            CommandLineParser parser = new CommandLineParser(CommandLineOptions);
            parser.Parse();

            if (CommandLineOptions.Help)
            {
                Console.WriteLine(parser.UsageInfo.GetOptionsAsString(90));
                Environment.Exit(0);
            }
            else
                if (parser.HasErrors)
                {
                    Console.WriteLine(parser.UsageInfo.GetErrorsAsString(90));
                    Environment.Exit(-1);
                }
        }
    }
}
