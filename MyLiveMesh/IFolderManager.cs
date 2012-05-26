﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLiveMesh.Utils;

namespace MyLiveMesh
{
    interface IFolderManager
    {
        WebResult Create(int userId, string name);
        WebResult Delete(int folderId);
        WebResult Rename(int folderId, string name);
    }
}