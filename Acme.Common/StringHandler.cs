namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// insert space before each capital letter in a string 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpace(this string source)
        {
            string result = String.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (Char.IsUpper(letter)) {
                        result = result.Trim();
                        result += " ";
                    }
                    result+=letter;
                }
            }
            
            return result.Trim();
        }
    }
}