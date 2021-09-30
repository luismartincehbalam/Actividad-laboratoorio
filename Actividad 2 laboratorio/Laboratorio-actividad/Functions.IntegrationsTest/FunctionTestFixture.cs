using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net.Http;
using Function.Integrations;

namespace Functions.IntegrationsTest
{
   public class FunctionTestFixture : IDisposable
    {
        private Process _functionprocess;
        private int _port = 7071;
        public HttpClient Client = new HttpClient();

        public FunctionTestFixture()
        {
            var dotnet = Environment.ExpandEnvironmentVariables(Helper.Settings.DotnetExPath);
            var functionHost = Environment.ExpandEnvironmentVariables(Helper.Settings.FunctionHostPath);
            var folderFunction = Environment.ExpandEnvironmentVariables(Helper.Settings.FunctionApplicationPath);

            _functionprocess = new Process
            {
                StartInfo =
                {
                    FileName = dotnet,
                    Arguments = $"\"{functionHost}\" start -p {_port}",
                    WorkingDirectory = folderFunction }
            };
            var success = _functionprocess.Start();
            Client.BaseAddress = new Uri($"http://localhost: {_port}");
        }


        public void Dispose()
        {
            if (!_functionprocess.HasExited) 
            {
                _functionprocess.Kill();
            }
            _functionprocess.Dispose();
        }
    }
}
