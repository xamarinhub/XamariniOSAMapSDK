using System;
using AMapFoundationKit;
using AMapNaviKit;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AMapNaviKit
{
	

	// typedef void (^MAOfflineMapDownloadBlock)(MAOfflineItem *, MAOfflineMapDownloadStatus, id);
	public delegate void MAOfflineMapDownloadBlock(MAOfflineItem arg0, MAOfflineMapDownloadStatus arg1, NSObject arg2);

	// typedef void (^MAOfflineMapNewestVersionBlock)(BOOL);
	public delegate void MAOfflineMapNewestVersionBlock(bool arg0);

	// typedef void (^MAProcessingCallback)(int, NSArray<MATracePoint *> *);
	public delegate void MAProcessingCallback(int arg0, MATracePoint[] arg1);

	// typedef void (^MAFinishCallback)(NSArray<MATracePoint *> *, double);
	public delegate void MAFinishCallback(MATracePoint[] arg0, double arg1);

	// typedef void (^MAFailedCallback)(int, NSString *);
	public delegate void MAFailedCallback(int arg0, string arg1);

	// typedef void (^MATraceLocationCallback)(NSArray<CLLocation *> *, NSArray<MATracePoint *> *, double, NSError *);
	public delegate void MATraceLocationCallback(CLLocation[] arg0, MATracePoint[] arg1, double arg2, NSError arg3);

	[Static]
	partial interface Constants
	{
		// extern NSString *const MAMapKitVersion;
		[Field("MAMapKitVersion", "__Internal")]
		NSString MAMapKitVersion { get; }

		// extern NSString *const MAMapKitName;
		[Field("MAMapKitName", "__Internal")]
		NSString MAMapKitName { get; }
	}

	partial interface Constants
	{
		// extern const MAMapSize MAMapSizeWorld;
		[Field("MAMapSizeWorld", "__Internal")]
		//MAMapSize MAMapSizeWorld { get; }
		IntPtr MAMapSizeWorld { get; }

		// extern const MAMapRect MAMapRectWorld;
		[Field("MAMapRectWorld", "__Internal")]
		//MAMapRect MAMapRectWorld { get; }
		IntPtr MAMapRectWorld { get; }

		// extern const MAMapRect MAMapRectNull;
		[Field("MAMapRectNull", "__Internal")]
		//MAMapRect MAMapRectNull { get; }
		IntPtr MAMapRectNull { get; }

		// extern const MAMapRect MAMapRectZero;
		[Field("MAMapRectZero", "__Internal")]
		//MAMapRect MAMapRectZero { get; }
		IntPtr MAMapRectZero { get; }
	}	

	// @interface NSValueMAGeometryExtensions (NSValue)
	[Category]
	[BaseType(typeof(NSValue))]
	interface NSValue_NSValueMAGeometryExtensions
	{
		// +(NSValue *)valueWithMAMapPoint:(MAMapPoint)mapPoint;
		[Static]
		[Export("valueWithMAMapPoint:")]
		NSValue ValueWithMAMapPoint(MAMapPoint mapPoint);

		// +(NSValue *)valueWithMAMapSize:(MAMapSize)mapSize;
		[Static]
		[Export("valueWithMAMapSize:")]
		NSValue ValueWithMAMapSize(MAMapSize mapSize);

		// +(NSValue *)valueWithMAMapRect:(MAMapRect)mapRect;
		[Static]
		[Export("valueWithMAMapRect:")]
		NSValue ValueWithMAMapRect(MAMapRect mapRect);

		// +(NSValue *)valueWithMACoordinate:(CLLocationCoordinate2D)coordinate;
		[Static]
		[Export("valueWithMACoordinate:")]
		NSValue ValueWithMACoordinate(CLLocationCoordinate2D coordinate);

		// -(MAMapPoint)MAMapPointValue;
		//[Export("MAMapPointValue")]
		//MAMapPoint MAMapPointValue { get; }
		[Export("MAMapPointValue")]
		MAMapPoint MAMapPointValue();

		// -(MAMapSize)MAMapSizeValue;
		//[Export("MAMapSizeValue")]
		//MAMapSize MAMapSizeValue { get; }
		[Export("MAMapSizeValue")]
		MAMapSize MAMapSizeValue();

		// -(MAMapRect)MAMapRectValue;
		//[Export("MAMapRectValue")]
		//MAMapRect MAMapRectValue { get; }
		[Export("MAMapRectValue")]
		MAMapRect MAMapRectValue();

		// -(CLLocationCoordinate2D)MACoordinateValue;
		//[Export("MACoordinateValue")]
		//CLLocationCoordinate2D MACoordinateValue { get; }
		[Export("MACoordinateValue")]
		CLLocationCoordinate2D MACoordinateValue();
	}

	// @protocol MAAnnotation <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	
	//interface IMAAnnotation { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface MAAnnotation
	{
		// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
		//[Abstract]
		[Export("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }

		// @optional @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @optional @property (copy, nonatomic) NSString * subtitle;
		[Export("subtitle")]
		string Subtitle { get; set; }

		// @optional -(void)setCoordinate:(CLLocationCoordinate2D)newCoordinate;
		[Export("setCoordinate:")]
		void SetCoordinate(CLLocationCoordinate2D newCoordinate);
	}

	// @protocol MAAnimatableAnnotation <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	//interface IMAAnimatableAnnotation { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface MAAnimatableAnnotation
	{
		// @required -(void)step:(CGFloat)timeDelta;
		[Abstract]
		[Export("step:")]
		void Step(nfloat timeDelta);

		// @required -(BOOL)isAnimationFinished;
		[Abstract]
		[Export("isAnimationFinished")]
		bool IsAnimationFinished { get; }

		// @required -(BOOL)shouldAnimationStart;
		[Abstract]
		[Export("shouldAnimationStart")]
		bool ShouldAnimationStart { get; }

		// @optional -(CLLocationDirection)rotateDegree;
		[Export("rotateDegree")]
		double RotateDegree { get; }
	}

	// @protocol MAOverlay <MAAnnotation>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	//interface IMAOverlay { }
	[Protocol]
    [BaseType(typeof(MAAnnotation))]
	interface MAOverlay //: MAAnnotation
	{
		// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
		//[Abstract]
		[Export("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }

		// @required @property (readonly, nonatomic) MAMapRect boundingMapRect;
		[Abstract]
		[Export("boundingMapRect")]
		MAMapRect BoundingMapRect { get; }
	}

    [Protocol,Model]
    [BaseType(typeof(NSObject))]
	interface MAOverlayRenderDelegate { }

	// @interface MAOverlayRenderer : NSObject
	[BaseType(typeof(NSObject))]
	interface MAOverlayRenderer
	{
		[Wrap("WeakRendererDelegate")]
		MAOverlayRenderDelegate RendererDelegate { get; set; }

		// @property (nonatomic, weak) id<MAOverlayRenderDelegate> rendererDelegate;
		[NullAllowed, Export("rendererDelegate", ArgumentSemantic.Weak)]
		NSObject WeakRendererDelegate { get; set; }

		// @property (readonly, retain, nonatomic) id<MAOverlay> overlay;
		[Export("overlay", ArgumentSemantic.Retain)]
		MAOverlay Overlay { get; }

		// @property (nonatomic, strong) UIImage * strokeImage;
		[Export("strokeImage", ArgumentSemantic.Strong)]
		UIImage StrokeImage { get; set; }

		// @property (readonly, nonatomic) GLuint strokeTextureID;
		[Export("strokeTextureID")]
		uint StrokeTextureID { get; }

		// @property (assign, nonatomic) CGFloat alpha;
		[Export("alpha")]
		nfloat Alpha { get; set; }

		// @property (readonly, nonatomic) CGFloat contentScale;
		[Export("contentScale")]
		nfloat ContentScale { get; }

		// -(instancetype)initWithOverlay:(id<MAOverlay>)overlay;
		[Export("initWithOverlay:")]
		IntPtr Constructor(MAOverlay overlay);

		// -(float *)getViewMatrix;
		[Export("getViewMatrix")]
		float ViewMatrix { get; }

		// -(float *)getProjectionMatrix;
		[Export("getProjectionMatrix")]
		float ProjectionMatrix { get; }

		// -(MAMapPoint)getOffsetPoint;
		[Export("getOffsetPoint")]
		MAMapPoint OffsetPoint { get; }

		// -(CGFloat)getMapZoomLevel;
		[Export("getMapZoomLevel")]
		nfloat MapZoomLevel { get; }

		// -(CGPoint)glPointForMapPoint:(MAMapPoint)mapPoint;
		[Export("glPointForMapPoint:")]
		CGPoint GlPointForMapPoint(MAMapPoint mapPoint);

		// -(CGPoint *)glPointsForMapPoints:(MAMapPoint *)mapPoints count:(NSUInteger)count;
		[Export("glPointsForMapPoints:count:")]
		CGPoint GlPointsForMapPoints(MAMapPoint mapPoints, nuint count);

		// -(CGFloat)glWidthForWindowWidth:(CGFloat)windowWidth;
		[Export("glWidthForWindowWidth:")]
		nfloat GlWidthForWindowWidth(nfloat windowWidth);

		// -(void)renderLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount strokeColor:(UIColor *)strokeColor lineWidth:(CGFloat)lineWidth looped:(BOOL)looped __attribute__((deprecated("已废弃")));
		[Export("renderLinesWithPoints:pointCount:strokeColor:lineWidth:looped:")]
		void RenderLinesWithPoints(CGPoint points, nuint pointCount, UIColor strokeColor, nfloat lineWidth, bool looped);

		// -(void)renderLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount strokeColor:(UIColor *)strokeColor lineWidth:(CGFloat)lineWidth looped:(BOOL)looped LineJoinType:(MALineJoinType)lineJoinType LineCapType:(MALineCapType)lineCapType lineDash:(MALineDashType)lineDash __attribute__((deprecated("已废弃")));
		[Export("renderLinesWithPoints:pointCount:strokeColor:lineWidth:looped:LineJoinType:LineCapType:lineDash:")]
		void RenderLinesWithPoints(CGPoint points, nuint pointCount, UIColor strokeColor, nfloat lineWidth, bool looped, MALineJoinType lineJoinType, MALineCapType lineCapType, MALineDashType lineDash);

		// -(void)renderTexturedLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount lineWidth:(CGFloat)lineWidth textureID:(GLuint)textureID looped:(BOOL)looped __attribute__((deprecated("已废弃")));
		[Export("renderTexturedLinesWithPoints:pointCount:lineWidth:textureID:looped:")]
		void RenderTexturedLinesWithPoints(CGPoint points, nuint pointCount, nfloat lineWidth, uint textureID, bool looped);

		// -(void)renderTexturedLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount lineWidth:(CGFloat)lineWidth textureIDs:(NSArray *)textureIDs drawStyleIndexes:(NSArray *)drawStyleIndexes looped:(BOOL)looped __attribute__((deprecated("已废弃")));
		[Export("renderTexturedLinesWithPoints:pointCount:lineWidth:textureIDs:drawStyleIndexes:looped:")]
		void RenderTexturedLinesWithPoints(CGPoint points, nuint pointCount, nfloat lineWidth, NSObject[] textureIDs, NSObject[] drawStyleIndexes, bool looped);

		// -(void)renderLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount strokeColors:(NSArray *)strokeColors drawStyleIndexes:(NSArray *)drawStyleIndexes isGradient:(BOOL)isGradient lineWidth:(CGFloat)lineWidth looped:(BOOL)looped LineJoinType:(MALineJoinType)lineJoinType LineCapType:(MALineCapType)lineCapType lineDash:(MALineDashType)lineDash __attribute__((deprecated("已废弃")));
		[Export("renderLinesWithPoints:pointCount:strokeColors:drawStyleIndexes:isGradient:lineWidth:looped:LineJoinType:LineCapType:lineDash:")]
		void RenderLinesWithPoints(CGPoint points, nuint pointCount, NSObject[] strokeColors, NSObject[] drawStyleIndexes, bool isGradient, nfloat lineWidth, bool looped, MALineJoinType lineJoinType, MALineCapType lineCapType, MALineDashType lineDash);

		// -(void)renderRegionWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount fillColor:(UIColor *)fillColor usingTriangleFan:(BOOL)usingTriangleFan __attribute__((deprecated("已废弃")));
		[Export("renderRegionWithPoints:pointCount:fillColor:usingTriangleFan:")]
		void RenderRegionWithPoints(CGPoint points, nuint pointCount, UIColor fillColor, bool usingTriangleFan);

		// -(void)renderStrokedRegionWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount fillColor:(UIColor *)fillColor strokeColor:(UIColor *)strokeColor strokeLineWidth:(CGFloat)strokeLineWidth strokeLineJoinType:(MALineJoinType)strokeLineJoinType strokeLineDash:(MALineDashType)strokeLineDash usingTriangleFan:(BOOL)usingTriangleFan __attribute__((deprecated("已废弃")));
		[Export("renderStrokedRegionWithPoints:pointCount:fillColor:strokeColor:strokeLineWidth:strokeLineJoinType:strokeLineDash:usingTriangleFan:")]
		void RenderStrokedRegionWithPoints(CGPoint points, nuint pointCount, UIColor fillColor, UIColor strokeColor, nfloat strokeLineWidth, MALineJoinType strokeLineJoinType, MALineDashType strokeLineDash, bool usingTriangleFan);

		// -(void)renderTextureStrokedRegionWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount fillColor:(UIColor *)fillColor strokeTineWidth:(CGFloat)strokeLineWidth strokeTextureID:(GLuint)strokeTexture usingTriangleFan:(BOOL)usingTriangleFan __attribute__((deprecated("已废弃")));
		[Export("renderTextureStrokedRegionWithPoints:pointCount:fillColor:strokeTineWidth:strokeTextureID:usingTriangleFan:")]
		void RenderTextureStrokedRegionWithPoints(CGPoint points, nuint pointCount, UIColor fillColor, nfloat strokeLineWidth, uint strokeTexture, bool usingTriangleFan);

		// -(void)renderIconWithTextureID:(GLuint)textureID points:(CGPoint *)points __attribute__((deprecated("已废弃")));
		[Export("renderIconWithTextureID:points:")]
		void RenderIconWithTextureID(uint textureID, CGPoint points);

		// -(void)renderIconWithTextureID:(GLuint)textureID points:(CGPoint *)points modulateColor:(UIColor *)modulateColor __attribute__((deprecated("已废弃")));
		[Export("renderIconWithTextureID:points:modulateColor:")]
		void RenderIconWithTextureID(uint textureID, CGPoint points, UIColor modulateColor);

		// -(void)glRender;
		[Export("glRender")]
		void GlRender();

		// -(GLuint)loadStrokeTextureImage:(UIImage *)textureImage __attribute__((deprecated("已废弃, 请通过属性strokeImage设置")));
		[Export("loadStrokeTextureImage:")]
		uint LoadStrokeTextureImage(UIImage textureImage);

		// -(GLuint)loadTexture:(UIImage *)textureImage;
		[Export("loadTexture:")]
		uint LoadTexture(UIImage textureImage);

		// -(void)deleteTexture:(GLuint)textureId;
		[Export("deleteTexture:")]
		void DeleteTexture(uint textureId);

		// -(void)setNeedsUpdate;
		[Export("setNeedsUpdate")]
		void SetNeedsUpdate();
	}

	// @interface MACustomCalloutView : UIView
	[BaseType(typeof(UIView))]
	interface MACustomCalloutView
	{
		// @property (readonly, nonatomic, strong) UIView * customView;
		[Export("customView", ArgumentSemantic.Strong)]
		UIView CustomView { get; }

		// @property (nonatomic, strong) id userData;
		[Export("userData", ArgumentSemantic.Strong)]
		NSObject UserData { get; set; }

		// -(id)initWithCustomView:(UIView *)customView;
		[Export("initWithCustomView:")]
		IntPtr Constructor(UIView customView);
	}

	// @interface MAAnnotationView : UIView
	[BaseType(typeof(UIView))]
	interface MAAnnotationView
	{
		// @property (readonly, copy, nonatomic) NSString * reuseIdentifier;
		[Export("reuseIdentifier")]
		string ReuseIdentifier { get; }

		// @property (assign, nonatomic) NSInteger zIndex;
		[Export("zIndex")]
		nint ZIndex { get; set; }

		// @property (nonatomic, strong) id<MAAnnotation> annotation;
		[Export("annotation", ArgumentSemantic.Strong)]
		MAAnnotation Annotation { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (readonly, nonatomic, strong) UIImageView * imageView;
		[Export("imageView", ArgumentSemantic.Strong)]
		UIImageView ImageView { get; }

		// @property (nonatomic, strong) MACustomCalloutView * customCalloutView;
		[Export("customCalloutView", ArgumentSemantic.Strong)]
		MACustomCalloutView CustomCalloutView { get; set; }

		// @property (nonatomic) CGPoint centerOffset;
		[Export("centerOffset", ArgumentSemantic.Assign)]
		CGPoint CenterOffset { get; set; }

		// @property (nonatomic) CGPoint calloutOffset;
		[Export("calloutOffset", ArgumentSemantic.Assign)]
		CGPoint CalloutOffset { get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export("enabled")]
		bool Enabled { [Bind("isEnabled")] get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export("highlighted")]
		bool Highlighted { [Bind("isHighlighted")] get; set; }

		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export("selected")]
		bool Selected { [Bind("isSelected")] get; set; }

		// @property (nonatomic) BOOL canShowCallout;
		[Export("canShowCallout")]
		bool CanShowCallout { get; set; }

		// @property (nonatomic, strong) UIView * leftCalloutAccessoryView;
		[Export("leftCalloutAccessoryView", ArgumentSemantic.Strong)]
		UIView LeftCalloutAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * rightCalloutAccessoryView;
		[Export("rightCalloutAccessoryView", ArgumentSemantic.Strong)]
		UIView RightCalloutAccessoryView { get; set; }

		// @property (getter = isDraggable, nonatomic) BOOL draggable;
		[Export("draggable")]
		bool Draggable { [Bind("isDraggable")] get; set; }

		// @property (nonatomic) MAAnnotationViewDragState dragState;
		[Export("dragState", ArgumentSemantic.Assign)]
		MAAnnotationViewDragState DragState { get; set; }

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export("setSelected:animated:")]
		void SetSelected(bool selected, bool animated);

		// -(id)initWithAnnotation:(id<MAAnnotation>)annotation reuseIdentifier:(NSString *)reuseIdentifier;
		[Export("initWithAnnotation:reuseIdentifier:")]
		IntPtr Constructor(MAAnnotation annotation, string reuseIdentifier);

		// -(void)prepareForReuse;
		[Export("prepareForReuse")]
		void PrepareForReuse();

		// -(void)setDragState:(MAAnnotationViewDragState)newDragState animated:(BOOL)animated;
		[Export("setDragState:animated:")]
		void SetDragState(MAAnnotationViewDragState newDragState, bool animated);
	}

	// @interface MAShape : NSObject <MAAnnotation>
	[BaseType(typeof(NSObject))]
	interface MAShape : MAAnnotation
	{
		// @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * subtitle;
		[Export("subtitle")]
		string Subtitle { get; set; }
	}

	// @interface MACircle : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	interface MACircle : MAOverlay
	{
		// @property (nonatomic, strong) NSArray<id<MAOverlay>> * hollowShapes;
		[Export("hollowShapes", ArgumentSemantic.Strong)]
		MAOverlay[] HollowShapes { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) CLLocationDistance radius;
		[Export("radius")]
		double Radius { get; set; }

		// @property (readonly, nonatomic) MAMapRect boundingMapRect;
		[Export("boundingMapRect")]
		MAMapRect BoundingMapRect { get; }

		// +(instancetype)circleWithCenterCoordinate:(CLLocationCoordinate2D)coord radius:(CLLocationDistance)radius;
		[Static]
		[Export("circleWithCenterCoordinate:radius:")]
		MACircle CircleWithCenterCoordinate(CLLocationCoordinate2D coord, double radius);

		// +(instancetype)circleWithMapRect:(MAMapRect)mapRect;
		[Static]
		[Export("circleWithMapRect:")]
		MACircle CircleWithMapRect(MAMapRect mapRect);

		// -(BOOL)setCircleWithCenterCoordinate:(CLLocationCoordinate2D)coord radius:(CLLocationDistance)radius;
		[Export("setCircleWithCenterCoordinate:radius:")]
		bool SetCircleWithCenterCoordinate(CLLocationCoordinate2D coord, double radius);
	}

	// @interface MAPointAnnotation : MAShape
	[BaseType(typeof(MAShape))]
	interface MAPointAnnotation
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (getter = isLockedToScreen, assign, nonatomic) BOOL lockedToScreen;
		[Export("lockedToScreen")]
		bool LockedToScreen { [Bind("isLockedToScreen")] get; set; }

		// @property (assign, nonatomic) CGPoint lockedScreenPoint;
		[Export("lockedScreenPoint", ArgumentSemantic.Assign)]
		CGPoint LockedScreenPoint { get; set; }
	}

	// @interface MAAnnotationMoveAnimation : NSObject
	[BaseType(typeof(NSObject))]
	interface MAAnnotationMoveAnimation
	{
		// -(NSString *)name;
		[Export("name")]
		string Name { get; }

		// -(CLLocationCoordinate2D *)coordinates;
		[Export("coordinates")]
		CLLocationCoordinate2D Coordinates { get; }

		// -(NSUInteger)count;
		[Export("count")]
		nuint Count { get; }

		// -(CGFloat)duration;
		[Export("duration")]
		nfloat Duration { get; }

		// -(CGFloat)elapsedTime;
		[Export("elapsedTime")]
		nfloat ElapsedTime { get; }

		// -(void)cancel;
		[Export("cancel")]
		void Cancel();

		// -(BOOL)isCancelled;
		[Export("isCancelled")]
		bool IsCancelled { get; }

		// -(NSInteger)passedPointCount;
		[Export("passedPointCount")]
		nint PassedPointCount { get; }
	}

	// @interface MAAnimatedAnnotation : MAPointAnnotation <MAAnimatableAnnotation>
	[BaseType(typeof(MAPointAnnotation))]
	interface MAAnimatedAnnotation : MAAnimatableAnnotation
	{
		// @property (assign, nonatomic) CLLocationDirection movingDirection;
		[Export("movingDirection")]
		double MovingDirection { get; set; }

		// -(MAAnnotationMoveAnimation *)addMoveAnimationWithKeyCoordinates:(CLLocationCoordinate2D *)coordinates count:(NSUInteger)count withDuration:(CGFloat)duration withName:(NSString *)name completeCallback:(void (^)(BOOL))completeCallback;
		[Export("addMoveAnimationWithKeyCoordinates:count:withDuration:withName:completeCallback:")]
		MAAnnotationMoveAnimation AddMoveAnimationWithKeyCoordinates(CLLocationCoordinate2D coordinates, nuint count, nfloat duration, string name, Action<bool> completeCallback);

		// -(MAAnnotationMoveAnimation *)addMoveAnimationWithKeyCoordinates:(CLLocationCoordinate2D *)coordinates count:(NSUInteger)count withDuration:(CGFloat)duration withName:(NSString *)name completeCallback:(void (^)(BOOL))completeCallback stepCallback:(void (^)(MAAnnotationMoveAnimation *))stepCallback;
		[Export("addMoveAnimationWithKeyCoordinates:count:withDuration:withName:completeCallback:stepCallback:")]
		MAAnnotationMoveAnimation AddMoveAnimationWithKeyCoordinates(CLLocationCoordinate2D coordinates, nuint count, nfloat duration, string name, Action<bool> completeCallback, Action<MAAnnotationMoveAnimation> stepCallback);

		// -(NSArray<MAAnnotationMoveAnimation *> *)allMoveAnimations;
		[Export("allMoveAnimations")]
		MAAnnotationMoveAnimation[] AllMoveAnimations { get; }

		// -(void)setNeedsStart;
		[Export("setNeedsStart")]
		void SetNeedsStart();
	}

	// @interface MAUserLocation : MAAnimatedAnnotation
	[BaseType(typeof(MAAnimatedAnnotation))]
	interface MAUserLocation
	{
		// @property (readonly, getter = isUpdating, nonatomic) BOOL updating;
		[Export("updating")]
		bool Updating { [Bind("isUpdating")] get; }

		// @property (readonly, nonatomic, strong) CLLocation * location;
		[Export("location", ArgumentSemantic.Strong)]
		CLLocation Location { get; }

		// @property (readonly, nonatomic, strong) CLHeading * heading;
		[Export("heading", ArgumentSemantic.Strong)]
		CLHeading Heading { get; }
	}

	// @interface MAMapStatus : NSObject
	[BaseType(typeof(NSObject))]
	interface MAMapStatus
	{
		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export("centerCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		// @property (nonatomic) CGFloat zoomLevel;
		[Export("zoomLevel")]
		nfloat ZoomLevel { get; set; }

		// @property (nonatomic) CGFloat rotationDegree;
		[Export("rotationDegree")]
		nfloat RotationDegree { get; set; }

		// @property (nonatomic) CGFloat cameraDegree;
		[Export("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (nonatomic) CGPoint screenAnchor;
		[Export("screenAnchor", ArgumentSemantic.Assign)]
		CGPoint ScreenAnchor { get; set; }

		// +(instancetype)statusWithCenterCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel rotationDegree:(CGFloat)rotationDegree cameraDegree:(CGFloat)cameraDegree screenAnchor:(CGPoint)screenAnchor;
		[Static]
		[Export("statusWithCenterCoordinate:zoomLevel:rotationDegree:cameraDegree:screenAnchor:")]
		MAMapStatus StatusWithCenterCoordinate(CLLocationCoordinate2D coordinate, nfloat zoomLevel, nfloat rotationDegree, nfloat cameraDegree, CGPoint screenAnchor);

		// -(id)initWithCenterCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel rotationDegree:(CGFloat)rotationDegree cameraDegree:(CGFloat)cameraDegree screenAnchor:(CGPoint)screenAnchor;
		[Export("initWithCenterCoordinate:zoomLevel:rotationDegree:cameraDegree:screenAnchor:")]
		IntPtr Constructor(CLLocationCoordinate2D coordinate, nfloat zoomLevel, nfloat rotationDegree, nfloat cameraDegree, CGPoint screenAnchor);
	}

	// @interface MAIndoorFloorInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface MAIndoorFloorInfo
	{
		// @property (readonly, nonatomic) NSString * floorName;
		[Export("floorName")]
		string FloorName { get; }

		// @property (readonly, nonatomic) int floorIndex;
		[Export("floorIndex")]
		int FloorIndex { get; }

		// @property (readonly, nonatomic) NSString * floorNona;
		[Export("floorNona")]
		string FloorNona { get; }

		// @property (readonly, nonatomic) BOOL isPark;
		[Export("isPark")]
		bool IsPark { get; }
	}

	// @interface MAIndoorInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface MAIndoorInfo
	{
		// @property (readonly, nonatomic) NSString * cnName;
		[Export("cnName")]
		string CnName { get; }

		// @property (readonly, nonatomic) NSString * enName;
		[Export("enName")]
		string EnName { get; }

		// @property (readonly, nonatomic) NSString * poiID;
		[Export("poiID")]
		string PoiID { get; }

		// @property (readonly, nonatomic) NSString * buildingType;
		[Export("buildingType")]
		string BuildingType { get; }

		// @property (readonly, nonatomic) int activeFloorIndex;
		[Export("activeFloorIndex")]
		int ActiveFloorIndex { get; }

		// @property (readonly, nonatomic) int activeFloorInfoIndex;
		[Export("activeFloorInfoIndex")]
		int ActiveFloorInfoIndex { get; }

		// @property (readonly, nonatomic) NSArray * floorInfo;
		[Export("floorInfo")]
		NSObject[] FloorInfo { get; }

		// @property (readonly, nonatomic) int numberOfFloor;
		[Export("numberOfFloor")]
		int NumberOfFloor { get; }

		// @property (readonly, nonatomic) int numberOfParkFloor;
		[Export("numberOfParkFloor")]
		int NumberOfParkFloor { get; }
	}

	// @interface MAUserLocationRepresentation : NSObject
	[BaseType(typeof(NSObject))]
	interface MAUserLocationRepresentation
	{
		// @property (assign, nonatomic) BOOL showsAccuracyRing;
		[Export("showsAccuracyRing")]
		bool ShowsAccuracyRing { get; set; }

		// @property (assign, nonatomic) BOOL showsHeadingIndicator;
		[Export("showsHeadingIndicator")]
		bool ShowsHeadingIndicator { get; set; }

		// @property (nonatomic, strong) UIColor * fillColor;
		[Export("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (nonatomic, strong) UIColor * strokeColor;
		[Export("strokeColor", ArgumentSemantic.Strong)]
		UIColor StrokeColor { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (nonatomic, strong) UIColor * locationDotBgColor;
		[Export("locationDotBgColor", ArgumentSemantic.Strong)]
		UIColor LocationDotBgColor { get; set; }

		// @property (nonatomic, strong) UIColor * locationDotFillColor;
		[Export("locationDotFillColor", ArgumentSemantic.Strong)]
		UIColor LocationDotFillColor { get; set; }

		// @property (assign, nonatomic) BOOL enablePulseAnnimation;
		[Export("enablePulseAnnimation")]
		bool EnablePulseAnnimation { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }
	}

	// @interface MAMapCustomStyleOptions : NSObject
	[BaseType(typeof(NSObject))]
	interface MAMapCustomStyleOptions
	{
		// @property (nonatomic, strong) NSData * styleData;
		[Export("styleData", ArgumentSemantic.Strong)]
		NSData StyleData { get; set; }

		// @property (nonatomic, strong) NSString * styleId;
		[Export("styleId", ArgumentSemantic.Strong)]
		string StyleId { get; set; }

		// @property (nonatomic, strong) NSData * styleTextureData;
		[Export("styleTextureData", ArgumentSemantic.Strong)]
		NSData StyleTextureData { get; set; }

		// @property (nonatomic, strong) NSData * styleExtraData;
		[Export("styleExtraData", ArgumentSemantic.Strong)]
		NSData StyleExtraData { get; set; }
	}

	partial interface Constants
	{
		// extern NSString *const kMAMapLayerCenterMapPointKey;
		[Field("kMAMapLayerCenterMapPointKey", "__Internal")]
		NSString kMAMapLayerCenterMapPointKey { get; }

		// extern NSString *const kMAMapLayerZoomLevelKey;
		[Field("kMAMapLayerZoomLevelKey", "__Internal")]
		NSString kMAMapLayerZoomLevelKey { get; }

		// extern NSString *const kMAMapLayerRotationDegreeKey;
		[Field("kMAMapLayerRotationDegreeKey", "__Internal")]
		NSString kMAMapLayerRotationDegreeKey { get; }

		// extern NSString *const kMAMapLayerCameraDegreeKey;
		[Field("kMAMapLayerCameraDegreeKey", "__Internal")]
		NSString kMAMapLayerCameraDegreeKey { get; }
	}

	// @interface MAMapView : UIView
	[BaseType(typeof(UIView))]
	interface MAMapView
	{
		[Wrap("WeakDelegate")]
		MAMapViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MAMapViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) MAMapType mapType;
		[Export("mapType", ArgumentSemantic.Assign)]
		MAMapType MapType { get; set; }

		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export("centerCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		// @property (nonatomic) MACoordinateRegion region;
		[Export("region", ArgumentSemantic.Assign)]
		MACoordinateRegion Region { get; set; }

		// @property (nonatomic) MAMapRect visibleMapRect;
		[Export("visibleMapRect", ArgumentSemantic.Assign)]
		MAMapRect VisibleMapRect { get; set; }

		// @property (assign, nonatomic) MACoordinateRegion limitRegion;
		[Export("limitRegion", ArgumentSemantic.Assign)]
		MACoordinateRegion LimitRegion { get; set; }

		// @property (assign, nonatomic) MAMapRect limitMapRect;
		[Export("limitMapRect", ArgumentSemantic.Assign)]
		MAMapRect LimitMapRect { get; set; }

		// @property (nonatomic) CGFloat zoomLevel;
		[Export("zoomLevel")]
		nfloat ZoomLevel { get; set; }

		// @property (nonatomic) CGFloat minZoomLevel;
		[Export("minZoomLevel")]
		nfloat MinZoomLevel { get; set; }

		// @property (nonatomic) CGFloat maxZoomLevel;
		[Export("maxZoomLevel")]
		nfloat MaxZoomLevel { get; set; }

		// @property (nonatomic) CGFloat rotationDegree;
		[Export("rotationDegree")]
		nfloat RotationDegree { get; set; }

		// @property (nonatomic) CGFloat cameraDegree;
		[Export("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (assign, nonatomic) BOOL zoomingInPivotsAroundAnchorPoint;
		[Export("zoomingInPivotsAroundAnchorPoint")]
		bool ZoomingInPivotsAroundAnchorPoint { get; set; }

		// @property (getter = isZoomEnabled, nonatomic) BOOL zoomEnabled;
		[Export("zoomEnabled")]
		bool ZoomEnabled { [Bind("isZoomEnabled")] get; set; }

		// @property (getter = isScrollEnabled, nonatomic) BOOL scrollEnabled;
		[Export("scrollEnabled")]
		bool ScrollEnabled { [Bind("isScrollEnabled")] get; set; }

		// @property (getter = isRotateEnabled, nonatomic) BOOL rotateEnabled;
		[Export("rotateEnabled")]
		bool RotateEnabled { [Bind("isRotateEnabled")] get; set; }

		// @property (getter = isRotateCameraEnabled, nonatomic) BOOL rotateCameraEnabled;
		[Export("rotateCameraEnabled")]
		bool RotateCameraEnabled { [Bind("isRotateCameraEnabled")] get; set; }

		// @property (getter = isSkyModelEnabled, nonatomic) BOOL skyModelEnable __attribute__((deprecated("已废弃 since 6.0.0")));
		[Export("skyModelEnable")]
		bool SkyModelEnable { [Bind("isSkyModelEnabled")] get; set; }

		// @property (getter = isShowsBuildings, nonatomic) BOOL showsBuildings;
		[Export("showsBuildings")]
		bool ShowsBuildings { [Bind("isShowsBuildings")] get; set; }

		// @property (getter = isShowsLabels, assign, nonatomic) BOOL showsLabels;
		[Export("showsLabels")]
		bool ShowsLabels { [Bind("isShowsLabels")] get; set; }

		// @property (getter = isShowTraffic, nonatomic) BOOL showTraffic;
		[Export("showTraffic")]
		bool ShowTraffic { [Bind("isShowTraffic")] get; set; }

		// @property (copy, nonatomic) NSDictionary<NSNumber *,UIColor *> * trafficStatus;
		[Export("trafficStatus", ArgumentSemantic.Copy)]
		NSDictionary<NSNumber, UIColor> TrafficStatus { get; set; }

		// @property (assign, nonatomic) CGFloat trafficRatio __attribute__((deprecated("已废弃 since 6.0.0, 不再支持修改实时交通线宽")));
		[Export("trafficRatio")]
		nfloat TrafficRatio { get; set; }

		// @property (assign, nonatomic) BOOL touchPOIEnabled;
		[Export("touchPOIEnabled")]
		bool TouchPOIEnabled { get; set; }

		// @property (assign, nonatomic) BOOL showsCompass;
		[Export("showsCompass")]
		bool ShowsCompass { get; set; }

		// @property (assign, nonatomic) CGPoint compassOrigin;
		[Export("compassOrigin", ArgumentSemantic.Assign)]
		CGPoint CompassOrigin { get; set; }

		// @property (readonly, nonatomic) CGSize compassSize;
		[Export("compassSize")]
		CGSize CompassSize { get; }

		// @property (assign, nonatomic) BOOL showsScale;
		[Export("showsScale")]
		bool ShowsScale { get; set; }

		// @property (assign, nonatomic) CGPoint scaleOrigin;
		[Export("scaleOrigin", ArgumentSemantic.Assign)]
		CGPoint ScaleOrigin { get; set; }

		// @property (readonly, nonatomic) CGSize scaleSize;
		[Export("scaleSize")]
		CGSize ScaleSize { get; }

		// @property (assign, nonatomic) CGPoint logoCenter;
		[Export("logoCenter", ArgumentSemantic.Assign)]
		CGPoint LogoCenter { get; set; }

		// @property (readonly, nonatomic) CGSize logoSize;
		[Export("logoSize")]
		CGSize LogoSize { get; }

		// @property (readonly, nonatomic) double metersPerPointForCurrentZoom;
		[Export("metersPerPointForCurrentZoom")]
		double MetersPerPointForCurrentZoom { get; }

		// @property (readonly, nonatomic) BOOL isAbroad;
		[Export("isAbroad")]
		bool IsAbroad { get; }

		// @property (assign, nonatomic) NSUInteger maxRenderFrame;
		[Export("maxRenderFrame")]
		nuint MaxRenderFrame { get; set; }

		// @property (assign, nonatomic) BOOL isAllowDecreaseFrame;
		[Export("isAllowDecreaseFrame")]
		bool IsAllowDecreaseFrame { get; set; }

		// @property (assign, nonatomic) BOOL openGLESDisabled;
		[Export("openGLESDisabled")]
		bool OpenGLESDisabled { get; set; }

		// @property (assign, nonatomic) CGPoint screenAnchor;
		[Export("screenAnchor", ArgumentSemantic.Assign)]
		CGPoint ScreenAnchor { get; set; }

		// @property (copy, nonatomic) NSRunLoopMode runLoopMode;
		[Export("runLoopMode")]
		string RunLoopMode { get; set; }

		// @property (getter = isShowsWorldMap, nonatomic) NSNumber * showsWorldMap;
		[Export("showsWorldMap", ArgumentSemantic.Assign)]
		NSNumber ShowsWorldMap { [Bind("isShowsWorldMap")] get; set; }

		// @property (nonatomic, strong) NSNumber * mapLanguage;
		[Export("mapLanguage", ArgumentSemantic.Strong)]
		NSNumber MapLanguage { get; set; }

		// -(void)setRegion:(MACoordinateRegion)region animated:(BOOL)animated;
		[Export("setRegion:animated:")]
		void SetRegion(MACoordinateRegion region, bool animated);

		// -(MACoordinateRegion)regionThatFits:(MACoordinateRegion)region;
		[Export("regionThatFits:")]
		MACoordinateRegion RegionThatFits(MACoordinateRegion region);

		// -(void)setVisibleMapRect:(MAMapRect)mapRect animated:(BOOL)animated;
		[Export("setVisibleMapRect:animated:")]
		void SetVisibleMapRect(MAMapRect mapRect, bool animated);

		// -(MAMapRect)mapRectThatFits:(MAMapRect)mapRect;
		[Export("mapRectThatFits:")]
		MAMapRect MapRectThatFits(MAMapRect mapRect);

		// -(MAMapRect)mapRectThatFits:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets;
		[Export("mapRectThatFits:edgePadding:")]
		MAMapRect MapRectThatFits(MAMapRect mapRect, UIEdgeInsets insets);

		// -(void)setVisibleMapRect:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("setVisibleMapRect:edgePadding:animated:")]
		void SetVisibleMapRect(MAMapRect mapRect, UIEdgeInsets insets, bool animated);

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
		[Export("setCenterCoordinate:animated:")]
		void SetCenterCoordinate(CLLocationCoordinate2D coordinate, bool animated);

		// -(void)setZoomLevel:(CGFloat)zoomLevel animated:(BOOL)animated;
		[Export("setZoomLevel:animated:")]
		void SetZoomLevel(nfloat zoomLevel, bool animated);

		// -(void)setZoomLevel:(CGFloat)zoomLevel atPivot:(CGPoint)pivot animated:(BOOL)animated;
		[Export("setZoomLevel:atPivot:animated:")]
		void SetZoomLevel(nfloat zoomLevel, CGPoint pivot, bool animated);

		// -(void)setRotationDegree:(CGFloat)rotationDegree animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export("setRotationDegree:animated:duration:")]
		void SetRotationDegree(nfloat rotationDegree, bool animated, double duration);

		// -(void)setCameraDegree:(CGFloat)cameraDegree animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export("setCameraDegree:animated:duration:")]
		void SetCameraDegree(nfloat cameraDegree, bool animated, double duration);

		// -(MAMapStatus *)getMapStatus;
		[Export("getMapStatus")]
		MAMapStatus MapStatus { get; }

		// -(void)setMapStatus:(MAMapStatus *)status animated:(BOOL)animated;
		[Export("setMapStatus:animated:")]
		void SetMapStatus(MAMapStatus status, bool animated);

		// -(void)setMapStatus:(MAMapStatus *)status animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export("setMapStatus:animated:duration:")]
		void SetMapStatus(MAMapStatus status, bool animated, double duration);

		// -(void)setCompassImage:(UIImage *)image;
		[Export("setCompassImage:")]
		void SetCompassImage(UIImage image);

		// -(UIImage *)takeSnapshotInRect:(CGRect)rect __attribute__((deprecated("已废弃，请使用takeSnapshotInRect:withCompletionBlock:方法 since 6.0.0")));
		[Export("takeSnapshotInRect:")]
		UIImage TakeSnapshotInRect(CGRect rect);

		// -(void)takeSnapshotInRect:(CGRect)rect withCompletionBlock:(void (^)(UIImage *, NSInteger))block;
		[Export("takeSnapshotInRect:withCompletionBlock:")]
		void TakeSnapshotInRect(CGRect rect, Action<UIImage, nint> block);

		// -(double)metersPerPointForZoomLevel:(CGFloat)zoomLevel;
		[Export("metersPerPointForZoomLevel:")]
		double MetersPerPointForZoomLevel(nfloat zoomLevel);

		// -(CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView *)view;
		[Export("convertCoordinate:toPointToView:")]
		CGPoint ConvertCoordinate(CLLocationCoordinate2D coordinate, UIView view);

		// -(CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView *)view;
		[Export("convertPoint:toCoordinateFromView:")]
		CLLocationCoordinate2D ConvertPoint(CGPoint point, UIView view);

		// -(CGRect)convertRegion:(MACoordinateRegion)region toRectToView:(UIView *)view;
		[Export("convertRegion:toRectToView:")]
		CGRect ConvertRegion(MACoordinateRegion region, UIView view);

		// -(MACoordinateRegion)convertRect:(CGRect)rect toRegionFromView:(UIView *)view;
		[Export("convertRect:toRegionFromView:")]
		MACoordinateRegion ConvertRect(CGRect rect, UIView view);

		// -(void)reloadMap;
		[Export("reloadMap")]
		void ReloadMap();

		// -(void)clearDisk;
		[Export("clearDisk")]
		void ClearDisk();

		// -(void)reloadInternalTexture;
		[Export("reloadInternalTexture")]
		void ReloadInternalTexture();

		// -(NSString *)mapContentApprovalNumber;
		[Export("mapContentApprovalNumber")]
		string MapContentApprovalNumber { get; }

		// -(NSString *)satelliteImageApprovalNumber;
		[Export("satelliteImageApprovalNumber")]
		string SatelliteImageApprovalNumber { get; }

		// -(void)addAnimationWith:(CAKeyframeAnimation *)mapCenterAnimation zoomAnimation:(CAKeyframeAnimation *)zoomAnimation rotateAnimation:(CAKeyframeAnimation *)rotateAnimation cameraDegreeAnimation:(CAKeyframeAnimation *)cameraDegreeAnimation;
		[Export("addAnimationWith:zoomAnimation:rotateAnimation:cameraDegreeAnimation:")]
		void AddAnimationWith(CAKeyFrameAnimation mapCenterAnimation, CAKeyFrameAnimation zoomAnimation, CAKeyFrameAnimation rotateAnimation, CAKeyFrameAnimation cameraDegreeAnimation);

		// -(void)forceRefresh;
		[Export("forceRefresh")]
		void ForceRefresh();
	}

	// @interface Annotation (MAMapView)
	[Category]
	[BaseType(typeof(MAMapView))]
	interface MAMapView_Annotation
	{
		// @property (readonly, nonatomic) NSArray * annotations;
		//[Export("annotations")]
		//NSObject[] Annotations { get; }
		[Export("annotations")]
		NSObject[] Annotations();

		// @property (copy, nonatomic) NSArray * selectedAnnotations;
		//[Export("selectedAnnotations", ArgumentSemantic.Copy)]
		//NSObject[] SelectedAnnotations { get; set; }
		[Export("selectedAnnotations", ArgumentSemantic.Copy)]
		NSObject[] SelectedAnnotations();
		[Export("setSelectedAnnotations:", ArgumentSemantic.Copy)]
		void SelectedAnnotations(NSObject[] thevalue);

		// @property (readonly, nonatomic) CGRect annotationVisibleRect;
		//[Export("annotationVisibleRect")]
		//CGRect AnnotationVisibleRect { get; }
		[Export("annotationVisibleRect")]
		CGRect AnnotationVisibleRect();

		// @property (assign, nonatomic) BOOL allowsAnnotationViewSorting __attribute__((deprecated("已废弃 since 5.3.0")));
		//[Export("allowsAnnotationViewSorting")]
		//bool AllowsAnnotationViewSorting { get; set; }
		[Export("allowsAnnotationViewSorting")]
		bool AllowsAnnotationViewSorting();
		[Export("setAllowsAnnotationViewSorting:")]
		void AllowsAnnotationViewSorting(bool thevalue);

		// -(void)addAnnotation:(id<MAAnnotation>)annotation;
		[Export("addAnnotation:")]
		void AddAnnotation(MAAnnotation annotation);

		// -(void)addAnnotations:(NSArray *)annotations;
		[Export("addAnnotations:")]
		void AddAnnotations(NSObject[] annotations);

		// -(void)removeAnnotation:(id<MAAnnotation>)annotation;
		[Export("removeAnnotation:")]
		void RemoveAnnotation(MAAnnotation annotation);

		// -(void)removeAnnotations:(NSArray *)annotations;
		[Export("removeAnnotations:")]
		void RemoveAnnotations(NSObject[] annotations);

		// -(NSSet *)annotationsInMapRect:(MAMapRect)mapRect;
		[Export("annotationsInMapRect:")]
		NSSet AnnotationsInMapRect(MAMapRect mapRect);

		// -(MAAnnotationView *)viewForAnnotation:(id<MAAnnotation>)annotation;
		[Export("viewForAnnotation:")]
		MAAnnotationView ViewForAnnotation(MAAnnotation annotation);

		// -(MAAnnotationView *)dequeueReusableAnnotationViewWithIdentifier:(NSString *)identifier;
		[Export("dequeueReusableAnnotationViewWithIdentifier:")]
		MAAnnotationView DequeueReusableAnnotationViewWithIdentifier(string identifier);

		// -(void)selectAnnotation:(id<MAAnnotation>)annotation animated:(BOOL)animated;
		[Export("selectAnnotation:animated:")]
		void SelectAnnotation(MAAnnotation annotation, bool animated);

		// -(void)deselectAnnotation:(id<MAAnnotation>)annotation animated:(BOOL)animated;
		[Export("deselectAnnotation:animated:")]
		void DeselectAnnotation(MAAnnotation annotation, bool animated);

		// -(void)showAnnotations:(NSArray *)annotations animated:(BOOL)animated;
		[Export("showAnnotations:animated:")]
		void ShowAnnotations(NSObject[] annotations, bool animated);

		// -(void)showAnnotations:(NSArray *)annotations edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("showAnnotations:edgePadding:animated:")]
		void ShowAnnotations(NSObject[] annotations, UIEdgeInsets insets, bool animated);
	}

	// @interface UserLocation (MAMapView)
	[Category]
	[BaseType(typeof(MAMapView))]
	interface MAMapView_UserLocation
	{
		// @property (nonatomic) BOOL showsUserLocation;
		//[Export("showsUserLocation")]
		//bool ShowsUserLocation { get; set; }
		[Export("showsUserLocation")]
		bool ShowsUserLocation();
		[Export("setShowsUserLocation:")]
		void ShowsUserLocation(bool thevalue);

		// @property (readonly, nonatomic) MAUserLocation * userLocation;
		//[Export("userLocation")]
		//MAUserLocation UserLocation { get; }
		[Export("userLocation")]
		MAUserLocation UserLocation();

		// @property (nonatomic) BOOL customizeUserLocationAccuracyCircleRepresentation;
		//[Export("customizeUserLocationAccuracyCircleRepresentation")]
		//bool CustomizeUserLocationAccuracyCircleRepresentation { get; set; }
		[Export("customizeUserLocationAccuracyCircleRepresentation")]
		bool CustomizeUserLocationAccuracyCircleRepresentation();
		[Export("setCustomizeUserLocationAccuracyCircleRepresentation:")]
		void CustomizeUserLocationAccuracyCircleRepresentation(bool thevalue);

		// @property (readonly, nonatomic) MACircle * userLocationAccuracyCircle;
		//[Export("userLocationAccuracyCircle")]
		//MACircle UserLocationAccuracyCircle { get; }
		[Export("userLocationAccuracyCircle")]
		MACircle UserLocationAccuracyCircle();

		// @property (nonatomic) MAUserTrackingMode userTrackingMode;
		//[Export("userTrackingMode", ArgumentSemantic.Assign)]
		//MAUserTrackingMode UserTrackingMode { get; set; }
		[Export("userTrackingMode", ArgumentSemantic.Assign)]
		MAUserTrackingMode UserTrackingMode();
		[Export("setMAUserTrackingMode:", ArgumentSemantic.Assign)]
		void MAUserTrackingMode(MAUserTrackingMode thevalue);

		// @property (readonly, getter = isUserLocationVisible, nonatomic) BOOL userLocationVisible;
		//[Export("userLocationVisible")]
		//bool UserLocationVisible { [Bind("isUserLocationVisible")] get; }
		[Export("userLocationVisible")]
		[Bind("isUserLocationVisible")]
		bool UserLocationVisible();

		// @property (nonatomic) CLLocationDistance distanceFilter;
		//[Export("distanceFilter")]
		//double DistanceFilter { get; set; }
		[Export("distanceFilter")]
		double DistanceFilter();
		[Export("setDistanceFilter:")]
		void DistanceFilter(double thevalue);

		// @property (nonatomic) CLLocationAccuracy desiredAccuracy;
		//[Export("desiredAccuracy")]
		//double DesiredAccuracy { get; set; }
		[Export("desiredAccuracy")]
		double DesiredAccuracy();
		[Export("setDesiredAccuracy:")]
		void DesiredAccuracy(double thevalue);

		// @property (nonatomic) CLLocationDegrees headingFilter;
		//[Export("headingFilter")]
		//double HeadingFilter { get; set; }
		[Export("headingFilter")]
		double HeadingFilter();
		[Export("setHeadingFilter:")]
		void HeadingFilter(double thevalue);

		// @property (nonatomic) BOOL pausesLocationUpdatesAutomatically;
		//[Export("pausesLocationUpdatesAutomatically")]
		//bool PausesLocationUpdatesAutomatically { get; set; }
		[Export("pausesLocationUpdatesAutomatically")]
		bool PausesLocationUpdatesAutomatically();
		[Export("setPausesLocationUpdatesAutomatically:")]
		void PausesLocationUpdatesAutomatically(bool thevalue);

		// @property (nonatomic) BOOL allowsBackgroundLocationUpdates;
		//[Export("allowsBackgroundLocationUpdates")]
		//bool AllowsBackgroundLocationUpdates { get; set; }
		[Export("allowsBackgroundLocationUpdates")]
		bool AllowsBackgroundLocationUpdates();
		[Export("setAllowsBackgroundLocationUpdates:")]
		void AllowsBackgroundLocationUpdates(bool thevalue);

		// -(void)setUserTrackingMode:(MAUserTrackingMode)mode animated:(BOOL)animated;
		[Export("setUserTrackingMode:animated:")]
		void SetUserTrackingMode(MAUserTrackingMode mode, bool animated);

		// -(void)updateUserLocationRepresentation:(MAUserLocationRepresentation *)representation;
		[Export("updateUserLocationRepresentation:")]
		void UpdateUserLocationRepresentation(MAUserLocationRepresentation representation);
	}

	// @interface Overlay (MAMapView)
	[Category]
	[BaseType(typeof(MAMapView))]
	interface MAMapView_Overlay
	{
		// @property (readonly, nonatomic) NSArray * overlays;
		//[Export("overlays")]
		//NSObject[] Overlays { get; }
		[Export("overlays")]
		NSObject[] Overlays();

		// -(NSArray *)overlaysInLevel:(MAOverlayLevel)level;
		[Export("overlaysInLevel:")]
		NSObject[] OverlaysInLevel(MAOverlayLevel level);

		// -(void)addOverlay:(id<MAOverlay>)overlay;
		[Export("addOverlay:")]
		void AddOverlay(MAOverlay overlay);

		// -(void)addOverlays:(NSArray *)overlays;
		[Export("addOverlays:")]
		void AddOverlays(NSObject[] overlays);

		// -(void)addOverlay:(id<MAOverlay>)overlay level:(MAOverlayLevel)level;
		[Export("addOverlay:level:")]
		//void AddOverlay(MAOverlay overlay, MAOverlayLevel level);
		void AddOverlayLevel(MAOverlay overlay, MAOverlayLevel level);

		// -(void)addOverlays:(NSArray *)overlays level:(MAOverlayLevel)level;
		[Export("addOverlays:level:")]
		//void AddOverlays(NSObject[] overlays, MAOverlayLevel level);
		void AddOverlaysLevel(NSObject[] overlays, MAOverlayLevel level);

		// -(void)removeOverlay:(id<MAOverlay>)overlay;
		[Export("removeOverlay:")]
		void RemoveOverlay(MAOverlay overlay);

		// -(void)removeOverlays:(NSArray *)overlays;
		[Export("removeOverlays:")]
		void RemoveOverlays(NSObject[] overlays);

		// -(void)insertOverlay:(id<MAOverlay>)overlay atIndex:(NSUInteger)index level:(MAOverlayLevel)level;
		[Export("insertOverlay:atIndex:level:")]
		//void InsertOverlay(MAOverlay overlay, nuint index, MAOverlayLevel level);
		void InsertOverlayAtIndexLevel(MAOverlay overlay, nuint index, MAOverlayLevel level);

		// -(void)insertOverlay:(id<MAOverlay>)overlay aboveOverlay:(id<MAOverlay>)sibling;
		[Export("insertOverlay:aboveOverlay:")]
		//void InsertOverlay(MAOverlay overlay, MAOverlay sibling);
		void InsertOverlayAboveOverlay(MAOverlay overlay, MAOverlay sibling);

		// -(void)insertOverlay:(id<MAOverlay>)overlay belowOverlay:(id<MAOverlay>)sibling;
		[Export("insertOverlay:belowOverlay:")]
		//void InsertOverlay(MAOverlay overlay, MAOverlay sibling);
		void InsertOverlayBelowOverlay(MAOverlay overlay, MAOverlay sibling);

		// -(void)insertOverlay:(id<MAOverlay>)overlay atIndex:(NSUInteger)index;
		[Export("insertOverlay:atIndex:")]
		//void InsertOverlay(MAOverlay overlay, nuint index);
		void InsertOverlayAtIndex(MAOverlay overlay, nuint index);

		// -(void)exchangeOverlayAtIndex:(NSUInteger)index1 withOverlayAtIndex:(NSUInteger)index2;
		[Export("exchangeOverlayAtIndex:withOverlayAtIndex:")]
		//void ExchangeOverlayAtIndex(nuint index1, nuint index2);
		void ExchangeOverlayAtIndexWithOverlayAtIndex(nuint index1, nuint index2);

		// -(void)exchangeOverlayAtIndex:(NSUInteger)index1 withOverlayAtIndex:(NSUInteger)index2 atLevel:(MAOverlayLevel)level;
		[Export("exchangeOverlayAtIndex:withOverlayAtIndex:atLevel:")]
		//void ExchangeOverlayAtIndex(nuint index1, nuint index2, MAOverlayLevel level);
		void ExchangeOverlayAtIndexWithOverlayAtIndex(nuint index1, nuint index2, MAOverlayLevel level);

		// -(void)exchangeOverlay:(id<MAOverlay>)overlay1 withOverlay:(id<MAOverlay>)overlay2;
		[Export("exchangeOverlay:withOverlay:")]
		//void ExchangeOverlay(MAOverlay overlay1, MAOverlay overlay2);
		void ExchangeOverlayWithOverlay(MAOverlay overlay1, MAOverlay overlay2);

		// -(MAOverlayRenderer *)rendererForOverlay:(id<MAOverlay>)overlay;
		[Export("rendererForOverlay:")]
		MAOverlayRenderer RendererForOverlay(MAOverlay overlay);

		// -(void)showOverlays:(NSArray *)overlays animated:(BOOL)animated;
		[Export("showOverlays:animated:")]
		//void ShowOverlays(NSObject[] overlays, bool animated);
		void ShowOverlaysAnimated(NSObject[] overlays, bool animated);

		// -(void)showOverlays:(NSArray *)overlays edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("showOverlays:edgePadding:animated:")]
		//void ShowOverlays(NSObject[] overlays, UIEdgeInsets insets, bool animated);
		void ShowOverlaysEdgePaddingAnimated(NSObject[] overlays, UIEdgeInsets insets, bool animated);

		// -(NSArray *)getHittedPolylinesWith:(CLLocationCoordinate2D)tappedCoord traverseAll:(BOOL)traverseAll;
		[Export("getHittedPolylinesWith:traverseAll:")]
		NSObject[] GetHittedPolylinesWith(CLLocationCoordinate2D tappedCoord, bool traverseAll);
	}

	// @interface Indoor (MAMapView)
	[Category]
	[BaseType(typeof(MAMapView))]
	interface MAMapView_Indoor
	{
		// @property (getter = isShowsIndoorMap, nonatomic) BOOL showsIndoorMap;
		//[Export("showsIndoorMap")]
		//bool ShowsIndoorMap { [Bind("isShowsIndoorMap")] get; set; }
		[Export("showsIndoorMap")]
		[Bind("isShowsIndoorMap")]
		bool ShowsIndoorMap();
		[Export("setShowsIndoorMap:")]
		void ShowsIndoorMap(bool thevalue);

		// @property (getter = isShowsIndoorMapControl, nonatomic) BOOL showsIndoorMapControl;
		//[Export("showsIndoorMapControl")]
		//bool ShowsIndoorMapControl { [Bind("isShowsIndoorMapControl")] get; set; }
		[Export("showsIndoorMapControl")]
		[Bind("isShowsIndoorMapControl")]
		bool ShowsIndoorMapControl();
		[Export("setShowsIndoorMapControl:")]
		void ShowsIndoorMapControl(bool thevalue);

		// @property (readonly, nonatomic) CGSize indoorMapControlSize;
		//[Export("indoorMapControlSize")]
		//CGSize IndoorMapControlSize { get; }
		[Export("indoorMapControlSize")]
		CGSize IndoorMapControlSize();

		// -(void)setIndoorMapControlOrigin:(CGPoint)origin;
		[Export("setIndoorMapControlOrigin:")]
		void SetIndoorMapControlOrigin(CGPoint origin);

		// -(void)setCurrentIndoorMapFloorIndex:(NSInteger)floorIndex;
		[Export("setCurrentIndoorMapFloorIndex:")]
		void SetCurrentIndoorMapFloorIndex(nint floorIndex);

		// -(void)clearIndoorMapCache;
		[Export("clearIndoorMapCache")]
		void ClearIndoorMapCache();
	}

	// @interface CustomMapStyle (MAMapView)
	[Category]
	[BaseType(typeof(MAMapView))]
	interface MAMapView_CustomMapStyle
	{
		// @property (assign, nonatomic) BOOL customMapStyleEnabled;
		//[Export("customMapStyleEnabled")]
		//bool CustomMapStyleEnabled { get; set; }
		[Export("customMapStyleEnabled")]
		bool CustomMapStyleEnabled();
		[Export("setCustomMapStyleEnabled:")]
		void CustomMapStyleEnabled(bool thevalue);

		// -(void)setCustomMapStyleWithWebData:(NSData *)data __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: since 6.6.0")));
		[Export("setCustomMapStyleWithWebData:")]
		void SetCustomMapStyleWithWebData(NSData data);

		// -(void)setCustomTextureResourcePath:(NSString *)customTextureResourcePath __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: since 6.6.0")));
		[Export("setCustomTextureResourcePath:")]
		void SetCustomTextureResourcePath(string customTextureResourcePath);

		// -(void)setCustomMapStyleID:(NSString *)customMapStyleID __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: since 6.6.0")));
		[Export("setCustomMapStyleID:")]
		void SetCustomMapStyleID(string customMapStyleID);

		// -(void)setCustomMapStyleOptions:(MAMapCustomStyleOptions *)styleOptions;
		[Export("setCustomMapStyleOptions:")]
		void SetCustomMapStyleOptions(MAMapCustomStyleOptions styleOptions);
	}

	// @protocol MAMapViewDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface MAMapViewDelegate
	{
		// @optional -(void)mapViewRegionChanged:(MAMapView *)mapView;
		[Export("mapViewRegionChanged:")]
		void MapViewRegionChanged(MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView regionWillChangeAnimated:(BOOL)animated;
		[Export("mapView:regionWillChangeAnimated:")]
		void MapView(MAMapView mapView, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView regionDidChangeAnimated:(BOOL)animated;
		[Export("mapView:regionDidChangeAnimated:")]
		//void MapView(MAMapView mapView, bool animated);
		void MapViewRegionDidChangeAnimated(MAMapView mapView, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView mapWillMoveByUser:(BOOL)wasUserAction;
		[Export("mapView:mapWillMoveByUser:")]
		//void MapView(MAMapView mapView, bool wasUserAction);
		void MapViewMapWillMoveByUser(MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapDidMoveByUser:(BOOL)wasUserAction;
		[Export("mapView:mapDidMoveByUser:")]
		//void MapView(MAMapView mapView, bool wasUserAction);
		void MapViewMapDidMoveByUser(MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapWillZoomByUser:(BOOL)wasUserAction;
		[Export("mapView:mapWillZoomByUser:")]
		//void MapView(MAMapView mapView, bool wasUserAction);
		void MapViewMapWillZoomByUser(MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapDidZoomByUser:(BOOL)wasUserAction;
		[Export("mapView:mapDidZoomByUser:")]
		//void MapView(MAMapView mapView, bool wasUserAction);
		void MapViewMapDidZoomByUser(MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapViewWillStartLoadingMap:(MAMapView *)mapView;
		[Export("mapViewWillStartLoadingMap:")]
		void MapViewWillStartLoadingMap(MAMapView mapView);

		// @optional -(void)mapViewDidFinishLoadingMap:(MAMapView *)mapView;
		[Export("mapViewDidFinishLoadingMap:")]
		void MapViewDidFinishLoadingMap(MAMapView mapView);

		// @optional -(void)mapViewDidFailLoadingMap:(MAMapView *)mapView withError:(NSError *)error;
		[Export("mapViewDidFailLoadingMap:withError:")]
		void MapViewDidFailLoadingMap(MAMapView mapView, NSError error);

		// @optional -(MAAnnotationView *)mapView:(MAMapView *)mapView viewForAnnotation:(id<MAAnnotation>)annotation;
		[Export("mapView:viewForAnnotation:")]
		//MAAnnotationView MapView(MAMapView mapView, MAAnnotation annotation);
		MAAnnotationView MapViewViewForAnnotation(MAMapView mapView, MAAnnotation annotation);

		// @optional -(void)mapView:(MAMapView *)mapView didAddAnnotationViews:(NSArray *)views;
		[Export("mapView:didAddAnnotationViews:")]
		//void MapView(MAMapView mapView, NSObject[] views);
		void MapViewDidAddAnnotationViews(MAMapView mapView, NSObject[] views);

		// @optional -(void)mapView:(MAMapView *)mapView didSelectAnnotationView:(MAAnnotationView *)view;
		[Export("mapView:didSelectAnnotationView:")]
		//void MapView(MAMapView mapView, MAAnnotationView view);
		void MapViewDidSelectAnnotationView(MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapView:(MAMapView *)mapView didDeselectAnnotationView:(MAAnnotationView *)view;
		[Export("mapView:didDeselectAnnotationView:")]
		//void MapView(MAMapView mapView, MAAnnotationView view);
		void MapViewDidDeselectAnnotationView(MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapViewWillStartLocatingUser:(MAMapView *)mapView;
		[Export("mapViewWillStartLocatingUser:")]
		void MapViewWillStartLocatingUser(MAMapView mapView);

		// @optional -(void)mapViewDidStopLocatingUser:(MAMapView *)mapView;
		[Export("mapViewDidStopLocatingUser:")]
		void MapViewDidStopLocatingUser(MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView didUpdateUserLocation:(MAUserLocation *)userLocation updatingLocation:(BOOL)updatingLocation;
		[Export("mapView:didUpdateUserLocation:updatingLocation:")]
		//void MapView(MAMapView mapView, MAUserLocation userLocation, bool updatingLocation);
		void MapViewDidUpdateUserLocation(MAMapView mapView, MAUserLocation userLocation, bool updatingLocation);

		// @optional -(void)mapViewRequireLocationAuth:(CLLocationManager *)locationManager;
		[Export("mapViewRequireLocationAuth:")]
		void MapViewRequireLocationAuth(CLLocationManager locationManager);

		// @optional -(void)mapView:(MAMapView *)mapView didFailToLocateUserWithError:(NSError *)error;
		[Export("mapView:didFailToLocateUserWithError:")]
		//void MapView(MAMapView mapView, NSError error);
		void MapViewDidFailToLocateUserWithError(MAMapView mapView, NSError error);

		// @optional -(void)mapView:(MAMapView *)mapView annotationView:(MAAnnotationView *)view didChangeDragState:(MAAnnotationViewDragState)newState fromOldState:(MAAnnotationViewDragState)oldState;
		[Export("mapView:annotationView:didChangeDragState:fromOldState:")]
		//void MapView(MAMapView mapView, MAAnnotationView view, MAAnnotationViewDragState newState, MAAnnotationViewDragState oldState);
		void MapViewAnnotationViewDidChangeDragStateFromOldState(MAMapView mapView, MAAnnotationView view, MAAnnotationViewDragState newState, MAAnnotationViewDragState oldState);

		// @optional -(MAOverlayRenderer *)mapView:(MAMapView *)mapView rendererForOverlay:(id<MAOverlay>)overlay;
		[Export("mapView:rendererForOverlay:")]
		//MAOverlayRenderer MapView(MAMapView mapView, MAOverlay overlay);
		MAOverlayRenderer MapViewRendererForOverlay(MAMapView mapView, MAOverlay overlay);

		// @optional -(void)mapView:(MAMapView *)mapView didAddOverlayRenderers:(NSArray *)overlayRenderers;
		[Export("mapView:didAddOverlayRenderers:")]
		//void MapView(MAMapView mapView, NSObject[] overlayRenderers);
		void MapViewDidAddOverlayRenderers(MAMapView mapView, NSObject[] overlayRenderers);

		// @optional -(void)mapView:(MAMapView *)mapView annotationView:(MAAnnotationView *)view calloutAccessoryControlTapped:(UIControl *)control;
		[Export("mapView:annotationView:calloutAccessoryControlTapped:")]
		//void MapView(MAMapView mapView, MAAnnotationView view, UIControl control);
		void MapViewAnnotationViewCalloutAccessoryControlTapped(MAMapView mapView, MAAnnotationView view, UIControl control);

		// @optional -(void)mapView:(MAMapView *)mapView didAnnotationViewCalloutTapped:(MAAnnotationView *)view;
		[Export("mapView:didAnnotationViewCalloutTapped:")]
		//void MapView(MAMapView mapView, MAAnnotationView view);
		void MapViewDidAnnotationViewCalloutTapped(MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapView:(MAMapView *)mapView didAnnotationViewTapped:(MAAnnotationView *)view;
		[Export("mapView:didAnnotationViewTapped:")]
		//void MapView(MAMapView mapView, MAAnnotationView view);
		void MapViewDidAnnotationViewTapped(MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapView:(MAMapView *)mapView didChangeUserTrackingMode:(MAUserTrackingMode)mode animated:(BOOL)animated;
		[Export("mapView:didChangeUserTrackingMode:animated:")]
		//void MapView(MAMapView mapView, MAUserTrackingMode mode, bool animated);
		void MapViewDidChangeUserTrackingModeAnimated(MAMapView mapView, MAUserTrackingMode mode, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView didChangeOpenGLESDisabled:(BOOL)openGLESDisabled;
		[Export("mapView:didChangeOpenGLESDisabled:")]
		//void MapView(MAMapView mapView, bool openGLESDisabled);
		void MapViewDidChangeOpenGLESDisabled(MAMapView mapView, bool openGLESDisabled);

		// @optional -(void)mapView:(MAMapView *)mapView didTouchPois:(NSArray *)pois;
		[Export("mapView:didTouchPois:")]
		//void MapView(MAMapView mapView, NSObject[] pois);
		void MapViewDidTouchPois(MAMapView mapView, NSObject[] pois);

		// @optional -(void)mapView:(MAMapView *)mapView didSingleTappedAtCoordinate:(CLLocationCoordinate2D)coordinate;
		[Export("mapView:didSingleTappedAtCoordinate:")]
		//void MapView(MAMapView mapView, CLLocationCoordinate2D coordinate);
		void MapViewDidSingleTappedAtCoordinate(MAMapView mapView, CLLocationCoordinate2D coordinate);

		// @optional -(void)mapView:(MAMapView *)mapView didLongPressedAtCoordinate:(CLLocationCoordinate2D)coordinate;
		[Export("mapView:didLongPressedAtCoordinate:")]
		//void MapView(MAMapView mapView, CLLocationCoordinate2D coordinate);
		void MapViewDidLongPressedAtCoordinate(MAMapView mapView, CLLocationCoordinate2D coordinate);

		// @optional -(void)mapInitComplete:(MAMapView *)mapView;
		[Export("mapInitComplete:")]
		void MapInitComplete(MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapShowed:(MAIndoorInfo *)indoorInfo;
		[Export("mapView:didIndoorMapShowed:")]
		//void MapView(MAMapView mapView, MAIndoorInfo indoorInfo);
		void MapViewDidIndoorMapShowed(MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapFloorIndexChanged:(MAIndoorInfo *)indoorInfo;
		[Export("mapView:didIndoorMapFloorIndexChanged:")]
		//void MapView(MAMapView mapView, MAIndoorInfo indoorInfo);
		void MapViewDidIndoorMapFloorIndexChanged(MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapHidden:(MAIndoorInfo *)indoorInfo;
		[Export("mapView:didIndoorMapHidden:")]
		//void MapView(MAMapView mapView, MAIndoorInfo indoorInfo);
		void MapViewDidIndoorMapHidden(MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)offlineDataWillReload:(MAMapView *)mapView;
		[Export("offlineDataWillReload:")]
		void OfflineDataWillReload(MAMapView mapView);

		// @optional -(void)offlineDataDidReload:(MAMapView *)mapView;
		[Export("offlineDataDidReload:")]
		void OfflineDataDidReload(MAMapView mapView);
	}

	// @interface MAPinAnnotationView : MAAnnotationView
	[BaseType(typeof(MAAnnotationView))]
	interface MAPinAnnotationView
	{
		// @property (nonatomic) MAPinAnnotationColor pinColor;
		[Export("pinColor", ArgumentSemantic.Assign)]
		MAPinAnnotationColor PinColor { get; set; }

		// @property (nonatomic) BOOL animatesDrop;
		[Export("animatesDrop")]
		bool AnimatesDrop { get; set; }
	}

	// @interface MAOverlayPathRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MAOverlayPathRenderer
	{
		// @property (retain, nonatomic) UIColor * fillColor;
		[Export("fillColor", ArgumentSemantic.Retain)]
		UIColor FillColor { get; set; }

		// @property (retain, nonatomic) UIColor * strokeColor;
		[Export("strokeColor", ArgumentSemantic.Retain)]
		UIColor StrokeColor { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (assign, nonatomic) MALineJoinType lineJoinType;
		[Export("lineJoinType", ArgumentSemantic.Assign)]
		MALineJoinType LineJoinType { get; set; }

		// @property (assign, nonatomic) MALineCapType lineCapType;
		[Export("lineCapType", ArgumentSemantic.Assign)]
		MALineCapType LineCapType { get; set; }

		// @property (assign, nonatomic) CGFloat miterLimit;
		[Export("miterLimit")]
		nfloat MiterLimit { get; set; }

		// @property (assign, nonatomic) BOOL lineDash __attribute__((deprecated("已废弃，请使用lineDashType")));
		[Export("lineDash")]
		bool LineDash { get; set; }

		// @property (assign, nonatomic) MALineDashType lineDashType;
		[Export("lineDashType", ArgumentSemantic.Assign)]
		MALineDashType LineDashType { get; set; }
	}

	// @interface MACircleRenderer : MAOverlayPathRenderer
	[BaseType(typeof(MAOverlayPathRenderer))]
	interface MACircleRenderer
	{
		// @property (readonly, nonatomic) MACircle * circle;
		[Export("circle")]
		MACircle Circle { get; }

		// -(instancetype)initWithCircle:(MACircle *)circle;
		[Export("initWithCircle:")]
		IntPtr Constructor(MACircle circle);
	}

	// @interface MAArc : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	interface MAArc : MAOverlay
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D startCoordinate;
		[Export("startCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D StartCoordinate { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D passedCoordinate;
		[Export("passedCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D PassedCoordinate { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D endCoordinate;
		[Export("endCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D EndCoordinate { get; set; }

		// @property (readonly, nonatomic) MAMapRect boundingMapRect;
		[Export("boundingMapRect")]
		MAMapRect BoundingMapRect { get; }

		// +(instancetype)arcWithStartCoordinate:(CLLocationCoordinate2D)startCoordinate passedCoordinate:(CLLocationCoordinate2D)passedCoordinate endCoordinate:(CLLocationCoordinate2D)endCoordinate;
		[Static]
		[Export("arcWithStartCoordinate:passedCoordinate:endCoordinate:")]
		MAArc ArcWithStartCoordinate(CLLocationCoordinate2D startCoordinate, CLLocationCoordinate2D passedCoordinate, CLLocationCoordinate2D endCoordinate);
	}

	// @interface MAArcRenderer : MAOverlayPathRenderer
	[BaseType(typeof(MAOverlayPathRenderer))]
	interface MAArcRenderer
	{
		// @property (readonly, nonatomic) MAArc * arc;
		[Export("arc")]
		MAArc Arc { get; }

		// -(instancetype)initWithArc:(MAArc *)arc;
		[Export("initWithArc:")]
		IntPtr Constructor(MAArc arc);
	}

	// @interface MAMultiPoint : MAShape
	[BaseType(typeof(MAShape))]
	interface MAMultiPoint
	{
		// @property (readonly, nonatomic) MAMapPoint * points;
		[Export("points")]
		MAMapPoint Points { get; }

		// @property (readonly, nonatomic) NSUInteger pointCount;
		[Export("pointCount")]
		nuint PointCount { get; }

		// @property (readonly, assign, nonatomic) BOOL cross180Longitude;
		[Export("cross180Longitude")]
		bool Cross180Longitude { get; }

		// -(void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
		[Export("getCoordinates:range:")]
		void GetCoordinates(CLLocationCoordinate2D coords, NSRange range);
	}

	// @interface MAPolygon : MAMultiPoint <MAOverlay>
	[BaseType(typeof(MAMultiPoint))]
	interface MAPolygon : MAOverlay
	{
		// @property (nonatomic, strong) NSArray<id<MAOverlay>> * hollowShapes;
		[Export("hollowShapes", ArgumentSemantic.Strong)]
		MAOverlay[] HollowShapes { get; set; }

		// +(instancetype)polygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export("polygonWithCoordinates:count:")]
		MAPolygon PolygonWithCoordinates(CLLocationCoordinate2D coords, nuint count);

		// +(instancetype)polygonWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export("polygonWithPoints:count:")]
		MAPolygon PolygonWithPoints(MAMapPoint points, nuint count);

		// -(BOOL)setPolygonWithPoints:(MAMapPoint *)points count:(NSInteger)count;
		[Export("setPolygonWithPoints:count:")]
		bool SetPolygonWithPoints(MAMapPoint points, nint count);

		// -(BOOL)setPolygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSInteger)count;
		[Export("setPolygonWithCoordinates:count:")]
		bool SetPolygonWithCoordinates(CLLocationCoordinate2D coords, nint count);
	}

	// @interface MAPolygonRenderer : MAOverlayPathRenderer
	[BaseType(typeof(MAOverlayPathRenderer))]
	interface MAPolygonRenderer
	{
		// @property (readonly, nonatomic) MAPolygon * polygon;
		[Export("polygon")]
		MAPolygon Polygon { get; }

		// -(instancetype)initWithPolygon:(MAPolygon *)polygon;
		[Export("initWithPolygon:")]
		IntPtr Constructor(MAPolygon polygon);
	}

	// @interface MAPolyline : MAMultiPoint <MAOverlay>
	[BaseType(typeof(MAMultiPoint))]
	interface MAPolyline : MAOverlay
	{
		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export("polylineWithPoints:count:")]
		MAPolyline PolylineWithPoints(MAMapPoint points, nuint count);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export("polylineWithCoordinates:count:")]
		MAPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count);

		// -(BOOL)setPolylineWithPoints:(MAMapPoint *)points count:(NSInteger)count;
		[Export("setPolylineWithPoints:count:")]
		bool SetPolylineWithPoints(MAMapPoint points, nint count);

		// -(BOOL)setPolylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSInteger)count;
		[Export("setPolylineWithCoordinates:count:")]
		bool SetPolylineWithCoordinates(CLLocationCoordinate2D coords, nint count);
	}

	// @interface MAPolylineRenderer : MAOverlayPathRenderer
	[BaseType(typeof(MAOverlayPathRenderer))]
	interface MAPolylineRenderer
	{
		// @property (readonly, nonatomic) MAPolyline * polyline;
		[Export("polyline")]
		MAPolyline Polyline { get; }

		// @property (assign, nonatomic) BOOL is3DArrowLine;
		[Export("is3DArrowLine")]
		bool Is3DArrowLine { get; set; }

		// @property (nonatomic, strong) UIColor * sideColor;
		[Export("sideColor", ArgumentSemantic.Strong)]
		UIColor SideColor { get; set; }

		// @property (assign, nonatomic) BOOL userInteractionEnabled;
		[Export("userInteractionEnabled")]
		bool UserInteractionEnabled { get; set; }

		// @property (assign, nonatomic) CGFloat hitTestInset;
		[Export("hitTestInset")]
		nfloat HitTestInset { get; set; }

		// -(instancetype)initWithPolyline:(MAPolyline *)polyline;
		[Export("initWithPolyline:")]
		IntPtr Constructor(MAPolyline polyline);
	}

	// @interface MAGeodesicPolyline : MAPolyline
	[BaseType(typeof(MAPolyline))]
	interface MAGeodesicPolyline
	{
		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export("polylineWithPoints:count:")]
		MAGeodesicPolyline PolylineWithPoints(MAMapPoint points, nuint count);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export("polylineWithCoordinates:count:")]
		MAGeodesicPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count);

		// -(BOOL)setPolylineWithPoints:(MAMapPoint *)points count:(NSInteger)count;
		[Export("setPolylineWithPoints:count:")]
		bool SetPolylineWithPoints(MAMapPoint points, nint count);

		// -(BOOL)setPolylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSInteger)count;
		[Export("setPolylineWithCoordinates:count:")]
		bool SetPolylineWithCoordinates(CLLocationCoordinate2D coords, nint count);
	}

	// @interface MAMultiPolyline : MAPolyline
	[BaseType(typeof(MAPolyline))]
	interface MAMultiPolyline
	{
		// @property (nonatomic, strong) NSArray<NSNumber *> * drawStyleIndexes;
		[Export("drawStyleIndexes", ArgumentSemantic.Strong)]
		NSNumber[] DrawStyleIndexes { get; set; }

		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count drawStyleIndexes:(NSArray<NSNumber *> *)drawStyleIndexes;
		[Static]
		[Export("polylineWithPoints:count:drawStyleIndexes:")]
		MAMultiPolyline PolylineWithPoints(MAMapPoint points, nuint count, NSNumber[] drawStyleIndexes);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count drawStyleIndexes:(NSArray<NSNumber *> *)drawStyleIndexes;
		[Static]
		[Export("polylineWithCoordinates:count:drawStyleIndexes:")]
		MAMultiPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count, NSNumber[] drawStyleIndexes);

		// -(BOOL)setPolylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count drawStyleIndexes:(NSArray<NSNumber *> *)drawStyleIndexes;
		[Export("setPolylineWithPoints:count:drawStyleIndexes:")]
		bool SetPolylineWithPoints(MAMapPoint points, nuint count, NSNumber[] drawStyleIndexes);

		// -(BOOL)setPolylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count drawStyleIndexes:(NSArray<NSNumber *> *)drawStyleIndexes;
		[Export("setPolylineWithCoordinates:count:drawStyleIndexes:")]
		bool SetPolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count, NSNumber[] drawStyleIndexes);
	}

	// @interface MAMultiTexturePolylineRenderer : MAPolylineRenderer
	[BaseType(typeof(MAPolylineRenderer))]
	interface MAMultiTexturePolylineRenderer
	{
		// @property (readonly, nonatomic) MAMultiPolyline * multiPolyline;
		[Export("multiPolyline")]
		MAMultiPolyline MultiPolyline { get; }

		// @property (nonatomic, strong) NSArray * strokeTextureImages;
		[Export("strokeTextureImages", ArgumentSemantic.Strong)]
		NSObject[] StrokeTextureImages { get; set; }

		// @property (readonly, nonatomic, strong) NSArray<NSNumber *> * strokeTextureIDs;
		[Export("strokeTextureIDs", ArgumentSemantic.Strong)]
		NSNumber[] StrokeTextureIDs { get; }

		// -(instancetype)initWithMultiPolyline:(MAMultiPolyline *)multiPolyline;
		[Export("initWithMultiPolyline:")]
		IntPtr Constructor(MAMultiPolyline multiPolyline);

		// -(BOOL)loadStrokeTextureImages:(NSArray *)textureImages __attribute__((deprecated("已废弃, 请通过属性strokeTextureImages设置")));
		[Export("loadStrokeTextureImages:")]
		bool LoadStrokeTextureImages(NSObject[] textureImages);
	}

	// @interface MAMultiColoredPolylineRenderer : MAPolylineRenderer
	[BaseType(typeof(MAPolylineRenderer))]
	interface MAMultiColoredPolylineRenderer
	{
		// @property (readonly, nonatomic) MAMultiPolyline * multiPolyline;
		[Export("multiPolyline")]
		MAMultiPolyline MultiPolyline { get; }

		// @property (nonatomic, strong) NSArray<UIColor *> * strokeColors;
		[Export("strokeColors", ArgumentSemantic.Strong)]
		UIColor[] StrokeColors { get; set; }

		// @property (getter = isGradient, nonatomic) BOOL gradient;
		[Export("gradient")]
		bool Gradient { [Bind("isGradient")] get; set; }

		// -(instancetype)initWithMultiPolyline:(MAMultiPolyline *)multiPolyline;
		[Export("initWithMultiPolyline:")]
		IntPtr Constructor(MAMultiPolyline multiPolyline);
	}

	// @interface MAGroundOverlay : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	interface MAGroundOverlay : MAOverlay
	{
		// @property (readonly, nonatomic) UIImage * icon;
		[Export("icon")]
		UIImage Icon { get; }

		// @property (assign, nonatomic) CGFloat alpha;
		[Export("alpha")]
		nfloat Alpha { get; set; }

		// @property (readonly, nonatomic) CGFloat zoomLevel;
		[Export("zoomLevel")]
		nfloat ZoomLevel { get; }

		// @property (readonly, nonatomic) MACoordinateBounds bounds;
		[Export("bounds")]
		MACoordinateBounds Bounds { get; }

		// +(instancetype)groundOverlayWithBounds:(MACoordinateBounds)bounds icon:(UIImage *)icon;
		[Static]
		[Export("groundOverlayWithBounds:icon:")]
		MAGroundOverlay GroundOverlayWithBounds(MACoordinateBounds bounds, UIImage icon);

		// +(instancetype)groundOverlayWithCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel icon:(UIImage *)icon;
		[Static]
		[Export("groundOverlayWithCoordinate:zoomLevel:icon:")]
		MAGroundOverlay GroundOverlayWithCoordinate(CLLocationCoordinate2D coordinate, nfloat zoomLevel, UIImage icon);

		// -(BOOL)setGroundOverlayWithBounds:(MACoordinateBounds)bounds icon:(UIImage *)icon;
		[Export("setGroundOverlayWithBounds:icon:")]
		bool SetGroundOverlayWithBounds(MACoordinateBounds bounds, UIImage icon);

		// -(BOOL)setGroundOverlayWithCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel icon:(UIImage *)icon;
		[Export("setGroundOverlayWithCoordinate:zoomLevel:icon:")]
		bool SetGroundOverlayWithCoordinate(CLLocationCoordinate2D coordinate, nfloat zoomLevel, UIImage icon);
	}

	// @interface MAGroundOverlayRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MAGroundOverlayRenderer
	{
		// @property (readonly, nonatomic) MAGroundOverlay * groundOverlay;
		[Export("groundOverlay")]
		MAGroundOverlay GroundOverlay { get; }

		// -(instancetype)initWithGroundOverlay:(MAGroundOverlay *)groundOverlay;
		[Export("initWithGroundOverlay:")]
		IntPtr Constructor(MAGroundOverlay groundOverlay);
	}

	// @interface MATileOverlay : NSObject <MAOverlay>
	[BaseType(typeof(NSObject))]
	interface MATileOverlay : MAOverlay
	{
		// @property (assign, nonatomic) CGSize tileSize;
		[Export("tileSize", ArgumentSemantic.Assign)]
		CGSize TileSize { get; set; }

		// @property NSInteger minimumZ;
		[Export("minimumZ")]
		nint MinimumZ { get; set; }

		// @property NSInteger maximumZ;
		[Export("maximumZ")]
		nint MaximumZ { get; set; }

		// @property (readonly) NSString * URLTemplate;
		[Export("URLTemplate")]
		string URLTemplate { get; }

		// @property (nonatomic) BOOL canReplaceMapContent;
		[Export("canReplaceMapContent")]
		bool CanReplaceMapContent { get; set; }

		// @property (nonatomic) MAMapRect boundingMapRect;
		[Export("boundingMapRect", ArgumentSemantic.Assign)]
		MAMapRect BoundingMapRect { get; set; }

		// @property (assign, nonatomic) BOOL disableOffScreenTileLoading;
		[Export("disableOffScreenTileLoading")]
		bool DisableOffScreenTileLoading { get; set; }

		// -(id)initWithURLTemplate:(NSString *)URLTemplate;
		[Export("initWithURLTemplate:")]
		IntPtr Constructor(string URLTemplate);
	}

	// @interface CustomLoading (MATileOverlay)
	[Category]
	[BaseType(typeof(MATileOverlay))]
	interface MATileOverlay_CustomLoading
	{
		// -(NSURL *)URLForTilePath:(MATileOverlayPath)path;
		[Export("URLForTilePath:")]
		NSUrl URLForTilePath(MATileOverlayPath path);

		// -(void)loadTileAtPath:(MATileOverlayPath)path result:(void (^)(NSData *, NSError *))result;
		[Export("loadTileAtPath:result:")]
		void LoadTileAtPath(MATileOverlayPath path, Action<NSData, NSError> result);

		// -(void)cancelLoadOfTileAtPath:(MATileOverlayPath)path;
		[Export("cancelLoadOfTileAtPath:")]
		void CancelLoadOfTileAtPath(MATileOverlayPath path);
	}

	// @interface MATileOverlayRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MATileOverlayRenderer
	{
		// @property (readonly, nonatomic) MATileOverlay * tileOverlay;
		[Export("tileOverlay")]
		MATileOverlay TileOverlay { get; }

		// -(instancetype)initWithTileOverlay:(MATileOverlay *)tileOverlay;
		[Export("initWithTileOverlay:")]
		IntPtr Constructor(MATileOverlay tileOverlay);

		// -(void)reloadData;
		[Export("reloadData")]
		void ReloadData();
	}

	// @interface MACustomBuildingOverlayOption : MAMultiPoint
	[BaseType(typeof(MAMultiPoint))]
	interface MACustomBuildingOverlayOption
	{
		// @property (assign, nonatomic) CGFloat height;
		[Export("height")]
		nfloat Height { get; set; }

		// @property (assign, nonatomic) CGFloat heightScale;
		[Export("heightScale")]
		nfloat HeightScale { get; set; }

		// @property (nonatomic, strong) UIColor * topColor;
		[Export("topColor", ArgumentSemantic.Strong)]
		UIColor TopColor { get; set; }

		// @property (nonatomic, strong) UIColor * sideColor;
		[Export("sideColor", ArgumentSemantic.Strong)]
		UIColor SideColor { get; set; }

		// @property (assign, nonatomic) BOOL visibile;
		[Export("visibile")]
		bool Visibile { get; set; }

		// +(instancetype)optionWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export("optionWithCoordinates:count:")]
		MACustomBuildingOverlayOption OptionWithCoordinates(CLLocationCoordinate2D coords, nuint count);

		// -(BOOL)setOptionWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Export("setOptionWithCoordinates:count:")]
		bool SetOptionWithCoordinates(CLLocationCoordinate2D coords, nuint count);
	}

	// @interface MACustomBuildingOverlay : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	interface MACustomBuildingOverlay : MAOverlay
	{
		// @property (readonly, nonatomic) MACustomBuildingOverlayOption * defaultOption;
		[Export("defaultOption")]
		MACustomBuildingOverlayOption DefaultOption { get; }

		// @property (readonly, nonatomic) NSArray<MACustomBuildingOverlayOption *> * customOptions;
		[Export("customOptions")]
		MACustomBuildingOverlayOption[] CustomOptions { get; }

		// -(void)addCustomOption:(MACustomBuildingOverlayOption *)option;
		[Export("addCustomOption:")]
		void AddCustomOption(MACustomBuildingOverlayOption option);

		// -(void)removeCustomOption:(MACustomBuildingOverlayOption *)option;
		[Export("removeCustomOption:")]
		void RemoveCustomOption(MACustomBuildingOverlayOption option);
	}

	// @interface MACustomBuildingOverlayRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MACustomBuildingOverlayRenderer
	{
		// @property (readonly, nonatomic) MACustomBuildingOverlay * customBuildingOverlay;
		[Export("customBuildingOverlay")]
		MACustomBuildingOverlay CustomBuildingOverlay { get; }

		// -(instancetype)initWithCustomBuildingOverlay:(MACustomBuildingOverlay *)customBuildingOverlay;
		[Export("initWithCustomBuildingOverlay:")]
		IntPtr Constructor(MACustomBuildingOverlay customBuildingOverlay);
	}

	// @protocol MAParticleVelocityGenerate <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	//interface IMAParticleVelocityGenerate { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface MAParticleVelocityGenerate
	{
		// @required -(CGFloat)getX;
		[Abstract]
		[Export("getX")]
		nfloat X { get; }

		// @required -(CGFloat)getY;
		[Abstract]
		[Export("getY")]
		nfloat Y { get; }

		// @required -(CGFloat)getZ;
		[Abstract]
		[Export("getZ")]
		nfloat Z { get; }
	}

	// @interface MAParticleRandomVelocityGenerate : NSObject <MAParticleVelocityGenerate>
	[BaseType(typeof(NSObject))]
	interface MAParticleRandomVelocityGenerate : MAParticleVelocityGenerate
	{
		// -(instancetype)initWithBoundaryValueX1:(float)x1 Y1:(float)y1 Z1:(float)z1 X2:(float)x2 Y2:(float)y2 Z2:(float)z2;
		[Export("initWithBoundaryValueX1:Y1:Z1:X2:Y2:Z2:")]
		IntPtr Constructor(float x1, float y1, float z1, float x2, float y2, float z2);
	}

	// @protocol MAParticleColorGenerate <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	//interface IMAParticleColorGenerate { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface MAParticleColorGenerate
	{
		// @required -(float *)getColor;
		[Abstract]
		[Export("getColor")]
		float Color { get; }
	}

	// @interface MAParticleRandomColorGenerate : NSObject <MAParticleColorGenerate>
	[BaseType(typeof(NSObject))]
	interface MAParticleRandomColorGenerate : MAParticleColorGenerate
	{
		// -(instancetype)initWithBoundaryColorR1:(float)r1 G1:(float)g1 B1:(float)b1 A1:(float)a1 R2:(float)r2 G2:(float)g2 B2:(float)b2 A2:(float)a2;
		[Export("initWithBoundaryColorR1:G1:B1:A1:R2:G2:B2:A2:")]
		IntPtr Constructor(float r1, float g1, float b1, float a1, float r2, float g2, float b2, float a2);
	}

	// @protocol MAParticleRotationGenerate <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	//interface IMAParticleRotationGenerate { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface MAParticleRotationGenerate
	{
		// @required -(float)getRotate;
		[Abstract]
		[Export("getRotate")]
		float Rotate { get; }
	}

	// @interface MAParticleConstantRotationGenerate : NSObject <MAParticleRotationGenerate>
	[BaseType(typeof(NSObject))]
	interface MAParticleConstantRotationGenerate : MAParticleRotationGenerate
	{
		// -(instancetype)initWithRotate:(float)rotate;
		[Export("initWithRotate:")]
		IntPtr Constructor(float rotate);
	}

	// @protocol MAParticleSizeGenerate <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	//interface IMAParticleSizeGenerate { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface MAParticleSizeGenerate
	{
		// @required -(float)getSizeX:(float)timeFrame;
		[Abstract]
		[Export("getSizeX:")]
		float GetSizeX(float timeFrame);

		// @required -(float)getSizeY:(float)timeFrame;
		[Abstract]
		[Export("getSizeY:")]
		float GetSizeY(float timeFrame);

		// @required -(float)getSizeZ:(float)timeFrame;
		[Abstract]
		[Export("getSizeZ:")]
		float GetSizeZ(float timeFrame);
	}

	// @interface MAParticleCurveSizeGenerate : NSObject <MAParticleSizeGenerate>
	[BaseType(typeof(NSObject))]
	interface MAParticleCurveSizeGenerate : MAParticleSizeGenerate
	{
		// -(instancetype)initWithCurveX:(float)x Y:(float)y Z:(float)z;
		[Export("initWithCurveX:Y:Z:")]
		IntPtr Constructor(float x, float y, float z);
	}

	// @interface MAParticleEmissionModule : NSObject
	[BaseType(typeof(NSObject))]
	interface MAParticleEmissionModule
	{
		// -(instancetype)initWithEmissionRate:(int)rate rateTime:(int)rateTime;
		[Export("initWithEmissionRate:rateTime:")]
		IntPtr Constructor(int rate, int rateTime);
	}

	// @protocol MAParticleShapeModule <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	//interface IMAParticleShapeModule { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface MAParticleShapeModule
	{
		// @required -(float *)getPoint;
		[Abstract]
		[Export("getPoint")]
		float Point { get; }

		// @required -(BOOL)isRatioEnable;
		[Abstract]
		[Export("isRatioEnable")]
		bool IsRatioEnable { get; }
	}

	// @interface MAParticleSinglePointShapeModule : NSObject <MAParticleShapeModule>
	[BaseType(typeof(NSObject))]
	interface MAParticleSinglePointShapeModule : MAParticleShapeModule
	{
		// -(instancetype)initWithShapeX:(float)x Y:(float)y Z:(float)z useRatio:(BOOL)isUseRatio;
		[Export("initWithShapeX:Y:Z:useRatio:")]
		IntPtr Constructor(float x, float y, float z, bool isUseRatio);
	}

	// @interface MAParticleRectShapeModule : NSObject <MAParticleShapeModule>
	[BaseType(typeof(NSObject))]
	interface MAParticleRectShapeModule : MAParticleShapeModule
	{
		// -(instancetype)initWithLeft:(float)left top:(float)top right:(float)right bottom:(float)bottom useRatio:(BOOL)isUseRatio;
		[Export("initWithLeft:top:right:bottom:useRatio:")]
		IntPtr Constructor(float left, float top, float right, float bottom, bool isUseRatio);
	}

	// @interface MAParticleOverLifeModule : NSObject
	[BaseType(typeof(NSObject))]
	interface MAParticleOverLifeModule
	{
		// -(void)setVelocityOverLife:(id<MAParticleVelocityGenerate>)velocity;
		[Export("setVelocityOverLife:")]
		void SetVelocityOverLife(MAParticleVelocityGenerate velocity);

		// -(void)setRotationOverLife:(id<MAParticleRotationGenerate>)rotation;
		[Export("setRotationOverLife:")]
		void SetRotationOverLife(MAParticleRotationGenerate rotation);

		// -(void)setSizeOverLife:(id<MAParticleSizeGenerate>)size;
		[Export("setSizeOverLife:")]
		void SetSizeOverLife(MAParticleSizeGenerate size);

		// -(void)setColorOverLife:(id<MAParticleColorGenerate>)color;
		[Export("setColorOverLife:")]
		void SetColorOverLife(MAParticleColorGenerate color);
	}

	// @interface MAParticleOverlayOptions : NSObject
	[BaseType(typeof(NSObject))]
	interface MAParticleOverlayOptions
	{
		// @property (assign, nonatomic) BOOL visibile;
		[Export("visibile")]
		bool Visibile { get; set; }

		// @property (assign, nonatomic) NSTimeInterval duration;
		[Export("duration")]
		double Duration { get; set; }

		// @property (assign, nonatomic) BOOL loop;
		[Export("loop")]
		bool Loop { get; set; }

		// @property (assign, nonatomic) NSInteger maxParticles;
		[Export("maxParticles")]
		nint MaxParticles { get; set; }

		// @property (nonatomic, strong) UIImage * icon;
		[Export("icon", ArgumentSemantic.Strong)]
		UIImage Icon { get; set; }

		// @property (assign, nonatomic) CGSize startParticleSize;
		[Export("startParticleSize", ArgumentSemantic.Assign)]
		CGSize StartParticleSize { get; set; }

		// @property (assign, nonatomic) NSTimeInterval particleLifeTime;
		[Export("particleLifeTime")]
		double ParticleLifeTime { get; set; }

		// @property (nonatomic, strong) id<MAParticleColorGenerate> particleStartColor;
		[Export("particleStartColor", ArgumentSemantic.Strong)]
		MAParticleColorGenerate ParticleStartColor { get; set; }

		// @property (nonatomic, strong) id<MAParticleVelocityGenerate> particleStartSpeed;
		[Export("particleStartSpeed", ArgumentSemantic.Strong)]
		MAParticleVelocityGenerate ParticleStartSpeed { get; set; }

		// @property (nonatomic, strong) MAParticleEmissionModule * particleEmissionModule;
		[Export("particleEmissionModule", ArgumentSemantic.Strong)]
		MAParticleEmissionModule ParticleEmissionModule { get; set; }

		// @property (nonatomic, strong) id<MAParticleShapeModule> particleShapeModule;
		[Export("particleShapeModule", ArgumentSemantic.Strong)]
		MAParticleShapeModule ParticleShapeModule { get; set; }

		// @property (nonatomic, strong) MAParticleOverLifeModule * particleOverLifeModule;
		[Export("particleOverLifeModule", ArgumentSemantic.Strong)]
		MAParticleOverLifeModule ParticleOverLifeModule { get; set; }
	}

	// @interface MAParticleOverlayOptionsFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface MAParticleOverlayOptionsFactory
	{
		// +(NSArray<MAParticleOverlayOptions *> *)particleOverlayOptionsWithType:(MAParticleOverlayType)particleType;
		[Static]
		[Export("particleOverlayOptionsWithType:")]
		MAParticleOverlayOptions[] ParticleOverlayOptionsWithType(MAParticleOverlayType particleType);
	}

	// @interface MAParticleOverlay : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	interface MAParticleOverlay : MAOverlay
	{
		// +(instancetype)particleOverlayWithOption:(MAParticleOverlayOptions *)option;
		[Static]
		[Export("particleOverlayWithOption:")]
		MAParticleOverlay ParticleOverlayWithOption(MAParticleOverlayOptions option);

		// @property (readonly, nonatomic, strong) MAParticleOverlayOptions * overlayOption;
		[Export("overlayOption", ArgumentSemantic.Strong)]
		MAParticleOverlayOptions OverlayOption { get; }

		// -(void)updateOverlayOption:(MAParticleOverlayOptions *)overlayOption;
		[Export("updateOverlayOption:")]
		void UpdateOverlayOption(MAParticleOverlayOptions overlayOption);
	}

	// @interface MAParticleOverlayRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MAParticleOverlayRenderer
	{
		// @property (readonly, nonatomic) MAParticleOverlay * particleOverlay;
		[Export("particleOverlay")]
		MAParticleOverlay ParticleOverlay { get; }

		// -(instancetype)initWithParticleOverlay:(MAParticleOverlay *)particleOverlay;
		[Export("initWithParticleOverlay:")]
		IntPtr Constructor(MAParticleOverlay particleOverlay);
	}

	// @interface MAHeatMapVectorNode : NSObject
	[BaseType(typeof(NSObject))]
	interface MAHeatMapVectorNode
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) float weight;
		[Export("weight")]
		float Weight { get; set; }
	}

	// @interface MAHeatMapVectorItem : NSObject
	[BaseType(typeof(NSObject))]
	interface MAHeatMapVectorItem
	{
		// @property (readonly, nonatomic) MAMapPoint center;
		[Export("center")]
		MAMapPoint Center { get; }

		// @property (readonly, nonatomic) float intensity;
		[Export("intensity")]
		float Intensity { get; }

		// @property (readonly, nonatomic) NSArray<NSNumber *> * nodeIndices;
		[Export("nodeIndices")]
		NSNumber[] NodeIndices { get; }
	}

	// @interface MAHeatMapVectorOverlayOptions : NSObject
	[BaseType(typeof(NSObject))]
	interface MAHeatMapVectorOverlayOptions
	{
		// @property (assign, nonatomic) MAHeatMapType type;
		[Export("type", ArgumentSemantic.Assign)]
		MAHeatMapType Type { get; set; }

		// @property (assign, nonatomic) BOOL visible;
		[Export("visible")]
		bool Visible { get; set; }

		// @property (nonatomic, strong) NSArray<MAHeatMapVectorNode *> * inputNodes;
		[Export("inputNodes", ArgumentSemantic.Strong)]
		MAHeatMapVectorNode[] InputNodes { get; set; }

		// @property (assign, nonatomic) CLLocationDistance size;
		[Export("size")]
		double Size { get; set; }

		// @property (assign, nonatomic) CGFloat gap;
		[Export("gap")]
		nfloat Gap { get; set; }

		// @property (nonatomic, strong) NSArray<UIColor *> * colors;
		[Export("colors", ArgumentSemantic.Strong)]
		UIColor[] Colors { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * startPoints;
		[Export("startPoints", ArgumentSemantic.Strong)]
		NSNumber[] StartPoints { get; set; }

		// @property (assign, nonatomic) CGFloat opacity;
		[Export("opacity")]
		nfloat Opacity { get; set; }

		// @property (assign, nonatomic) int maxIntensity;
		[Export("maxIntensity")]
		int MaxIntensity { get; set; }

		// @property (assign, nonatomic) CGFloat minZoom;
		[Export("minZoom")]
		nfloat MinZoom { get; set; }

		// @property (assign, nonatomic) CGFloat maxZoom;
		[Export("maxZoom")]
		nfloat MaxZoom { get; set; }
	}

	// @interface MAHeatMapVectorOverlay : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	interface MAHeatMapVectorOverlay : MAOverlay
	{
		// @property (nonatomic, strong) MAHeatMapVectorOverlayOptions * option;
		[Export("option", ArgumentSemantic.Strong)]
		MAHeatMapVectorOverlayOptions Option { get; set; }

		// +(instancetype)heatMapOverlayWithOption:(MAHeatMapVectorOverlayOptions *)option;
		[Static]
		[Export("heatMapOverlayWithOption:")]
		MAHeatMapVectorOverlay HeatMapOverlayWithOption(MAHeatMapVectorOverlayOptions option);
	}

	// @interface MAHeatMapVectorOverlayRender : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MAHeatMapVectorOverlayRender
	{
		// @property (readonly, nonatomic) MAHeatMapVectorOverlay * heatOverlay;
		[Export("heatOverlay")]
		MAHeatMapVectorOverlay HeatOverlay { get; }

		// -(instancetype)initWithHeatOverlay:(MAHeatMapVectorOverlay *)heatOverlay;
		[Export("initWithHeatOverlay:")]
		IntPtr Constructor(MAHeatMapVectorOverlay heatOverlay);

		// -(MAHeatMapVectorItem *)getHeatMapItem:(CLLocationCoordinate2D)coordinate;
		[Export("getHeatMapItem:")]
		MAHeatMapVectorItem GetHeatMapItem(CLLocationCoordinate2D coordinate);
	}

	// @interface MAMultiPointItem : NSObject <NSCopying, MAAnnotation>
	[BaseType(typeof(NSObject))]
	interface MAMultiPointItem : INSCopying, MAAnnotation
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		//[Export("coordinate", ArgumentSemantic.Assign)]
		//CLLocationCoordinate2D MAMultiPointItemCoordinate { get; set; }

		// @property (copy, nonatomic) NSString * customID;
		[Export("customID")]
		string CustomID { get; set; }

		// @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * subtitle;
		[Export("subtitle")]
		string Subtitle { get; set; }
	}

	// @interface MAMultiPointOverlay : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	interface MAMultiPointOverlay : MAOverlay
	{
		// @property (readonly, nonatomic) NSArray<MAMultiPointItem *> * items;
		[Export("items")]
		MAMultiPointItem[] Items { get; }

		// -(instancetype)initWithMultiPointItems:(NSArray<MAMultiPointItem *> *)items;
		[Export("initWithMultiPointItems:")]
		IntPtr Constructor(MAMultiPointItem[] items);
	}

	// @protocol MAMultiPointOverlayRendererDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface MAMultiPointOverlayRendererDelegate
	{
		// @optional -(void)multiPointOverlayRenderer:(MAMultiPointOverlayRenderer *)renderer didItemTapped:(MAMultiPointItem *)item;
		[Export("multiPointOverlayRenderer:didItemTapped:")]
		void DidItemTapped(MAMultiPointOverlayRenderer renderer, MAMultiPointItem item);
	}

	// @interface MAMultiPointOverlayRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MAMultiPointOverlayRenderer
	{
		[Wrap("WeakDelegate")]
		MAMultiPointOverlayRendererDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MAMultiPointOverlayRendererDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) UIImage * icon;
		[Export("icon", ArgumentSemantic.Strong)]
		UIImage Icon { get; set; }

		// @property (assign, nonatomic) CGSize pointSize;
		[Export("pointSize", ArgumentSemantic.Assign)]
		CGSize PointSize { get; set; }

		// @property (assign, nonatomic) CGPoint anchor;
		[Export("anchor", ArgumentSemantic.Assign)]
		CGPoint Anchor { get; set; }

		// @property (readonly, nonatomic) MAMultiPointOverlay * multiPointOverlay;
		[Export("multiPointOverlay")]
		MAMultiPointOverlay MultiPointOverlay { get; }

		// -(instancetype)initWithMultiPointOverlay:(MAMultiPointOverlay *)multiPointOverlay;
		[Export("initWithMultiPointOverlay:")]
		IntPtr Constructor(MAMultiPointOverlay multiPointOverlay);
	}

	// @interface MAHeatMapNode : NSObject
	[BaseType(typeof(NSObject))]
	interface MAHeatMapNode
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) float intensity;
		[Export("intensity")]
		float Intensity { get; set; }
	}

	// @interface MAHeatMapGradient : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface MAHeatMapGradient : INSCopying
	{
		// @property (readonly, nonatomic) NSArray<UIColor *> * colors;
		[Export("colors")]
		UIColor[] Colors { get; }

		// @property (readonly, nonatomic) NSArray<NSNumber *> * startPoints;
		[Export("startPoints")]
		NSNumber[] StartPoints { get; }

		// -(instancetype)initWithColor:(NSArray<UIColor *> *)colors andWithStartPoints:(NSArray<NSNumber *> *)startPoints;
		[Export("initWithColor:andWithStartPoints:")]
		IntPtr Constructor(UIColor[] colors, NSNumber[] startPoints);
	}

	// @interface MAHeatMapTileOverlay : MATileOverlay
	[BaseType(typeof(MATileOverlay))]
	interface MAHeatMapTileOverlay
	{
		// @property (nonatomic, strong) NSArray<MAHeatMapNode *> * data;
		[Export("data", ArgumentSemantic.Strong)]
		MAHeatMapNode[] Data { get; set; }

		// @property (assign, nonatomic) NSInteger radius;
		[Export("radius")]
		nint Radius { get; set; }

		// @property (assign, nonatomic) CGFloat opacity;
		[Export("opacity")]
		nfloat Opacity { get; set; }

		// @property (nonatomic, strong) MAHeatMapGradient * gradient;
		[Export("gradient", ArgumentSemantic.Strong)]
		MAHeatMapGradient Gradient { get; set; }

		// @property (assign, nonatomic) BOOL allowRetinaAdapting;
		[Export("allowRetinaAdapting")]
		bool AllowRetinaAdapting { get; set; }
	}

	// @interface MATouchPoi : NSObject
	[BaseType(typeof(NSObject))]
	interface MATouchPoi
	{
		// @property (readonly, copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; }

		// @property (readonly, copy, nonatomic) NSString * uid;
		[Export("uid")]
		string Uid { get; }
	}

	// @interface MAOfflineItem : NSObject
	[BaseType(typeof(NSObject))]
	public interface MAOfflineItem
	{
		// @property (readonly, copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * jianpin;
		[Export("jianpin")]
		string Jianpin { get; }

		// @property (readonly, copy, nonatomic) NSString * pinyin;
		[Export("pinyin")]
		string Pinyin { get; }

		// @property (readonly, copy, nonatomic) NSString * adcode;
		[Export("adcode")]
		string Adcode { get; }

		// @property (readonly, assign, nonatomic) long long size;
		[Export("size")]
		long Size { get; }

		// @property (readonly, assign, nonatomic) MAOfflineItemStatus itemStatus;
		[Export("itemStatus", ArgumentSemantic.Assign)]
		MAOfflineItemStatus ItemStatus { get; }

		// @property (readonly, assign, nonatomic) long long downloadedSize;
		[Export("downloadedSize")]
		long DownloadedSize { get; }
	}

	// @interface MAOfflineCity : MAOfflineItem
	[BaseType(typeof(MAOfflineItem))]
	interface MAOfflineCity
	{
		// @property (readonly, copy, nonatomic) NSString * cityCode;
		[Export("cityCode")]
		string CityCode { get; }

		// @property (readonly, copy, nonatomic) NSString * cityName __attribute__((deprecated("use name instead")));
		[Export("cityName")]
		string CityName { get; }

		// @property (readonly, copy, nonatomic) NSString * urlString __attribute__((deprecated("Not supported in future version")));
		[Export("urlString")]
		string UrlString { get; }

		// @property (readonly, assign, nonatomic) MAOfflineCityStatus status __attribute__((deprecated("use itemStatus instead")));
		[Export("status", ArgumentSemantic.Assign)]
		MAOfflineCityStatus Status { get; }
	}

	// @interface MAOfflineItemCommonCity : MAOfflineCity
	[BaseType(typeof(MAOfflineCity))]
	interface MAOfflineItemCommonCity
	{
		// @property (nonatomic, weak) MAOfflineItem * province;
		[Export("province", ArgumentSemantic.Weak)]
		MAOfflineItem Province { get; set; }
	}

	// @interface MAOfflineProvince : MAOfflineItem
	[BaseType(typeof(MAOfflineItem))]
	interface MAOfflineProvince
	{
		// @property (readonly, nonatomic, strong) NSArray * cities;
		[Export("cities", ArgumentSemantic.Strong)]
		NSObject[] Cities { get; }
	}

	// @interface MAOfflineItemNationWide : MAOfflineCity
	[BaseType(typeof(MAOfflineCity))]
	interface MAOfflineItemNationWide
	{
	}

	// @interface MAOfflineItemMunicipality : MAOfflineCity
	[BaseType(typeof(MAOfflineCity))]
	interface MAOfflineItemMunicipality
	{
	}

	partial interface Constants
	{
		// extern NSString *const MAOfflineMapErrorDomain;
		[Field("MAOfflineMapErrorDomain", "__Internal")]
		NSString MAOfflineMapErrorDomain { get; }
	}

	partial interface Constants
	{
		// extern NSString *const MAOfflineMapDownloadReceivedSizeKey;
		[Field("MAOfflineMapDownloadReceivedSizeKey", "__Internal")]
		NSString MAOfflineMapDownloadReceivedSizeKey { get; }

		// extern NSString *const MAOfflineMapDownloadExpectedSizeKey;
		[Field("MAOfflineMapDownloadExpectedSizeKey", "__Internal")]
		NSString MAOfflineMapDownloadExpectedSizeKey { get; }
	}

	

	// @interface MAOfflineMap : NSObject
	[BaseType(typeof(NSObject))]
	interface MAOfflineMap
	{
		// +(MAOfflineMap *)sharedOfflineMap;
		[Static]
		[Export("sharedOfflineMap")]
		MAOfflineMap SharedOfflineMap { get; }

		// @property (readonly, nonatomic) NSArray<MAOfflineProvince *> * provinces;
		[Export("provinces")]
		MAOfflineProvince[] Provinces { get; }

		// @property (readonly, nonatomic) NSArray<MAOfflineItemMunicipality *> * municipalities;
		[Export("municipalities")]
		MAOfflineItemMunicipality[] Municipalities { get; }

		// @property (readonly, nonatomic) MAOfflineItemNationWide * nationWide;
		[Export("nationWide")]
		MAOfflineItemNationWide NationWide { get; }

		// @property (readonly, nonatomic) NSArray<MAOfflineCity *> * cities;
		[Export("cities")]
		MAOfflineCity[] Cities { get; }

		// @property (readonly, nonatomic) NSString * version;
		[Export("version")]
		string Version { get; }

		// -(void)setupWithCompletionBlock:(void (^)(BOOL))block;
		[Export("setupWithCompletionBlock:")]
		void SetupWithCompletionBlock(Action<bool> block);

		// -(void)downloadItem:(MAOfflineItem *)item shouldContinueWhenAppEntersBackground:(BOOL)shouldContinueWhenAppEntersBackground downloadBlock:(MAOfflineMapDownloadBlock)downloadBlock;
		[Export("downloadItem:shouldContinueWhenAppEntersBackground:downloadBlock:")]
		void DownloadItem(MAOfflineItem item, bool shouldContinueWhenAppEntersBackground, MAOfflineMapDownloadBlock downloadBlock);

		// -(BOOL)isDownloadingForItem:(MAOfflineItem *)item;
		[Export("isDownloadingForItem:")]
		bool IsDownloadingForItem(MAOfflineItem item);

		// -(BOOL)pauseItem:(MAOfflineItem *)item;
		[Export("pauseItem:")]
		bool PauseItem(MAOfflineItem item);

		// -(void)deleteItem:(MAOfflineItem *)item;
		[Export("deleteItem:")]
		void DeleteItem(MAOfflineItem item);

		// -(void)cancelAll;
		[Export("cancelAll")]
		void CancelAll();

		// -(void)clearDisk;
		[Export("clearDisk")]
		void ClearDisk();

		// -(void)checkNewestVersion:(MAOfflineMapNewestVersionBlock)newestVersionBlock;
		[Export("checkNewestVersion:")]
		void CheckNewestVersion(MAOfflineMapNewestVersionBlock newestVersionBlock);
	}

	// @interface Deprecated (MAOfflineMap)
	[Category]
	[BaseType(typeof(MAOfflineMap))]
	interface MAOfflineMap_Deprecated
	{
		// @property (readonly, nonatomic) NSArray * offlineCities __attribute__((deprecated("use cities instead")));
		//[Export("offlineCities")]
		//NSObject[] OfflineCities { get; }
		[Export("offlineCities")]
		NSObject[] OfflineCities();

		// -(void)downloadCity:(MAOfflineCity *)city downloadBlock:(MAOfflineMapDownloadBlock)downloadBlock __attribute__((deprecated("use - (void)downloadItem:(MAOfflineItem *)item shouldContinueWhenAppEntersBackground:(BOOL)shouldContinueWhenAppEntersBackground downloadBlock:(MAOfflineMapDownloadBlock)downloadBlock instead")));
		[Export("downloadCity:downloadBlock:")]
		void DownloadCity(MAOfflineCity city, MAOfflineMapDownloadBlock downloadBlock);

		// -(void)downloadCity:(MAOfflineCity *)city shouldContinueWhenAppEntersBackground:(BOOL)shouldContinueWhenAppEntersBackground downloadBlock:(MAOfflineMapDownloadBlock)downloadBlock __attribute__((deprecated("use - (void)downloadItem:(MAOfflineItem *)item shouldContinueWhenAppEntersBackground:(BOOL)shouldContinueWhenAppEntersBackground downloadBlock:(MAOfflineMapDownloadBlock)downloadBlock instead")));
		[Export("downloadCity:shouldContinueWhenAppEntersBackground:downloadBlock:")]
		void DownloadCity(MAOfflineCity city, bool shouldContinueWhenAppEntersBackground, MAOfflineMapDownloadBlock downloadBlock);

		// -(BOOL)isDownloadingForCity:(MAOfflineCity *)city __attribute__((deprecated("use - (BOOL)isDownloadingForItem:(MAOfflineItem *)item instead")));
		[Export("isDownloadingForCity:")]
		bool IsDownloadingForCity(MAOfflineCity city);

		// -(void)pause:(MAOfflineCity *)city __attribute__((deprecated("use - (void)pauseItem:(MAOfflineItem *)item instead")));
		[Export("pause:")]
		void Pause(MAOfflineCity city);
	}

	// @interface MAOfflineMapViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface MAOfflineMapViewController
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		MAOfflineMapViewController SharedInstance();

		// @property (readonly, nonatomic) MAOfflineMap * offlineMap;
		[Export("offlineMap")]
		MAOfflineMap OfflineMap { get; }
	}

	// @interface MATracePoint : NSObject <NSCoding>
	[BaseType(typeof(NSObject))]
	public interface MATracePoint : INSCoding
	{
		// @property (assign, nonatomic) CLLocationDegrees latitude;
		[Export("latitude")]
		double Latitude { get; set; }

		// @property (assign, nonatomic) CLLocationDegrees longitude;
		[Export("longitude")]
		double Longitude { get; set; }
	}

	// @interface MATraceLocation : NSObject
	[BaseType(typeof(NSObject))]
	interface MATraceLocation
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D loc;
		[Export("loc", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Loc { get; set; }

		// @property (assign, nonatomic) double angle;
		[Export("angle")]
		double Angle { get; set; }

		// @property (assign, nonatomic) double speed;
		[Export("speed")]
		double Speed { get; set; }

		// @property (assign, nonatomic) double time;
		[Export("time")]
		double Time { get; set; }
	}	

	// @protocol MATraceDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface MATraceDelegate
	{
		// @required -(void)traceManager:(MATraceManager *)manager didTrace:(NSArray<CLLocation *> *)locations correct:(NSArray<MATracePoint *> *)tracePoints distance:(double)distance withError:(NSError *)error;
		[Abstract]
		[Export("traceManager:didTrace:correct:distance:withError:")]
		void TraceManager(MATraceManager manager, CLLocation[] locations, MATracePoint[] tracePoints, double distance, NSError error);

		// @optional -(void)mapViewRequireLocationAuth:(CLLocationManager *)locationManager;
		[Export("mapViewRequireLocationAuth:")]
		void MapViewRequireLocationAuth(CLLocationManager locationManager);
	}

	// @interface MATraceManager : NSObject
	[BaseType(typeof(NSObject))]
	interface MATraceManager
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		MATraceManager SharedInstance();

		// -(NSOperation *)queryProcessedTraceWith:(NSArray<MATraceLocation *> *)locations type:(AMapCoordinateType)type processingCallback:(MAProcessingCallback)processingCallback finishCallback:(MAFinishCallback)finishCallback failedCallback:(MAFailedCallback)failedCallback;
		[Export("queryProcessedTraceWith:type:processingCallback:finishCallback:failedCallback:")]
		NSOperation QueryProcessedTraceWith(MATraceLocation[] locations, AMapCoordinateType type, MAProcessingCallback processingCallback, MAFinishCallback finishCallback, MAFailedCallback failedCallback);

		// -(void)startTraceWith:(MATraceLocationCallback)locCallback __attribute__((deprecated("use start instead")));
		[Export("startTraceWith:")]
		void StartTraceWith(MATraceLocationCallback locCallback);

		// -(void)stopTrace __attribute__((deprecated("use stop instead")));
		[Export("stopTrace")]
		void StopTrace();

		[Wrap("WeakDelegate")]
		MATraceDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MATraceDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)start;
		[Export("start")]
		void Start();

		// -(void)stop;
		[Export("stop")]
		void Stop();
	}

	partial interface Constants
	{
		// extern NSString *const AMapNaviVersion;
		[Field("AMapNaviVersion", "__Internal")]
		NSString AMapNaviVersion { get; }

		// extern NSString *const AMapNaviName;
		[Field("AMapNaviName", "__Internal")]
		NSString AMapNaviName { get; }

		// extern NSString *const AMapNaviErrorDomain;
		[Field("AMapNaviErrorDomain", "__Internal")]
		NSString AMapNaviErrorDomain { get; }
	}

	// @interface AMapNaviPoint : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface AMapNaviPoint : INSCopying, INSCoding
	{
		// @property (assign, nonatomic) CGFloat latitude;
		[Export("latitude")]
		nfloat Latitude { get; set; }

		// @property (assign, nonatomic) CGFloat longitude;
		[Export("longitude")]
		nfloat Longitude { get; set; }

		// +(AMapNaviPoint *)locationWithLatitude:(CGFloat)lat longitude:(CGFloat)lon;
		[Static]
		[Export("locationWithLatitude:longitude:")]
		AMapNaviPoint LocationWithLatitude(nfloat lat, nfloat lon);

		// -(BOOL)isEqualToNaviPoint:(AMapNaviPoint *)aPoint;
		[Export("isEqualToNaviPoint:")]
		bool IsEqualToNaviPoint(AMapNaviPoint aPoint);
	}

	// @interface AMapNaviPointBounds : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface AMapNaviPointBounds : INSCopying, INSCoding
	{
		// @property (nonatomic, strong) AMapNaviPoint * northEast;
		[Export("northEast", ArgumentSemantic.Strong)]
		AMapNaviPoint NorthEast { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * southWest;
		[Export("southWest", ArgumentSemantic.Strong)]
		AMapNaviPoint SouthWest { get; set; }

		// +(AMapNaviPointBounds *)pointBoundsWithNorthEast:(AMapNaviPoint *)northEast southWest:(AMapNaviPoint *)southWest;
		[Static]
		[Export("pointBoundsWithNorthEast:southWest:")]
		AMapNaviPointBounds PointBoundsWithNorthEast(AMapNaviPoint northEast, AMapNaviPoint southWest);
	}

	// @interface AMapNaviGuide : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface AMapNaviGuide : INSCopying, INSCoding
	{
		// @property (nonatomic, strong) NSString * name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (assign, nonatomic) NSInteger length;
		[Export("length")]
		nint Length { get; set; }

		// @property (assign, nonatomic) NSInteger time;
		[Export("time")]
		nint Time { get; set; }

		// @property (assign, nonatomic) AMapNaviIconType iconType;
		[Export("iconType", ArgumentSemantic.Assign)]
		AMapNaviIconType IconType { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }
	}

	// @interface AMapNaviGroupSegment : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviGroupSegment : INSCopying
	{
		// @property (nonatomic, strong) NSString * groupName;
		[Export("groupName", ArgumentSemantic.Strong)]
		string GroupName { get; set; }

		// @property (assign, nonatomic) NSInteger distance;
		[Export("distance")]
		nint Distance { get; set; }

		// @property (assign, nonatomic) NSInteger toll;
		[Export("toll")]
		nint Toll { get; set; }

		// @property (assign, nonatomic) NSInteger startSegmentID;
		[Export("startSegmentID")]
		nint StartSegmentID { get; set; }

		// @property (assign, nonatomic) NSInteger segmentCount;
		[Export("segmentCount")]
		nint SegmentCount { get; set; }

		// @property (assign, nonatomic) BOOL isArriveWayPoint;
		[Export("isArriveWayPoint")]
		bool IsArriveWayPoint { get; set; }
	}

	// @interface AMapNaviTrafficStatus : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviTrafficStatus : INSCopying
	{
		// @property (assign, nonatomic) AMapNaviRouteStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		AMapNaviRouteStatus Status { get; set; }

		// @property (assign, nonatomic) NSInteger length;
		[Export("length")]
		nint Length { get; set; }
	}

	// @interface AMapNaviIntervalCameraDynamicInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviIntervalCameraDynamicInfo : INSCopying
	{
		// @property (assign, nonatomic) NSInteger length;
		[Export("length")]
		nint Length { get; set; }

		// @property (assign, nonatomic) NSInteger remainDistance;
		[Export("remainDistance")]
		nint RemainDistance { get; set; }

		// @property (assign, nonatomic) NSInteger averageSpeed;
		[Export("averageSpeed")]
		nint AverageSpeed { get; set; }

		// @property (assign, nonatomic) NSInteger reasonableSpeedInRemainDist;
		[Export("reasonableSpeedInRemainDist")]
		nint ReasonableSpeedInRemainDist { get; set; }
	}

	// @interface AMapNaviCameraInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviCameraInfo : INSCopying
	{
		// @property (assign, nonatomic) AMapNaviCameraType cameraType;
		[Export("cameraType", ArgumentSemantic.Assign)]
		AMapNaviCameraType CameraType { get; set; }

		// @property (assign, nonatomic) NSInteger cameraSpeed;
		[Export("cameraSpeed")]
		nint CameraSpeed { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }

		// @property (assign, nonatomic) NSInteger distance;
		[Export("distance")]
		nint Distance { get; set; }

		// @property (nonatomic, strong) AMapNaviIntervalCameraDynamicInfo * intervalCameraDynamicInfo;
		[Export("intervalCameraDynamicInfo", ArgumentSemantic.Strong)]
		AMapNaviIntervalCameraDynamicInfo IntervalCameraDynamicInfo { get; set; }
	}

	// @interface AMapNaviServiceAreaInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviServiceAreaInfo : INSCopying
	{
		// @property (assign, nonatomic) NSInteger remainDistance;
		[Export("remainDistance")]
		nint RemainDistance { get; set; }

		// @property (assign, nonatomic) NSInteger type;
		[Export("type")]
		nint Type { get; set; }

		// @property (nonatomic, strong) NSString * name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }
	}

	// @interface AMapNaviCruiseInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviCruiseInfo
	{
		// @property (assign, nonatomic) NSInteger cruisingDriveTime;
		[Export("cruisingDriveTime")]
		nint CruisingDriveTime { get; set; }

		// @property (assign, nonatomic) NSInteger cruisingDriveDistance;
		[Export("cruisingDriveDistance")]
		nint CruisingDriveDistance { get; set; }
	}

	// @interface AMapNaviTrafficFacilityInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviTrafficFacilityInfo
	{
		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }

		// @property (assign, nonatomic) NSInteger boardcastType;
		[Export("boardcastType")]
		nint BoardcastType { get; set; }

		// @property (assign, nonatomic) NSInteger distance;
		[Export("distance")]
		nint Distance { get; set; }

		// @property (assign, nonatomic) NSInteger limitSpeed;
		[Export("limitSpeed")]
		nint LimitSpeed { get; set; }
	}

	// @interface AMapNaviCruiseLinkStatus : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviCruiseLinkStatus
	{
		// @property (nonatomic, strong) NSArray<AMapNaviPoint *> * shapePoints;
		[Export("shapePoints", ArgumentSemantic.Strong)]
		AMapNaviPoint[] ShapePoints { get; set; }

		// @property (assign, nonatomic) AMapNaviRouteStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		AMapNaviRouteStatus Status { get; set; }
	}

	// @interface AMapNaviCruiseCongestionInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviCruiseCongestionInfo
	{
		// @property (copy, nonatomic) NSString * roadName;
		[Export("roadName")]
		string RoadName { get; set; }

		// @property (assign, nonatomic) AMapNaviRouteStatus congestionStatus;
		[Export("congestionStatus", ArgumentSemantic.Assign)]
		AMapNaviRouteStatus CongestionStatus { get; set; }

		// @property (assign, nonatomic) NSInteger etaTime;
		[Export("etaTime")]
		nint EtaTime { get; set; }

		// @property (assign, nonatomic) NSInteger length;
		[Export("length")]
		nint Length { get; set; }

		// @property (nonatomic, strong) AMapNaviCruiseLinkStatus * pLinkData;
		[Export("pLinkData", ArgumentSemantic.Strong)]
		AMapNaviCruiseLinkStatus PLinkData { get; set; }

		// @property (assign, nonatomic) NSInteger linkCnt;
		[Export("linkCnt")]
		nint LinkCnt { get; set; }

		// @property (assign, nonatomic) NSInteger eventType __attribute__((deprecated("该字段已废弃，since 7.0.0")));
		[Export("eventType")]
		nint EventType { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * eventPos __attribute__((deprecated("该字段已废弃，since 7.0.0")));
		[Export("eventPos", ArgumentSemantic.Strong)]
		AMapNaviPoint EventPos { get; set; }
	}

	// @interface AMapNaviRouteLabel : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviRouteLabel : INSCopying
	{
		// @property (assign, nonatomic) NSInteger type;
		[Export("type")]
		nint Type { get; set; }

		// @property (nonatomic, strong) NSString * content;
		[Export("content", ArgumentSemantic.Strong)]
		string Content { get; set; }
	}

	// @interface AMapNaviRestrictionInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviRestrictionInfo : INSCopying
	{
		// @property (assign, nonatomic) NSInteger titleType;
		[Export("titleType")]
		nint TitleType { get; set; }

		// @property (nonatomic, strong) NSString * title;
		[Export("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * tips;
		[Export("tips", ArgumentSemantic.Strong)]
		string Tips { get; set; }

		// @property (assign, nonatomic) NSInteger cityCode;
		[Export("cityCode")]
		nint CityCode { get; set; }

		// @property (nonatomic, strong) NSString * desc __attribute__((deprecated("该字段已废弃，since 6.0.0")));
		[Export("desc", ArgumentSemantic.Strong)]
		string Desc { get; set; }

		// @property (assign, nonatomic) NSInteger type __attribute__((deprecated("该字段已废弃,请使用 titleType . since 6.0.0")));
		[Export("type")]
		nint Type { get; set; }
	}

	// @interface AMapNaviParallelRoadStatus : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviParallelRoadStatus
	{
		// @property (assign, nonatomic) AMapNaviParallelRoadStatusFlag flag;
		[Export("flag", ArgumentSemantic.Assign)]
		AMapNaviParallelRoadStatusFlag Flag { get; set; }

		// @property (assign, nonatomic) AMapNaviElevatedRoadStatusFlag hwFlag;
		[Export("hwFlag", ArgumentSemantic.Assign)]
		AMapNaviElevatedRoadStatusFlag HwFlag { get; set; }

		// @property (assign, nonatomic) NSInteger status __attribute__((deprecated("该字段已废弃. since 7.0.0")));
		[Export("status")]
		nint Status { get; set; }
	}

	// @interface AMapNaviVehicleInfo : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface AMapNaviVehicleInfo : INSCopying, INSCoding
	{
		// @property (nonatomic, strong) NSString * vehicleId;
		[Export("vehicleId", ArgumentSemantic.Strong)]
		string VehicleId { get; set; }

		// @property (assign, nonatomic) BOOL isETARestriction;
		[Export("isETARestriction")]
		bool IsETARestriction { get; set; }

		// @property (assign, nonatomic) NSInteger type;
		[Export("type")]
		nint Type { get; set; }

		// @property (assign, nonatomic) BOOL isLoadIgnore;
		[Export("isLoadIgnore")]
		bool IsLoadIgnore { get; set; }

		// @property (assign, nonatomic) NSInteger size;
		[Export("size")]
		nint Size { get; set; }

		// @property (assign, nonatomic) NSInteger axisNums;
		[Export("axisNums")]
		nint AxisNums { get; set; }

		// @property (assign, nonatomic) CGFloat width;
		[Export("width")]
		nfloat Width { get; set; }

		// @property (assign, nonatomic) CGFloat height;
		[Export("height")]
		nfloat Height { get; set; }

		// @property (assign, nonatomic) CGFloat length;
		[Export("length")]
		nfloat Length { get; set; }

		// @property (assign, nonatomic) CGFloat load;
		[Export("load")]
		nfloat Load { get; set; }

		// @property (assign, nonatomic) CGFloat weight;
		[Export("weight")]
		nfloat Weight { get; set; }
	}

	// @interface AMapNaviNotAvoidFacilityAndForbiddenInfo : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface AMapNaviNotAvoidFacilityAndForbiddenInfo : INSCopying, INSCoding
	{
		// @property (assign, nonatomic) NSInteger type;
		[Export("type")]
		nint Type { get; set; }

		// @property (assign, nonatomic) NSInteger forbiddenType;
		[Export("forbiddenType")]
		nint ForbiddenType { get; set; }

		// @property (assign, nonatomic) NSInteger distance;
		[Export("distance")]
		nint Distance { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }
	}

	// @interface AMapNaviRouteForbiddenInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviRouteForbiddenInfo : INSCopying
	{
		// @property (assign, nonatomic) NSInteger type;
		[Export("type")]
		nint Type { get; set; }

		// @property (nonatomic, strong) NSString * vehicleType;
		[Export("vehicleType", ArgumentSemantic.Strong)]
		string VehicleType { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }

		// @property (nonatomic, strong) NSString * timeDescription;
		[Export("timeDescription", ArgumentSemantic.Strong)]
		string TimeDescription { get; set; }

		// @property (nonatomic, strong) NSString * roadName;
		[Export("roadName", ArgumentSemantic.Strong)]
		string RoadName { get; set; }
	}

	// @interface AMapNaviRoadFacilityInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviRoadFacilityInfo : INSCopying
	{
		// @property (assign, nonatomic) AMapNaviRoadFacilityType type;
		[Export("type", ArgumentSemantic.Assign)]
		AMapNaviRoadFacilityType Type { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }

		// @property (nonatomic, strong) NSString * roadName;
		[Export("roadName", ArgumentSemantic.Strong)]
		string RoadName { get; set; }
	}

	// @interface AMapNaviRouteNotifyData : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviRouteNotifyData : INSCopying
	{
		// @property (assign, nonatomic) AMapNaviRouteNotifyDataType type;
		[Export("type", ArgumentSemantic.Assign)]
		AMapNaviRouteNotifyDataType Type { get; set; }

		// @property (assign, nonatomic) BOOL success;
		[Export("success")]
		bool Success { get; set; }

		// @property (assign, nonatomic) NSInteger distance;
		[Export("distance")]
		nint Distance { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }

		// @property (copy, nonatomic) NSString * roadName;
		[Export("roadName")]
		string RoadName { get; set; }

		// @property (copy, nonatomic) NSString * reason;
		[Export("reason")]
		string Reason { get; set; }

		// @property (copy, nonatomic) NSString * subTitle;
		[Export("subTitle")]
		string SubTitle { get; set; }
	}

	// @interface AMapNaviCongestionInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviCongestionInfo : INSCopying
	{
		// @property (assign, nonatomic) NSInteger remainDistance;
		[Export("remainDistance")]
		nint RemainDistance { get; set; }

		// @property (assign, nonatomic) NSInteger remainTime;
		[Export("remainTime")]
		nint RemainTime { get; set; }

		// @property (assign, nonatomic) BOOL inCongestionArea;
		[Export("inCongestionArea")]
		bool InCongestionArea { get; set; }

		// @property (assign, nonatomic) AMapNaviRouteStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		AMapNaviRouteStatus Status { get; set; }

		// @property (assign, nonatomic) NSInteger beginSegmentIndex;
		[Export("beginSegmentIndex")]
		nint BeginSegmentIndex { get; set; }

		// @property (assign, nonatomic) NSInteger beginLinkIndex;
		[Export("beginLinkIndex")]
		nint BeginLinkIndex { get; set; }

		// @property (assign, nonatomic) NSInteger endSegmentIndex;
		[Export("endSegmentIndex")]
		nint EndSegmentIndex { get; set; }

		// @property (assign, nonatomic) NSInteger endLinkIndex;
		[Export("endLinkIndex")]
		nint EndLinkIndex { get; set; }
	}

	// @interface AMapNaviSuggestChangeMainNaviRouteInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviSuggestChangeMainNaviRouteInfo : INSCopying
	{
		// @property (nonatomic, weak) AMapNaviRoute * backupRoute;
		[Export("backupRoute", ArgumentSemantic.Weak)]
		AMapNaviRoute BackupRoute { get; set; }

		// @property (assign, nonatomic) NSInteger savingTime;
		[Export("savingTime")]
		nint SavingTime { get; set; }

		// @property (copy, nonatomic) NSString * wayRoadName;
		[Export("wayRoadName")]
		string WayRoadName { get; set; }
	}

	// @interface AMapNaviRouteIconPoint : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviRouteIconPoint : INSCopying
	{
		// @property (assign, nonatomic) AMapNaviRouteIconPointType type;
		[Export("type", ArgumentSemantic.Assign)]
		AMapNaviRouteIconPointType Type { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * point;
		[Export("point", ArgumentSemantic.Strong)]
		AMapNaviPoint Point { get; set; }
	}

	// @interface AMapNaviTrafficIncidentInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviTrafficIncidentInfo : INSCopying
	{
		// @property (nonatomic, strong) NSString * title;
		[Export("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }

		// @property (assign, nonatomic) NSInteger titleType;
		[Export("titleType")]
		nint TitleType { get; set; }
	}

	// @interface AMapNaviPOIInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviPOIInfo : INSCopying
	{
		// @property (copy, nonatomic) NSString * mid;
		[Export("mid")]
		string Mid { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * locPoint;
		[Export("locPoint", ArgumentSemantic.Strong)]
		AMapNaviPoint LocPoint { get; set; }

		// @property (assign, nonatomic) double startAngle;
		[Export("startAngle")]
		double StartAngle { get; set; }
	}

	// @interface AMapNaviParallelRoadInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviParallelRoadInfo
	{
		// @property (assign, nonatomic) NSInteger type;
		[Export("type")]
		nint Type { get; set; }
	}

	// @interface AMapNaviToWayPointInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviToWayPointInfo : INSCopying
	{
		// @property (copy, nonatomic) NSString * mid;
		[Export("mid")]
		string Mid { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * point;
		[Export("point", ArgumentSemantic.Strong)]
		AMapNaviPoint Point { get; set; }

		// @property (assign, nonatomic) NSInteger remainDistance;
		[Export("remainDistance")]
		nint RemainDistance { get; set; }

		// @property (assign, nonatomic) NSInteger remainTime;
		[Export("remainTime")]
		nint RemainTime { get; set; }
	}

	// @interface AMapNaviRouteWayPointInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviRouteWayPointInfo : INSCopying
	{
		// @property (copy, nonatomic) NSString * mid;
		[Export("mid")]
		string Mid { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * point;
		[Export("point", ArgumentSemantic.Strong)]
		AMapNaviPoint Point { get; set; }

		// @property (assign, nonatomic) NSUInteger segmentIndexInRoute;
		[Export("segmentIndexInRoute")]
		nuint SegmentIndexInRoute { get; set; }

		// @property (assign, nonatomic) NSUInteger pointIndexInRoute;
		[Export("pointIndexInRoute")]
		nuint PointIndexInRoute { get; set; }
	}

	// @interface AMapNaviExitBoardInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviExitBoardInfo : INSCopying
	{
		// @property (nonatomic, strong) NSArray<NSString *> * exitNames;
		[Export("exitNames", ArgumentSemantic.Strong)]
		string[] ExitNames { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * directionInfos;
		[Export("directionInfos", ArgumentSemantic.Strong)]
		string[] DirectionInfos { get; set; }
	}

	// @interface AMapNaviInfo : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface AMapNaviInfo : INSCopying, INSCoding
	{
		// @property (assign, nonatomic) AMapNaviMode naviMode;
		[Export("naviMode", ArgumentSemantic.Assign)]
		AMapNaviMode NaviMode { get; set; }

		// @property (assign, nonatomic) AMapNaviIconType iconType;
		[Export("iconType", ArgumentSemantic.Assign)]
		AMapNaviIconType IconType { get; set; }

		// @property (nonatomic, strong) NSString * currentRoadName;
		[Export("currentRoadName", ArgumentSemantic.Strong)]
		string CurrentRoadName { get; set; }

		// @property (nonatomic, strong) NSString * nextRoadName;
		[Export("nextRoadName", ArgumentSemantic.Strong)]
		string NextRoadName { get; set; }

		// @property (assign, nonatomic) NSInteger routeRemainDistance;
		[Export("routeRemainDistance")]
		nint RouteRemainDistance { get; set; }

		// @property (assign, nonatomic) NSInteger routeRemainTime;
		[Export("routeRemainTime")]
		nint RouteRemainTime { get; set; }

		// @property (assign, nonatomic) NSInteger currentSegmentIndex;
		[Export("currentSegmentIndex")]
		nint CurrentSegmentIndex { get; set; }

		// @property (assign, nonatomic) NSInteger segmentRemainDistance;
		[Export("segmentRemainDistance")]
		nint SegmentRemainDistance { get; set; }

		// @property (assign, nonatomic) NSInteger segmentRemainTime;
		[Export("segmentRemainTime")]
		nint SegmentRemainTime { get; set; }

		// @property (assign, nonatomic) NSInteger currentLinkIndex;
		[Export("currentLinkIndex")]
		nint CurrentLinkIndex { get; set; }

		// @property (assign, nonatomic) NSInteger currentPointIndex;
		[Export("currentPointIndex")]
		nint CurrentPointIndex { get; set; }

		// @property (assign, nonatomic) NSInteger routeDriveDistance;
		[Export("routeDriveDistance")]
		nint RouteDriveDistance { get; set; }

		// @property (assign, nonatomic) NSInteger routeDriveTime;
		[Export("routeDriveTime")]
		nint RouteDriveTime { get; set; }

		// @property (nonatomic, strong) AMapNaviNotAvoidFacilityAndForbiddenInfo * notAvoidInfo;
		[Export("notAvoidInfo", ArgumentSemantic.Strong)]
		AMapNaviNotAvoidFacilityAndForbiddenInfo NotAvoidInfo { get; set; }

		// @property (assign, nonatomic) NSInteger routeRemainTrafficLightCount;
		[Export("routeRemainTrafficLightCount")]
		nint RouteRemainTrafficLightCount { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviToWayPointInfo *> * toWayPointInfos;
		[Export("toWayPointInfos", ArgumentSemantic.Strong)]
		AMapNaviToWayPointInfo[] ToWayPointInfos { get; set; }

		// @property (nonatomic, strong) AMapNaviExitBoardInfo * exitBoardInfo;
		[Export("exitBoardInfo", ArgumentSemantic.Strong)]
		AMapNaviExitBoardInfo ExitBoardInfo { get; set; }

		// @property (assign, nonatomic) NSInteger carDirection __attribute__((deprecated("该字段已废弃 since 5.0.0")));
		[Export("carDirection")]
		nint CarDirection { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * carCoordinate __attribute__((deprecated("该字段已废弃 since 5.0.0")));
		[Export("carCoordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint CarCoordinate { get; set; }

		// @property (assign, nonatomic) NSInteger cameraIndex __attribute__((deprecated("该字段已废弃 since 5.0.0")));
		[Export("cameraIndex")]
		nint CameraIndex { get; set; }

		// @property (assign, nonatomic) NSInteger cameraDistance __attribute__((deprecated("该字段已废弃，使用AMapNaviCameraInfo.distance，since 5.0.0")));
		[Export("cameraDistance")]
		nint CameraDistance { get; set; }

		// @property (assign, nonatomic) NSInteger cameraType __attribute__((deprecated("该字段已废弃，使用AMapNaviCameraInfo.cameraType，since 5.0.0")));
		[Export("cameraType")]
		nint CameraType { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * cameraCoordinate __attribute__((deprecated("该字段已废弃，使用AMapNaviCameraInfo.coordinate，since 5.0.0")));
		[Export("cameraCoordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint CameraCoordinate { get; set; }

		// @property (assign, nonatomic) NSInteger cameraLimitSpeed __attribute__((deprecated("该字段已废弃，使用AMapNaviCameraInfo.cameraSpeed，since 5.0.0")));
		[Export("cameraLimitSpeed")]
		nint CameraLimitSpeed { get; set; }

		// @property (assign, nonatomic) NSInteger serviceAreaDistance __attribute__((deprecated("该字段已废弃，使用AMapNaviServiceAreaInfo.remainDistance，since 5.0.0")));
		[Export("serviceAreaDistance")]
		nint ServiceAreaDistance { get; set; }
	}

	// @interface AMapNaviLink : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviLink : INSCopying
	{
		// @property (nonatomic, strong) NSArray<AMapNaviPoint *> * coordinates;
		[Export("coordinates", ArgumentSemantic.Strong)]
		AMapNaviPoint[] Coordinates { get; set; }

		// @property (assign, nonatomic) NSInteger length;
		[Export("length")]
		nint Length { get; set; }

		// @property (assign, nonatomic) NSInteger time;
		[Export("time")]
		nint Time { get; set; }

		// @property (nonatomic, strong) NSString * roadName;
		[Export("roadName", ArgumentSemantic.Strong)]
		string RoadName { get; set; }

		// @property (assign, nonatomic) AMapNaviRoadClass roadClass;
		[Export("roadClass", ArgumentSemantic.Assign)]
		AMapNaviRoadClass RoadClass { get; set; }

		// @property (assign, nonatomic) AMapNaviFormWay formWay;
		[Export("formWay", ArgumentSemantic.Assign)]
		AMapNaviFormWay FormWay { get; set; }

		// @property (assign, nonatomic) BOOL isHadTrafficLights;
		[Export("isHadTrafficLights")]
		bool IsHadTrafficLights { get; set; }

		// @property (assign, nonatomic) AMapNaviRouteStatus trafficStatus;
		[Export("trafficStatus", ArgumentSemantic.Assign)]
		AMapNaviRouteStatus TrafficStatus { get; set; }

		// @property (assign, nonatomic) AMapNaviLinkType linkType;
		[Export("linkType", ArgumentSemantic.Assign)]
		AMapNaviLinkType LinkType { get; set; }
	}

	// @interface AMapNaviSegment : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviSegment : INSCopying
	{
		// @property (nonatomic, strong) NSArray<AMapNaviPoint *> * coordinates;
		[Export("coordinates", ArgumentSemantic.Strong)]
		AMapNaviPoint[] Coordinates { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviLink *> * links;
		[Export("links", ArgumentSemantic.Strong)]
		AMapNaviLink[] Links { get; set; }

		// @property (assign, nonatomic) NSInteger length;
		[Export("length")]
		nint Length { get; set; }

		// @property (assign, nonatomic) NSInteger time;
		[Export("time")]
		nint Time { get; set; }

		// @property (assign, nonatomic) AMapNaviIconType iconType;
		[Export("iconType", ArgumentSemantic.Assign)]
		AMapNaviIconType IconType { get; set; }

		// @property (assign, nonatomic) NSInteger chargeLength;
		[Export("chargeLength")]
		nint ChargeLength { get; set; }

		// @property (assign, nonatomic) NSInteger tollCost;
		[Export("tollCost")]
		nint TollCost { get; set; }

		// @property (assign, nonatomic) NSInteger trafficLightCount;
		[Export("trafficLightCount")]
		nint TrafficLightCount { get; set; }

		// @property (assign, nonatomic) BOOL isArriveWayPoint;
		[Export("isArriveWayPoint")]
		bool IsArriveWayPoint { get; set; }
	}

	// @interface AMapNaviRoute : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviRoute : INSCopying
	{
		// @property (assign, nonatomic) NSInteger routeLength;
		[Export("routeLength")]
		nint RouteLength { get; set; }

		// @property (assign, nonatomic) NSInteger routeTime;
		[Export("routeTime")]
		nint RouteTime { get; set; }

		// @property (nonatomic, strong) AMapNaviPointBounds * routeBounds;
		[Export("routeBounds", ArgumentSemantic.Strong)]
		AMapNaviPointBounds RouteBounds { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * routeCenterPoint;
		[Export("routeCenterPoint", ArgumentSemantic.Strong)]
		AMapNaviPoint RouteCenterPoint { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviPoint *> * routeCoordinates;
		[Export("routeCoordinates", ArgumentSemantic.Strong)]
		AMapNaviPoint[] RouteCoordinates { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * routeStartPoint;
		[Export("routeStartPoint", ArgumentSemantic.Strong)]
		AMapNaviPoint RouteStartPoint { get; set; }

		// @property (nonatomic, strong) AMapNaviPoint * routeEndPoint;
		[Export("routeEndPoint", ArgumentSemantic.Strong)]
		AMapNaviPoint RouteEndPoint { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviSegment *> * routeSegments;
		[Export("routeSegments", ArgumentSemantic.Strong)]
		AMapNaviSegment[] RouteSegments { get; set; }

		// @property (assign, nonatomic) NSInteger routeSegmentCount;
		[Export("routeSegmentCount")]
		nint RouteSegmentCount { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviCameraInfo *> * routeCameras;
		[Export("routeCameras", ArgumentSemantic.Strong)]
		AMapNaviCameraInfo[] RouteCameras { get; set; }

		// @property (assign, nonatomic) NSInteger routeTrafficLightCount;
		[Export("routeTrafficLightCount")]
		nint RouteTrafficLightCount { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviRouteLabel *> * routeLabels;
		[Export("routeLabels", ArgumentSemantic.Strong)]
		AMapNaviRouteLabel[] RouteLabels { get; set; }

		// @property (assign, nonatomic) AMapNaviDrivingStrategy routeStrategy __attribute__((deprecated("该字段已废弃，使用AMapNaviRouteLabel替代，since 5.0.0")));
		[Export("routeStrategy", ArgumentSemantic.Assign)]
		AMapNaviDrivingStrategy RouteStrategy { get; set; }

		// @property (assign, nonatomic) NSInteger routeTollCost;
		[Export("routeTollCost")]
		nint RouteTollCost { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviPoint *> * wayPoints __attribute__((deprecated("该字段已废弃，使用wayPointsInfo替代，since 6.7.0")));
		[Export("wayPoints", ArgumentSemantic.Strong)]
		AMapNaviPoint[] WayPoints { get; set; }

		// @property (nonatomic, strong) NSIndexPath * wayPointsIndexes __attribute__((deprecated("该字段已废弃，使用wayPointsInfo替代，since 6.7.0")));
		[Export("wayPointsIndexes", ArgumentSemantic.Strong)]
		NSIndexPath WayPointsIndexes { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * wayPointCoordIndexes __attribute__((deprecated("该字段已废弃，使用wayPointsInfo替代，since 6.7.0")));
		[Export("wayPointCoordIndexes", ArgumentSemantic.Strong)]
		NSNumber[] WayPointCoordIndexes { get; set; }

		// @property (nonatomic, strong) AMapNaviRestrictionInfo * restrictionInfo;
		[Export("restrictionInfo", ArgumentSemantic.Strong)]
		AMapNaviRestrictionInfo RestrictionInfo { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviTrafficStatus *> * routeTrafficStatuses;
		[Export("routeTrafficStatuses", ArgumentSemantic.Strong)]
		AMapNaviTrafficStatus[] RouteTrafficStatuses { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviGroupSegment *> * routeGroupSegments;
		[Export("routeGroupSegments", ArgumentSemantic.Strong)]
		AMapNaviGroupSegment[] RouteGroupSegments { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * routeCityAdcodes;
		[Export("routeCityAdcodes", ArgumentSemantic.Strong)]
		NSNumber[] RouteCityAdcodes { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviPoint *> * routeTrafficLights;
		[Export("routeTrafficLights", ArgumentSemantic.Strong)]
		AMapNaviPoint[] RouteTrafficLights { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviRouteForbiddenInfo *> * forbiddenInfo;
		[Export("forbiddenInfo", ArgumentSemantic.Strong)]
		AMapNaviRouteForbiddenInfo[] ForbiddenInfo { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviRoadFacilityInfo *> * roadFacilityInfo;
		[Export("roadFacilityInfo", ArgumentSemantic.Strong)]
		AMapNaviRoadFacilityInfo[] RoadFacilityInfo { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviRouteIconPoint *> * routeIconPoints;
		[Export("routeIconPoints", ArgumentSemantic.Strong)]
		AMapNaviRouteIconPoint[] RouteIconPoints { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviTrafficIncidentInfo *> * trafficIncidentInfo;
		[Export("trafficIncidentInfo", ArgumentSemantic.Strong)]
		AMapNaviTrafficIncidentInfo[] TrafficIncidentInfo { get; set; }

		// @property (nonatomic, strong) NSArray<AMapNaviRouteWayPointInfo *> * wayPointsInfo;
		[Export("wayPointsInfo", ArgumentSemantic.Strong)]
		AMapNaviRouteWayPointInfo[] WayPointsInfo { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * drawStyleIndexes;
		[Export("drawStyleIndexes", ArgumentSemantic.Strong)]
		NSNumber[] DrawStyleIndexes { get; set; }

		// @property (assign, nonatomic) NSUInteger routeUID;
		[Export("routeUID")]
		nuint RouteUID { get; set; }
	}

	// @interface AMapNaviLocation : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface AMapNaviLocation : INSCopying
	{
		// @property (nonatomic, strong) AMapNaviPoint * coordinate;
		[Export("coordinate", ArgumentSemantic.Strong)]
		AMapNaviPoint Coordinate { get; set; }

		// @property (assign, nonatomic) double accuracy;
		[Export("accuracy")]
		double Accuracy { get; set; }

		// @property (assign, nonatomic) double altitude;
		[Export("altitude")]
		double Altitude { get; set; }

		// @property (assign, nonatomic) NSInteger heading;
		[Export("heading")]
		nint Heading { get; set; }

		// @property (assign, nonatomic) NSInteger speed;
		[Export("speed")]
		nint Speed { get; set; }

		// @property (nonatomic, strong) NSDate * timestamp;
		[Export("timestamp", ArgumentSemantic.Strong)]
		NSDate Timestamp { get; set; }

		// @property (assign, nonatomic) BOOL isMatchNaviPath;
		[Export("isMatchNaviPath")]
		bool IsMatchNaviPath { get; set; }

		// @property (assign, nonatomic) int currentSegmentIndex;
		[Export("currentSegmentIndex")]
		int CurrentSegmentIndex { get; set; }

		// @property (assign, nonatomic) int currentLinkIndex;
		[Export("currentLinkIndex")]
		int CurrentLinkIndex { get; set; }

		// @property (assign, nonatomic) int currentPointIndex;
		[Export("currentPointIndex")]
		int CurrentPointIndex { get; set; }

		// @property (assign, nonatomic) BOOL isNetworkNavi;
		[Export("isNetworkNavi")]
		bool IsNetworkNavi { get; set; }
	}

	// @interface AMapNaviStatisticsInfo : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface AMapNaviStatisticsInfo : INSCopying, INSCoding
	{
		// @property (assign, nonatomic) NSInteger actualDrivenTime;
		[Export("actualDrivenTime")]
		nint ActualDrivenTime { get; set; }

		// @property (assign, nonatomic) NSInteger actualDrivenDisance;
		[Export("actualDrivenDisance")]
		nint ActualDrivenDisance { get; set; }

		// @property (assign, nonatomic) NSInteger averageSpeed;
		[Export("averageSpeed")]
		nint AverageSpeed { get; set; }

		// @property (assign, nonatomic) NSInteger highestSpeed;
		[Export("highestSpeed")]
		nint HighestSpeed { get; set; }

		// @property (assign, nonatomic) NSInteger overspeedCount;
		[Export("overspeedCount")]
		nint OverspeedCount { get; set; }

		// @property (assign, nonatomic) NSInteger rerouteCount;
		[Export("rerouteCount")]
		nint RerouteCount { get; set; }

		// @property (assign, nonatomic) NSInteger brakesCount;
		[Export("brakesCount")]
		nint BrakesCount { get; set; }

		// @property (assign, nonatomic) NSInteger slowTime;
		[Export("slowTime")]
		nint SlowTime { get; set; }
	}

	// @interface AMapNaviBaseManager : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviBaseManager
	{
		// @property (readonly, nonatomic) AMapNaviMode naviMode;
		[Export("naviMode")]
		AMapNaviMode NaviMode { get; }

		// @property (assign, nonatomic) BOOL screenAlwaysBright;
		[Export("screenAlwaysBright")]
		bool ScreenAlwaysBright { get; set; }

		// @property (assign, nonatomic) BOOL pausesLocationUpdatesAutomatically;
		[Export("pausesLocationUpdatesAutomatically")]
		bool PausesLocationUpdatesAutomatically { get; set; }

		// @property (assign, nonatomic) BOOL allowsBackgroundLocationUpdates;
		[Export("allowsBackgroundLocationUpdates")]
		bool AllowsBackgroundLocationUpdates { get; set; }

		// @property (assign, nonatomic) BOOL enableExternalLocation;
		[Export("enableExternalLocation")]
		bool EnableExternalLocation { get; set; }

		// @property (copy, nonatomic) CLLocation * _Nonnull externalLocation;
		[Export("externalLocation", ArgumentSemantic.Copy)]
		CLLocation ExternalLocation { get; set; }

		// @property (assign, nonatomic) BOOL isUseInternalTTS;
		[Export("isUseInternalTTS")]
		bool IsUseInternalTTS { get; set; }

		// -(void)setExternalLocation:(CLLocation * _Nonnull)externalLocation isAMapCoordinate:(BOOL)isAMapCoordinate;
		[Export("setExternalLocation:isAMapCoordinate:")]
		void SetExternalLocation(CLLocation externalLocation, bool isAMapCoordinate);

		// -(NSArray<AMapNaviGuide *> * _Nullable)getNaviGuideList;
		[NullAllowed, Export("getNaviGuideList")]
		AMapNaviGuide[] NaviGuideList { get; }

		// -(void)setEmulatorNaviSpeed:(int)speed;
		[Export("setEmulatorNaviSpeed:")]
		void SetEmulatorNaviSpeed(int speed);

		// -(BOOL)startEmulatorNavi;
		[Export("startEmulatorNavi")]
		bool StartEmulatorNavi { get; }

		// -(BOOL)startGPSNavi;
		[Export("startGPSNavi")]
		bool StartGPSNavi { get; }

		// -(void)stopNavi;
		[Export("stopNavi")]
		void StopNavi();

		// -(void)pauseNavi;
		[Export("pauseNavi")]
		void PauseNavi();

		// -(void)resumeNavi;
		[Export("resumeNavi")]
		void ResumeNavi();

		// -(BOOL)readNaviInfoManual;
		[Export("readNaviInfoManual")]
		bool ReadNaviInfoManual { get; }
	}

	// @protocol AMapNaviDriveDataRepresentable <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	interface IAMapNaviDriveDataRepresentable { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface AMapNaviDriveDataRepresentable
	{
		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateNaviMode:(AMapNaviMode)naviMode;
		[Export("driveManager:updateNaviMode:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviMode naviMode);
		void DriveManagerUpdateNaviMode(AMapNaviDriveManager driveManager, AMapNaviMode naviMode);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateNaviRouteID:(NSInteger)naviRouteID;
		[Export("driveManager:updateNaviRouteID:")]
		//void DriveManager(AMapNaviDriveManager driveManager, nint naviRouteID);
		void DriveManagerUpdateNaviRouteID(AMapNaviDriveManager driveManager, nint naviRouteID);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateNaviRoute:(AMapNaviRoute * _Nullable)naviRoute;
		[Export("driveManager:updateNaviRoute:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviRoute naviRoute);
		void DriveManagerUpdateNaviRoute(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviRoute naviRoute);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateNaviInfo:(AMapNaviInfo * _Nullable)naviInfo;
		[Export("driveManager:updateNaviInfo:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviInfo naviInfo);
		void DriveManagerUpdateNaviInfo(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviInfo naviInfo);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateNaviLocation:(AMapNaviLocation * _Nullable)naviLocation;
		[Export("driveManager:updateNaviLocation:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviLocation naviLocation);
		void DriveManagerUpdateNaviLocation(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviLocation naviLocation);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager showCrossImage:(UIImage * _Nonnull)crossImage;
		[Export("driveManager:showCrossImage:")]
		//void DriveManager(AMapNaviDriveManager driveManager, UIImage crossImage);
		void DriveManagerShowCrossImage(AMapNaviDriveManager driveManager, UIImage crossImage);

		// @optional -(void)driveManagerHideCrossImage:(AMapNaviDriveManager * _Nonnull)driveManager;
		[Export("driveManagerHideCrossImage:")]
		void DriveManagerHideCrossImage(AMapNaviDriveManager driveManager);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager showLaneBackInfo:(NSString * _Nonnull)laneBackInfo laneSelectInfo:(NSString * _Nonnull)laneSelectInfo;
		[Export("driveManager:showLaneBackInfo:laneSelectInfo:")]
		//void DriveManager(AMapNaviDriveManager driveManager, string laneBackInfo, string laneSelectInfo);
		void DriveManagerShowLaneBackInfoLaneSelectInfo(AMapNaviDriveManager driveManager, string laneBackInfo, string laneSelectInfo);

		// @optional -(void)driveManagerHideLaneInfo:(AMapNaviDriveManager * _Nonnull)driveManager;
		[Export("driveManagerHideLaneInfo:")]
		void DriveManagerHideLaneInfo(AMapNaviDriveManager driveManager);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateTrafficStatus:(NSArray<AMapNaviTrafficStatus *> * _Nullable)trafficStatus;
		[Export("driveManager:updateTrafficStatus:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviTrafficStatus[] trafficStatus);
		void DriveManagerUpdateTrafficStatus(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviTrafficStatus[] trafficStatus);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateCameraInfos:(NSArray<AMapNaviCameraInfo *> * _Nullable)cameraInfos;
		[Export("driveManager:updateCameraInfos:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviCameraInfo[] cameraInfos);
		void DriveManagerUpdateCameraInfos(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviCameraInfo[] cameraInfos);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateServiceAreaInfos:(NSArray<AMapNaviServiceAreaInfo *> * _Nullable)serviceAreaInfos;
		[Export("driveManager:updateServiceAreaInfos:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviServiceAreaInfo[] serviceAreaInfos);
		void DriveManagerUpdateServiceAreaInfos(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviServiceAreaInfo[] serviceAreaInfos);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateParallelRoadStatus:(AMapNaviParallelRoadStatus * _Nullable)parallelRoadStatus;
		[Export("driveManager:updateParallelRoadStatus:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviParallelRoadStatus parallelRoadStatus);
		void DriveManagerUpdateParallelRoadStatus(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviParallelRoadStatus parallelRoadStatus);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateIntervalCameraWithPositionState:(AMapNaviIntervalCameraPositionState)state startInfo:(AMapNaviCameraInfo * _Nullable)startInfo endInfo:(AMapNaviCameraInfo * _Nullable)endInfo;
		[Export("driveManager:updateIntervalCameraWithPositionState:startInfo:endInfo:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviIntervalCameraPositionState state, [NullAllowed] AMapNaviCameraInfo startInfo, [NullAllowed] AMapNaviCameraInfo endInfo);
		void DriveManagerUpdateIntervalCameraWithPositionStateStartInfoEndInfo(AMapNaviDriveManager driveManager, AMapNaviIntervalCameraPositionState state, [NullAllowed] AMapNaviCameraInfo startInfo, [NullAllowed] AMapNaviCameraInfo endInfo);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateTurnIconImage:(UIImage * _Nullable)turnIconImage turnIconType:(AMapNaviIconType)turnIconType;
		[Export("driveManager:updateTurnIconImage:turnIconType:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] UIImage turnIconImage, AMapNaviIconType turnIconType);
		void DriveManagerUpdateTurnIconImageTurnIconType(AMapNaviDriveManager driveManager, [NullAllowed] UIImage turnIconImage, AMapNaviIconType turnIconType);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateNextTurnIconImage:(UIImage * _Nullable)turnIconImage nextTurnIconType:(AMapNaviIconType)turnIconType;
		[Export("driveManager:updateNextTurnIconImage:nextTurnIconType:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] UIImage turnIconImage, AMapNaviIconType turnIconType);
		void DriveManagerUpdateNextTurnIconImageNextTurnIconType(AMapNaviDriveManager driveManager, [NullAllowed] UIImage turnIconImage, AMapNaviIconType turnIconType);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateBackupRoute:(NSArray<AMapNaviRoute *> * _Nullable)backupRoutes;
		[Export("driveManager:updateBackupRoute:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviRoute[] backupRoutes);
		void DriveManagerUpdateBackupRoute(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviRoute[] backupRoutes);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateTrafficFacilities:(NSArray<AMapNaviTrafficFacilityInfo *> * _Nullable)trafficFacilities;
		[Export("driveManager:updateTrafficFacilities:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviTrafficFacilityInfo[] trafficFacilities);
		void DriveManagerUpdateTrafficFacilities(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviTrafficFacilityInfo[] trafficFacilities);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateCruiseElecCameraInfos:(NSArray<AMapNaviTrafficFacilityInfo *> * _Nonnull)cameraInfos;
		[Export("driveManager:updateCruiseElecCameraInfos:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviTrafficFacilityInfo[] cameraInfos);
		void DriveManagerUpdateCruiseElecCameraInfos(AMapNaviDriveManager driveManager, AMapNaviTrafficFacilityInfo[] cameraInfos);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateCruiseInfo:(AMapNaviCruiseInfo * _Nullable)cruiseInfo;
		[Export("driveManager:updateCruiseInfo:")]
		//void DriveManager(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviCruiseInfo cruiseInfo);
		void DriveManagerUpdateCruiseInfo(AMapNaviDriveManager driveManager, [NullAllowed] AMapNaviCruiseInfo cruiseInfo);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateCruiseCongestionInfo:(AMapNaviCruiseCongestionInfo * _Nonnull)congestionInfo;
		[Export("driveManager:updateCruiseCongestionInfo:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviCruiseCongestionInfo congestionInfo);
		void DriveManagerUpdateCruiseCongestionInfo(AMapNaviDriveManager driveManager, AMapNaviCruiseCongestionInfo congestionInfo);
	}

	// @interface AMapNaviDriveManager : AMapNaviBaseManager
	[BaseType(typeof(AMapNaviBaseManager))]
	[DisableDefaultCtor]
	interface AMapNaviDriveManager
	{
		// +(AMapNaviDriveManager * _Nonnull)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		AMapNaviDriveManager SharedInstance { get; }

		// +(BOOL)destroyInstance;
		[Static]
		[Export("destroyInstance")]
		bool DestroyInstance { get; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapNaviDriveManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapNaviDriveManagerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)addEventListener:(id<AMapNaviDriveManagerDelegate> _Nonnull)aListener;
		[Export("addEventListener:")]
		void AddEventListener(AMapNaviDriveManagerDelegate aListener);

		// -(void)removeEventListener:(id<AMapNaviDriveManagerDelegate> _Nonnull)aListener;
		[Export("removeEventListener:")]
		void RemoveEventListener(AMapNaviDriveManagerDelegate aListener);

		// -(void)addDataRepresentative:(id<AMapNaviDriveDataRepresentable> _Nonnull)aRepresentative;
		[Export("addDataRepresentative:")]
		void AddDataRepresentative(IAMapNaviDriveDataRepresentable aRepresentative);

		// -(void)removeDataRepresentative:(id<AMapNaviDriveDataRepresentable> _Nonnull)aRepresentative;
		[Export("removeDataRepresentative:")]
		void RemoveDataRepresentative(IAMapNaviDriveDataRepresentable aRepresentative);

		// @property (readonly, nonatomic) NSInteger naviRouteID;
		[Export("naviRouteID")]
		nint NaviRouteID { get; }

		// @property (readonly, nonatomic) AMapNaviRoute * _Nullable naviRoute;
		[NullAllowed, Export("naviRoute")]
		AMapNaviRoute NaviRoute { get; }

		// @property (readonly, nonatomic) NSArray<NSNumber *> * _Nullable naviRouteIDs;
		[NullAllowed, Export("naviRouteIDs")]
		NSNumber[] NaviRouteIDs { get; }

		// @property (readonly, nonatomic) NSDictionary<NSNumber *,AMapNaviRoute *> * _Nullable naviRoutes;
		[NullAllowed, Export("naviRoutes")]
		NSDictionary<NSNumber, AMapNaviRoute> NaviRoutes { get; }

		// -(BOOL)selectNaviRouteWithRouteID:(NSInteger)routeID;
		[Export("selectNaviRouteWithRouteID:")]
		bool SelectNaviRouteWithRouteID(nint routeID);

		// -(void)switchParallelRoad:(AMapNaviParallelRoadInfo * _Nonnull)parallelRoadInfo;
		[Export("switchParallelRoad:")]
		void SwitchParallelRoad(AMapNaviParallelRoadInfo parallelRoadInfo);

		// -(void)setMultipleRouteNaviMode:(BOOL)multipleRouteNaviMode;
		[Export("setMultipleRouteNaviMode:")]
		void SetMultipleRouteNaviMode(bool multipleRouteNaviMode);

		// @property (assign, nonatomic) BOOL updateCameraInfo;
		[Export("updateCameraInfo")]
		bool UpdateCameraInfo { get; set; }

		// @property (assign, nonatomic) BOOL updateTrafficInfo;
		[Export("updateTrafficInfo")]
		bool UpdateTrafficInfo { get; set; }

		// @property (assign, nonatomic) BOOL isRecalculateRouteForYaw __attribute__((deprecated("已废弃，默认进行重算，since 5.0.0")));
		[Export("isRecalculateRouteForYaw")]
		bool IsRecalculateRouteForYaw { get; set; }

		// @property (assign, nonatomic) BOOL isRecalculateRouteForTrafficJam __attribute__((deprecated("已废弃，默认进行重算，since 5.0.0")));
		[Export("isRecalculateRouteForTrafficJam")]
		bool IsRecalculateRouteForTrafficJam { get; set; }

		// @property (assign, nonatomic) AMapNaviDetectedMode detectedMode;
		[Export("detectedMode", ArgumentSemantic.Assign)]
		AMapNaviDetectedMode DetectedMode { get; set; }

		// @property (readonly, assign, nonatomic) AMapNaviGPSSignalStrength gpsSignalStrength;
		[Export("gpsSignalStrength", ArgumentSemantic.Assign)]
		AMapNaviGPSSignalStrength GpsSignalStrength { get; }

		// @property (assign, nonatomic) NSUInteger gpsWeakDetecedInterval;
		[Export("gpsWeakDetecedInterval")]
		nuint GpsWeakDetecedInterval { get; set; }

		// -(BOOL)calculateDriveRouteWithEndPoints:(NSArray<AMapNaviPoint *> * _Nonnull)endPoints wayPoints:(NSArray<AMapNaviPoint *> * _Nullable)wayPoints drivingStrategy:(AMapNaviDrivingStrategy)strategy;
		[Export("calculateDriveRouteWithEndPoints:wayPoints:drivingStrategy:")]
		bool CalculateDriveRouteWithEndPoints(AMapNaviPoint[] endPoints, [NullAllowed] AMapNaviPoint[] wayPoints, AMapNaviDrivingStrategy strategy);

		// -(BOOL)calculateDriveRouteWithStartPoints:(NSArray<AMapNaviPoint *> * _Nonnull)startPoints endPoints:(NSArray<AMapNaviPoint *> * _Nonnull)endPoints wayPoints:(NSArray<AMapNaviPoint *> * _Nullable)wayPoints drivingStrategy:(AMapNaviDrivingStrategy)strategy;
		[Export("calculateDriveRouteWithStartPoints:endPoints:wayPoints:drivingStrategy:")]
		bool CalculateDriveRouteWithStartPoints(AMapNaviPoint[] startPoints, AMapNaviPoint[] endPoints, [NullAllowed] AMapNaviPoint[] wayPoints, AMapNaviDrivingStrategy strategy);

		// -(BOOL)calculateDriveRouteWithStartPointPOIId:(NSString * _Nullable)startPOIId endPointPOIId:(NSString * _Nonnull)endPOIId wayPointsPOIId:(NSArray<NSString *> * _Nullable)wayPOIIds drivingStrategy:(AMapNaviDrivingStrategy)strategy;
		[Export("calculateDriveRouteWithStartPointPOIId:endPointPOIId:wayPointsPOIId:drivingStrategy:")]
		bool CalculateDriveRouteWithStartPointPOIId([NullAllowed] string startPOIId, string endPOIId, [NullAllowed] string[] wayPOIIds, AMapNaviDrivingStrategy strategy);

		// -(BOOL)calculateDriveRouteWithStartPOIInfo:(AMapNaviPOIInfo * _Nullable)startPOIInfo endPOIInfo:(AMapNaviPOIInfo * _Nonnull)endPOIInfo wayPOIInfos:(NSArray<AMapNaviPOIInfo *> * _Nullable)wayPOIInfos drivingStrategy:(AMapNaviDrivingStrategy)strategy;
		[Export("calculateDriveRouteWithStartPOIInfo:endPOIInfo:wayPOIInfos:drivingStrategy:")]
		bool CalculateDriveRouteWithStartPOIInfo([NullAllowed] AMapNaviPOIInfo startPOIInfo, AMapNaviPOIInfo endPOIInfo, [NullAllowed] AMapNaviPOIInfo[] wayPOIInfos, AMapNaviDrivingStrategy strategy);

		// -(BOOL)recalculateDriveRouteWithDrivingStrategy:(AMapNaviDrivingStrategy)strategy;
		[Export("recalculateDriveRouteWithDrivingStrategy:")]
		bool RecalculateDriveRouteWithDrivingStrategy(AMapNaviDrivingStrategy strategy);

		// -(void)setVehicleProvince:(NSString * _Nonnull)province number:(NSString * _Nonnull)number __attribute__((deprecated("已废弃，请使用 setVehicleInfo: 替代，since 6.0.0")));
		[Export("setVehicleProvince:number:")]
		void SetVehicleProvince(string province, string number);

		// -(BOOL)setVehicleInfo:(AMapNaviVehicleInfo * _Nullable)vehicleInfo;
		[Export("setVehicleInfo:")]
		bool SetVehicleInfo([NullAllowed] AMapNaviVehicleInfo vehicleInfo);

		// -(BOOL)setBroadcastMode:(AMapNaviBroadcastMode)mode;
		[Export("setBroadcastMode:")]
		bool SetBroadcastMode(AMapNaviBroadcastMode mode);

		// -(BOOL)setOnlineCarHailingType:(AMapNaviOnlineCarHailingType)type;
		[Export("setOnlineCarHailingType:")]
		bool SetOnlineCarHailingType(AMapNaviOnlineCarHailingType type);

		// -(void)refreshTrafficStatusesManual __attribute__((deprecated("已废弃，since 5.0.0")));
		[Export("refreshTrafficStatusesManual")]
		void RefreshTrafficStatusesManual();

		// -(void)setTimeForOneWord:(int)time __attribute__((deprecated("已废弃，使用 driveManagerIsNaviSoundPlaying: 替代，since 5.0.0")));
		[Export("setTimeForOneWord:")]
		void SetTimeForOneWord(int time);

		// -(NSArray<AMapNaviTrafficStatus *> * _Nullable)getTrafficStatusesWithStartPosition:(int)startPosition distance:(int)distance;
		[Export("getTrafficStatusesWithStartPosition:distance:")]
		[return: NullAllowed]
		AMapNaviTrafficStatus[] GetTrafficStatusesWithStartPosition(int startPosition, int distance);

		// -(NSArray<AMapNaviTrafficStatus *> * _Nullable)getTrafficStatuses;
		[NullAllowed, Export("getTrafficStatuses")]
		AMapNaviTrafficStatus[] TrafficStatuses { get; }

		// -(void)setXcodeSimulateLocationEnable:(BOOL)enableNavi;
		[Export("setXcodeSimulateLocationEnable:")]
		void SetXcodeSimulateLocationEnable(bool enableNavi);

		// -(AMapNaviStatisticsInfo * _Nullable)getNaviStatisticsInfo __attribute__((deprecated("已废弃，since 5.0.0")));
		[NullAllowed, Export("getNaviStatisticsInfo")]
		AMapNaviStatisticsInfo NaviStatisticsInfo { get; }
	}

	// @interface Escort (AMapNaviDriveManager)
	[Category]
	[BaseType(typeof(AMapNaviDriveManager))]
	interface AMapNaviDriveManager_Escort
	{
		// -(BOOL)setEscortMissonID:(NSNumber * _Nonnull)missonID;
		[Export("setEscortMissonID:")]
		bool SetEscortMissonID(NSNumber missonID);
	}

	// @interface Private (AMapNaviDriveManager)
	[Category]
	[BaseType(typeof(AMapNaviDriveManager))]
	interface AMapNaviDriveManager_Private
	{
		// -(BOOL)pushDriveRouteWithData:(NSData * _Nonnull)routeData startPOIInfo:(AMapNaviPOIInfo * _Nonnull)startPOIInfo endPOIInfo:(AMapNaviPOIInfo * _Nonnull)endPOIInfo wayPOIInfos:(NSArray<AMapNaviPOIInfo *> * _Nullable)wayPOIInfos drivingStrategy:(AMapNaviDrivingStrategy)strategy;
		[Export("pushDriveRouteWithData:startPOIInfo:endPOIInfo:wayPOIInfos:drivingStrategy:")]
		bool PushDriveRouteWithData(NSData routeData, AMapNaviPOIInfo startPOIInfo, AMapNaviPOIInfo endPOIInfo, [NullAllowed] AMapNaviPOIInfo[] wayPOIInfos, AMapNaviDrivingStrategy strategy);

		// -(NSString * _Nonnull)routeSDKVersion;
		//[Export("routeSDKVersion")]
		//string RouteSDKVersion { get; }
		[Export("routeSDKVersion")]
		string RouteSDKVersion();

		// -(NSString * _Nonnull)routeServerVersion;
		//[Export("routeServerVersion")]
		//string RouteServerVersion { get; }
		[Export("routeServerVersion")]
		string RouteServerVersion();

		// -(void)setRouteId:(NSString * _Nullable)routeId;
		[Export("setRouteId:")]
		void SetRouteId([NullAllowed] string routeId);
	}

	// @protocol AMapNaviDriveManagerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapNaviDriveManagerDelegate
	{
		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager error:(NSError * _Nonnull)error;
		[Export("driveManager:error:")]
		//void DriveManager(AMapNaviDriveManager driveManager, NSError error);
		void DriveManagerError(AMapNaviDriveManager driveManager, NSError error);

		// @optional -(void)driveManagerOnCalculateRouteSuccess:(AMapNaviDriveManager * _Nonnull)driveManager;
		[Export("driveManagerOnCalculateRouteSuccess:")]
		void DriveManagerOnCalculateRouteSuccess(AMapNaviDriveManager driveManager);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager onCalculateRouteSuccessWithType:(AMapNaviRoutePlanType)type;
		[Export("driveManager:onCalculateRouteSuccessWithType:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviRoutePlanType type);
		void DriveManagerOnCalculateRouteSuccessWithType(AMapNaviDriveManager driveManager, AMapNaviRoutePlanType type);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager onCalculateRouteFailure:(NSError * _Nonnull)error;
		[Export("driveManager:onCalculateRouteFailure:")]
		//void DriveManager(AMapNaviDriveManager driveManager, NSError error);
		void DriveManagerOnCalculateRouteFailure(AMapNaviDriveManager driveManager, NSError error);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager onCalculateRouteFailure:(NSError * _Nonnull)error routePlanType:(AMapNaviRoutePlanType)type;
		[Export("driveManager:onCalculateRouteFailure:routePlanType:")]
		//void DriveManager(AMapNaviDriveManager driveManager, NSError error, AMapNaviRoutePlanType type);
		void DriveManagerOnCalculateRouteFailureRoutePlanType(AMapNaviDriveManager driveManager, NSError error, AMapNaviRoutePlanType type);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager didStartNavi:(AMapNaviMode)naviMode;
		[Export("driveManager:didStartNavi:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviMode naviMode);
		void DriveManagerDidStartNavi(AMapNaviDriveManager driveManager, AMapNaviMode naviMode);

		// @optional -(void)driveManagerNeedRecalculateRouteForYaw:(AMapNaviDriveManager * _Nonnull)driveManager;
		[Export("driveManagerNeedRecalculateRouteForYaw:")]
		void DriveManagerNeedRecalculateRouteForYaw(AMapNaviDriveManager driveManager);

		// @optional -(void)driveManagerNeedRecalculateRouteForTrafficJam:(AMapNaviDriveManager * _Nonnull)driveManager;
		[Export("driveManagerNeedRecalculateRouteForTrafficJam:")]
		void DriveManagerNeedRecalculateRouteForTrafficJam(AMapNaviDriveManager driveManager);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager onArrivedWayPoint:(int)wayPointIndex;
		[Export("driveManager:onArrivedWayPoint:")]
		//void DriveManager(AMapNaviDriveManager driveManager, int wayPointIndex);
		void DriveManagerOnArrivedWayPoint(AMapNaviDriveManager driveManager, int wayPointIndex);

		// @optional -(BOOL)driveManagerIsNaviSoundPlaying:(AMapNaviDriveManager * _Nonnull)driveManager;
		[Export("driveManagerIsNaviSoundPlaying:")]
		bool DriveManagerIsNaviSoundPlaying(AMapNaviDriveManager driveManager);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager playNaviSoundString:(NSString * _Nonnull)soundString soundStringType:(AMapNaviSoundType)soundStringType;
		[Export("driveManager:playNaviSoundString:soundStringType:")]
		//void DriveManager(AMapNaviDriveManager driveManager, string soundString, AMapNaviSoundType soundStringType);
		void DriveManagerPlayNaviSoundStringSoundStringType(AMapNaviDriveManager driveManager, string soundString, AMapNaviSoundType soundStringType);

		// @optional -(void)driveManagerDidEndEmulatorNavi:(AMapNaviDriveManager * _Nonnull)driveManager;
		[Export("driveManagerDidEndEmulatorNavi:")]
		void DriveManagerDidEndEmulatorNavi(AMapNaviDriveManager driveManager);

		// @optional -(void)driveManagerOnArrivedDestination:(AMapNaviDriveManager * _Nonnull)driveManager;
		[Export("driveManagerOnArrivedDestination:")]
		void DriveManagerOnArrivedDestination(AMapNaviDriveManager driveManager);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager onNaviPlayRing:(AMapNaviRingType)ringType;
		[Export("driveManager:onNaviPlayRing:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviRingType ringType);
		void DriveManagerOnNaviPlayRing(AMapNaviDriveManager driveManager, AMapNaviRingType ringType);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager updateGPSSignalStrength:(AMapNaviGPSSignalStrength)gpsSignalStrength;
		[Export("driveManager:updateGPSSignalStrength:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviGPSSignalStrength gpsSignalStrength);
		void DriveManagerUpdateGPSSignalStrength(AMapNaviDriveManager driveManager, AMapNaviGPSSignalStrength gpsSignalStrength);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager postRouteNotification:(AMapNaviRouteNotifyData * _Nonnull)notifyData;
		[Export("driveManager:postRouteNotification:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviRouteNotifyData notifyData);
		void DriveManagerPostRouteNotification(AMapNaviDriveManager driveManager, AMapNaviRouteNotifyData notifyData);

		// @optional -(void)driveManager:(AMapNaviDriveManager * _Nonnull)driveManager onSuggestChangeMainNaviRoute:(AMapNaviSuggestChangeMainNaviRouteInfo * _Nonnull)suggestChangeMainNaviRouteInfo;
		[Export("driveManager:onSuggestChangeMainNaviRoute:")]
		//void DriveManager(AMapNaviDriveManager driveManager, AMapNaviSuggestChangeMainNaviRouteInfo suggestChangeMainNaviRouteInfo);
		void DriveManagerOnSuggestChangeMainNaviRoute(AMapNaviDriveManager driveManager, AMapNaviSuggestChangeMainNaviRouteInfo suggestChangeMainNaviRouteInfo);
	}

	// @protocol AMapNaviWalkDataRepresentable <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	interface IAMapNaviWalkDataRepresentable { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface AMapNaviWalkDataRepresentable
	{
		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager updateNaviMode:(AMapNaviMode)naviMode;
		[Export("walkManager:updateNaviMode:")]
		void UpdateNaviMode(AMapNaviWalkManager walkManager, AMapNaviMode naviMode);

		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager updateNaviRouteID:(NSInteger)naviRouteID;
		[Export("walkManager:updateNaviRouteID:")]
		void UpdateNaviRouteID(AMapNaviWalkManager walkManager, nint naviRouteID);

		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager updateNaviRoute:(AMapNaviRoute * _Nullable)naviRoute;
		[Export("walkManager:updateNaviRoute:")]
		void UpdateNaviRoute(AMapNaviWalkManager walkManager, [NullAllowed] AMapNaviRoute naviRoute);

		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager updateNaviInfo:(AMapNaviInfo * _Nullable)naviInfo;
		[Export("walkManager:updateNaviInfo:")]
		void UpdateNaviInfo(AMapNaviWalkManager walkManager, [NullAllowed] AMapNaviInfo naviInfo);

		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager updateNaviLocation:(AMapNaviLocation * _Nullable)naviLocation;
		[Export("walkManager:updateNaviLocation:")]
		void UpdateNaviLocation(AMapNaviWalkManager walkManager, [NullAllowed] AMapNaviLocation naviLocation);
	}

	// @interface AMapNaviWalkManager : AMapNaviBaseManager
	[BaseType(typeof(AMapNaviBaseManager))]
	interface AMapNaviWalkManager
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapNaviWalkManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapNaviWalkManagerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)addDataRepresentative:(id<AMapNaviWalkDataRepresentable> _Nonnull)aRepresentative;
		[Export("addDataRepresentative:")]
		void AddDataRepresentative(IAMapNaviWalkDataRepresentable aRepresentative);

		// -(void)removeDataRepresentative:(id<AMapNaviWalkDataRepresentable> _Nonnull)aRepresentative;
		[Export("removeDataRepresentative:")]
		void RemoveDataRepresentative(IAMapNaviWalkDataRepresentable aRepresentative);

		// @property (readonly, nonatomic) NSInteger naviRouteID;
		[Export("naviRouteID")]
		nint NaviRouteID { get; }

		// @property (readonly, nonatomic) AMapNaviRoute * _Nullable naviRoute;
		[NullAllowed, Export("naviRoute")]
		AMapNaviRoute NaviRoute { get; }

		// @property (assign, nonatomic) BOOL isRecalculateRouteForYaw;
		[Export("isRecalculateRouteForYaw")]
		bool IsRecalculateRouteForYaw { get; set; }

		// -(BOOL)calculateWalkRouteWithEndPoints:(NSArray<AMapNaviPoint *> * _Nonnull)endPoints;
		[Export("calculateWalkRouteWithEndPoints:")]
		bool CalculateWalkRouteWithEndPoints(AMapNaviPoint[] endPoints);

		// -(BOOL)calculateWalkRouteWithStartPoints:(NSArray<AMapNaviPoint *> * _Nonnull)startPoints endPoints:(NSArray<AMapNaviPoint *> * _Nonnull)endPoints;
		[Export("calculateWalkRouteWithStartPoints:endPoints:")]
		bool CalculateWalkRouteWithStartPoints(AMapNaviPoint[] startPoints, AMapNaviPoint[] endPoints);

		// -(BOOL)recalculateWalkRoute;
		[Export("recalculateWalkRoute")]
		bool RecalculateWalkRoute { get; }

		// -(void)setTimeForOneWord:(int)time;
		[Export("setTimeForOneWord:")]
		void SetTimeForOneWord(int time);

		// -(AMapNaviStatisticsInfo * _Nullable)getNaviStatisticsInfo;
		[NullAllowed, Export("getNaviStatisticsInfo")]
		AMapNaviStatisticsInfo NaviStatisticsInfo { get; }
	}

	// @protocol AMapNaviWalkManagerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapNaviWalkManagerDelegate
	{
		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager error:(NSError * _Nonnull)error;
		[Export("walkManager:error:")]
		//void WalkManager(AMapNaviWalkManager walkManager, NSError error);
		void WalkManagerError(AMapNaviWalkManager walkManager, NSError error);

		// @optional -(void)walkManagerOnCalculateRouteSuccess:(AMapNaviWalkManager * _Nonnull)walkManager;
		[Export("walkManagerOnCalculateRouteSuccess:")]
		void WalkManagerOnCalculateRouteSuccess(AMapNaviWalkManager walkManager);

		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager onCalculateRouteFailure:(NSError * _Nonnull)error;
		[Export("walkManager:onCalculateRouteFailure:")]
		//void WalkManager(AMapNaviWalkManager walkManager, NSError error);
		void WalkManagerOnCalculateRouteFailure(AMapNaviWalkManager walkManager, NSError error);

		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager didStartNavi:(AMapNaviMode)naviMode;
		[Export("walkManager:didStartNavi:")]
		//void WalkManager(AMapNaviWalkManager walkManager, AMapNaviMode naviMode);
		void WalkManagerDidStartNavi(AMapNaviWalkManager walkManager, AMapNaviMode naviMode);

		// @optional -(void)walkManagerNeedRecalculateRouteForYaw:(AMapNaviWalkManager * _Nonnull)walkManager;
		[Export("walkManagerNeedRecalculateRouteForYaw:")]
		void WalkManagerNeedRecalculateRouteForYaw(AMapNaviWalkManager walkManager);

		// @optional -(void)walkManager:(AMapNaviWalkManager * _Nonnull)walkManager playNaviSoundString:(NSString * _Nonnull)soundString soundStringType:(AMapNaviSoundType)soundStringType;
		[Export("walkManager:playNaviSoundString:soundStringType:")]
		//void WalkManager(AMapNaviWalkManager walkManager, string soundString, AMapNaviSoundType soundStringType);
		void WalkManagerPlayNaviSoundStringSoundStringType(AMapNaviWalkManager walkManager, string soundString, AMapNaviSoundType soundStringType);

		// @optional -(void)walkManagerDidEndEmulatorNavi:(AMapNaviWalkManager * _Nonnull)walkManager;
		[Export("walkManagerDidEndEmulatorNavi:")]
		void WalkManagerDidEndEmulatorNavi(AMapNaviWalkManager walkManager);

		// @optional -(void)walkManagerOnArrivedDestination:(AMapNaviWalkManager * _Nonnull)walkManager;
		[Export("walkManagerOnArrivedDestination:")]
		void WalkManagerOnArrivedDestination(AMapNaviWalkManager walkManager);
	}

	// @protocol AMapNaviRideDataRepresentable <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	interface IAMapNaviRideDataRepresentable { }
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface AMapNaviRideDataRepresentable
	{
		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager updateNaviMode:(AMapNaviMode)naviMode;
		[Export("rideManager:updateNaviMode:")]
		void UpdateNaviMode(AMapNaviRideManager rideManager, AMapNaviMode naviMode);

		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager updateNaviRouteID:(NSInteger)naviRouteID;
		[Export("rideManager:updateNaviRouteID:")]
		void UpdateNaviRouteID(AMapNaviRideManager rideManager, nint naviRouteID);

		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager updateNaviRoute:(AMapNaviRoute * _Nullable)naviRoute;
		[Export("rideManager:updateNaviRoute:")]
		void UpdateNaviRoute(AMapNaviRideManager rideManager, [NullAllowed] AMapNaviRoute naviRoute);

		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager updateNaviInfo:(AMapNaviInfo * _Nullable)naviInfo;
		[Export("rideManager:updateNaviInfo:")]
		void UpdateNaviInfo(AMapNaviRideManager rideManager, [NullAllowed] AMapNaviInfo naviInfo);

		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager updateNaviLocation:(AMapNaviLocation * _Nullable)naviLocation;
		[Export("rideManager:updateNaviLocation:")]
		void UpdateNaviLocation(AMapNaviRideManager rideManager, [NullAllowed] AMapNaviLocation naviLocation);
	}

	// @interface AMapNaviRideManager : AMapNaviBaseManager
	[BaseType(typeof(AMapNaviBaseManager))]
	interface AMapNaviRideManager
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapNaviRideManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapNaviRideManagerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)addDataRepresentative:(id<AMapNaviRideDataRepresentable> _Nonnull)aRepresentative;
		[Export("addDataRepresentative:")]
		void AddDataRepresentative(IAMapNaviRideDataRepresentable aRepresentative);

		// -(void)removeDataRepresentative:(id<AMapNaviRideDataRepresentable> _Nonnull)aRepresentative;
		[Export("removeDataRepresentative:")]
		void RemoveDataRepresentative(IAMapNaviRideDataRepresentable aRepresentative);

		// @property (readonly, nonatomic) NSInteger naviRouteID;
		[Export("naviRouteID")]
		nint NaviRouteID { get; }

		// @property (readonly, nonatomic) AMapNaviRoute * _Nullable naviRoute;
		[NullAllowed, Export("naviRoute")]
		AMapNaviRoute NaviRoute { get; }

		// @property (assign, nonatomic) BOOL isRecalculateRouteForYaw;
		[Export("isRecalculateRouteForYaw")]
		bool IsRecalculateRouteForYaw { get; set; }

		// -(BOOL)calculateRideRouteWithEndPoint:(AMapNaviPoint * _Nonnull)endPoint;
		[Export("calculateRideRouteWithEndPoint:")]
		bool CalculateRideRouteWithEndPoint(AMapNaviPoint endPoint);

		// -(BOOL)calculateRideRouteWithStartPoint:(AMapNaviPoint * _Nonnull)startPoint endPoint:(AMapNaviPoint * _Nonnull)endPoint;
		[Export("calculateRideRouteWithStartPoint:endPoint:")]
		bool CalculateRideRouteWithStartPoint(AMapNaviPoint startPoint, AMapNaviPoint endPoint);

		// -(BOOL)recalculateRideRoute;
		[Export("recalculateRideRoute")]
		bool RecalculateRideRoute { get; }

		// -(void)setTimeForOneWord:(int)time;
		[Export("setTimeForOneWord:")]
		void SetTimeForOneWord(int time);

		// -(AMapNaviStatisticsInfo * _Nullable)getNaviStatisticsInfo;
		[NullAllowed, Export("getNaviStatisticsInfo")]
		AMapNaviStatisticsInfo NaviStatisticsInfo { get; }
	}

	// @protocol AMapNaviRideManagerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapNaviRideManagerDelegate
	{
		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager error:(NSError * _Nonnull)error;
		[Export("rideManager:error:")]
		//void RideManager(AMapNaviRideManager rideManager, NSError error);
		void RideManageError(AMapNaviRideManager rideManager, NSError error);

		// @optional -(void)rideManagerOnCalculateRouteSuccess:(AMapNaviRideManager * _Nonnull)rideManager;
		[Export("rideManagerOnCalculateRouteSuccess:")]
		void RideManagerOnCalculateRouteSuccess(AMapNaviRideManager rideManager);

		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager onCalculateRouteFailure:(NSError * _Nonnull)error;
		[Export("rideManager:onCalculateRouteFailure:")]
		//void RideManager(AMapNaviRideManager rideManager, NSError error);
		void RideManagerOnCalculateRouteFailure(AMapNaviRideManager rideManager, NSError error);

		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager didStartNavi:(AMapNaviMode)naviMode;
		[Export("rideManager:didStartNavi:")]
		//void RideManager(AMapNaviRideManager rideManager, AMapNaviMode naviMode);
		void RideManagerDidStartNavi(AMapNaviRideManager rideManager, AMapNaviMode naviMode);

		// @optional -(void)rideManagerNeedRecalculateRouteForYaw:(AMapNaviRideManager * _Nonnull)rideManager;
		[Export("rideManagerNeedRecalculateRouteForYaw:")]
		void RideManagerNeedRecalculateRouteForYaw(AMapNaviRideManager rideManager);

		// @optional -(void)rideManager:(AMapNaviRideManager * _Nonnull)rideManager playNaviSoundString:(NSString * _Nonnull)soundString soundStringType:(AMapNaviSoundType)soundStringType;
		[Export("rideManager:playNaviSoundString:soundStringType:")]
		//void RideManager(AMapNaviRideManager rideManager, string soundString, AMapNaviSoundType soundStringType);
		void RideManagerPlayNaviSoundStringSoundStringType(AMapNaviRideManager rideManager, string soundString, AMapNaviSoundType soundStringType);

		// @optional -(void)rideManagerDidEndEmulatorNavi:(AMapNaviRideManager * _Nonnull)rideManager;
		[Export("rideManagerDidEndEmulatorNavi:")]
		void RideManagerDidEndEmulatorNavi(AMapNaviRideManager rideManager);

		// @optional -(void)rideManagerOnArrivedDestination:(AMapNaviRideManager * _Nonnull)rideManager;
		[Export("rideManagerOnArrivedDestination:")]
		void RideManagerOnArrivedDestination(AMapNaviRideManager rideManager);
	}

	// @protocol AMapNaviCompositeOverlay <MAOverlay>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
    [BaseType(typeof(MAOverlay))]
	interface AMapNaviCompositeOverlay //: IMAOverlay
	{
		// @required @property (readonly, nonatomic, strong) MAOverlayRenderer * overlayRender;
		[Abstract]
		[Export("overlayRender", ArgumentSemantic.Strong)]
		MAOverlayRenderer OverlayRender { get; }

		// @optional @property (readonly, assign, nonatomic) MAOverlayLevel overlayLevel;
		[Export("overlayLevel", ArgumentSemantic.Assign)]
		MAOverlayLevel OverlayLevel { get; }
	}

	// @interface AMapNaviCompositeCustomAnnotation : NSObject <MAAnnotation>
	[BaseType(typeof(NSObject))]
	interface AMapNaviCompositeCustomAnnotation : MAAnnotation
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		//[Export("coordinate", ArgumentSemantic.Assign)]
		//CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) NSInteger zIndex;
		[Export("zIndex")]
		nint ZIndex { get; set; }

		// -(id)initWithCoordinate:(CLLocationCoordinate2D)coordinate view:(UIView *)view;
		[Export("initWithCoordinate:view:")]
		IntPtr Constructor(CLLocationCoordinate2D coordinate, UIView view);
	}

	// @interface AMapNaviDriveView : UIView <AMapNaviDriveDataRepresentable>
	[BaseType(typeof(UIView))]
	interface AMapNaviDriveView : AMapNaviDriveDataRepresentable
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapNaviDriveViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapNaviDriveViewDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[Wrap("WeakMapViewDelegate")]
		[NullAllowed]
		MAMapViewDelegate MapViewDelegate { get; set; }

		// @property (nonatomic, weak) id<MAMapViewDelegate> _Nullable mapViewDelegate;
		[NullAllowed, Export("mapViewDelegate", ArgumentSemantic.Weak)]
		NSObject WeakMapViewDelegate { get; set; }

		// @property (assign, nonatomic) AMapNaviViewTrackingMode trackingMode;
		[Export("trackingMode", ArgumentSemantic.Assign)]
		AMapNaviViewTrackingMode TrackingMode { get; set; }

		// @property (assign, nonatomic) AMapNaviDriveViewShowMode showMode;
		[Export("showMode", ArgumentSemantic.Assign)]
		AMapNaviDriveViewShowMode ShowMode { get; set; }

		// @property (assign, nonatomic) CGPoint logoCenter;
		[Export("logoCenter", ArgumentSemantic.Assign)]
		CGPoint LogoCenter { get; set; }

		// @property (readonly, assign, nonatomic) CGSize logoSize;
		[Export("logoSize", ArgumentSemantic.Assign)]
		CGSize LogoSize { get; }

		// @property (assign, nonatomic) BOOL showScale;
		[Export("showScale")]
		bool ShowScale { get; set; }

		// @property (assign, nonatomic) CGPoint scaleOrigin;
		[Export("scaleOrigin", ArgumentSemantic.Assign)]
		CGPoint ScaleOrigin { get; set; }

		// @property (assign, nonatomic) BOOL showCompass;
		[Export("showCompass")]
		bool ShowCompass { get; set; }

		// @property (assign, nonatomic) CGPoint compassOrigin;
		[Export("compassOrigin", ArgumentSemantic.Assign)]
		CGPoint CompassOrigin { get; set; }

		// @property (readonly, assign, nonatomic) CGSize compassSize;
		[Export("compassSize", ArgumentSemantic.Assign)]
		CGSize CompassSize { get; }

		// @property (assign, nonatomic) BOOL mapShowTraffic;
		[Export("mapShowTraffic")]
		bool MapShowTraffic { get; set; }

		// @property (assign, nonatomic) CGFloat mapZoomLevel;
		[Export("mapZoomLevel")]
		nfloat MapZoomLevel { get; set; }

		// @property (assign, nonatomic) BOOL autoZoomMapLevel;
		[Export("autoZoomMapLevel")]
		bool AutoZoomMapLevel { get; set; }

		// @property (assign, nonatomic) CGFloat cameraDegree;
		[Export("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (assign, nonatomic) CGPoint screenAnchor;
		[Export("screenAnchor", ArgumentSemantic.Assign)]
		CGPoint ScreenAnchor { get; set; }

		// @property (assign, nonatomic) NSUInteger maxRenderFrame;
		[Export("maxRenderFrame")]
		nuint MaxRenderFrame { get; set; }

		// @property (assign, nonatomic) AMapNaviViewMapModeType mapViewModeType;
		[Export("mapViewModeType", ArgumentSemantic.Assign)]
		AMapNaviViewMapModeType MapViewModeType { get; set; }

		// -(void)setCustomMapStyleOptions:(MAMapCustomStyleOptions * _Nonnull)styleOptions;
		[Export("setCustomMapStyleOptions:")]
		void SetCustomMapStyleOptions(MAMapCustomStyleOptions styleOptions);

		// @property (assign, nonatomic) BOOL autoSwitchDayNightType __attribute__((deprecated("已废弃, 请使用 mapViewModeType 替代 since 6.7.0")));
		[Export("autoSwitchDayNightType")]
		bool AutoSwitchDayNightType { get; set; }

		// @property (assign, nonatomic) BOOL showStandardNightType __attribute__((deprecated("已废弃, 请使用 mapViewModeType 替代 since 6.7.0")));
		[Export("showStandardNightType")]
		bool ShowStandardNightType { get; set; }

		// @property (assign, nonatomic) BOOL customMapStyleEnabled __attribute__((deprecated("已废弃, 请使用 mapViewModeType 替代 since 6.7.0")));
		[Export("customMapStyleEnabled")]
		bool CustomMapStyleEnabled { get; set; }

		// -(void)setCustomMapStyle:(NSData * _Nonnull)customJson __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: 替代 since 6.6.0")));
		[Export("setCustomMapStyle:")]
		void SetCustomMapStyle(NSData customJson);

		// -(void)setCustomMapStyleWithWebData:(NSData * _Nonnull)data __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: 替代 since 6.6.0")));
		[Export("setCustomMapStyleWithWebData:")]
		void SetCustomMapStyleWithWebData(NSData data);

		// @property (assign, nonatomic) BOOL showTrafficLayer;
		[Export("showTrafficLayer")]
		bool ShowTrafficLayer { get; set; }

		// @property (assign, nonatomic) BOOL showCamera;
		[Export("showCamera")]
		bool ShowCamera { get; set; }

		// @property (assign, nonatomic) BOOL showTurnArrow;
		[Export("showTurnArrow")]
		bool ShowTurnArrow { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull turnArrowColor;
		[Export("turnArrowColor", ArgumentSemantic.Strong)]
		UIColor TurnArrowColor { get; set; }

		// @property (assign, nonatomic) CGFloat turnArrowWidth;
		[Export("turnArrowWidth")]
		nfloat TurnArrowWidth { get; set; }

		// @property (assign, nonatomic) BOOL turnArrowIs3D;
		[Export("turnArrowIs3D")]
		bool TurnArrowIs3D { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull turnArrowSideColor;
		[Export("turnArrowSideColor", ArgumentSemantic.Strong)]
		UIColor TurnArrowSideColor { get; set; }

		// @property (assign, nonatomic) BOOL showVectorline;
		[Export("showVectorline")]
		bool ShowVectorline { get; set; }

		// @property (assign, nonatomic) BOOL showTrafficLights;
		[Export("showTrafficLights")]
		bool ShowTrafficLights { get; set; }

		// @property (assign, nonatomic) BOOL showCar;
		[Export("showCar")]
		bool ShowCar { get; set; }

		// @property (assign, nonatomic) BOOL showRoute;
		[Export("showRoute")]
		bool ShowRoute { get; set; }

		// @property (assign, nonatomic) BOOL showBackupRoute;
		[Export("showBackupRoute")]
		bool ShowBackupRoute { get; set; }

		// @property (assign, nonatomic) BOOL showGreyAfterPass;
		[Export("showGreyAfterPass")]
		bool ShowGreyAfterPass { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (nonatomic, strong) MACustomCalloutView * _Nullable customCalloutView;
		[NullAllowed, Export("customCalloutView", ArgumentSemantic.Strong)]
		MACustomCalloutView CustomCalloutView { get; set; }

		// @property (assign, nonatomic) CGFloat dashedLineWidth;
		[Export("dashedLineWidth")]
		nfloat DashedLineWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull dashedLineColor;
		[Export("dashedLineColor", ArgumentSemantic.Strong)]
		UIColor DashedLineColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull dashedLineGreyColor;
		[Export("dashedLineGreyColor", ArgumentSemantic.Strong)]
		UIColor DashedLineGreyColor { get; set; }

		// @property (copy, nonatomic) UIImage * _Nullable greyTexture;
		[NullAllowed, Export("greyTexture", ArgumentSemantic.Copy)]
		UIImage GreyTexture { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSNumber *,UIImage *> * _Nonnull statusTextures;
		[Export("statusTextures", ArgumentSemantic.Copy)]
		NSDictionary<NSNumber, UIImage> StatusTextures { get; set; }

		// @property (copy, nonatomic) UIImage * _Nullable normalTexture;
		[NullAllowed, Export("normalTexture", ArgumentSemantic.Copy)]
		UIImage NormalTexture { get; set; }

		// -(void)setCameraImage:(UIImage * _Nullable)cameraImage;
		[Export("setCameraImage:")]
		void SetCameraImage([NullAllowed] UIImage cameraImage);

		// -(void)setStartPointImage:(UIImage * _Nullable)startPointImage;
		[Export("setStartPointImage:")]
		void SetStartPointImage([NullAllowed] UIImage startPointImage);

		// -(void)setWayPointImage:(UIImage * _Nullable)wayPointImage;
		[Export("setWayPointImage:")]
		void SetWayPointImage([NullAllowed] UIImage wayPointImage);

		// -(void)setEndPointImage:(UIImage * _Nullable)endPointImage;
		[Export("setEndPointImage:")]
		void SetEndPointImage([NullAllowed] UIImage endPointImage);

		// -(void)setCarImage:(UIImage * _Nullable)carImage;
		[Export("setCarImage:")]
		void SetCarImage([NullAllowed] UIImage carImage);

		// -(void)setCarCompassImage:(UIImage * _Nullable)carCompassImage;
		[Export("setCarCompassImage:")]
		void SetCarCompassImage([NullAllowed] UIImage carCompassImage);

		// -(void)addCustomAnnotation:(AMapNaviCompositeCustomAnnotation * _Nonnull)annotation;
		[Export("addCustomAnnotation:")]
		void AddCustomAnnotation(AMapNaviCompositeCustomAnnotation annotation);

		// -(void)removeCustomAnnotation:(AMapNaviCompositeCustomAnnotation * _Nonnull)annotation;
		[Export("removeCustomAnnotation:")]
		void RemoveCustomAnnotation(AMapNaviCompositeCustomAnnotation annotation);

		// -(void)addCustomOverlay:(id<AMapNaviCompositeOverlay> _Nonnull)overlay;
		[Export("addCustomOverlay:")]
		void AddCustomOverlay(AMapNaviCompositeOverlay overlay);

		// -(void)removeCustomOverlay:(id<AMapNaviCompositeOverlay> _Nonnull)overlay;
		[Export("removeCustomOverlay:")]
		void RemoveCustomOverlay(AMapNaviCompositeOverlay overlay);

		// @property (assign, nonatomic) BOOL showUIElements;
		[Export("showUIElements")]
		bool ShowUIElements { get; set; }

		// @property (assign, nonatomic) BOOL showCrossImage;
		[Export("showCrossImage")]
		bool ShowCrossImage { get; set; }

		// @property (assign, nonatomic) BOOL showTrafficButton;
		[Export("showTrafficButton")]
		bool ShowTrafficButton { get; set; }

		// @property (assign, nonatomic) BOOL showTrafficBar;
		[Export("showTrafficBar")]
		bool ShowTrafficBar { get; set; }

		// @property (assign, nonatomic) BOOL showBrowseRouteButton;
		[Export("showBrowseRouteButton")]
		bool ShowBrowseRouteButton { get; set; }

		// @property (assign, nonatomic) BOOL showMoreButton;
		[Export("showMoreButton")]
		bool ShowMoreButton { get; set; }

		// @property (readonly, assign, nonatomic) BOOL isLandscape;
		[Export("isLandscape")]
		bool IsLandscape { get; }

		// @property (assign, nonatomic) BOOL autoSwitchShowModeToCarPositionLocked;
		[Export("autoSwitchShowModeToCarPositionLocked")]
		bool AutoSwitchShowModeToCarPositionLocked { get; set; }

		// -(void)updateRoutePolylineInTheVisualRangeWhenTheShowModeIsOverview;
		[Export("updateRoutePolylineInTheVisualRangeWhenTheShowModeIsOverview")]
		void UpdateRoutePolylineInTheVisualRangeWhenTheShowModeIsOverview();
	}

	// @protocol AMapNaviDriveViewDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapNaviDriveViewDelegate
	{
		// @optional -(void)driveViewCloseButtonClicked:(AMapNaviDriveView * _Nonnull)driveView;
		[Export("driveViewCloseButtonClicked:")]
		void DriveViewCloseButtonClicked(AMapNaviDriveView driveView);

		// @optional -(void)driveViewMoreButtonClicked:(AMapNaviDriveView * _Nonnull)driveView;
		[Export("driveViewMoreButtonClicked:")]
		void DriveViewMoreButtonClicked(AMapNaviDriveView driveView);

		// @optional -(void)driveViewTrunIndicatorViewTapped:(AMapNaviDriveView * _Nonnull)driveView;
		[Export("driveViewTrunIndicatorViewTapped:")]
		void DriveViewTrunIndicatorViewTapped(AMapNaviDriveView driveView);

		// @optional -(void)driveView:(AMapNaviDriveView * _Nonnull)driveView didChangeShowMode:(AMapNaviDriveViewShowMode)showMode;
		[Export("driveView:didChangeShowMode:")]
		//void DriveView(AMapNaviDriveView driveView, AMapNaviDriveViewShowMode showMode);
		void DriveViewDidChangeShowMode(AMapNaviDriveView driveView, AMapNaviDriveViewShowMode showMode);

		// @optional -(void)driveView:(AMapNaviDriveView * _Nonnull)driveView didChangeTrackingMode:(AMapNaviViewTrackingMode)trackMode;
		[Export("driveView:didChangeTrackingMode:")]
		//void DriveView(AMapNaviDriveView driveView, AMapNaviViewTrackingMode trackMode);
		void DriveViewDidChangeTrackingMode(AMapNaviDriveView driveView, AMapNaviViewTrackingMode trackMode);

		// @optional -(void)driveView:(AMapNaviDriveView * _Nonnull)driveView didChangeOrientation:(BOOL)isLandscape;
		[Export("driveView:didChangeOrientation:")]
		//void DriveView(AMapNaviDriveView driveView, bool isLandscape);
		void DriveViewDidChangeOrientation(AMapNaviDriveView driveView, bool isLandscape);

		// @optional -(void)driveView:(AMapNaviDriveView * _Nonnull)driveView didChangeDayNightType:(BOOL)showStandardNightType;
		[Export("driveView:didChangeDayNightType:")]
		//void DriveView(AMapNaviDriveView driveView, bool showStandardNightType);
		void DriveViewDidChangeDayNightType(AMapNaviDriveView driveView, bool showStandardNightType);

		// @optional -(UIEdgeInsets)driveViewEdgePadding:(AMapNaviDriveView * _Nonnull)driveView;
		[Export("driveViewEdgePadding:")]
		UIEdgeInsets DriveViewEdgePadding(AMapNaviDriveView driveView);

		// @optional -(id _Nonnull)driveView:(AMapNaviDriveView * _Nonnull)driveView needUpdatePolylineOptionForRoute:(AMapNaviRoute * _Nonnull)naviRoute __attribute__((deprecated("已废弃，请使用 lineWidth、statusTextures、greyTexture、dashedLineColor 等相关属性替代, since 6.2.0")));
		[Export("driveView:needUpdatePolylineOptionForRoute:")]
		//NSObject DriveView(AMapNaviDriveView driveView, AMapNaviRoute naviRoute);
		NSObject DriveViewNeedUpdatePolylineOptionForRoute(AMapNaviDriveView driveView, AMapNaviRoute naviRoute);
	}

	// @interface AMapNaviWalkView : UIView <AMapNaviWalkDataRepresentable>
	[BaseType(typeof(UIView))]
	interface AMapNaviWalkView : AMapNaviWalkDataRepresentable
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapNaviWalkViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapNaviWalkViewDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL isLandscape;
		[Export("isLandscape")]
		bool IsLandscape { get; set; }

		// @property (assign, nonatomic) AMapNaviViewTrackingMode trackingMode;
		[Export("trackingMode", ArgumentSemantic.Assign)]
		AMapNaviViewTrackingMode TrackingMode { get; set; }

		// @property (assign, nonatomic) AMapNaviWalkViewShowMode showMode;
		[Export("showMode", ArgumentSemantic.Assign)]
		AMapNaviWalkViewShowMode ShowMode { get; set; }

		// @property (assign, nonatomic) BOOL showUIElements;
		[Export("showUIElements")]
		bool ShowUIElements { get; set; }

		// @property (assign, nonatomic) BOOL showStandardNightType;
		[Export("showStandardNightType")]
		bool ShowStandardNightType { get; set; }

		// @property (assign, nonatomic) BOOL showBrowseRouteButton;
		[Export("showBrowseRouteButton")]
		bool ShowBrowseRouteButton { get; set; }

		// @property (assign, nonatomic) BOOL showMoreButton;
		[Export("showMoreButton")]
		bool ShowMoreButton { get; set; }

		// @property (assign, nonatomic) BOOL showTurnArrow;
		[Export("showTurnArrow")]
		bool ShowTurnArrow { get; set; }

		// @property (assign, nonatomic) BOOL showSensorHeading;
		[Export("showSensorHeading")]
		bool ShowSensorHeading { get; set; }

		// @property (assign, nonatomic) BOOL showCompass;
		[Export("showCompass")]
		bool ShowCompass { get; set; }

		// @property (assign, nonatomic) CGFloat cameraDegree;
		[Export("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (assign, nonatomic) BOOL showScale;
		[Export("showScale")]
		bool ShowScale { get; set; }

		// @property (assign, nonatomic) CGPoint scaleOrigin;
		[Export("scaleOrigin", ArgumentSemantic.Assign)]
		CGPoint ScaleOrigin { get; set; }

		// @property (assign, nonatomic) BOOL customMapStyleEnabled;
		[Export("customMapStyleEnabled")]
		bool CustomMapStyleEnabled { get; set; }

		// -(void)setCustomMapStyle:(NSData * _Nonnull)customJson __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: since 6.6.0")));
		[Export("setCustomMapStyle:")]
		void SetCustomMapStyle(NSData customJson);

		// -(void)setCustomMapStyleWithWebData:(NSData * _Nonnull)data __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: since 6.6.0")));
		[Export("setCustomMapStyleWithWebData:")]
		void SetCustomMapStyleWithWebData(NSData data);

		// -(void)setCustomMapStyleOptions:(MAMapCustomStyleOptions * _Nonnull)styleOptions;
		[Export("setCustomMapStyleOptions:")]
		void SetCustomMapStyleOptions(MAMapCustomStyleOptions styleOptions);

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (copy, nonatomic) UIImage * _Nullable normalTexture;
		[NullAllowed, Export("normalTexture", ArgumentSemantic.Copy)]
		UIImage NormalTexture { get; set; }

		// -(void)setStartPointImage:(UIImage * _Nullable)startPointImage;
		[Export("setStartPointImage:")]
		void SetStartPointImage([NullAllowed] UIImage startPointImage);

		// -(void)setEndPointImage:(UIImage * _Nullable)endPointImage;
		[Export("setEndPointImage:")]
		void SetEndPointImage([NullAllowed] UIImage endPointImage);

		// -(void)setCarImage:(UIImage * _Nullable)carImage;
		[Export("setCarImage:")]
		void SetCarImage([NullAllowed] UIImage carImage);

		// -(void)setCarCompassImage:(UIImage * _Nullable)carCompassImage;
		[Export("setCarCompassImage:")]
		void SetCarCompassImage([NullAllowed] UIImage carCompassImage);
	}

	// @protocol AMapNaviWalkViewDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapNaviWalkViewDelegate
	{
		// @optional -(void)walkViewCloseButtonClicked:(AMapNaviWalkView * _Nonnull)walkView;
		[Export("walkViewCloseButtonClicked:")]
		void WalkViewCloseButtonClicked(AMapNaviWalkView walkView);

		// @optional -(void)walkViewMoreButtonClicked:(AMapNaviWalkView * _Nonnull)walkView;
		[Export("walkViewMoreButtonClicked:")]
		void WalkViewMoreButtonClicked(AMapNaviWalkView walkView);

		// @optional -(void)walkViewTrunIndicatorViewTapped:(AMapNaviWalkView * _Nonnull)walkView;
		[Export("walkViewTrunIndicatorViewTapped:")]
		void WalkViewTrunIndicatorViewTapped(AMapNaviWalkView walkView);

		// @optional -(void)walkView:(AMapNaviWalkView * _Nonnull)walkView didChangeShowMode:(AMapNaviWalkViewShowMode)showMode;
		[Export("walkView:didChangeShowMode:")]
		void WalkView(AMapNaviWalkView walkView, AMapNaviWalkViewShowMode showMode);
	}

	// @interface AMapNaviRideView : UIView <AMapNaviRideDataRepresentable>
	[BaseType(typeof(UIView))]
	interface AMapNaviRideView : AMapNaviRideDataRepresentable
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapNaviRideViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapNaviRideViewDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL isLandscape;
		[Export("isLandscape")]
		bool IsLandscape { get; set; }

		// @property (assign, nonatomic) AMapNaviViewTrackingMode trackingMode;
		[Export("trackingMode", ArgumentSemantic.Assign)]
		AMapNaviViewTrackingMode TrackingMode { get; set; }

		// @property (assign, nonatomic) AMapNaviRideViewShowMode showMode;
		[Export("showMode", ArgumentSemantic.Assign)]
		AMapNaviRideViewShowMode ShowMode { get; set; }

		// @property (assign, nonatomic) BOOL showUIElements;
		[Export("showUIElements")]
		bool ShowUIElements { get; set; }

		// @property (assign, nonatomic) BOOL showStandardNightType;
		[Export("showStandardNightType")]
		bool ShowStandardNightType { get; set; }

		// @property (assign, nonatomic) BOOL showBrowseRouteButton;
		[Export("showBrowseRouteButton")]
		bool ShowBrowseRouteButton { get; set; }

		// @property (assign, nonatomic) BOOL showMoreButton;
		[Export("showMoreButton")]
		bool ShowMoreButton { get; set; }

		// @property (assign, nonatomic) BOOL showTurnArrow;
		[Export("showTurnArrow")]
		bool ShowTurnArrow { get; set; }

		// @property (assign, nonatomic) BOOL showSensorHeading;
		[Export("showSensorHeading")]
		bool ShowSensorHeading { get; set; }

		// @property (assign, nonatomic) BOOL showCompass;
		[Export("showCompass")]
		bool ShowCompass { get; set; }

		// @property (assign, nonatomic) CGFloat cameraDegree;
		[Export("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (assign, nonatomic) BOOL showScale;
		[Export("showScale")]
		bool ShowScale { get; set; }

		// @property (assign, nonatomic) CGPoint scaleOrigin;
		[Export("scaleOrigin", ArgumentSemantic.Assign)]
		CGPoint ScaleOrigin { get; set; }

		// @property (assign, nonatomic) BOOL customMapStyleEnabled;
		[Export("customMapStyleEnabled")]
		bool CustomMapStyleEnabled { get; set; }

		// -(void)setCustomMapStyle:(NSData * _Nonnull)customJson __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: since 6.6.0")));
		[Export("setCustomMapStyle:")]
		void SetCustomMapStyle(NSData customJson);

		// -(void)setCustomMapStyleWithWebData:(NSData * _Nonnull)data __attribute__((deprecated("已废弃, 请使用 setCustomMapStyleOptions: since 6.6.0")));
		[Export("setCustomMapStyleWithWebData:")]
		void SetCustomMapStyleWithWebData(NSData data);

		// -(void)setCustomMapStyleOptions:(MAMapCustomStyleOptions * _Nonnull)styleOptions;
		[Export("setCustomMapStyleOptions:")]
		void SetCustomMapStyleOptions(MAMapCustomStyleOptions styleOptions);

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (copy, nonatomic) UIImage * _Nullable normalTexture;
		[NullAllowed, Export("normalTexture", ArgumentSemantic.Copy)]
		UIImage NormalTexture { get; set; }

		// -(void)setStartPointImage:(UIImage * _Nullable)startPointImage;
		[Export("setStartPointImage:")]
		void SetStartPointImage([NullAllowed] UIImage startPointImage);

		// -(void)setEndPointImage:(UIImage * _Nullable)endPointImage;
		[Export("setEndPointImage:")]
		void SetEndPointImage([NullAllowed] UIImage endPointImage);

		// -(void)setCarImage:(UIImage * _Nullable)carImage;
		[Export("setCarImage:")]
		void SetCarImage([NullAllowed] UIImage carImage);

		// -(void)setCarCompassImage:(UIImage * _Nullable)carCompassImage;
		[Export("setCarCompassImage:")]
		void SetCarCompassImage([NullAllowed] UIImage carCompassImage);
	}

	// @protocol AMapNaviRideViewDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapNaviRideViewDelegate
	{
		// @optional -(void)rideViewCloseButtonClicked:(AMapNaviRideView * _Nonnull)rideView;
		[Export("rideViewCloseButtonClicked:")]
		void RideViewCloseButtonClicked(AMapNaviRideView rideView);

		// @optional -(void)rideViewMoreButtonClicked:(AMapNaviRideView * _Nonnull)rideView;
		[Export("rideViewMoreButtonClicked:")]
		void RideViewMoreButtonClicked(AMapNaviRideView rideView);

		// @optional -(void)rideViewTrunIndicatorViewTapped:(AMapNaviRideView * _Nonnull)rideView;
		[Export("rideViewTrunIndicatorViewTapped:")]
		void RideViewTrunIndicatorViewTapped(AMapNaviRideView rideView);

		// @optional -(void)rideView:(AMapNaviRideView * _Nonnull)rideView didChangeShowMode:(AMapNaviRideViewShowMode)showMode;
		[Export("rideView:didChangeShowMode:")]
		void RideView(AMapNaviRideView rideView, AMapNaviRideViewShowMode showMode);
	}

	// @interface AMapNaviHUDView : UIView <AMapNaviDriveDataRepresentable, AMapNaviWalkDataRepresentable>
	[BaseType(typeof(UIView))]
	interface AMapNaviHUDView : AMapNaviDriveDataRepresentable, AMapNaviWalkDataRepresentable
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapNaviHUDViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapNaviHUDViewDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL isLandscape;
		[Export("isLandscape")]
		bool IsLandscape { get; set; }

		// @property (assign, nonatomic) BOOL isMirror;
		[Export("isMirror")]
		bool IsMirror { get; set; }

		// @property (assign, nonatomic) BOOL showRemainDistance;
		[Export("showRemainDistance")]
		bool ShowRemainDistance { get; set; }

		// @property (assign, nonatomic) BOOL showRemainTime;
		[Export("showRemainTime")]
		bool ShowRemainTime { get; set; }
	}

	// @protocol AMapNaviHUDViewDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapNaviHUDViewDelegate
	{
		// @required -(void)hudViewCloseButtonClicked:(AMapNaviHUDView * _Nonnull)hudView;
		[Abstract]
		[Export("hudViewCloseButtonClicked:")]
		void HudViewCloseButtonClicked(AMapNaviHUDView hudView);
	}

	// @interface AMapNaviTrafficBarView : UIView <AMapNaviDriveDataRepresentable>
	[BaseType(typeof(UIView))]
	interface AMapNaviTrafficBarView : AMapNaviDriveDataRepresentable
	{
		// @property (assign, nonatomic) BOOL showCar;
		[Export("showCar")]
		bool ShowCar { get; set; }

		// @property (assign, nonatomic) BOOL wholeCourse;
		[Export("wholeCourse")]
		bool WholeCourse { get; set; }

		// @property (assign, nonatomic) CGFloat borderWidth;
		[Export("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull borderColor;
		[Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSNumber *,UIColor *> * _Nullable statusColors;
		[NullAllowed, Export("statusColors", ArgumentSemantic.Copy)]
		NSDictionary<NSNumber, UIColor> StatusColors { get; set; }

		// -(void)updateTrafficBarWithTrafficStatuses:(NSArray<AMapNaviTrafficStatus *> * _Nullable)trafficStatuses __attribute__((deprecated("已废弃，请通过 AMapNaviDriveManager 的 -addDataRepresentative: 将 AMapNaviTrafficBarView 注册为数据接收者，即可自动更新光柱信息，无需再主动调用此方法，可参考官方demo中的CustomUIViewController例子，since 6.2.0")));
		[Export("updateTrafficBarWithTrafficStatuses:")]
		void UpdateTrafficBarWithTrafficStatuses([NullAllowed] AMapNaviTrafficStatus[] trafficStatuses);

		// -(void)updateTrafficBarWithCarPositionPercent:(double)posPercent __attribute__((deprecated("已废弃，请通过 AMapNaviDriveManager 的 -addDataRepresentative: 将 AMapNaviTrafficBarView 注册为数据接收者，即可自动更新光柱百分比，无需再主动调用此方法，可参考官方demo中的CustomUIViewController例子，since 6.2.0")));
		[Export("updateTrafficBarWithCarPositionPercent:")]
		void UpdateTrafficBarWithCarPositionPercent(double posPercent);
	}

	// @interface AMapNaviCompositeManager : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviCompositeManager
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		AMapNaviCompositeManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AMapNaviCompositeManagerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) NSInteger naviRouteID;
		[Export("naviRouteID")]
		nint NaviRouteID { get; }

		// @property (readonly, nonatomic) AMapNaviRoute * _Nullable naviRoute;
		[NullAllowed, Export("naviRoute")]
		AMapNaviRoute NaviRoute { get; }

		// @property (readonly, nonatomic) NSArray<NSNumber *> * _Nullable naviRouteIDs;
		[NullAllowed, Export("naviRouteIDs")]
		NSNumber[] NaviRouteIDs { get; }

		// @property (readonly, nonatomic) NSDictionary<NSNumber *,AMapNaviRoute *> * _Nullable naviRoutes;
		[NullAllowed, Export("naviRoutes")]
		NSDictionary<NSNumber, AMapNaviRoute> NaviRoutes { get; }

		// -(void)presentRoutePlanViewControllerWithOptions:(AMapNaviCompositeUserConfig * _Nullable)options;
		[Export("presentRoutePlanViewControllerWithOptions:")]
		void PresentRoutePlanViewControllerWithOptions([NullAllowed] AMapNaviCompositeUserConfig options);

		// -(void)dismissWithAnimated:(BOOL)animated;
		[Export("dismissWithAnimated:")]
		void DismissWithAnimated(bool animated);

		// -(void)addAnnotation:(AMapNaviCompositeCustomAnnotation * _Nonnull)annotation;
		[Export("addAnnotation:")]
		void AddAnnotation(AMapNaviCompositeCustomAnnotation annotation);

		// -(void)removeAnnotation:(AMapNaviCompositeCustomAnnotation * _Nonnull)annotation;
		[Export("removeAnnotation:")]
		void RemoveAnnotation(AMapNaviCompositeCustomAnnotation annotation);

		// -(void)addCustomOverlay:(id<AMapNaviCompositeOverlay> _Nonnull)customOverlay;
		[Export("addCustomOverlay:")]
		void AddCustomOverlay(AMapNaviCompositeOverlay customOverlay);

		// -(void)removeCustomOverlay:(id<AMapNaviCompositeOverlay> _Nonnull)customOverlay;
		[Export("removeCustomOverlay:")]
		void RemoveCustomOverlay(AMapNaviCompositeOverlay customOverlay);
	}

	// @protocol AMapNaviCompositeManagerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface AMapNaviCompositeManagerDelegate
	{
		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager error:(NSError * _Nonnull)error;
		[Export("compositeManager:error:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, NSError error);
		void CompositeManagerError(AMapNaviCompositeManager compositeManager, NSError error);

		// @optional -(void)compositeManagerOnCalculateRouteSuccess:(AMapNaviCompositeManager * _Nonnull)compositeManager;
		[Export("compositeManagerOnCalculateRouteSuccess:")]
		void CompositeManagerOnCalculateRouteSuccess(AMapNaviCompositeManager compositeManager);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager onCalculateRouteSuccessWithType:(AMapNaviRoutePlanType)type;
		[Export("compositeManager:onCalculateRouteSuccessWithType:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, AMapNaviRoutePlanType type);
		void CompositeManagerOnCalculateRouteSuccessWithType(AMapNaviCompositeManager compositeManager, AMapNaviRoutePlanType type);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager onCalculateRouteFailure:(NSError * _Nonnull)error;
		[Export("compositeManager:onCalculateRouteFailure:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, NSError error);
		void CompositeManagerOnCalculateRouteFailure(AMapNaviCompositeManager compositeManager, NSError error);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager didStartNavi:(AMapNaviMode)naviMode;
		[Export("compositeManager:didStartNavi:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, AMapNaviMode naviMode);
		void CompositeManagerDidStartNavi(AMapNaviCompositeManager compositeManager, AMapNaviMode naviMode);

		// @optional -(BOOL)compositeManagerIsNaviSoundPlaying:(AMapNaviCompositeManager * _Nonnull)compositeManager;
		[Export("compositeManagerIsNaviSoundPlaying:")]
		bool CompositeManagerIsNaviSoundPlaying(AMapNaviCompositeManager compositeManager);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager playNaviSoundString:(NSString * _Nullable)soundString soundStringType:(AMapNaviSoundType)soundStringType;
		[Export("compositeManager:playNaviSoundString:soundStringType:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, [NullAllowed] string soundString, AMapNaviSoundType soundStringType);
		void CompositeManagerPlayNaviSoundStringSoundStringType(AMapNaviCompositeManager compositeManager, [NullAllowed] string soundString, AMapNaviSoundType soundStringType);

		// @optional -(void)compositeManagerStopPlayNaviSound:(AMapNaviCompositeManager * _Nonnull)compositeManager;
		[Export("compositeManagerStopPlayNaviSound:")]
		void CompositeManagerStopPlayNaviSound(AMapNaviCompositeManager compositeManager);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager updateNaviLocation:(AMapNaviLocation * _Nullable)naviLocation;
		[Export("compositeManager:updateNaviLocation:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, [NullAllowed] AMapNaviLocation naviLocation);
		void CompositeManagerUpdateNaviLocation(AMapNaviCompositeManager compositeManager, [NullAllowed] AMapNaviLocation naviLocation);


		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager didChangeDayNightType:(BOOL)showStandardNightType;
		[Export("compositeManager:didChangeDayNightType:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, bool showStandardNightType);
		void CompositeManagerDidChangeDayNightType(AMapNaviCompositeManager compositeManager, bool showStandardNightType);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager didArrivedDestination:(AMapNaviMode)naviMode;
		[Export("compositeManager:didArrivedDestination:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, AMapNaviMode naviMode);
		void CompositeManagerDidArrivedDestination(AMapNaviCompositeManager compositeManager, AMapNaviMode naviMode);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager didBackwardAction:(AMapNaviCompositeVCBackwardActionType)backwardActionType;
		[Export("compositeManager:didBackwardAction:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, AMapNaviCompositeVCBackwardActionType backwardActionType);
		void CompositeManagerDidBackwardAction(AMapNaviCompositeManager compositeManager, AMapNaviCompositeVCBackwardActionType backwardActionType);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager onDriveStrategyChanged:(AMapNaviDrivingStrategy)driveStrategy;
		[Export("compositeManager:onDriveStrategyChanged:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, AMapNaviDrivingStrategy driveStrategy);
		void CompositeManagerOnDriveStrategyChanged(AMapNaviCompositeManager compositeManager, AMapNaviDrivingStrategy driveStrategy);

		// @optional -(void)compositeManager:(AMapNaviCompositeManager * _Nonnull)compositeManager onArrivedWayPoint:(int)wayPointIndex;
		[Export("compositeManager:onArrivedWayPoint:")]
		//void CompositeManager(AMapNaviCompositeManager compositeManager, int wayPointIndex);
		void CompositeManagerOnArrivedWayPoint(AMapNaviCompositeManager compositeManager, int wayPointIndex);

		// @optional -(void)compositeManagerDidChangeMapViewModeType:(AMapNaviViewMapModeType)type;
		[Export("compositeManagerDidChangeMapViewModeType:")]
		void CompositeManagerDidChangeMapViewModeType(AMapNaviViewMapModeType type);

		// @optional -(void)compositeManagerDidChangeBroadcastType:(AMapNaviCompositeBroadcastType)type;
		[Export("compositeManagerDidChangeBroadcastType:")]
		void CompositeManagerDidChangeBroadcastType(AMapNaviCompositeBroadcastType type);

		// @optional -(void)compositeManagerDidChangeTrackingMode:(AMapNaviViewTrackingMode)mode;
		[Export("compositeManagerDidChangeTrackingMode:")]
		void CompositeManagerDidChangeTrackingMode(AMapNaviViewTrackingMode mode);

		// @optional -(void)compositeManagerDidChangeAutoZoomMapLevel:(BOOL)autoZoomMapLevel;
		[Export("compositeManagerDidChangeAutoZoomMapLevel:")]
		void CompositeManagerDidChangeAutoZoomMapLevel(bool autoZoomMapLevel);
	}

	// @interface AMapNaviCompositeUserConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface AMapNaviCompositeUserConfig
	{
		// -(BOOL)setRoutePlanPOIType:(AMapNaviRoutePlanPOIType)type location:(AMapNaviPoint * _Nonnull)locationPoint name:(NSString * _Nullable)name POIId:(NSString * _Nullable)mid;
		[Export("setRoutePlanPOIType:location:name:POIId:")]
		bool SetRoutePlanPOIType(AMapNaviRoutePlanPOIType type, AMapNaviPoint locationPoint, [NullAllowed] string name, [NullAllowed] string mid);

		// -(void)setStartNaviDirectly:(BOOL)directly;
		[Export("setStartNaviDirectly:")]
		void SetStartNaviDirectly(bool directly);

		// -(void)setThemeType:(AMapNaviCompositeThemeType)themeType;
		[Export("setThemeType:")]
		void SetThemeType(AMapNaviCompositeThemeType themeType);

		// -(void)setNeedCalculateRouteWhenPresent:(BOOL)need;
		[Export("setNeedCalculateRouteWhenPresent:")]
		void SetNeedCalculateRouteWhenPresent(bool need);

		// -(void)setShowNextRoadInfo:(BOOL)showNextRoadInfo;
		[Export("setShowNextRoadInfo:")]
		void SetShowNextRoadInfo(bool showNextRoadInfo);

		// -(void)setNeedDestoryDriveManagerInstanceWhenDismiss:(BOOL)need;
		[Export("setNeedDestoryDriveManagerInstanceWhenDismiss:")]
		void SetNeedDestoryDriveManagerInstanceWhenDismiss(bool need);

		// -(void)setNeedShowConfirmViewWhenStopGPSNavi:(BOOL)need;
		[Export("setNeedShowConfirmViewWhenStopGPSNavi:")]
		void SetNeedShowConfirmViewWhenStopGPSNavi(bool need);

		// -(void)setVehicleInfo:(AMapNaviVehicleInfo * _Nonnull)vehicleInfo;
		[Export("setVehicleInfo:")]
		void SetVehicleInfo(AMapNaviVehicleInfo vehicleInfo);

		// -(void)addCustomViewToNaviDriveView:(UIView * _Nonnull)customView;
		[Export("addCustomViewToNaviDriveView:")]
		void AddCustomViewToNaviDriveView(UIView customView);

		// -(void)addLeftCustomViewToNaviDriveView:(UIView * _Nonnull)customView;
		[Export("addLeftCustomViewToNaviDriveView:")]
		void AddLeftCustomViewToNaviDriveView(UIView customView);

		// -(BOOL)addCustomBottomViewToNaviDriveView:(UIView * _Nonnull)customBottomView;
		[Export("addCustomBottomViewToNaviDriveView:")]
		bool AddCustomBottomViewToNaviDriveView(UIView customBottomView);

		// -(void)setDriveStrategy:(AMapNaviDrivingStrategy)driveStrategy;
		[Export("setDriveStrategy:")]
		void SetDriveStrategy(AMapNaviDrivingStrategy driveStrategy);

		// -(void)setShowCrossImage:(BOOL)need;
		[Export("setShowCrossImage:")]
		void SetShowCrossImage(bool need);

		// -(void)setShowDrivingStrategyPreferenceView:(BOOL)need;
		[Export("setShowDrivingStrategyPreferenceView:")]
		void SetShowDrivingStrategyPreferenceView(bool need);

		// -(void)setRemovePolylineAndVectorlineWhenArrivedDestination:(BOOL)need;
		[Export("setRemovePolylineAndVectorlineWhenArrivedDestination:")]
		void SetRemovePolylineAndVectorlineWhenArrivedDestination(bool need);

		// -(void)setMultipleRouteNaviMode:(BOOL)multipleRouteNaviMode;
		[Export("setMultipleRouteNaviMode:")]
		void SetMultipleRouteNaviMode(bool multipleRouteNaviMode);

		// -(void)setShowBackupRoute:(BOOL)need;
		[Export("setShowBackupRoute:")]
		void SetShowBackupRoute(bool need);

		// -(BOOL)setOnlineCarHailingType:(AMapNaviOnlineCarHailingType)type;
		[Export("setOnlineCarHailingType:")]
		bool SetOnlineCarHailingType(AMapNaviOnlineCarHailingType type);

		// -(void)setMapShowTraffic:(BOOL)need;
		[Export("setMapShowTraffic:")]
		void SetMapShowTraffic(bool need);

		// -(void)setMapViewModeType:(AMapNaviViewMapModeType)type;
		[Export("setMapViewModeType:")]
		void SetMapViewModeType(AMapNaviViewMapModeType type);

		// -(void)setBroadcastType:(AMapNaviCompositeBroadcastType)type;
		[Export("setBroadcastType:")]
		void SetBroadcastType(AMapNaviCompositeBroadcastType type);

		// -(void)setTrackingMode:(AMapNaviViewTrackingMode)mode;
		[Export("setTrackingMode:")]
		void SetTrackingMode(AMapNaviViewTrackingMode mode);

		// -(void)setAutoZoomMapLevel:(BOOL)autoZoomMapLevel;
		[Export("setAutoZoomMapLevel:")]
		void SetAutoZoomMapLevel(bool autoZoomMapLevel);

		// -(void)setPresenterViewController:(UIViewController * _Nonnull)presenterViewController;
		[Export("setPresenterViewController:")]
		void SetPresenterViewController(UIViewController presenterViewController);
	}

}

