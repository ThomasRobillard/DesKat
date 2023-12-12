using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesKat
{
    public class Folder : Icon, IModifiable
    {
        private List<File> _files;

        public List<File> Files
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void AddFile(File file)
        {
            throw new NotImplementedException();
        }

        public void RemoveFile(File file)
        {
            throw new NotImplementedException();
        }

        public void RenameItem(string name, string newName)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem()
        {
            throw new NotImplementedException();
        }
        public void CopyItem(string source, string destination)
        {
            throw new NotImplementedException();
        }
    }
}
