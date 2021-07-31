using System;

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

            return FullPath.Substring(startingindex).Replace(@"\","");

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



    }
}
