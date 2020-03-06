using System;
using AMapFoundationKit;
using ObjCRuntime;
using System.Runtime.InteropServices;

namespace AMapFoundationKit
{
    public class ConstantsEx
    {
        static bool _amapLocationOverseas;
        static public bool AMapLocationOverseas
        {
            get
            {
                IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen(null, 0);
                IntPtr ptr = Dlfcn.dlsym(RTLD_MAIN_ONLY, "_amapLocationOverseas");
                _amapLocationOverseas = Marshal.PtrToStructure<bool>(ptr);
                Dlfcn.dlclose(RTLD_MAIN_ONLY);
                return _amapLocationOverseas;
            }
        }
    }
}
