namespace Thread_Files.Extensions
{
    public static class FileExtension
    {
        public static string GenerateFullPath(this string path, string fileName)
        {
            return $"{path}\\{fileName}";
        }
    }
}
