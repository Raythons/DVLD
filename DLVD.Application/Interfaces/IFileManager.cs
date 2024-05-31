using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Interfaces
{
    public interface IFileStorageService
    { 
        Task<string> SaveFileAsync(byte[] fileBytes);

        string CombinePathAndFile(string fileName);

        //Task DeleteFileAsync(string Name);
    }
}
