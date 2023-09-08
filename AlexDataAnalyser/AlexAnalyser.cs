using Contract;
using System;
using System.Collections.Generic;

namespace AlexDataAnalyser
{
    public class AlexAnalyser : IDataAnalyser
    {
        public string Author => "Alex";

        public string Path
        {
            get;
            private set;
        }

        public IEnumerable<string> GetTopTenStrings(string path)
        {
            string[] result = { "aa", "bb", "cc", "dd" };
            return result;
        }

        public AlexAnalyser(string path)
        {
            this.Path = path;
        }
    }
}
