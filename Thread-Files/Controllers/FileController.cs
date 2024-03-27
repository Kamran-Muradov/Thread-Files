using System.Reflection;
using Thread_Files.Extensions;
using Thread_Files.Services;
using Thread_Files.Services.Interfaces;

namespace Thread_Files.Controllers
{
    public class FileController
    {
        private readonly IFileService _fileService;

        public FileController()
        {
            _fileService = new FileService();
        }

        public async Task ReadDataAsync()
        {
            string result = await _fileService.ReadFromFileAsync("C:\\Workspace Code Academy\\Thread-Files\\file1.txt");
            Console.WriteLine(result);

            var data = AppDomain.CurrentDomain.BaseDirectory;

            var datas = data.Split("\\");

            var res = string.Empty;

            foreach (var item in datas)
            {
                if (item != "Workspace Code Academy")
                {
                    res += item + "\\";
                }
                else
                {
                    break;
                }

                res += "Workspace Code Academy";

            }

            await Console.Out.WriteLineAsync(res);
        }

        //"C:\\Workspace Code Academy\\Thread-Files"

        public async Task CreateFileWithContentAsync()
        {
            var data = AppDomain.CurrentDomain.BaseDirectory;

            var datas = data.Split("\\");

            var path = string.Empty;

            foreach (var item in datas)
            {
                if (item != "Workspace Code Academy")
                {
                    path += item + "\\";
                }
                else
                {
                    break;
                }

                path += "Workspace Code Academy";

            }

            await Console.Out.WriteLineAsync("Add file name:");
            string fileName = Console.ReadLine();

            await Console.Out.WriteLineAsync("Add your text:");
            string text = Console.ReadLine();

            string resultPath = path.GenerateFullPath(fileName);
            await _fileService.WriteToNewFileAsync(resultPath, text);

        }

        public async Task DeleteFileAsync()
        {
            await _fileService.DeleteAsync("C:\\Workspace Code Academy\\Thread-Files\\file7.txt");
        }
    }
}
