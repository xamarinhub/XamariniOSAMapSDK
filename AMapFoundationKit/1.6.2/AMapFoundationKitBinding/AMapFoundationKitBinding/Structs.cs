using System.Runtime.InteropServices;
using AMapFoundationKit;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using System;
using Foundation;

namespace AMapFoundationKit
{

	[Native]
	public enum AMapDrivingStrategy : long
	{
		Fastest = 0,
		MinFare = 1,
		Shortest = 2,
		NoHighways = 3,
		AvoidCongestion = 4,
		AvoidHighwaysAndFare = 5,
		AvoidHighwaysAndCongestion = 6,
		AvoidFareAndCongestion = 7,
		AvoidHighwaysAndFareAndCongestion = 8
	}

	[Native]
	public enum AMapTransitStrategy : long
	{
		Fastest = 0,
		MinFare = 1,
		MinTransfer = 2,
		MinWalk = 3,
		MostComfortable = 4,
		AvoidSubway = 5
	}

	[Native]
	public enum AMapRouteSearchType : long
	{
		Driving = 0,
		Transit = 1,
		Walking = 2
	}

	//static class CFunctions	
	public static class CFunctions	
	{
		// NSString * AMapEmptyStringIfNil (NSString *s);
		/*
		[DllImport("__Internal")]
		static extern NSString AMapEmptyStringIfNil(NSString s);*/
		public static NSString AMapEmptyStringIfNil(NSString s)
		{
			return s != null ? s : new NSString("");
		}

		// extern CLLocationCoordinate2D AMapCoordinateConvert (CLLocationCoordinate2D coordinate, AMapCoordinateType type);
		/*
		[DllImport("__Internal")]
		static extern CLLocationCoordinate2D AMapCoordinateConvert(CLLocationCoordinate2D coordinate, AMapCoordinateType type);*/
		[DllImport("__Internal", EntryPoint = "AMapCoordinateConvert")]
		static extern CLLocationCoordinate2D _AMapCoordinateConvert(CLLocationCoordinate2D coordinate, AMapCoordinateType type);
		public static CLLocationCoordinate2D AMapCoordinateConvert(CLLocationCoordinate2D coordinate, AMapCoordinateType type)
		{
			return _AMapCoordinateConvert(coordinate, type);
		}

		// extern BOOL AMapDataAvailableForCoordinate (CLLocationCoordinate2D coordinate);
		/*
		[DllImport("__Internal")]
		static extern bool AMapDataAvailableForCoordinate(CLLocationCoordinate2D coordinate);*/
		[DllImport("__Internal", EntryPoint = "AMapDataAvailableForCoordinate")]
		static extern bool _AMapDataAvailableForCoordinate(CLLocationCoordinate2D coordinate);
		public static bool AMapDataAvailableForCoordinate(CLLocationCoordinate2D coordinate)
		{
			return _AMapDataAvailableForCoordinate(coordinate);
		}
	}

	[Native]
	public enum AMapCoordinateType : long
	{
		AMap = -1,
		Baidu = 0,
		MapBar,
		MapABC,
		SoSoMap,
		AliYun,
		Google,
		Gps
	}
}

