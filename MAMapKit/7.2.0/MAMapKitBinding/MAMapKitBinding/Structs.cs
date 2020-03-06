using System;
using System.Runtime.InteropServices;
using CoreLocation;
using Foundation;
using MAMapKit;
using ObjCRuntime;

namespace MAMapKit
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
		AllCorners = /*~0x0*/~0UL
	}

	//static class CFunctions
	public static class CFunctions
	{
		// MACoordinateBounds MACoordinateBoundsMake (CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
		//[DllImport("__Internal",EntryPoint = "MACoordinateBoundsMake")]
		//static extern MACoordinateBounds _MACoordinateBoundsMake(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
        ////
		public static MACoordinateBounds MACoordinateBoundsMake(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest)
        {
			return new MACoordinateBounds() { northEast = northEast, southWest = southWest };
        }

		// MACoordinateSpan MACoordinateSpanMake (CLLocationDegrees latitudeDelta, CLLocationDegrees longitudeDelta);
		//[DllImport("__Internal",EntryPoint = "MACoordinateSpanMake")]
		//static extern MACoordinateSpan _MACoordinateSpanMake(double latitudeDelta, double longitudeDelta);
		////
		public static MACoordinateSpan MACoordinateSpanMake(double latitudeDelta, double longitudeDelta)
        {
			return new MACoordinateSpan(){ latitudeDelta= latitudeDelta, longitudeDelta=longitudeDelta };
		}

		// MACoordinateRegion MACoordinateRegionMake (CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span);
		//[DllImport("__Internal",EntryPoint = "MACoordinateRegionMake")]
		//static extern MACoordinateRegion _MACoordinateRegionMake(CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span);
        ////
		public static MACoordinateRegion MACoordinateRegionMake(CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span)
        {
			return new MACoordinateRegion() { center= centerCoordinate, span=span };
		}

		// extern MACoordinateRegion MACoordinateRegionMakeWithDistance (CLLocationCoordinate2D centerCoordinate, CLLocationDistance latitudinalMeters, CLLocationDistance longitudinalMeters);
		[DllImport("__Internal",EntryPoint = "MACoordinateRegionMakeWithDistance")]
		static extern MACoordinateRegion _MACoordinateRegionMakeWithDistance(CLLocationCoordinate2D centerCoordinate, double latitudinalMeters, double longitudinalMeters);
		public static MACoordinateRegion MACoordinateRegionMakeWithDistance(CLLocationCoordinate2D centerCoordinate, double latitudinalMeters, double longitudinalMeters)
        {
			return _MACoordinateRegionMakeWithDistance(centerCoordinate, latitudinalMeters, longitudinalMeters);
		}

		// extern MAMapPoint MAMapPointForCoordinate (CLLocationCoordinate2D coordinate);
		[DllImport("__Internal",EntryPoint = "MAMapPointForCoordinate")]
		static extern MAMapPoint _MAMapPointForCoordinate(CLLocationCoordinate2D coordinate);
		public static MAMapPoint MAMapPointForCoordinate(CLLocationCoordinate2D coordinate)
        {
			return _MAMapPointForCoordinate(coordinate);
		}

		// extern CLLocationCoordinate2D MACoordinateForMapPoint (MAMapPoint mapPoint);
		[DllImport("__Internal",EntryPoint = "MACoordinateForMapPoint")]
		static extern CLLocationCoordinate2D _MACoordinateForMapPoint(MAMapPoint mapPoint);
		public static CLLocationCoordinate2D MACoordinateForMapPoint(MAMapPoint mapPoint)
        {
			return _MACoordinateForMapPoint(mapPoint);
		}

		// extern MACoordinateRegion MACoordinateRegionForMapRect (MAMapRect rect);
		[DllImport("__Internal",EntryPoint = "MACoordinateRegionForMapRect")]
		static extern MACoordinateRegion _MACoordinateRegionForMapRect(MAMapRect rect);
		public static MACoordinateRegion MACoordinateRegionForMapRect(MAMapRect rect)
        {
			return _MACoordinateRegionForMapRect(rect);
		}

		// extern MAMapRect MAMapRectForCoordinateRegion (MACoordinateRegion region);
		[DllImport("__Internal",EntryPoint = "MAMapRectForCoordinateRegion")]
		static extern MAMapRect _MAMapRectForCoordinateRegion(MACoordinateRegion region);
		public static MAMapRect MAMapRectForCoordinateRegion(MACoordinateRegion region)
        {
			return _MAMapRectForCoordinateRegion(region);
		}

		// extern CLLocationDistance MAMetersPerMapPointAtLatitude (CLLocationDegrees latitude);
		[DllImport("__Internal",EntryPoint = "MAMetersPerMapPointAtLatitude")]
		static extern double _MAMetersPerMapPointAtLatitude(double latitude);
		public static double MAMetersPerMapPointAtLatitude(double latitude)
		{
			return _MAMetersPerMapPointAtLatitude(latitude);
		}

		// extern double MAMapPointsPerMeterAtLatitude (CLLocationDegrees latitude);
		[DllImport("__Internal", EntryPoint= "MAMapPointsPerMeterAtLatitude")]
		static extern double _MAMapPointsPerMeterAtLatitude(double latitude);
		public static double MAMapPointsPerMeterAtLatitude(double latitude)
        {
			return _MAMapPointsPerMeterAtLatitude(latitude);
		}

		// extern CLLocationDistance MAMetersBetweenMapPoints (MAMapPoint a, MAMapPoint b);
		[DllImport("__Internal",EntryPoint = "MAMetersBetweenMapPoints")]
		static extern double _MAMetersBetweenMapPoints(MAMapPoint a, MAMapPoint b);
		public static double MAMetersBetweenMapPoints(MAMapPoint a, MAMapPoint b)
        {
			return _MAMetersBetweenMapPoints(a, b);
		}

		// extern double MAAreaBetweenCoordinates (CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
		[DllImport("__Internal",EntryPoint = "MAAreaBetweenCoordinates")]
		static extern double _MAAreaBetweenCoordinates(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
		public static double MAAreaBetweenCoordinates(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest)
        {
			return _MAAreaBetweenCoordinates(northEast, southWest);
		}

		// extern MAMapRect MAMapRectInset (MAMapRect rect, double dx, double dy);
		[DllImport("__Internal",EntryPoint = "MAMapRectInset")]
		static extern MAMapRect _MAMapRectInset(MAMapRect rect, double dx, double dy);
		public static MAMapRect MAMapRectInset(MAMapRect rect, double dx, double dy)
        {
			return _MAMapRectInset(rect, dx, dy);
		}

		// extern MAMapRect MAMapRectUnion (MAMapRect rect1, MAMapRect rect2);
		[DllImport("__Internal", EntryPoint = "MAMapRectUnion")]
		static extern MAMapRect _MAMapRectUnion(MAMapRect rect1, MAMapRect rect2);
		public static MAMapRect MAMapRectUnion(MAMapRect rect1, MAMapRect rect2)
        {
			return _MAMapRectUnion(rect1, rect2);
        }

		// extern BOOL MAMapSizeContainsSize (MAMapSize size1, MAMapSize size2);
		[DllImport("__Internal",EntryPoint = "MAMapSizeContainsSize")]
		static extern bool _MAMapSizeContainsSize(MAMapSize size1, MAMapSize size2);
		public static bool MAMapSizeContainsSize(MAMapSize size1, MAMapSize size2)
        {
			return _MAMapSizeContainsSize(size1, size2);
		}

		// extern BOOL MAMapRectContainsPoint (MAMapRect rect, MAMapPoint point);
		[DllImport("__Internal",EntryPoint = "MAMapRectContainsPoint")]
		static extern bool _MAMapRectContainsPoint(MAMapRect rect, MAMapPoint point);
		public static bool MAMapRectContainsPoint(MAMapRect rect, MAMapPoint point)
        {
			return _MAMapRectContainsPoint(rect, point);
		}

		// extern BOOL MAMapRectIntersectsRect (MAMapRect rect1, MAMapRect rect2);
		[DllImport("__Internal",EntryPoint = "MAMapRectIntersectsRect")]
		static extern bool _MAMapRectIntersectsRect(MAMapRect rect1, MAMapRect rect2);
		public static bool MAMapRectIntersectsRect(MAMapRect rect1, MAMapRect rect2)
        {
			return _MAMapRectIntersectsRect(rect1, rect2);
		}

		// extern BOOL MAMapRectContainsRect (MAMapRect rect1, MAMapRect rect2);
		[DllImport("__Internal",EntryPoint = "MAMapRectContainsRect")]
		static extern bool _MAMapRectContainsRect(MAMapRect rect1, MAMapRect rect2);
		public static bool MAMapRectContainsRect(MAMapRect rect1, MAMapRect rect2)
        {
			return _MAMapRectContainsRect(rect1, rect2);
		}

		// extern BOOL MACircleContainsPoint (MAMapPoint point, MAMapPoint center, double radius);
		[DllImport("__Internal",EntryPoint = "MACircleContainsPoint")]
		static extern bool _MACircleContainsPoint(MAMapPoint point, MAMapPoint center, double radius);
		public static bool MACircleContainsPoint(MAMapPoint point, MAMapPoint center, double radius)
        {
            return _MACircleContainsPoint(point, center, radius);
        }

		// extern BOOL MACircleContainsCoordinate (CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius);
		[DllImport("__Internal",EntryPoint = "MACircleContainsCoordinate")]
		static extern bool _MACircleContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius);
		public static bool MACircleContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius)
        {
			return _MACircleContainsCoordinate(point, center, radius);
		}

		// extern MAMapPoint MAGetNearestMapPointFromPolyline (MAMapPoint point, MAMapPoint *polyline, NSUInteger count);
		[DllImport("__Internal",EntryPoint = "MAGetNearestMapPointFromPolyline")]
		static extern MAMapPoint _MAGetNearestMapPointFromPolyline(MAMapPoint point, MAMapPoint polyline, nuint count);
		public static MAMapPoint MAGetNearestMapPointFromPolyline(MAMapPoint point, MAMapPoint polyline, nuint count)
        {
			return _MAGetNearestMapPointFromPolyline(point, polyline, count);
		}

		// extern BOOL MAPolygonContainsPoint (MAMapPoint point, MAMapPoint *polygon, NSUInteger count);
		[DllImport("__Internal",EntryPoint = "MAPolygonContainsPoint")]
		static extern bool _MAPolygonContainsPoint(MAMapPoint point, MAMapPoint polygon, nuint count);
		public static bool MAPolygonContainsPoint(MAMapPoint point, MAMapPoint polygon, nuint count)
        {
			return _MAPolygonContainsPoint(point, polygon, count);
		}

		// extern BOOL MAPolygonContainsCoordinate (CLLocationCoordinate2D point, CLLocationCoordinate2D *polygon, NSUInteger count);
		[DllImport("__Internal",EntryPoint = "MAPolygonContainsCoordinate")]
		static extern bool _MAPolygonContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D polygon, nuint count);
		public static bool MAPolygonContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D polygon, nuint count)
        {
			return _MAPolygonContainsCoordinate(point, polygon, count);
		}

		// extern MAMapPoint MAGetNearestMapPointFromLine (MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point);
		[DllImport("__Internal",EntryPoint = "MAGetNearestMapPointFromLine")]
		static extern MAMapPoint _MAGetNearestMapPointFromLine(MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point);
		public static MAMapPoint MAGetNearestMapPointFromLine(MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point)
        {
			return _MAGetNearestMapPointFromLine(lineStart, lineEnd, point);
		}

		// extern void MAGetTileProjectionFromBounds (MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection);
		[DllImport("__Internal",EntryPoint = "MAGetTileProjectionFromBounds")]
		static extern void _MAGetTileProjectionFromBounds(MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection);        
		public static void MAGetTileProjectionFromBounds(MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection)
        {
			_MAGetTileProjectionFromBounds(bounds, levelOfDetails, tileProjection);
		}

		// extern double MAAreaForPolygon (CLLocationCoordinate2D *coordinates, int count);
		[DllImport("__Internal",EntryPoint = "MAAreaForPolygon")]
		static extern double _MAAreaForPolygon(CLLocationCoordinate2D coordinates, int count);
		public static double MAAreaForPolygon(CLLocationCoordinate2D coordinates, int count)
        {
			return _MAAreaForPolygon(coordinates, count);
		}

		// MAMapPoint MAMapPointMake (double x, double y);
		//[DllImport("__Internal",EntryPoint = "MAMapPointMake")]
		//static extern MAMapPoint _MAMapPointMake(double x, double y);
        ////
		public static MAMapPoint MAMapPointMake(double x, double y)            
        {
			return new MAMapPoint() { x = x, y = y };
		}

		// MAMapSize MAMapSizeMake (double width, double height);
		//[DllImport("__Internal",EntryPoint = "MAMapSizeMake")]
		//static extern MAMapSize _MAMapSizeMake(double width, double height);
        ////
		public static MAMapSize MAMapSizeMake(double width, double height)
        {
			return new MAMapSize() { width = width, height = height };
		}

		// MAMapRect MAMapRectMake (double x, double y, double width, double height);
		//[DllImport("__Internal",EntryPoint = "MAMapRectMake")]
		//static extern MAMapRect _MAMapRectMake(double x, double y, double width, double height);
        ////
		public static MAMapRect MAMapRectMake(double x, double y, double width, double height)
        {
			return new MAMapRect() { origin = MAMapPointMake(x, y), size = MAMapSizeMake(width, height) };
		}

		// double MAMapRectGetMinX (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectGetMinX")]
		//static extern double _MAMapRectGetMinX(MAMapRect rect);
        ////
		public static double MAMapRectGetMinX(MAMapRect rect)
        {
			return rect.origin.x;
		}

		// double MAMapRectGetMinY (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectGetMinY")]
		//static extern double _MAMapRectGetMinY(MAMapRect rect);
        ////
		public static double MAMapRectGetMinY(MAMapRect rect)
        {
			return rect.origin.y;
		}

		// double MAMapRectGetMidX (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectGetMidX")]
		//static extern double _MAMapRectGetMidX(MAMapRect rect);
        ////
		public static double MAMapRectGetMidX(MAMapRect rect)
        {
			return rect.origin.x + rect.size.width / 2.0;
		}

		// double MAMapRectGetMidY (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectGetMidY")]
		//static extern double _MAMapRectGetMidY(MAMapRect rect);
        ////
		public static double MAMapRectGetMidY(MAMapRect rect)
        {
			return rect.origin.y + rect.size.height / 2.0;
		}

		// double MAMapRectGetMaxX (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectGetMaxX")]
		//static extern double _MAMapRectGetMaxX(MAMapRect rect);
        ////
		public static double MAMapRectGetMaxX(MAMapRect rect)
        {
			return rect.origin.x + rect.size.width;
		}

		// double MAMapRectGetMaxY (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectGetMaxY")]
		//static extern double _MAMapRectGetMaxY(MAMapRect rect);
        ////
		public static double MAMapRectGetMaxY(MAMapRect rect)
        {
			return rect.origin.y + rect.size.height;
		}

		// double MAMapRectGetWidth (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectGetWidth")]
		//static extern double _MAMapRectGetWidth(MAMapRect rect);
        ////
		public static double MAMapRectGetWidth(MAMapRect rect)
        {
			return rect.size.width;
		}

		// double MAMapRectGetHeight (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectGetHeight")]
		//static extern double _MAMapRectGetHeight(MAMapRect rect);
        ////
		public static double MAMapRectGetHeight(MAMapRect rect)
        {
			return rect.size.height;
		}

		// BOOL MAMapPointEqualToPoint (MAMapPoint point1, MAMapPoint point2);
		//[DllImport("__Internal",EntryPoint = "MAMapPointEqualToPoint")]
		//static extern bool _MAMapPointEqualToPoint(MAMapPoint point1, MAMapPoint point2);
        ////
		public static bool MAMapPointEqualToPoint(MAMapPoint point1, MAMapPoint point2)
        {
			return point1.x == point2.x && point1.y == point2.y;
		}

		// BOOL MAMapSizeEqualToSize (MAMapSize size1, MAMapSize size2);
		//[DllImport("__Internal",EntryPoint = "MAMapSizeEqualToSize")]
		//static extern bool _MAMapSizeEqualToSize(MAMapSize size1, MAMapSize size2);
        ////
		public static bool MAMapSizeEqualToSize(MAMapSize size1, MAMapSize size2)
        {
			return size1.width == size2.width && size1.height == size2.height;
		}

		// BOOL MAMapRectEqualToRect (MAMapRect rect1, MAMapRect rect2);
		//[DllImport("__Internal",EntryPoint = "MAMapRectEqualToRect")]
		//static extern bool _MAMapRectEqualToRect(MAMapRect rect1, MAMapRect rect2);
        ////
		public static bool MAMapRectEqualToRect(MAMapRect rect1, MAMapRect rect2)
        {
			var one = MAMapPointEqualToPoint(rect1.origin, rect2.origin);
			var two = MAMapSizeEqualToSize(rect1.size, rect2.size);

			return one && two;
		}

		// BOOL MAMapRectIsNull (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectIsNull")]
		//static extern bool _MAMapRectIsNull(MAMapRect rect);
        ////
		public static bool MAMapRectIsNull(MAMapRect rect)
        {
			return double.IsInfinity(rect.origin.x) || double.IsInfinity(rect.origin.y);
		}

		// BOOL MAMapRectIsEmpty (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAMapRectIsEmpty")]
		//static extern bool _MAMapRectIsEmpty(MAMapRect rect);
        ////
		public static bool MAMapRectIsEmpty(MAMapRect rect)
        {
			return MAMapRectIsNull(rect) || (rect.size.width == 0.0 && rect.size.height == 0.0);
		}

		// NSString * MAStringFromMapPoint (MAMapPoint point);
		//[DllImport("__Internal",EntryPoint = "MAStringFromMapPoint")]
		//static extern NSString _MAStringFromMapPoint(MAMapPoint point);
        ////
        public static string MAStringFromMapPoint(MAMapPoint point)
        {            
			return string.Format(@"{%.1f, %.1f}", point.x, point.y);
		}

		// NSString * MAStringFromMapSize (MAMapSize size);
		//[DllImport("__Internal",EntryPoint = "MAStringFromMapSize")]
		//static extern NSString _MAStringFromMapSize(MAMapSize size);
        ////
        public static string MAStringFromMapSize(MAMapSize size)
        {
			var a = size.width;
			var b = size.height;
			return string.Format(@"{%.1f, %.1f}", a, b);
		}

		// NSString * MAStringFromMapRect (MAMapRect rect);
		//[DllImport("__Internal",EntryPoint = "MAStringFromMapRect")]
		//static extern NSString _MAStringFromMapRect(MAMapRect rect);
        ////
		public static string MAStringFromMapRect(MAMapRect rect)
        {
			var a = MAStringFromMapPoint(rect.origin);
			var b = MAStringFromMapSize(rect.size);
			return string.Format(@"{%@, %@}", a, b);
		}

		// extern CLLocationCoordinate2D MACoordinateConvert (CLLocationCoordinate2D coordinate, MACoordinateType type) __attribute__((deprecated("已废弃，使用AMapFoundation中关于坐标转换的接口")));
		[DllImport("__Internal",EntryPoint = "MACoordinateConvert")]
		static extern CLLocationCoordinate2D _MACoordinateConvert(CLLocationCoordinate2D coordinate, MACoordinateType type);
		public static CLLocationCoordinate2D MACoordinateConvert(CLLocationCoordinate2D coordinate, MACoordinateType type)
        {
			return _MACoordinateConvert(coordinate, type);
		}

		// extern CLLocationDirection MAGetDirectionFromCoords (CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord);
		[DllImport("__Internal",EntryPoint = "MAGetDirectionFromCoords")]
		static extern double _MAGetDirectionFromCoords(CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord);
		public static double MAGetDirectionFromCoords(CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord)
        {
			return _MAGetDirectionFromCoords(fromCoord, toCoord);
		}

		// extern CLLocationDirection MAGetDirectionFromPoints (MAMapPoint fromPoint, MAMapPoint toPoint);
		[DllImport("__Internal",EntryPoint = "MAGetDirectionFromPoints")]
		static extern double _MAGetDirectionFromPoints(MAMapPoint fromPoint, MAMapPoint toPoint);
		public static double MAGetDirectionFromPoints(MAMapPoint fromPoint, MAMapPoint toPoint)
        {
			return _MAGetDirectionFromPoints(fromPoint, toPoint);
		}

		// extern double MAGetDistanceFromPointToLine (MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd);
		[DllImport("__Internal",EntryPoint = "MAGetDistanceFromPointToLine")]
		static extern double _MAGetDistanceFromPointToLine(MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd);
		public static double MAGetDistanceFromPointToLine(MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd)
        {
			return _MAGetDistanceFromPointToLine(point, lineBegin, lineEnd);
		}

		// extern BOOL MAPolylineHitTest (MAMapPoint *linePoints, NSUInteger count, MAMapPoint tappedPoint, CGFloat lineWidth);
		[DllImport("__Internal",EntryPoint = "MAPolylineHitTest")]
		static extern bool _MAPolylineHitTest(MAMapPoint linePoints, nuint count, MAMapPoint tappedPoint, nfloat lineWidth);
		public static bool MAPolylineHitTest(MAMapPoint linePoints, nuint count, MAMapPoint tappedPoint, nfloat lineWidth)
        {
			return _MAPolylineHitTest(linePoints, count, tappedPoint, lineWidth);
		}
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
}

