using System;
using System.Collections.Generic;
using System.Text;

namespace Contract
{
    public interface IDataAnalyser
    {
        /// <summary>
        /// The author
        /// </summary>
        string Author { get; }
        /// <summary>
        /// The path of folder which stores data files
        /// </summary>
        string Path { get; }
        /// <summary>
        /// Analyse data and 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        IEnumerable<string> GetTopTenStrings(string path);
    }
}
