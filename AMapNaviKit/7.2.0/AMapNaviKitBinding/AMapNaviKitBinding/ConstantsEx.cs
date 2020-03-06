using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using AMapNaviKit;

namespace AMapNaviKit
{
    public class ConstantsEx
    {
        static MAMapSize _MAMapSizeWorld;
        static public MAMapSize MAMapSizeWorld
        {
            get
            {
                IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen(null, 0);
                IntPtr ptr = Dlfcn.dlsym(RTLD_MAIN_ONLY, "MAMapSizeWorld");
                _MAMapSizeWorld = Marshal.PtrToStructure<MAMapSize>(ptr);
                Dlfcn.dlclose(RTLD_MAIN_ONLY);
                return _MAMapSizeWorld;
            }
        }

        static MAMapRect _MAMapRectWorld;
        static public MAMapRect MAMapRectWorld
        {
            get
            {
                IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen(null, 0);
                IntPtr ptr = Dlfcn.dlsym(RTLD_MAIN_ONLY, "MAMapRectWorld");
                _MAMapRectWorld = Marshal.PtrToStructure<MAMapRect>(ptr);
                Dlfcn.dlclose(RTLD_MAIN_ONLY);
                return _MAMapRectWorld;
            }
        }

        static MAMapRect _MAMapRectNull;
        static public MAMapRect MAMapRectNull
        {
            get
            {
                IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen(null, 0);
                IntPtr ptr = Dlfcn.dlsym(RTLD_MAIN_ONLY, "MAMapRectNull");
                _MAMapRectNull = Marshal.PtrToStructure<MAMapRect>(ptr);
                Dlfcn.dlclose(RTLD_MAIN_ONLY);
                return _MAMapRectNull;
            }
        }

        static MAMapRect _MAMapRectZero;
        static public MAMapRect MAMapRectZero
        {
            get
            {
                IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen(null, 0);
                IntPtr ptr = Dlfcn.dlsym(RTLD_MAIN_ONLY, "MAMapRectZero");
                _MAMapRectZero = Marshal.PtrToStructure<MAMapRect>(ptr);
                Dlfcn.dlclose(RTLD_MAIN_ONLY);
                return _MAMapRectZero;
            }
        }
    }
}
