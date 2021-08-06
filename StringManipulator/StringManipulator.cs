using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace CarbonTechnologies
{
    /// <summary>
    /// Main static class for string manipulation
    /// </summary>
    public static class StringManipulator
    {
        /// <summary>
        /// Finds the string in between.
        /// Ex1:
        /// mainstring = "This is a bunch of instance words.",
        /// firstring = "This is a",
        /// secondstring = "instance",
        /// RETURNS: " bunch of "
        /// </summary>
        /// <param name="mainstring">This is the string main string that will be searched</param>
        /// <param name="firststring">First string (will be excluded from the returning string)</param>
        /// <param name="secondstring">Second string (will be excluded from the returning string)</param>
        /// <returns>Return the string between 1st and 2nd strings on mainstring</returns>;
        public static string FindStringBetween2Strings(string mainstring, string firststring, string secondstring)
        {
            int startingindex = mainstring.IndexOf(firststring) + firststring.Length;
            int lastindex = mainstring.IndexOf(secondstring);

            return mainstring.Substring(startingindex, lastindex - startingindex);
        }

        /// <summary>
        /// Return pure file name from full path information. Ex. FullPath: "C:\Users\Public\myfilet.txt", RETURNS: "myfile.txt"
        /// </summary>
        /// <param name="FullPath">Full path of the file</param>
        /// <returns>File name with extension</returns>
        public static string GetFileNameFromFullPath(string FullPath)
        {
            int startingindex = FullPath.LastIndexOf(@"\");

            return FullPath.Substring(startingindex).Replace(@"\", "");

        }

        /// <summary>
        /// Returns the text removed version of the main string."
        /// </summary>
        /// <param name="MainString">Main String</param>
        /// /// <param name="StringToBeRemoved">The Text/String which will be removed from the Main String</param>
        /// <returns>File name with extension</returns>
        public static string RemoveTextFromString(string MainString, string StringToBeRemoved)
        {
            return MainString.Replace(StringToBeRemoved, "");
        }






        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// Writes a Key-Value pair to a file
        /// </summary>
        /// <param name="FilePath">File path of the file. Creates if there is not file. You should have admin priviliges in the path</param>
        /// <param name="Key">Key string paired for the value to be stored</param>
        /// <param name="Value">String value to be stored</param>
        /// <returns>Returns true if writing process is successful</returns>
        public static bool WriteKeyToFile(string FilePath, string Key, string Value)
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    FileStream fileStream = File.Create(FilePath);
                    fileStream.Close();
                }

                WritePrivateProfileString("LocalStrings", Key, Value, FilePath);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            if (Value == ReadKeyFromFile(FilePath, Key))
                return true;
            else
                return false;
        }



        /// <summary>
        /// Reads a Key-Value pair from a file
        /// </summary>
        /// <param name="FilePath">File path of the file. Returns null . You should have admin priviliges in the path</param>
        /// <param name="Key">Key paired for the desired value</param>
        /// <returns>String value for the Key. Returns "-1" if there is no file in path</returns>
        public static string ReadKeyFromFile(string FilePath, string Key)
        {
            try
            {
                StringBuilder temp = new StringBuilder(255);

                if (!File.Exists(FilePath))
                    return "-1";

                int i = GetPrivateProfileString("LocalStrings", Key, "", temp, 255, FilePath);
                return temp.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }





    }
}
