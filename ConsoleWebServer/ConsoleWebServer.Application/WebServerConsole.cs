﻿namespace ConsoleWebServer.Application
{
    using System;
    using System.Linq;
    using System.Text;
    using ConsoleWebServer.Framework;

    public class WebServerConsole
    {
        private readonly ResponseProvider responseProvider;

        public WebServerConsole()
        {
            this.responseProvider = new ResponseProvider();
        }

        public void Start()
        {
            var requestBuilder = new StringBuilder();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    HttpResponse response = this.responseProvider.GetResponse(requestBuilder.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(response);
                    Console.ResetColor();
                    requestBuilder.Clear();
                    continue;
                }

                requestBuilder.AppendLine(inputLine);
            }
        }
    }
}