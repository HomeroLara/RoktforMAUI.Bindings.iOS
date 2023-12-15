using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace RoktforMAUI.iOS
{

    // @interface RoktEmbeddedViewWrapper : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RoktEmbeddedViewWrapper
    {
        // -(instancetype _Nonnull)initWithClientKey:(NSString * _Nonnull)clientKey __attribute__((objc_designated_initializer));
        [Export("initWithClientKey:")]
        [DesignatedInitializer]
        IntPtr Constructor(string clientKey);

        // -(void)resizeRoktEmbeddedViewWithNewHeight:(double)newHeight newWidth:(double)newWidth;
        [Export("resizeRoktEmbeddedViewWithNewHeight:newWidth:")]
        void ResizeRoktEmbeddedViewWithNewHeight(double newHeight, double newWidth);

        // -(CGFloat)getViewHeight __attribute__((warn_unused_result("")));
        [Export("getViewHeight")]
        nfloat ViewHeight { get; }

        // -(UIView * _Nonnull)getView __attribute__((warn_unused_result("")));
        [Export("getView")]
        UIView View { get; }

        // -(DisplayDetails * _Nonnull)getDisplayDetails __attribute__((warn_unused_result("")));
        [Export("getDisplayDetails")]
        DisplayDetails DisplayDetails { get; }

        // -(void)showWidgetWithAttributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes callback:(id<RoktEmbeddedViewCallback> _Nonnull)callback viewName:(NSString * _Nonnull)viewName controlName:(NSString * _Nonnull)controlName;
        [Export("showWidgetWithAttributes:callback:viewName:controlName:")]
        void ShowWidgetWithAttributes(NSDictionary<NSString, NSString> attributes, RoktEmbeddedViewCallback callback, string viewName, string controlName);
    }

    // @protocol RoktEmbeddedViewCallback
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [BaseType(typeof(NSObject))]
    [Model]
    interface RoktEmbeddedViewCallback
    {
        // @required -(void)onLoad;
        [Abstract]
        [Export("onLoad")]
        void OnLoad();

        // @required -(void)onUnLoad;
        [Abstract]
        [Export("onUnLoad")]
        void OnUnLoad();

        // @required -(void)onShouldShowLoadingIndicator;
        [Abstract]
        [Export("onShouldShowLoadingIndicator")]
        void OnShouldShowLoadingIndicator();

        // @required -(void)onShouldHideLoadingIndicator;
        [Abstract]
        [Export("onShouldHideLoadingIndicator")]
        void OnShouldHideLoadingIndicator();

        // @required -(void)onEmbeddedViewSizeChanged;
        [Abstract]
        [Export("onEmbeddedViewSizeChanged")]
        void OnEmbeddedViewSizeChanged();
    }

    // @interface DisplayDetails : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface DisplayDetails
    {
        // -(instancetype _Nonnull)initWithClientKey:(NSString * _Nonnull)clientKey viewName:(NSString * _Nonnull)viewName controlName:(NSString * _Nonnull)controlName displayPlacements:(NSDictionary<NSString *,RoktEmbeddedView *> * _Nonnull)displayPlacements attributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes __attribute__((objc_designated_initializer));
        [Export("initWithClientKey:viewName:controlName:displayPlacements:attributes:")]
        [DesignatedInitializer]
        IntPtr Constructor(string clientKey, string viewName, string controlName, NSDictionary<NSString, UIView> displayPlacements, NSDictionary<NSString, NSString> attributes);

        // -(NSDictionary<NSString *,RoktEmbeddedView *> * _Nonnull)getPlacements __attribute__((warn_unused_result("")));
        [Export("getPlacements")]
        NSDictionary<NSString, UIView> Placements { get; }

        // -(NSString * _Nonnull)getViewName __attribute__((warn_unused_result("")));
        [Export("getViewName")]
        string ViewName { get; }

        // -(NSString * _Nonnull)getControlName __attribute__((warn_unused_result("")));
        [Export("getControlName")]
        string ControlName { get; }

        // -(NSDictionary<NSString *,NSString *> * _Nonnull)getAttributes __attribute__((warn_unused_result("")));
        [Export("getAttributes")]
        NSDictionary<NSString, NSString> Attributes { get; }

        // -(NSString * _Nonnull)getClientKey __attribute__((warn_unused_result("")));
        [Export("getClientKey")]
        string ClientKey { get; }

        // -(void)printInformation;
        [Export("printInformation")]
        void PrintInformation();
    }
}


