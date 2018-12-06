using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyTunes.Shared
{
    public interface IStreamLoader
    {
        Stream GetStreamForFilename(string filename);
    }
}
