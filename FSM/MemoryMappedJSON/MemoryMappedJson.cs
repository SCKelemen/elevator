using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.MemoryMappedFiles;


namespace MemoryMappedJSON
{
    public class MemoryMappedJson
    {
        private string _path;
        private string _ext;
        private MemoryMappedFile _mmf;
        public MemoryMappedJson(string path)
        {
            string ext = System.IO.Path.GetExtension(path);
            if (!string.Equals(ext, "json", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("File most have a .JSON extension.");
            }
            _ext = ext;
            _path = System.IO.Path.GetFullPath(path);
            _mmf = MemoryMappedFile.CreateFromFile(_path, FileMode.Open);
        }
    }
}

