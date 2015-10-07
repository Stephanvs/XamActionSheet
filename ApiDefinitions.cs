using System;
using CoreGraphics;
using Foundation;
using MapKit;
using ObjCRuntime;
using UIKit;

// typedef void (^DoActionSheetHandler)(int);
delegate void DoActionSheetHandler (int arg0);

// @interface DoActionSheet : UIView <MKMapViewDelegate>
[BaseType (typeof(UIView))]
interface DoActionSheet : IMKMapViewDelegate
{
	// @property (readwrite) int nAnimationType;
	[Export ("nAnimationType")]
	int NAnimationType { get; set; }

	// @property (readwrite) int nContentMode;
	[Export ("nContentMode")]
	int NContentMode { get; set; }

	// @property (readwrite) int nDestructiveIndex;
	[Export ("nDestructiveIndex")]
	int NDestructiveIndex { get; set; }

	// @property (readwrite) double dRound;
	[Export ("dRound")]
	double DRound { get; set; }

	// @property (readwrite) double dButtonRound;
	[Export ("dButtonRound")]
	double DButtonRound { get; set; }

	// @property (readwrite) BOOL bDestructive;
	[Export ("bDestructive")]
	bool BDestructive { get; set; }

	// @property (readonly) int nTag;
	[Export ("nTag")]
	int NTag { get; }

	// @property (nonatomic, strong) NSArray * aButtons;
	[Export ("aButtons", ArgumentSemantic.Strong)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] AButtons { get; set; }

	// @property (nonatomic, strong) UIImage * iImage;
	[Export ("iImage", ArgumentSemantic.Strong)]
	UIImage IImage { get; set; }

	// @property (nonatomic, strong) NSDictionary * dLocation;
	[Export ("dLocation", ArgumentSemantic.Strong)]
	NSDictionary DLocation { get; set; }

	// @property (nonatomic, strong) UIColor * doBackColor;
	[Export ("doBackColor", ArgumentSemantic.Strong)]
	UIColor DoBackColor { get; set; }

	// @property (nonatomic, strong) UIColor * doButtonColor;
	[Export ("doButtonColor", ArgumentSemantic.Strong)]
	UIColor DoButtonColor { get; set; }

	// @property (nonatomic, strong) UIColor * doCancelColor;
	[Export ("doCancelColor", ArgumentSemantic.Strong)]
	UIColor DoCancelColor { get; set; }

	// @property (nonatomic, strong) UIColor * doDestructiveColor;
	[Export ("doDestructiveColor", ArgumentSemantic.Strong)]
	UIColor DoDestructiveColor { get; set; }

	// @property (nonatomic, strong) UIColor * doTitleTextColor;
	[Export ("doTitleTextColor", ArgumentSemantic.Strong)]
	UIColor DoTitleTextColor { get; set; }

	// @property (nonatomic, strong) UIColor * doButtonTextColor;
	[Export ("doButtonTextColor", ArgumentSemantic.Strong)]
	UIColor DoButtonTextColor { get; set; }

	// @property (nonatomic, strong) UIColor * doCancelTextColor;
	[Export ("doCancelTextColor", ArgumentSemantic.Strong)]
	UIColor DoCancelTextColor { get; set; }

	// @property (nonatomic, strong) UIColor * doDestructiveTextColor;
	[Export ("doDestructiveTextColor", ArgumentSemantic.Strong)]
	UIColor DoDestructiveTextColor { get; set; }

	// @property (nonatomic, strong) UIColor * doDimmedColor;
	[Export ("doDimmedColor", ArgumentSemantic.Strong)]
	UIColor DoDimmedColor { get; set; }

	// @property (nonatomic, strong) UIFont * doTitleFont;
	[Export ("doTitleFont", ArgumentSemantic.Strong)]
	UIFont DoTitleFont { get; set; }

	// @property (nonatomic, strong) UIFont * doButtonFont;
	[Export ("doButtonFont", ArgumentSemantic.Strong)]
	UIFont DoButtonFont { get; set; }

	// @property (nonatomic, strong) UIFont * doCancelFont;
	[Export ("doCancelFont", ArgumentSemantic.Strong)]
	UIFont DoCancelFont { get; set; }

	// @property (readwrite) UIEdgeInsets doTitleInset;
	[Export ("doTitleInset", ArgumentSemantic.Assign)]
	UIEdgeInsets DoTitleInset { get; set; }

	// @property (readwrite) UIEdgeInsets doButtonInset;
	[Export ("doButtonInset", ArgumentSemantic.Assign)]
	UIEdgeInsets DoButtonInset { get; set; }

	// @property (readwrite) CGFloat doButtonHeight;
	[Export ("doButtonHeight")]
	nfloat DoButtonHeight { get; set; }

	// @property (assign, nonatomic) BOOL underLineEnable;
	[Export ("underLineEnable")]
	bool UnderLineEnable { get; set; }

	// -(void)showC:(NSString *)strTitle cancel:(NSString *)strCancel buttons:(NSArray *)aButtons result:(DoActionSheetHandler)result;
	[Export ("showC:cancel:buttons:result:")]
	[Verify (StronglyTypedNSArray)]
	void ShowC (string strTitle, string strCancel, NSObject[] aButtons, DoActionSheetHandler result);

	// -(void)showC:(NSString *)strCancel buttons:(NSArray *)aButtons result:(DoActionSheetHandler)result;
	[Export ("showC:buttons:result:")]
	[Verify (StronglyTypedNSArray)]
	void ShowC (string strCancel, NSObject[] aButtons, DoActionSheetHandler result);

	// -(void)show:(NSString *)strTitle buttons:(NSArray *)aButtons result:(DoActionSheetHandler)result;
	[Export ("show:buttons:result:")]
	[Verify (StronglyTypedNSArray)]
	void Show (string strTitle, NSObject[] aButtons, DoActionSheetHandler result);

	// -(void)show:(NSArray *)aButtons result:(DoActionSheetHandler)result;
	[Export ("show:result:")]
	[Verify (StronglyTypedNSArray)]
	void Show (NSObject[] aButtons, DoActionSheetHandler result);
}

// @interface ResizeMagick (UIImage)
[Category]
[BaseType (typeof(UIImage))]
interface UIImage_ResizeMagick
{
	// -(UIImage *)resizedImageByMagick:(NSString *)spec;
	[Export ("resizedImageByMagick:")]
	UIImage ResizedImageByMagick (string spec);

	// -(UIImage *)resizedImageByWidth:(NSUInteger)width;
	[Export ("resizedImageByWidth:")]
	UIImage ResizedImageByWidth (nuint width);

	// -(UIImage *)resizedImageByHeight:(NSUInteger)height;
	[Export ("resizedImageByHeight:")]
	UIImage ResizedImageByHeight (nuint height);

	// -(UIImage *)resizedImageWithMaximumSize:(CGSize)size;
	[Export ("resizedImageWithMaximumSize:")]
	UIImage ResizedImageWithMaximumSize (CGSize size);

	// -(UIImage *)resizedImageWithMinimumSize:(CGSize)size;
	[Export ("resizedImageWithMinimumSize:")]
	UIImage ResizedImageWithMinimumSize (CGSize size);
}
