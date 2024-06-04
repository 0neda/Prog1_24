using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.Utils
{
    public class ExportToFile
    {
		private const string dir = @"/home/oneda/Área de trabalho/Faculdade/Prog1_24/Exercícios/240401_01/dados_excel";
        
        public static bool SaveToDelimitedTxt(string fileName, string fileContent)
        {
            string filePath = @$"{dir}/{fileName}";

            try
            {
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                using(StreamWriter sw = File.CreateText(filePath))
                {
                    sw.Write(fileContent);
                }
            }
            
            catch
            {
                return false;
            }
            
            
            
            
            return true;
        }
    }
}