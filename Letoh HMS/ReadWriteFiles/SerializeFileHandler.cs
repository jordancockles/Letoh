using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Letoh_HMS
{
    public class SerializeFileHandler
    {
        public void SaveLetohFile(Letoh letoh, String filePath)
        {
            FileStream outFile;
            BinaryFormatter bFormatter = new BinaryFormatter();

            //Open output file
            outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //Output object to file through serialization
            bFormatter.Serialize(outFile, letoh);

            //Close file
            outFile.Close();
        }

        public Letoh LoadLetohFile(String filePath)
        {
            FileStream inFile;
            BinaryFormatter bFormatter = new BinaryFormatter();
            Letoh letoh = new Letoh();

            //Open input file
            inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            //Obtain objects from file through serialization
            letoh = (Letoh)bFormatter.Deserialize(inFile);

            inFile.Close();
            
            return letoh;
        }
    }
}
