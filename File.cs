using System;

namespace FileManagement
{
    public enum FileType
    {
        File,
        Folder
    }

    public class File
    {
        public string Name { get; set; } 
        public FileType Category { get; }
        public long Size { get; }
        public string Location { get; set; }

        public File(string name, FileType category, long size, string location)
        {
            Name = name;
            Category = category;
            Size = size;
            Location = location;
        }

        public File Copy(string newPath)
        {
            return new File(Name, Category, Size, newPath);
        }

        public void Move(string newLocation)
        {
            Location = newLocation;
        }

        public void Rename(string newName)
        {
            Name = newName;
        }
    }
}


