using System;
using System.Collections.Generic;
using System.Text;

namespace Function.Integrations
{
   public class Settings
    {
        public string DotnetExPath { get; set; }
        public string FunctionHostPath { get; set; }
        public string FunctionApplicationPath { get; set; }
        public string AzureWebJobsStorage { get; set; }
    }
}
