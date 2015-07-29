using System.Diagnostics;
using System.IO;

namespace BackupMechanism
{
    /// <summary>
    ///  Backup Mechanism.
    /// </summary>
    public class BackupData
    {
        private string SYMBOL = "";

        public int fileCount
        {
            get;
            set;
        }

        public BackupData(string source, string target)
        {
            this.source = source;
            this.target = target;
            fileCount = 0;
        }

        public string source { get; set; }

        public string target { get; set; }

        /// <summary>
        /// Copy all data from source to target
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool copyData()
        {
            return copyData(source, target);
        }

        private bool copyData(string source, string target)
        {

            if (System.IO.Directory.Exists(source))
            {
                // Debug.Assert(source == SYMBOL && target == SYMBOL, "Invalid Pathes!");
                if (source != SYMBOL && target != SYMBOL)
                {
                    try
                    {
                        // If derictory from target exist in source don`t copy(BUG)

                        // Create all of the directories
                        foreach (string dirPath in Directory.EnumerateDirectories(source, "*",
                            SearchOption.AllDirectories))
                        {
                            if (!dirPath.Equals(target))
                            {
                                Directory.CreateDirectory(dirPath.Replace(source, target));
                            }
                        }
                    }
                    catch
                    {
                        return false;
                    }
                    try
                    {
                        // Copy all the files & Replaces any files with the same name
                        foreach (string newPath in Directory.EnumerateFiles(source, "*.*",
                        SearchOption.AllDirectories))
                        {
                            File.Copy(newPath, newPath.Replace(source, target), true);
                            fileCount++;
                        }
                    }
                    catch
                    {
                        return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}