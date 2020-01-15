using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDemo
{
    public class SourceManager
    {
        private readonly ISource sourceService;

        public SourceManager(ISource service)
        {
            sourceService = service;
        }

        public string ChangeText() { return sourceService.ChangeText(); }



    }
}
