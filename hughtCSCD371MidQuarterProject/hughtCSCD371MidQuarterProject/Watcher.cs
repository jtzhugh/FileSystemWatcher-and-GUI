using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hughtCSCD371MidQuarterProject;

namespace hughtCSCD371MidQuarterProject
{

    public class Watcher
    {
        public MainWindow targetForm;
        public string targetDir;
        public string filter;
        private FileSystemWatcher FCS;
        public SQLRec rec;

        public Watcher(string targetD, string fil, MainWindow targetF1, SQLRec inp)
        {
            rec = inp;
            targetForm = targetF1;
            // Create a new FileSystemWatcher and set its properties.
            targetDir = targetD;
            if (fil == "")
                fil = "*.*";
            FCS = new FileSystemWatcher(targetD, fil);
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            FCS.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Setting filters

            // Add event handlers.
            FCS.Changed += new FileSystemEventHandler(OnChanged);
            FCS.Created += new FileSystemEventHandler(OnChanged);
            FCS.Deleted += new FileSystemEventHandler(OnChanged);
            FCS.Renamed += new RenamedEventHandler(OnRenamed);

            FCS.IncludeSubdirectories = true;
            
            // Begin watching.
            FCS.EnableRaisingEvents = true;
        }
        public void Dispose()
        {
            FCS.Dispose();
        }

        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed!");
            // Specify what is done when a file is changed, created, or deleted.
            string post = "File: " + e.FullPath + " " + e.ChangeType + " " + DateTime.Now + "\n";
            targetForm.AddOutTxt(post);
            rec.Add(new SQLRec.SRec(e.Name, e.FullPath, e.ChangeType.ToString(), DateTime.Now.ToString(), Path.GetExtension(e.FullPath)));
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("Renamed");
            // Specify what is done when a file is renamed.
            string post = "File: "+ e.OldFullPath +" renamed to " + e.FullPath + " " + DateTime.Now +  "\n";
            targetForm.AddOutTxt(post);
            rec.Add(new SQLRec.SRec(e.Name + " from " + e.OldName, e.FullPath, e.ChangeType.ToString(), DateTime.Now.ToString(), Path.GetExtension(e.FullPath)));
        }

    }
}
