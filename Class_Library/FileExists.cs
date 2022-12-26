namespace Class_Library
{
    public class FileExists
    {
      public bool File_Exists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(fileName);
        }
    }
}