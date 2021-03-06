﻿// ===================================
// The use and distribution terms for this software are covered by the Microsoft public license, 
// visit for more info : http://www.testcontrol.org  (or) http://testcontrol.codeplex.com 
// 
// You must not remove this copyright notice, or any other, from this software
// 
// Senthil Maruthaiappan  senips@gmail.com
// ===================================
using System;

namespace TestControl.Net.Interfaces
{
    public interface ICodeHelperItem
    {
        string AssemblyFile { get; }
        Type ClassType { get; }
        string ClassName { get; }
        object[] TypeItems { get; }
        string WndClassName { get; }
        ICodeHelper CodeHelper { get; }
    }
}