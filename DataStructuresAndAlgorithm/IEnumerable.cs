using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithm
{
    public class IEnumerable:IEnumerable<string>
    {
        private string _filePath;
        public StramReaderEnumerable(string filePath)
        {
            _filePath = filePath;
        }
    }
}
