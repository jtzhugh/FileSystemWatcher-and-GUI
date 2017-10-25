/*
 * This class just holds the FileSystemWatcher event records before they are added to a database or deleted
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hughtCSCD371MidQuarterProject
{
    public class SQLRec
    {
        public List<SRec> holder;

        public SQLRec()
        {
            
            holder = new List<SRec>();
        }

        public class SRec
        {
            public string name;
            public string absPath;
            public string eventType;
            public string time;
            public string ext;

            public SRec(string name, string absPath, string eventType, string time, string ext)
            {
                this.name = name;
                this.absPath = absPath;
                this.eventType = eventType;
                this.time = time;
                this.ext = ext;
            }
        }
        public void Add(SRec inp)
        {
            this.holder.Add(inp);
        }
        public int getCount()
        {
            return holder.Count;
        }
    }
}
