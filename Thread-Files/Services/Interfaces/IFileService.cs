namespace Thread_Files.Services.Interfaces
{
    public interface IFileService
    {
        Task WriteToExistFileAsync(string path, string text);
        Task<string> ReadFromFileAsync(string path);
        Task WriteToNewFileAsync(string path, string text);
        Task DeleteAsync(string path);
    }
}
