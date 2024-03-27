using System.Text;
using Thread_Files.Services.Interfaces;

namespace Thread_Files.Services
{
    public class FileService : IFileService
    {
        public async Task WriteToExistFileAsync(string path, string text)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter wr = new StreamWriter(fs))
                {
                    await wr.WriteAsync(text);

                }

            }

            //"C:\\Workspace Code Academy\\Thread-Files\\file1.txt"
        }

        public async Task<string> ReadFromFileAsync(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    return await sr.ReadToEndAsync();

                }
            }
        }

        public async Task WriteToNewFileAsync(string path, string text)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = new(path, FileMode.CreateNew, FileAccess.Write))
                    {
                        byte[] datas = Encoding.UTF8.GetBytes(text);

                        await fs.WriteAsync(datas, 0, datas.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task DeleteAsync(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
