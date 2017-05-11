using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gallery
{
    class ListViewItem
    {
        public string Name { get; set; }
        public string PathName { get; set; }

        public static List<ListViewItem> GetFiles(string Path)
        {
            DirectoryInfo dir = new DirectoryInfo(Path);
            List<ListViewItem> ListViewFiles = new List<ListViewItem>();
            List<FileInfo> ListFiles = dir.GetFiles("*.jpg").ToList();
            foreach (var item in ListFiles)
            {
                ListViewFiles.Add(new ListViewItem() { Name = item.Name, PathName = item.FullName });
            }
            return ListViewFiles;
        }
    }
}
