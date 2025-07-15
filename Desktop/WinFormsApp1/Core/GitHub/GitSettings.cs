using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Core.GitHub
{
    internal class GitSettings : IParserSettings
    {
        public GitSettings(int start,int end)
        { 
            StartPoint=start;
            EndPoint=end;
        }
        public string BaseUrl { get; set; } = "https://habr.com";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
