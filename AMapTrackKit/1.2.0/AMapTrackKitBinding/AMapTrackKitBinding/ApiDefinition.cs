using System;
using AMapTrackKit;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace AMapTrackKit
{

	[Static]
	partial interface Constants
	{
		// extern NSString *const AMapTrackVersion;
		[Field("AMapTrackVersion", "__Internal")]
		NSString AMapTrackVersion { get; }

		// extern NSString *const AMapTrackName;
		[Field("AMapTrackName", "__Internal")]
		NSString AMapTrackName { get; }

		// extern NSString *const AMapTrackErrorDomain;
		[Field("AMapTrackErrorDomain", "__Internal")]
		NSString AMapTrackErrorDomain { get; }
	}

	// @interface AMapTrackManagerOptions : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapTrackManagerOptions
	{
		// @property (copy, nonatomic) NSString * _Nonnull serviceID;
		[Export("serviceID")]
		string ServiceID { get; set; }
	}

	// @interface AMapTrackManagerServiceOption : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapTrackManagerServiceOption
	{
		// @property (copy, nonatomic) NSString * _Nonnull terminalID;
		[Export("terminalID")]
		string TerminalID { get; set; }
	}

	// @interface AMapTrackObject : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface AMapTrackObject : INSCopying, INSCoding
	{
		// -(NSString * _Nonnull)formattedDescription;
		[Export("formattedDescription")]
		string FormattedDescription { get; }
	}

	// @interface AMapTrackBaseRequest : AMapTrackObject
	[BaseType(typeof(AMapTrackObject))]
	interface AMapTrackBaseRequest
	{
		// @property (copy, nonatomic) NSString * _Nonnull serviceID;
		[Export("serviceID")]
		string ServiceID { get; set; }
	}

	// @interface AMapTrackBaseResponse : AMapTrackObject
	[BaseType(typeof(AMapTrackObject))]
	interface AMapTrackBaseResponse
	{
		// @property (assign, nonatomic) AMapTrackErrorCode code;
		[Export("code", ArgumentSemantic.Assign)]
		AMapTrackErrorCode Code { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull info;
		[Export("info")]
		string Info { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull detail;
		[Export("detail")]
		string Detail { get; set; }
	}

	// @interface AMapTrackTerminal : AMapTrackObject
	[BaseType(typeof(AMapTrackObject))]
	interface AMapTrackTerminal
	{
		// @property (copy, nonatomic) NSString * _Nonnull tid;
		[Export("tid")]
		string Tid { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull desc;
		[Export("desc")]
		string Desc { get; set; }

		// @property (assign, nonatomic) long long createTime;
		[Export("createTime")]
		long CreateTime { get; set; }

		// @property (assign, nonatomic) long long locateTime;
		[Export("locateTime")]
		long LocateTime { get; set; }
	}

	// @interface AMapTrackPoint : AMapTrackObject
	[BaseType(typeof(AMapTrackObject))]
	interface AMapTrackPoint
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) long long locateTime;
		[Export("locateTime")]
		long LocateTime { get; set; }

		// @property (assign, nonatomic) double speed;
		[Export("speed")]
		double Speed { get; set; }

		// @property (assign, nonatomic) double direction;
		[Export("direction")]
		double Direction { get; set; }

		// @property (assign, nonatomic) double height;
		[Export("height")]
		double Height { get; set; }

		// @property (assign, nonatomic) double accuracy;
		[Export("accuracy")]
		double Accuracy { get; set; }

		// @property (assign, nonatomic) long long createTime;
		[Export("createTime")]
		long CreateTime { get; set; }

		// -(NSDictionary * _Nonnull)customProperties;
		[Export("customProperties")]
		NSDictionary CustomProperties { get; }
	}

	// @interface AMapTrackBasicTrack : AMapTrackObject
	[BaseType(typeof(AMapTrackObject))]
	interface AMapTrackBasicTrack
	{
		// @property (copy, nonatomic) NSString * _Nonnull trackID;
		[Export("trackID")]
		string TrackID { get; set; }

		// @property (assign, nonatomic) NSUInteger counts;
		[Export("counts")]
		nuint Counts { get; set; }

		// @property (assign, nonatomic) NSUInteger distance;
		[Export("distance")]
		nuint Distance { get; set; }

		// @property (assign, nonatomic) long long lastingTime;
		[Export("lastingTime")]
		long LastingTime { get; set; }

		// @property (nonatomic, strong) NSArray<AMapTrackPoint *> * _Nonnull points;
		[Export("points", ArgumentSemantic.Strong)]
		AMapTrackPoint[] Points { get; set; }

		// @property (nonatomic, strong) AMapTrackPoint * _Nonnull startPoint;
		[Export("startPoint", ArgumentSemantic.Strong)]
		AMapTrackPoint StartPoint { get; set; }

		// @property (nonatomic, strong) AMapTrackPoint * _Nonnull endPoint;
		[Export("endPoint", ArgumentSemantic.Strong)]
		AMapTrackPoint EndPoint { get; set; }
	}

	// @interface AMapTrackAddTerminalRequest : AMapTrackBaseRequest
	[BaseType(typeof(AMapTrackBaseRequest))]
	interface AMapTrackAddTerminalRequest
	{
		// @property (copy, nonatomic) NSString * terminalName;
		[Export("terminalName")]
		string TerminalName { get; set; }

		// @property (copy, nonatomic) NSString * terminalDesc;
		[Export("terminalDesc")]
		string TerminalDesc { get; set; }
	}

	// @interface AMapTrackAddTerminalResponse : AMapTrackBaseResponse
	[BaseType(typeof(AMapTrackBaseResponse))]
	interface AMapTrackAddTerminalResponse
	{
		// @property (copy, nonatomic) NSString * serviceID;
		[Export("serviceID")]
		string ServiceID { get; set; }

		// @property (copy, nonatomic) NSString * terminalID;
		[Export("terminalID")]
		string TerminalID { get; set; }

		// @property (copy, nonatomic) NSString * terminalName;
		[Export("terminalName")]
		string TerminalName { get; set; }
	}

	// @interface AMapTrackQueryTerminalRequest : AMapTrackBaseRequest
	[BaseType(typeof(AMapTrackBaseRequest))]
	interface AMapTrackQueryTerminalRequest
	{
		// @property (copy, nonatomic) NSString * terminalID;
		[Export("terminalID")]
		string TerminalID { get; set; }

		// @property (copy, nonatomic) NSString * terminalName;
		[Export("terminalName")]
		string TerminalName { get; set; }
	}

	// @interface AMapTrackQueryTerminalResponse : AMapTrackBaseResponse
	[BaseType(typeof(AMapTrackBaseResponse))]
	interface AMapTrackQueryTerminalResponse
	{
		// @property (nonatomic, strong) NSArray<AMapTrackTerminal *> * terminals;
		[Export("terminals", ArgumentSemantic.Strong)]
		AMapTrackTerminal[] Terminals { get; set; }
	}

	// @interface AMapTrackAddTrackRequest : AMapTrackBaseRequest
	[BaseType(typeof(AMapTrackBaseRequest))]
	interface AMapTrackAddTrackRequest
	{
		// @property (nonatomic, strong) NSString * terminalID;
		[Export("terminalID", ArgumentSemantic.Strong)]
		string TerminalID { get; set; }
	}

	// @interface AMapTrackAddTrackResponse : AMapTrackBaseResponse
	[BaseType(typeof(AMapTrackBaseResponse))]
	interface AMapTrackAddTrackResponse
	{
		// @property (nonatomic, strong) NSString * trackID;
		[Export("trackID", ArgumentSemantic.Strong)]
		string TrackID { get; set; }
	}

	// @interface AMapTrackDeleteTrackRequest : AMapTrackBaseRequest
	[BaseType(typeof(AMapTrackBaseRequest))]
	interface AMapTrackDeleteTrackRequest
	{
		// @property (nonatomic, strong) NSString * terminalID;
		[Export("terminalID", ArgumentSemantic.Strong)]
		string TerminalID { get; set; }

		// @property (nonatomic, strong) NSString * trackID;
		[Export("trackID", ArgumentSemantic.Strong)]
		string TrackID { get; set; }
	}

	// @interface AMapTrackQueryLastPointRequest : AMapTrackBaseRequest
	[BaseType(typeof(AMapTrackBaseRequest))]
	interface AMapTrackQueryLastPointRequest
	{
		// @property (copy, nonatomic) NSString * terminalID;
		[Export("terminalID")]
		string TerminalID { get; set; }

		// @property (copy, nonatomic) NSString * trackID;
		[Export("trackID")]
		string TrackID { get; set; }

		// @property (copy, nonatomic) NSString * correctionMode;
		[Export("correctionMode")]
		string CorrectionMode { get; set; }
	}

	// @interface AMapTrackQueryLastPointResponse : AMapTrackBaseResponse
	[BaseType(typeof(AMapTrackBaseResponse))]
	interface AMapTrackQueryLastPointResponse
	{
		// @property (nonatomic, strong) AMapTrackPoint * lastPoint;
		[Export("lastPoint", ArgumentSemantic.Strong)]
		AMapTrackPoint LastPoint { get; set; }
	}

	// @interface AMapTrackQueryTrackDistanceRequest : AMapTrackBaseRequest
	[BaseType(typeof(AMapTrackBaseRequest))]
	interface AMapTrackQueryTrackDistanceRequest
	{
		// @property (copy, nonatomic) NSString * terminalID;
		[Export("terminalID")]
		string TerminalID { get; set; }

		// @property (copy, nonatomic) NSString * trackID;
		[Export("trackID")]
		string TrackID { get; set; }

		// @property (assign, nonatomic) long long startTime;
		[Export("startTime")]
		long StartTime { get; set; }

		// @property (assign, nonatomic) long long endTime;
		[Export("endTime")]
		long EndTime { get; set; }

		// @property (copy, nonatomic) NSString * correctionMode;
		[Export("correctionMode")]
		string CorrectionMode { get; set; }

		// @property (assign, nonatomic) AMapTrackRecoupMode recoupMode;
		[Export("recoupMode", ArgumentSemantic.Assign)]
		AMapTrackRecoupMode RecoupMode { get; set; }

		// @property (assign, nonatomic) NSUInteger recoupGap;
		[Export("recoupGap")]
		nuint RecoupGap { get; set; }
	}

	// @interface AMapTrackQueryTrackDistanceResponse : AMapTrackBaseResponse
	[BaseType(typeof(AMapTrackBaseResponse))]
	interface AMapTrackQueryTrackDistanceResponse
	{
		// @property (assign, nonatomic) NSUInteger distance;
		[Export("distance")]
		nuint Distance { get; set; }
	}

	// @interface AMapTrackQueryTrackHistoryAndDistanceRequest : AMapTrackBaseRequest
	[BaseType(typeof(AMapTrackBaseRequest))]
	interface AMapTrackQueryTrackHistoryAndDistanceRequest
	{
		// @property (copy, nonatomic) NSString * terminalID;
		[Export("terminalID")]
		string TerminalID { get; set; }

		// @property (assign, nonatomic) long long startTime;
		[Export("startTime")]
		long StartTime { get; set; }

		// @property (assign, nonatomic) long long endTime;
		[Export("endTime")]
		long EndTime { get; set; }

		// @property (copy, nonatomic) NSString * correctionMode;
		[Export("correctionMode")]
		string CorrectionMode { get; set; }

		// @property (assign, nonatomic) AMapTrackRecoupMode recoupMode;
		[Export("recoupMode", ArgumentSemantic.Assign)]
		AMapTrackRecoupMode RecoupMode { get; set; }

		// @property (assign, nonatomic) NSUInteger recoupGap;
		[Export("recoupGap")]
		nuint RecoupGap { get; set; }

		// @property (assign, nonatomic) int sortType;
		[Export("sortType")]
		int SortType { get; set; }

		// @property (assign, nonatomic) NSUInteger pageIndex;
		[Export("pageIndex")]
		nuint PageIndex { get; set; }

		// @property (assign, nonatomic) NSUInteger pageSize;
		[Export("pageSize")]
		nuint PageSize { get; set; }
	}

	// @interface AMapTrackQueryTrackHistoryAndDistanceResponse : AMapTrackBaseResponse
	[BaseType(typeof(AMapTrackBaseResponse))]
	interface AMapTrackQueryTrackHistoryAndDistanceResponse
	{
		// @property (assign, nonatomic) NSUInteger distance;
		[Export("distance")]
		nuint Distance { get; set; }

		// @property (assign, nonatomic) NSUInteger count;
		[Export("count")]
		nuint Count { get; set; }

		// @property (nonatomic, strong) AMapTrackPoint * startPoint;
		[Export("startPoint", ArgumentSemantic.Strong)]
		AMapTrackPoint StartPoint { get; set; }

		// @property (nonatomic, strong) AMapTrackPoint * endPoint;
		[Export("endPoint", ArgumentSemantic.Strong)]
		AMapTrackPoint EndPoint { get; set; }

		// @property (nonatomic, strong) NSArray<AMapTrackPoint *> * points;
		[Export("points", ArgumentSemantic.Strong)]
		AMapTrackPoint[] Points { get; set; }
	}

	// @interface AMapTrackQueryTrackInfoRequest : AMapTrackBaseRequest
	[BaseType(typeof(AMapTrackBaseRequest))]
	interface AMapTrackQueryTrackInfoRequest
	{
		// @property (copy, nonatomic) NSString * terminalID;
		[Export("terminalID")]
		string TerminalID { get; set; }

		// @property (copy, nonatomic) NSString * trackID;
		[Export("trackID")]
		string TrackID { get; set; }

		// @property (assign, nonatomic) long long startTime;
		[Export("startTime")]
		long StartTime { get; set; }

		// @property (assign, nonatomic) long long endTime;
		[Export("endTime")]
		long EndTime { get; set; }

		// @property (copy, nonatomic) NSString * correctionMode;
		[Export("correctionMode")]
		string CorrectionMode { get; set; }

		// @property (assign, nonatomic) AMapTrackRecoupMode recoupMode;
		[Export("recoupMode", ArgumentSemantic.Assign)]
		AMapTrackRecoupMode RecoupMode { get; set; }

		// @property (assign, nonatomic) NSUInteger recoupGap;
		[Export("recoupGap")]
		nuint RecoupGap { get; set; }

		// @property (assign, nonatomic) BOOL containPoints;
		[Export("containPoints")]
		bool ContainPoints { get; set; }

		// @property (assign, nonatomic) NSUInteger pageIndex;
		[Export("pageIndex")]
		nuint PageIndex { get; set; }

		// @property (assign, nonatomic) NSUInteger pageSize;
		[Export("pageSize")]
		nuint PageSize { get; set; }
	}

	// @interface AMapTrackQueryTrackInfoResponse : AMapTrackBaseResponse
	[BaseType(typeof(AMapTrackBaseResponse))]
	interface AMapTrackQueryTrackInfoResponse
	{
		// @property (nonatomic, strong) NSArray<AMapTrackBasicTrack *> * tracks;
		[Export("tracks", ArgumentSemantic.Strong)]
		AMapTrackBasicTrack[] Tracks { get; set; }

		// @property (assign, nonatomic) NSUInteger counts;
		[Export("counts")]
		nuint Counts { get; set; }
	}

	// @interface AMapTrackManager : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapTrackManager
	{
		// -(instancetype _Nonnull)initWithOptions:(AMapTrackManagerOptions * _Nonnull)options __attribute__((objc_designated_initializer));
		[Export("initWithOptions:")]
		[DesignatedInitializer]
		IntPtr Constructor(AMapTrackManagerOptions options);

		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapTrackManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapTrackManagerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) CLActivityType activityType;
		[Export("activityType", ArgumentSemantic.Assign)]
		CLActivityType ActivityType { get; set; }

		// @property (assign, nonatomic) CLLocationDistance distanceFilter;
		[Export("distanceFilter")]
		double DistanceFilter { get; set; }

		// @property (assign, nonatomic) CLLocationAccuracy desiredAccuracy;
		[Export("desiredAccuracy")]
		double DesiredAccuracy { get; set; }

		// @property (assign, nonatomic) BOOL pausesLocationUpdatesAutomatically;
		[Export("pausesLocationUpdatesAutomatically")]
		bool PausesLocationUpdatesAutomatically { get; set; }

		// @property (assign, nonatomic) BOOL allowsBackgroundLocationUpdates;
		[Export("allowsBackgroundLocationUpdates")]
		bool AllowsBackgroundLocationUpdates { get; set; }

		// @property (readonly, nonatomic) NSUInteger gatherInterval;
		[Export("gatherInterval")]
		nuint GatherInterval { get; }

		// @property (readonly, nonatomic) NSUInteger packInterval;
		[Export("packInterval")]
		nuint PackInterval { get; }

		// -(void)changeGatherAndPackTimeInterval:(NSInteger)gatherTimeInterval packTimeInterval:(NSInteger)packTimeInterval;
		[Export("changeGatherAndPackTimeInterval:packTimeInterval:")]
		void ChangeGatherAndPackTimeInterval(nint gatherTimeInterval, nint packTimeInterval);

		// @property (readonly, nonatomic) NSString * _Nonnull serviceID;
		[Export("serviceID")]
		string ServiceID { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull terminalID;
		[Export("terminalID")]
		string TerminalID { get; }

		// @property (copy, nonatomic) NSString * _Nonnull trackID;
		[Export("trackID")]
		string TrackID { get; set; }

		// -(void)startServiceWithOptions:(AMapTrackManagerServiceOption * _Nonnull)options;
		[Export("startServiceWithOptions:")]
		void StartServiceWithOptions(AMapTrackManagerServiceOption options);

		// -(void)stopService;
		[Export("stopService")]
		void StopService();

		// -(void)startGatherAndPack;
		[Export("startGatherAndPack")]
		void StartGatherAndPack();

		// -(void)stopGaterAndPack;
		[Export("stopGaterAndPack")]
		void StopGaterAndPack();

		// -(BOOL)setLocalCacheMaxSize:(NSInteger)cacheMaxSize;
		[Export("setLocalCacheMaxSize:")]
		bool SetLocalCacheMaxSize(nint cacheMaxSize);

		// @property (readonly, nonatomic) NSUInteger cacheMaxSize;
		[Export("cacheMaxSize")]
		nuint CacheMaxSize { get; }

		// @property (assign, nonatomic) NSInteger timeout;
		[Export("timeout")]
		nint Timeout { get; set; }

		// -(void)cancelAllRequests;
		[Export("cancelAllRequests")]
		void CancelAllRequests();

		// -(void)AMapTrackAddTerminal:(AMapTrackAddTerminalRequest * _Nonnull)request;
		[Export("AMapTrackAddTerminal:")]
		void AMapTrackAddTerminal(AMapTrackAddTerminalRequest request);

		// -(void)AMapTrackQueryTerminal:(AMapTrackQueryTerminalRequest * _Nonnull)request;
		[Export("AMapTrackQueryTerminal:")]
		void AMapTrackQueryTerminal(AMapTrackQueryTerminalRequest request);

		// -(void)AMapTrackAddTrack:(AMapTrackAddTrackRequest * _Nonnull)request;
		[Export("AMapTrackAddTrack:")]
		void AMapTrackAddTrack(AMapTrackAddTrackRequest request);

		// -(void)AMapTrackDeleteTrack:(AMapTrackDeleteTrackRequest * _Nonnull)request;
		[Export("AMapTrackDeleteTrack:")]
		void AMapTrackDeleteTrack(AMapTrackDeleteTrackRequest request);

		// -(void)AMapTrackQueryLastPoint:(AMapTrackQueryLastPointRequest * _Nonnull)request;
		[Export("AMapTrackQueryLastPoint:")]
		void AMapTrackQueryLastPoint(AMapTrackQueryLastPointRequest request);

		// -(void)AMapTrackQueryTrackDistance:(AMapTrackQueryTrackDistanceRequest * _Nonnull)request;
		[Export("AMapTrackQueryTrackDistance:")]
		void AMapTrackQueryTrackDistance(AMapTrackQueryTrackDistanceRequest request);

		// -(void)AMapTrackQueryTrackHistoryAndDistance:(AMapTrackQueryTrackHistoryAndDistanceRequest * _Nonnull)request;
		[Export("AMapTrackQueryTrackHistoryAndDistance:")]
		void AMapTrackQueryTrackHistoryAndDistance(AMapTrackQueryTrackHistoryAndDistanceRequest request);

		// -(void)AMapTrackQueryTrackInfo:(AMapTrackQueryTrackInfoRequest * _Nonnull)request;
		[Export("AMapTrackQueryTrackInfo:")]
		void AMapTrackQueryTrackInfo(AMapTrackQueryTrackInfoRequest request);
	}

	// @protocol AMapTrackManagerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapTrackManagerDelegate
	{
		// @optional -(void)didFailWithError:(NSError * _Nonnull)error associatedRequest:(id _Nonnull)request;
		[Export("didFailWithError:associatedRequest:")]
		void DidFailWithError(NSError error, NSObject request);

		// @optional -(void)onStartService:(AMapTrackErrorCode)errorCode;
		[Export("onStartService:")]
		void OnStartService(AMapTrackErrorCode errorCode);

		// @optional -(void)onStopService:(AMapTrackErrorCode)errorCode;
		[Export("onStopService:")]
		void OnStopService(AMapTrackErrorCode errorCode);

		// @optional -(void)onStartGatherAndPack:(AMapTrackErrorCode)errorCode;
		[Export("onStartGatherAndPack:")]
		void OnStartGatherAndPack(AMapTrackErrorCode errorCode);

		// @optional -(void)onStopGatherAndPack:(AMapTrackErrorCode)errorCode;
		[Export("onStopGatherAndPack:")]
		void OnStopGatherAndPack(AMapTrackErrorCode errorCode);

		// @optional -(void)onStopGatherAndPack:(AMapTrackErrorCode)errorCode errorMessage:(NSString * _Nullable)errorMessage;
		[Export("onStopGatherAndPack:errorMessage:")]
		void OnStopGatherAndPack(AMapTrackErrorCode errorCode, [NullAllowed] string errorMessage);

		// @optional -(NSDictionary<NSString *,NSString *> * _Nonnull)trackManagerGetCustomDictionary;
		[Export("trackManagerGetCustomDictionary")]
		NSDictionary<NSString, NSString> TrackManagerGetCustomDictionary { get; }

		// @optional -(void)onAddTerminalDone:(AMapTrackAddTerminalRequest * _Nonnull)request response:(AMapTrackAddTerminalResponse * _Nonnull)response;
		[Export("onAddTerminalDone:response:")]
		void OnAddTerminalDone(AMapTrackAddTerminalRequest request, AMapTrackAddTerminalResponse response);

		// @optional -(void)onQueryTerminalDone:(AMapTrackQueryTerminalRequest * _Nonnull)request response:(AMapTrackQueryTerminalResponse * _Nonnull)response;
		[Export("onQueryTerminalDone:response:")]
		void OnQueryTerminalDone(AMapTrackQueryTerminalRequest request, AMapTrackQueryTerminalResponse response);

		// @optional -(void)onAddTrackDone:(AMapTrackAddTrackRequest * _Nonnull)request response:(AMapTrackAddTrackResponse * _Nonnull)response;
		[Export("onAddTrackDone:response:")]
		void OnAddTrackDone(AMapTrackAddTrackRequest request, AMapTrackAddTrackResponse response);

		// @optional -(void)onDeleteTrackDone:(AMapTrackDeleteTrackRequest * _Nonnull)request response:(AMapTrackBaseResponse * _Nonnull)response;
		[Export("onDeleteTrackDone:response:")]
		void OnDeleteTrackDone(AMapTrackDeleteTrackRequest request, AMapTrackBaseResponse response);

		// @optional -(void)onQueryLastPointDone:(AMapTrackQueryLastPointRequest * _Nonnull)request response:(AMapTrackQueryLastPointResponse * _Nonnull)response;
		[Export("onQueryLastPointDone:response:")]
		void OnQueryLastPointDone(AMapTrackQueryLastPointRequest request, AMapTrackQueryLastPointResponse response);

		// @optional -(void)onQueryTrackDistanceDone:(AMapTrackQueryTrackDistanceRequest * _Nonnull)request response:(AMapTrackQueryTrackDistanceResponse * _Nonnull)response;
		[Export("onQueryTrackDistanceDone:response:")]
		void OnQueryTrackDistanceDone(AMapTrackQueryTrackDistanceRequest request, AMapTrackQueryTrackDistanceResponse response);

		// @optional -(void)onQueryTrackHistoryAndDistanceDone:(AMapTrackQueryTrackHistoryAndDistanceRequest * _Nonnull)request response:(AMapTrackQueryTrackHistoryAndDistanceResponse * _Nonnull)response;
		[Export("onQueryTrackHistoryAndDistanceDone:response:")]
		void OnQueryTrackHistoryAndDistanceDone(AMapTrackQueryTrackHistoryAndDistanceRequest request, AMapTrackQueryTrackHistoryAndDistanceResponse response);

		// @optional -(void)onQueryTrackInfoDone:(AMapTrackQueryTrackInfoRequest * _Nonnull)request response:(AMapTrackQueryTrackInfoResponse * _Nonnull)response;
		[Export("onQueryTrackInfoDone:response:")]
		void OnQueryTrackInfoDone(AMapTrackQueryTrackInfoRequest request, AMapTrackQueryTrackInfoResponse response);
	}
}

