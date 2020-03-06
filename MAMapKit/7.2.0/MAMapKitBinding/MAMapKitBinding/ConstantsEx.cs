using System;
using System.Runtime.InteropServices;
using MAMapKit;

namespace MAMapKit
{
    public class ConstantsEx
    {
        static MAMapSize _MAMapSizeWorld;
        static public MAMapSize MAMapSizeWorld
        {
            get
            {
                _MAMapSizeWorld = Marshal.PtrToStructure<MAMapSize>(Constants.MAMapSizeWorld);
                return _MAMapSizeWorld;
            }
        }

        static MAMapRect _MAMapRectWorld;
        static public MAMapRect MAMapRectWorld
        {
            get
            {
                _MAMapRectWorld = Marshal.PtrToStructure<MAMapRect>(Constants.MAMapRectWorld);
                return _MAMapRectWorld;
            }
        }

        static MAMapRect _MAMapRectNull;
        static public MAMapRect MAMapRectNull
        {
            get
            {
                _MAMapRectNull = Marshal.PtrToStructure<MAMapRect>(Constants.MAMapRectNull);
                return _MAMapRectNull;
            }
        }

        static MAMapRect _MAMapRectZero;
        static public MAMapRect MAMapRectZero
        {
            get
            {
                _MAMapRectZero = Marshal.PtrToStructure<MAMapRect>(Constants.MAMapRectZero);
                return _MAMapRectZero;
            }
        }
    }
}
