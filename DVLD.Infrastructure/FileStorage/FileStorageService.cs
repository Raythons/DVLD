using DLVD.App.Interfaces;

namespace DVLD.Infrastructure.FileStorage
{
    public class LocalFileStorageService : IFileStorageService
    {
        private readonly string _uploadPath = "C:\\Users\\H1202\\Desktop\\ASP.CORE\\DVLD\\DVLD.Client\\public";
        
        public async Task<string>  SaveFileAsync(byte[] fileBytes)
        {
            string fileName = GenerateFileName(fileBytes);
            var isSaved = await SaveFileToStorage(fileBytes, fileName);
            if (!isSaved)
                throw new Exception("couldn't  do it boss");
            
            return fileName;
        }
        private async Task<bool> SaveFileToStorage(byte[] fileBytes, string fileName)
        {
             string fileAbsolutePath = Path.Combine(_uploadPath, fileName);

            using var fileStream = new FileStream(fileAbsolutePath, FileMode.Create);

            await fileStream.WriteAsync(fileBytes);
            return true;
        }
        private static string GenerateFileName(byte[] fileBytes)
        {
            string fileExtension = FileExtesnionHelper.TryGetExtension(fileBytes);

            var randomString = Guid.NewGuid().ToString().Replace("-", "");
            string FileName = randomString +  "." + fileExtension;
            return FileName;
        }

        private string GetStoragePath() =>  _uploadPath;
        
        public string CombinePathAndFile(string fileName)
        {
            return GetStoragePath() + fileName;
        }

    }
}
