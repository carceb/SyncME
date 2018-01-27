using System;
using System.IO;

namespace DM.StaticMethods
{
    public static class IOmethods
    {

        public static long GetDirectorySize(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            return DirSize(di);
        }

        public static int GetFileCount(string path)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            int n = files.Length;
            //files = null;
            return n;
        }

        public static int GetDirectoryCount(string path)
        {
            string[] dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            int n = dirs.Length;
            //dirs = null;
            return n;
        }

        public static bool DirectoryExists(string path)
        {
            //if (path[path.Length - 1] != Path.DirectorySeparatorChar)
            //    path += Path.DirectorySeparatorChar;
            if (Directory.Exists(path)) return true;
            return false;
        }

        private static long DirSize(DirectoryInfo d)
        {
            long Size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                Size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                Size += DirSize(di);
            }
            return (Size);
        }

        ///<summary>
        /// Copy files and directory structure recursively.
        ///</summary>
        public static void CopyDirectoryRecursively(string source, string mirror)
        {
            String[] Files;

            if (mirror[mirror.Length - 1] != Path.DirectorySeparatorChar)
                mirror += Path.DirectorySeparatorChar;
            if (!Directory.Exists(mirror))
                Directory.CreateDirectory(mirror);

            Files = Directory.GetFileSystemEntries(source);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectoryRecursively(Element, mirror + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, mirror + Path.GetFileName(Element), true);
            }
        }

        public static void DeleteAll(string path)
        {
            if (Directory.Exists(path))
            {
                String[] Files;
                Files = Directory.GetFileSystemEntries(path);
                foreach (string element in Files)
                {
                    if (Directory.Exists(element))
                        Directory.Delete(element, true);
                    else
                        File.Delete(element);
                }
            }
        }

        #region Soft Rebuild

        public static void MirrorUpdate(string source, string mirror)
        {

            if (appearIdentical(source, mirror)) return;

            String[] ioData = Directory.GetFileSystemEntries(source);

            // Add missing folders and files
            foreach (string path in ioData)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessAddFile(path, source, mirror);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessAddDirectory(path, source, mirror);
                }
            }

            if (appearIdentical(source, mirror)) return;

            removeOrpahns(source, mirror);
        }

        // Remove files and folders from the mirror that dont exist in the source folder
        private static void removeOrpahns(string source, string mirror)
        {
            String[] ioData = Directory.GetFileSystemEntries(mirror);

            // Delete orphan folders and files
            foreach (string path in ioData)
            {
                if (File.Exists(path))
                {
                    if (!File.Exists(path.Replace(mirror, source))) File.Delete(path);
                }
                else if (Directory.Exists(path))
                {
                    if (!Directory.Exists(path.Replace(mirror, source))) Directory.Delete(path, true);
                    else removeOrpahns(path.Replace(mirror, source), path);
                }
            }
        }

        private static bool appearIdentical(string source, string mirror)
        {
            long sSize = GetDirectorySize(source);
            long mSize = GetDirectorySize(mirror);
            if (sSize == mSize) return true;
            return false;
        }

        private static void ProcessAddDirectory(string path, string source, string mirror)
        {
            string target = path.Replace(source, mirror);
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
                CopyDirectoryRecursively(path, target);
            }

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
            {
                ProcessAddFile(fileName, source, mirror);
            }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessAddDirectory(subdirectory, source, mirror);
            }
        }

        private static void ProcessAddFile(string path, string source, string mirror)
        {
            string target = path.Replace(source, mirror);
            if (!File.Exists(target))
            {
                File.Copy(path, target);
            }
            else
            {
                FileInfo fS = new FileInfo(path);
                FileInfo fM = new FileInfo(target);
                if (fS.Length != fM.Length)
                {
                    File.Copy(path, target);
                }
            }
        }

        #endregion

    }
}
