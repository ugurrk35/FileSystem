using System.Collections.Generic;

namespace FileSystem.Models
{
    public class FileUploadViewModel
    {
        public List<FileSystemModel> FileSystemModel { get; set; }
        public List<FileDatabaseModel> FileDatabaseModel { get; set; }
    }
}
