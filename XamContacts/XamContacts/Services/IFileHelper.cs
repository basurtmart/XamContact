using System;
using System.Collections.Generic;
using System.Text;

namespace XamContacts.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
