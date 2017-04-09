using System.Linq;

namespace OrganizeMusic
{
    static class Validate
    {
        public static bool HasSpecialCharacters(ref string str)
        {
            return str.Any(ch => !char.IsLetterOrDigit(ch));
        }

        public static bool validateInputDirectory(string directory)
        {
            if (!System.IO.Directory.Exists(directory))
            {
                throw new System.ArgumentException(("Invalid Input Directory: " + directory), "inputDirectory");
            }
            return true;
        }

        public static bool validateOutputDirectory(string directory)
        {
            try
            {
                if (!System.IO.Directory.Exists(directory))
                {
                    System.IO.Directory.CreateDirectory(directory);
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
