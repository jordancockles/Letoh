using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Letoh_HMS
{
    public class TextReportGenerator
    {
        public void GenerateReport(IDisplay obj, String filePath)
        {
            FileStream outFile;
            StreamWriter writer;

            outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            writer = new StreamWriter(outFile);

            writer.WriteLine(obj.Display());

            writer.Close();
            outFile.Close();
        }
    }
}
