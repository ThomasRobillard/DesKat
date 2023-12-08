using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesKat
{
    public interface IModifiable
    {
        void RenameItem(string name, string newName);

        void DeleteItem();

        void CopyItem(string name, string destination);
    }
}
