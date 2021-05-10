using System;

namespace CarbonTechnologies
{
    public static class StringManipulator
    {

        /// <summary>
        /// Finds the string in between.
        /// Ex:
        /// mainstring = "This is a bunch of instance words.",
        /// firstring = "This is a",
        /// secondstring = "instance",
        /// RETURNS: " bunch of "
        /// </summary>
        /// <param name="mainstring">This is the string main string that will be searched</param>
        /// <param name="firststring">First string (will be excluded from the returning string)</param>
        /// <param name="secondstring">Second string (will be excluded from the returning string)</param>
        /// <returns>Return the string between 1st and 2nd strings on mainstring</returns>
        public static string FindStringBetween2Strings(string mainstring, string firststring, string secondstring)
        {
            int startingindex = mainstring.IndexOf(firststring) + firststring.Length;
            int lastindex = mainstring.IndexOf(secondstring);

            return mainstring.Substring(startingindex, lastindex - startingindex);
                       
        }


    }
}
