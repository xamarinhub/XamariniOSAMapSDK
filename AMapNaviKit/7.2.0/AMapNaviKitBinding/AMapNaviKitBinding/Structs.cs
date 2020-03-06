using System;
using System.Runtime.InteropServices;
using AMapNaviKit;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AMapNaviKit
{
	// typedef void (^AMapTileProjectionBlock)(int, int, int, int, int, int);
	public delegate void AMapTileProjectionBlock(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

	[StructLayout(LayoutKind.Sequential)]
	public struct MACoordinateBounds
	{
		public CLLocationCoordinate2D northEast;

		public CLLocationCoordinate2D southWest;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MACoordinateSpan
	{
		public double latitudeDelta;

		public double longitudeDelta;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MACoordinateRegion
	{
		public CLLocationCoordinate2D center;

		public MACoordinateSpan span;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MAMapPoint
	{
		public double x;

		public double y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MAMapSize
	{
		public double width;

		public double height;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MAMapRect
	{
		public MAMapPoint origin;

		public MAMapSize size;
	}

	[Flags]
	[Native]
	public enum MAMapRectCorner : ulong
	{
		TopLeft = 1uL << 0,
		TopRight = 1uL << 1,
		BottomLeft = 1uL << 2,
		BottomRight = 1uL << 3,
		AllCorners = ~0uL
	}

	static class CFunctions
	{
		// MACoordinateBounds MACoordinateBoundsMake (CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
		//[DllImport("__Internal")]
		//static extern MACoordinateBounds MACoordinateBoundsMake(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
		////
        public static MACoordinateBounds MACoordinateBoundsMake(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest)
		{
			return new MACoordinateBounds() { northEast = northEast, southWest = southWest };
		}

		// MACoordinateSpan MACoordinateSpanMake (CLLocationDegrees latitudeDelta, CLLocationDegrees longitudeDelta);
		//[DllImport("__Internal")]
		//static extern MACoordinateSpan MACoordinateSpanMake(double latitudeDelta, double longitudeDelta);
		////
		public static MACoordinateSpan MACoordinateSpanMake(double latitudeDelta, double longitudeDelta)
		{
			return new MACoordinateSpan() { latitudeDelta = latitudeDelta, longitudeDelta = longitudeDelta };
		}

		// MACoordinateRegion MACoordinateRegionMake (CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span);
		//[DllImport("__Internal")]
		//static extern MACoordinateRegion MACoordinateRegionMake(CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span);
		////
		public static MACoordinateRegion MACoordinateRegionMake(CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span)
		{
			return new MACoordinateRegion() { center = centerCoordinate, span = span };
		}

		// extern MACoordinateRegion MACoordinateRegionMakeWithDistance (CLLocationCoordinate2D centerCoordinate, CLLocationDistance latitudinalMeters, CLLocationDistance longitudinalMeters);
		[DllImport("__Internal")]
		static extern MACoordinateRegion MACoordinateRegionMakeWithDistance(CLLocationCoordinate2D centerCoordinate, double latitudinalMeters, double longitudinalMeters);

		// extern MAMapPoint MAMapPointForCoordinate (CLLocationCoordinate2D coordinate);
		[DllImport("__Internal")]
		static extern MAMapPoint MAMapPointForCoordinate(CLLocationCoordinate2D coordinate);

		// extern CLLocationCoordinate2D MACoordinateForMapPoint (MAMapPoint mapPoint);
		[DllImport("__Internal")]
		static extern CLLocationCoordinate2D MACoordinateForMapPoint(MAMapPoint mapPoint);

		// extern MACoordinateRegion MACoordinateRegionForMapRect (MAMapRect rect);
		[DllImport("__Internal")]
		static extern MACoordinateRegion MACoordinateRegionForMapRect(MAMapRect rect);

		// extern MAMapRect MAMapRectForCoordinateRegion (MACoordinateRegion region);
		[DllImport("__Internal")]
		static extern MAMapRect MAMapRectForCoordinateRegion(MACoordinateRegion region);

		// extern CLLocationDistance MAMetersPerMapPointAtLatitude (CLLocationDegrees latitude);
		[DllImport("__Internal")]
		static extern double MAMetersPerMapPointAtLatitude(double latitude);

		// extern double MAMapPointsPerMeterAtLatitude (CLLocationDegrees latitude);
		[DllImport("__Internal")]
		static extern double MAMapPointsPerMeterAtLatitude(double latitude);

		// extern CLLocationDistance MAMetersBetweenMapPoints (MAMapPoint a, MAMapPoint b);
		[DllImport("__Internal")]
		static extern double MAMetersBetweenMapPoints(MAMapPoint a, MAMapPoint b);

		// extern double MAAreaBetweenCoordinates (CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
		[DllImport("__Internal")]
		static extern double MAAreaBetweenCoordinates(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);

		// extern MAMapRect MAMapRectInset (MAMapRect rect, double dx, double dy);
		[DllImport("__Internal")]
		static extern MAMapRect MAMapRectInset(MAMapRect rect, double dx, double dy);

		// extern MAMapRect MAMapRectUnion (MAMapRect rect1, MAMapRect rect2);
		[DllImport("__Internal")]
		static extern MAMapRect MAMapRectUnion(MAMapRect rect1, MAMapRect rect2);

		// extern BOOL MAMapSizeContainsSize (MAMapSize size1, MAMapSize size2);
		[DllImport("__Internal")]
		static extern bool MAMapSizeContainsSize(MAMapSize size1, MAMapSize size2);

		// extern BOOL MAMapRectContainsPoint (MAMapRect rect, MAMapPoint point);
		[DllImport("__Internal")]
		static extern bool MAMapRectContainsPoint(MAMapRect rect, MAMapPoint point);

		// extern BOOL MAMapRectIntersectsRect (MAMapRect rect1, MAMapRect rect2);
		[DllImport("__Internal")]
		static extern bool MAMapRectIntersectsRect(MAMapRect rect1, MAMapRect rect2);

		// extern BOOL MAMapRectContainsRect (MAMapRect rect1, MAMapRect rect2);
		[DllImport("__Internal")]
		static extern bool MAMapRectContainsRect(MAMapRect rect1, MAMapRect rect2);

		// extern BOOL MACircleContainsPoint (MAMapPoint point, MAMapPoint center, double radius);
		[DllImport("__Internal")]
		static extern bool MACircleContainsPoint(MAMapPoint point, MAMapPoint center, double radius);

		// extern BOOL MACircleContainsCoordinate (CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius);
		[DllImport("__Internal")]
		static extern bool MACircleContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius);

		// extern MAMapPoint MAGetNearestMapPointFromPolyline (MAMapPoint point, MAMapPoint *polyline, NSUInteger count);
		[DllImport("__Internal")]
		static extern MAMapPoint MAGetNearestMapPointFromPolyline(MAMapPoint point, MAMapPoint polyline, nuint count);

		// extern BOOL MAPolygonContainsPoint (MAMapPoint point, MAMapPoint *polygon, NSUInteger count);
		[DllImport("__Internal")]
		static extern bool MAPolygonContainsPoint(MAMapPoint point, MAMapPoint polygon, nuint count);

		// extern BOOL MAPolygonContainsCoordinate (CLLocationCoordinate2D point, CLLocationCoordinate2D *polygon, NSUInteger count);
		[DllImport("__Internal")]
		static extern bool MAPolygonContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D polygon, nuint count);

		// extern MAMapPoint MAGetNearestMapPointFromLine (MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point);
		[DllImport("__Internal")]
		static extern MAMapPoint MAGetNearestMapPointFromLine(MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point);

		// extern void MAGetTileProjectionFromBounds (MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection);
		[DllImport("__Internal")]
		static extern void MAGetTileProjectionFromBounds(MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection);

		// extern double MAAreaForPolygon (CLLocationCoordinate2D *coordinates, int count);
		[DllImport("__Internal")]
		static extern double MAAreaForPolygon(CLLocationCoordinate2D coordinates, int count);

		// MAMapPoint MAMapPointMake (double x, double y);
		//[DllImport("__Internal")]
		//static extern MAMapPoint MAMapPointMake(double x, double y);
		////
		public static MAMapPoint MAMapPointMake(double x, double y)
		{
			return new MAMapPoint() { x = x, y = y };
		}

		// MAMapSize MAMapSizeMake (double width, double height);
		//[DllImport("__Internal")]
		//static extern MAMapSize MAMapSizeMake(double width, double height);
		////
		public static MAMapSize MAMapSizeMake(double width, double height)
		{
			return new MAMapSize() { width = width, height = height };
		}

		// MAMapRect MAMapRectMake (double x, double y, double width, double height);
		//[DllImport("__Internal")]
		//static extern MAMapRect MAMapRectMake(double x, double y, double width, double height);
		////
		public static MAMapRect MAMapRectMake(double x, double y, double width, double height)
		{
			return new MAMapRect() { origin = MAMapPointMake(x, y), size = MAMapSizeMake(width, height) };
		}

		// double MAMapRectGetMinX (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern double MAMapRectGetMinX(MAMapRect rect);
		////
		public static double MAMapRectGetMinX(MAMapRect rect)
		{
			return rect.origin.x;
		}

		// double MAMapRectGetMinY (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern double MAMapRectGetMinY(MAMapRect rect);
		////
		public static double MAMapRectGetMinY(MAMapRect rect)
		{
			return rect.origin.y;
		}

		// double MAMapRectGetMidX (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern double MAMapRectGetMidX(MAMapRect rect);
		////
		public static double MAMapRectGetMidX(MAMapRect rect)
		{
			return rect.origin.x + rect.size.width / 2.0;
		}

		// double MAMapRectGetMidY (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern double MAMapRectGetMidY(MAMapRect rect);
		////
		public static double MAMapRectGetMidY(MAMapRect rect)
		{
			return rect.origin.y + rect.size.height / 2.0;
		}

		// double MAMapRectGetMaxX (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern double MAMapRectGetMaxX(MAMapRect rect);
		////
		public static double MAMapRectGetMaxX(MAMapRect rect)
		{
			return rect.origin.x + rect.size.width;
		}

		// double MAMapRectGetMaxY (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern double MAMapRectGetMaxY(MAMapRect rect);
		////
		public static double MAMapRectGetMaxY(MAMapRect rect)
		{
			return rect.origin.y + rect.size.height;
		}

		// double MAMapRectGetWidth (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern double MAMapRectGetWidth(MAMapRect rect);
		////
		public static double MAMapRectGetWidth(MAMapRect rect)
		{
			return rect.size.width;
		}

		// double MAMapRectGetHeight (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern double MAMapRectGetHeight(MAMapRect rect);
		////
		public static double MAMapRectGetHeight(MAMapRect rect)
		{
			return rect.size.height;
		}

		// BOOL MAMapPointEqualToPoint (MAMapPoint point1, MAMapPoint point2);
		//[DllImport("__Internal")]
		//static extern bool MAMapPointEqualToPoint(MAMapPoint point1, MAMapPoint point2);
		////
		public static bool MAMapPointEqualToPoint(MAMapPoint point1, MAMapPoint point2)
		{
			return point1.x == point2.x && point1.y == point2.y;
		}

		// BOOL MAMapSizeEqualToSize (MAMapSize size1, MAMapSize size2);
		//[DllImport("__Internal")]
		//static extern bool MAMapSizeEqualToSize(MAMapSize size1, MAMapSize size2);
		////
		public static bool MAMapSizeEqualToSize(MAMapSize size1, MAMapSize size2)
		{
			return size1.width == size2.width && size1.height == size2.height;
		}

		// BOOL MAMapRectEqualToRect (MAMapRect rect1, MAMapRect rect2);
		//[DllImport("__Internal")]
		//static extern bool MAMapRectEqualToRect(MAMapRect rect1, MAMapRect rect2);
		////
		public static bool MAMapRectEqualToRect(MAMapRect rect1, MAMapRect rect2)
		{
			var one = MAMapPointEqualToPoint(rect1.origin, rect2.origin);
			var two = MAMapSizeEqualToSize(rect1.size, rect2.size);

			return one && two;
		}

		// BOOL MAMapRectIsNull (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern bool MAMapRectIsNull(MAMapRect rect);
		////
		public static bool MAMapRectIsNull(MAMapRect rect)
		{
			return double.IsInfinity(rect.origin.x) || double.IsInfinity(rect.origin.y);
		}

		// BOOL MAMapRectIsEmpty (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern bool MAMapRectIsEmpty(MAMapRect rect);
		////
		public static bool MAMapRectIsEmpty(MAMapRect rect)
		{
			return MAMapRectIsNull(rect) || (rect.size.width == 0.0 && rect.size.height == 0.0);
		}

		// NSString * MAStringFromMapPoint (MAMapPoint point);
		//[DllImport("__Internal")]
		//static extern NSString MAStringFromMapPoint(MAMapPoint point);
		////
		public static string MAStringFromMapPoint(MAMapPoint point)
		{
			return string.Format(@"{%.1f, %.1f}", point.x, point.y);
		}

		// NSString * MAStringFromMapSize (MAMapSize size);
		//[DllImport("__Internal")]
		//static extern NSString MAStringFromMapSize(MAMapSize size);
		////
		public static string MAStringFromMapSize(MAMapSize size)
		{
			var a = size.width;
			var b = size.height;
			return string.Format(@"{%.1f, %.1f}", a, b);
		}

		// NSString * MAStringFromMapRect (MAMapRect rect);
		//[DllImport("__Internal")]
		//static extern NSString MAStringFromMapRect(MAMapRect rect);
		////
		public static string MAStringFromMapRect(MAMapRect rect)
		{
			var a = MAStringFromMapPoint(rect.origin);
			var b = MAStringFromMapSize(rect.size);
			return string.Format(@"{%@, %@}", a, b);
		}

		// extern CLLocationCoordinate2D MACoordinateConvert (CLLocationCoordinate2D coordinate, MACoordinateType type) __attribute__((deprecated("已废弃，使用AMapFoundation中关于坐标转换的接口")));
		[DllImport("__Internal")]
		static extern CLLocationCoordinate2D MACoordinateConvert(CLLocationCoordinate2D coordinate, MACoordinateType type);

		// extern CLLocationDirection MAGetDirectionFromCoords (CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord);
		[DllImport("__Internal")]
		static extern double MAGetDirectionFromCoords(CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord);

		// extern CLLocationDirection MAGetDirectionFromPoints (MAMapPoint fromPoint, MAMapPoint toPoint);
		[DllImport("__Internal")]
		static extern double MAGetDirectionFromPoints(MAMapPoint fromPoint, MAMapPoint toPoint);

		// extern double MAGetDistanceFromPointToLine (MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd);
		[DllImport("__Internal")]
		static extern double MAGetDistanceFromPointToLine(MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd);

		// extern BOOL MAPolylineHitTest (MAMapPoint *linePoints, NSUInteger count, MAMapPoint tappedPoint, CGFloat lineWidth);
		[DllImport("__Internal")]
		static extern bool MAPolylineHitTest(MAMapPoint linePoints, nuint count, MAMapPoint tappedPoint, nfloat lineWidth);

		// extern UIImage * CreateLaneInfoImageWithLaneInfo (NSString *laneBackInfo, NSString *laneSelectInfo);
		[DllImport("__Internal")]
		static extern UIImage CreateLaneInfoImageWithLaneInfo(NSString laneBackInfo, NSString laneSelectInfo);

		// extern AMapNaviDrivingStrategy ConvertDrivingPreferenceToDrivingStrategy (BOOL multipleRoute, BOOL avoidCongestion, BOOL avoidHighway, BOOL avoidCost, BOOL prioritiseHighway);
		[DllImport("__Internal")]
		static extern AMapNaviDrivingStrategy ConvertDrivingPreferenceToDrivingStrategy(bool multipleRoute, bool avoidCongestion, bool avoidHighway, bool avoidCost, bool prioritiseHighway);
	}

	[Native]
	public enum MACoordinateType : ulong
	{
		Baidu = 0,
		MapBar,
		MapABC,
		SoSoMap,
		AliYun,
		Google,
		Gps
	}

	public enum MALineJoinType : uint
	{
		Bevel,
		Miter,
		Round
	}

	public enum MALineCapType : uint
	{
		Butt,
		Square,
		Arrow,
		Round
	}

	[Native]
	public enum MALineDashType : ulong
	{
		None = 0,
		Square,
		Dot
	}

	[Native]
	public enum MAAnnotationViewDragState : long
	{
		None = 0,
		Starting,
		Dragging,
		Canceling,
		Ending
	}

	[Native]
	public enum MAMapType : long
	{
		Standard = 0,
		Satellite,
		StandardNight,
		Navi,
		Bus
	}

	[Native]
	public enum MAUserTrackingMode : long
	{
		None = 0,
		Follow = 1,
		FollowWithHeading = 2
	}

	[Native]
	public enum MATrafficStatus : long
	{
		Smooth = 1,
		Slow,
		Jam,
		SeriousJam
	}

	[Native]
	public enum MAOverlayLevel : long
	{
		Roads = 0,
		Labels
	}

	[Native]
	public enum MAPinAnnotationColor : long
	{
		Red = 0,
		Green,
		Purple
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MATileOverlayPath
	{
		public nint x;

		public nint y;

		public nint z;

		public nfloat contentScaleFactor;
	}

	[Native]
	public enum MAParticleOverlayType : long
	{
		Sunny = 1,
		Rain,
		Snowy,
		Haze
	}

	[Native]
	public enum MAHeatMapType : long
	{
		Square = 1,
		Honeycomb = 2
	}

	[Native]
	public enum MAOfflineItemStatus : long
	{
		None = 0,
		Cached,
		Installed,
		Expired
	}

	public enum MAOfflineCityStatus : long
	{
		None = MAOfflineItemStatus.None,
		Cached = MAOfflineItemStatus.Cached,
		Installed = MAOfflineItemStatus.Installed,
		Expired = MAOfflineItemStatus.Expired
	}

	[Native]
	public enum MAOfflineMapDownloadStatus : long
	{
		Waiting = 0,
		Start,
		Progress,
		Completed,
		Cancelled,
		Unzip,
		Finished,
		Error
	}

	[Native]
	public enum MAOfflineMapError : long
	{
		Unknown = -1,
		CannotWriteToTmp = -2,
		CannotOpenZipFile = -3,
		CannotExpand = -4
	}

	[Native]
	public enum AMapNaviError : long
	{
		UnknowError = -1,
		ErrorNoGPSPermission = -2
	}

	[Native]
	public enum AMapNaviMode : long
	{
		None = 0,
		Gps,
		Emulator
	}

	[Native]
	public enum AMapNaviViewTrackingMode : long
	{
		MapNorth = 0,
		CarNorth
	}

	[Native]
	public enum AMapNaviDriveViewShowMode : long
	{
		CarPositionLocked = 1,
		Overview = 2,
		Normal = 3
	}

	[Native]
	public enum AMapNaviDrivingStrategy : long
	{
		SingleDefault = 0,
		SingleAvoidCost = 1,
		SinglePrioritiseDistance = 2,
		SingleAvoidExpressway = 3,
		SingleAvoidCongestion = 4,
		SinglePrioritiseSpeedCostDistance = 5,
		SingleAvoidHighway = 6,
		SingleAvoidHighwayAndCost = 7,
		SingleAvoidCostAndCongestion = 8,
		SingleAvoidHighwayAndCostAndCongestion = 9,
		MultipleDefault = 10,
		MultipleShortestTimeDistance = 11,
		MultipleAvoidCongestion = 12,
		MultipleAvoidHighway = 13,
		MultipleAvoidCost = 14,
		MultipleAvoidHighwayAndCongestion = 15,
		MultipleAvoidHighwayAndCost = 16,
		MultipleAvoidCostAndCongestion = 17,
		MultipleAvoidHighwayAndCostAndCongestion = 18,
		MultiplePrioritiseHighway = 19,
		MultiplePrioritiseHighwayAvoidCongestion = 20,
		Default = SingleDefault,
		SaveMoney = SingleAvoidCost,
		ShortDistance = SinglePrioritiseDistance,
		NoExpressways = SingleAvoidExpressway,
		FastestTime = SingleAvoidCongestion,
		DefaultAndFastest = MultipleAvoidCongestion,
		DefaultAndShort = MultipleDefault,
		AvoidCongestion = SingleAvoidCostAndCongestion,
		DefaultAndFastestAndShort = MultipleAvoidCongestion
	}

	[Native]
	public enum AMapNaviCalcRouteState : long
	{
		EnvFailed = 0,
		Succeed = 1,
		NetworkError = 2,
		ParamInvalid = NetworkError,
		StartPointError = 3,
		ProtocolError = 4,
		CallCenterError = 5,
		EndPointError = 6,
		EncodeFalse = 7,
		LackPreview = 8,
		DataBufError = 9,
		StartRouteError = 10,
		EndRouteError = 11,
		PassRouteError = 12,
		RouteFail = 13,
		DistanceTooLong = 19,
		PassPointError = 21
	}

	[Native]
	public enum AMapNaviIconType : long
	{
		None = 0,
		Default,
		Left,
		Right,
		LeftFront,
		RightFront,
		LeftBack,
		RightBack,
		LeftAndAround,
		Straight,
		ArrivedWayPoint,
		EnterRoundabout,
		OutRoundabout,
		ArrivedServiceArea,
		ArrivedTollGate,
		ArrivedDestination,
		ArrivedTunnel,
		EntryLeftRing,
		LeaveLeftRing,
		UTurnRight,
		SpecialContinue,
		EntryRingLeft,
		EntryRingRight,
		EntryRingContinue,
		EntryRingUTurn,
		EntryLeftRingLeft,
		EntryLeftRingRight,
		EntryLeftRingContinue,
		EntryLeftRingUTurn,
		Crosswalk,
		Flyover,
		Underpass,
		Square,
		Park,
		Staircase,
		Lift,
		Cableway,
		OverheadPassage,
		Passage,
		Walks,
		Cruises,
		Sightseeingbus,
		Slip,
		Stair,
		Slope,
		Bridge,
		Ferryboat,
		Subway,
		EnterBuilding,
		LeaveBuilding,
		ByElevator,
		ByStair,
		Escalator,
		LowTrafficCross,
		LowCross
	}

	[Native]
	public enum AMapNaviSoundType : long
	{
		AMapNaviSoundTypeDefault = 0
	}

	[Native]
	public enum AMapNaviDetectedMode : long
	{
		None = 0,
		Camera,
		SpecialRoad,
		CameraAndSpecialRoad
	}

	[Native]
	public enum AMapNaviRoadClass : long
	{
		HighWay = 0,
		NationalRoad,
		ProvincialRoad,
		CountyRoad,
		VillageRoad,
		CountyInternalRoad,
		MainStreet,
		MainRoad,
		MinorRoad,
		NormalRoad,
		NotNaviRoad
	}

	[Native]
	public enum AMapNaviFormWay : long
	{
		None = -1,
		MainRoad = 1,
		InternalRoad,
		Jct,
		Roundabout,
		RestArea,
		Ramp,
		SideRoad,
		RampAndJCT,
		Exit,
		Entrance,
		TurnRightRoadA,
		TurnRightRoadB,
		TurnLeftRoadA,
		TurnLeftRoadB,
		NormalRoad,
		TurnLeftAndRightRoad,
		RestAreaAndJCT = 53,
		RestAreaAndRamp = 56,
		RestAreaRampJCT = 58
	}

	[Native]
	public enum AMapNaviCameraType : long
	{
		Speed = 0,
		Surveillance = 1,
		TrafficLight = 2,
		BreakRule = 3,
		Busway = 4,
		EmergencyLane = 5,
		BicycleLane = 6,
		IntervalVelocityStart = 8,
		IntervalVelocityEnd = 9,
		FlowSpeed = 10
	}

	[Native]
	public enum AMapNaviBroadcastMode : long
	{
		Concise = 1,
		Detailed
	}

	[Native]
	public enum AMapNaviRouteStatus : long
	{
		Unknow = 0,
		Smooth,
		Slow,
		Jam,
		SeriousJam
	}

	[Native]
	public enum AMapNaviRoutePlanPOIType : long
	{
		Start = 0,
		End,
		Way
	}

	[Native]
	public enum AMapNaviParallelRoadStatusFlag : long
	{
		None = 0,
		Assist = 1,
		Main = 2
	}

	[Native]
	public enum AMapNaviElevatedRoadStatusFlag : long
	{
		None = 0,
		Under = 1,
		Up = 2
	}

	[Native]
	public enum AMapNaviCompositeThemeType : long
	{
		Default = 0,
		Light = 1,
		Dark = 2
	}

	[Native]
	public enum AMapNaviRingType : long
	{
		Null = 0,
		Reroute = 1,
		Ding = 100,
		Dong = 101,
		ElecDing = 102,
		ElecOverSpeedDing = 103
	}

	[Native]
	public enum AMapNaviGPSSignalStrength : long
	{
		Unknow = 0,
		Strong = 1,
		Weak = 2
	}

	[Native]
	public enum AMapNaviCompositeVCBackwardActionType : long
	{
		Dismiss = 0,
		NaviPop = 1
	}

	[Native]
	public enum AMapNaviRoutePlanType : long
	{
		Common = 1,
		Yaw = 2,
		ChangeStratege = 3,
		ParallelRoad = 4,
		Tmc = 5,
		LimitLine = 6,
		DamagedRoad = 7,
		ChangeJnyPnt = 9,
		UpdateCityData = 10,
		LimitForbid = 11,
		ManualRefresh = 12,
		MutiRouteRequest = 14,
		Dispatch = 16,
		PushRouteData = 200
	}

	[Native]
	public enum AMapNaviIntervalCameraPositionState : long
	{
		Null = 0,
		Ready = 1,
		In = 2,
		Out = 3
	}

	[Native]
	public enum AMapNaviRoadFacilityType : long
	{
		Null = 0,
		LeftInterflow = 1,
		RightInterflow = 2,
		SharpTurn = 3,
		ReverseTurn = 4,
		LinkingTurn = 5,
		AccidentArea = 6,
		FallingRocks = 7,
		FailwayCross = 8,
		Slippery = 9,
		MaxSpeedLimit = 10,
		MinSpeedLimit = 11,
		Village = 12,
		LeftNarrow = 13,
		RightNarrow = 14,
		DoubleNarrow = 15,
		CrosswindArea = 16,
		TruckHeightLimit = 81,
		TruckWidthLimit = 82,
		TruckWeightLimit = 83,
		CheckPoint = 91
	}

	[Native]
	public enum AMapNaviRouteNotifyDataType : long
	{
		Null = 0,
		RestrictArea = 1,
		ForbidArea = 2,
		RoadClosedArea = 3,
		JamArea = 4,
		Dispatch = 5,
		ChangeMainRoute = 20,
		GPSSignalWeak = 21
	}

	[Native]
	public enum AMapNaviLinkType : long
	{
		Null = -1,
		NormalRoad = 0,
		Fairway = 1,
		UnderPass = 2,
		Bridge = 3,
		ElevatedRd = 4
	}

	[Native]
	public enum AMapNaviRouteIconPointType : long
	{
		Null = -1,
		Foot = 0,
		VehicleFerry = 1,
		MannedFerry = 2
	}

	[Native]
	public enum AMapNaviOnlineCarHailingType : long
	{
		Invalid = -1,
		None = 0,
		PickUp = 1,
		Transport = 2
	}

	[Native]
	public enum AMapNaviViewMapModeType : long
	{
		Day = 0,
		Night = 1,
		DayNightAuto = 2,
		Custom = 3
	}

	[Flags]
	[Native]
	public enum AMapNaviCompositeBroadcastType : ulong
	{
		Detailed = 0x0,
		Concise = 0x1,
		Mute = 0x2
	}

	[Native]
	public enum AMapNaviWalkViewShowMode : long
	{
		CarPositionLocked = 1,
		Overview = 2,
		Normal = 3
	}

	[Native]
	public enum AMapNaviRideViewShowMode : long
	{
		CarPositionLocked = 1,
		Overview = 2,
		Normal = 3
	}
}

