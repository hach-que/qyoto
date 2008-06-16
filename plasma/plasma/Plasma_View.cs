//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	/// <remarks>
	///  See <see cref="IViewSignals"></see> for signals emitted by View
	/// </remarks>		<short> A QGraphicsView for Plasma.Applets. Each View is associated with  a Plasma.Containment and tracks geometry changes, maps to the current desktop  (if any) among other helpful utilities. It isn't stricly required to use  a Plasma.View with Plasma enabled applications, but it can make some  things easier.  </short>
	[SmokeClass("Plasma::View")]
	public class View : QGraphicsView, IDisposable {
 		protected View(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(View), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static View() {
			staticInterceptor = new SmokeInvocation(typeof(View), null);
		}
		/// <remarks>
		///  Constructs a view for a given contanment. An Id is automatically
		///  assigned to the View.
		///  @arg containment the containment to center the view on
		///  @arg parent the parent object for this view
		///      </remarks>		<short>    Constructs a view for a given contanment.</short>
		public View(Plasma.Containment containment, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("View##", "View(Plasma::Containment*, QWidget*)", typeof(void), typeof(Plasma.Containment), containment, typeof(QWidget), parent);
		}
		public View(Plasma.Containment containment) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("View#", "View(Plasma::Containment*)", typeof(void), typeof(Plasma.Containment), containment);
		}
		/// <remarks>
		///  Constructs a view for a given contanment.
		///  @arg containment the containment to center the view on
		///  @arg viewId the id to assign to this view
		///  @arg parent the parent object for this view
		///      </remarks>		<short>    Constructs a view for a given contanment.</short>
		public View(Plasma.Containment containment, int viewId, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("View#$#", "View(Plasma::Containment*, int, QWidget*)", typeof(void), typeof(Plasma.Containment), containment, typeof(int), viewId, typeof(QWidget), parent);
		}
		public View(Plasma.Containment containment, int viewId) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("View#$", "View(Plasma::Containment*, int)", typeof(void), typeof(Plasma.Containment), containment, typeof(int), viewId);
		}
		/// <remarks>
		///  Sets whether or not to draw the containment wallpaper when painting
		///  on this item
		///      </remarks>		<short>    Sets whether or not to draw the containment wallpaper when painting  on this item      </short>
		public void SetWallpaperEnabled(bool draw) {
			interceptor.Invoke("setWallpaperEnabled$", "setWallpaperEnabled(bool)", typeof(void), typeof(bool), draw);
		}
		/// <remarks>
		/// </remarks>		<return> whether or not containments should draw wallpaper
		///      </return>
		/// 		<short>   </short>
		public bool IsWallpaperEnabled() {
			return (bool) interceptor.Invoke("isWallpaperEnabled", "isWallpaperEnabled() const", typeof(bool));
		}
		/// <remarks>
		///  Sets which screen this view is associated with, if any.
		///  This will also set the containment if a valid screen is specified
		///  @arg screen the xinerama screen number; -1 for no screen
		///      </remarks>		<short>    Sets which screen this view is associated with, if any.</short>
		public void SetScreen(int screen) {
			interceptor.Invoke("setScreen$", "setScreen(int)", typeof(void), typeof(int), screen);
		}
		/// <remarks>
		///  Returns the screen this view is associated with
		/// </remarks>		<return> the xinerama screen number, or -1 for none
		///      </return>
		/// 		<short>    Returns the screen this view is associated with </short>
		public int Screen() {
			return (int) interceptor.Invoke("screen", "screen() const", typeof(int));
		}
		/// <remarks>
		///  Sets which desktop this view is asociated with, if any.
		///  @arg desktop a valid desktop number, -1 for all desktops, less than -1 for none
		///      </remarks>		<short>    Sets which virtual desktop this view is asociated with, if any.</short>
		public void SetDesktop(int desktop) {
			interceptor.Invoke("setDesktop$", "setDesktop(int)", typeof(void), typeof(int), desktop);
		}
		/// <remarks>
		///  The desktop this view is associated with
		/// </remarks>		<return> the desktop number, -1 for all desktops and less than -1 for none
		///      </return>
		/// 		<short>    The virtual desktop this view is associated with </short>
		public int Desktop() {
			return (int) interceptor.Invoke("desktop", "desktop() const", typeof(int));
		}
		/// <remarks>
		///  The desktop this view is actually being viewed on
		/// </remarks>		<return> the desktop number (always valid, never < 0)
		///      </return>
		/// 		<short>    The virtual desktop this view is actually being viewed on </short>
		public int EffectiveDesktop() {
			return (int) interceptor.Invoke("effectiveDesktop", "effectiveDesktop() const", typeof(int));
		}
		/// <remarks>
		/// </remarks>		<return> the containment associated with this view, or 0 if none is
		///      </return>
		/// 		<short>   </short>
		public Plasma.Containment Containment() {
			return (Plasma.Containment) interceptor.Invoke("containment", "containment() const", typeof(Plasma.Containment));
		}
		/// <remarks>
		///  Set whether or not the view should adjust its size when the associated
		///  containment does.
		///  @arg trackChanges true to syncronize the view's size with the containment's
		///  (this is the default behaviour), false to ignore containment size changes
		///      </remarks>		<short>    Set whether or not the view should adjust its size when the associated  containment does.</short>
		public void SetTrackContainmentChanges(bool trackChanges) {
			interceptor.Invoke("setTrackContainmentChanges$", "setTrackContainmentChanges(bool)", typeof(void), typeof(bool), trackChanges);
		}
		/// <remarks>
		/// </remarks>		<return> whether or not the view tracks changes to the containment
		///      </return>
		/// 		<short>   </short>
		public bool TrackContainmentChanges() {
			return (bool) interceptor.Invoke("trackContainmentChanges", "trackContainmentChanges()", typeof(bool));
		}
		/// <remarks>
		/// </remarks>		<return> the id of the View set in the constructor
		///      </return>
		/// 		<short>   </short>
		public int Id() {
			return (int) interceptor.Invoke("id", "id() const", typeof(int));
		}
		/// <remarks>
		///  Sets the containment for this view, which will also cause the view
		///  to track the geometry of the containment.
		///  @arg containment the containment to center the view on
		///      </remarks>		<short>    Sets the containment for this view, which will also cause the view  to track the geometry of the containment.</short>
		[Q_SLOT("void setContainment(Plasma::Containment*)")]
		[SmokeMethod("setContainment(Plasma::Containment*)")]
		public virtual void SetContainment(Plasma.Containment containment) {
			interceptor.Invoke("setContainment#", "setContainment(Plasma::Containment*)", typeof(void), typeof(Plasma.Containment), containment);
		}
		/// <remarks>
		/// </remarks>		<return> a KConfigGroup in the application's config file unique to the view
		///      </return>
		/// 		<short>   </short>
		protected KConfigGroup Config() {
			return (KConfigGroup) interceptor.Invoke("config", "config() const", typeof(KConfigGroup));
		}
		~View() {
			interceptor.Invoke("~View", "~View()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~View", "~View()", typeof(void));
		}
		/// <remarks>
		/// <param> name="pos" the position in screen coordinates.
		/// </param></remarks>		<return> the Plasma.View that is at position pos.
		///      </return>
		/// 		<short>   </short>
		public static Plasma.View TopLevelViewAt(QPoint pos) {
			return (Plasma.View) staticInterceptor.Invoke("topLevelViewAt#", "topLevelViewAt(const QPoint&)", typeof(Plasma.View), typeof(QPoint), pos);
		}
		protected new IViewSignals Emit {
			get { return (IViewSignals) Q_EMIT; }
		}
	}

	public interface IViewSignals : IQGraphicsViewSignals {
		/// <remarks>
		///  This signal is emitted whenever the containment being viewed has
		///  changed its geometry, but before the View has shifted the viewd scene rect
		///  to the new geometry. This is useful for Views which want to keep
		///  their rect() in sync with the containment'sa
		///      </remarks>		<short>    This signal is emitted whenever the containment being viewed has  changed its geometry, but before the View has shifted the viewd scene rect  to the new geometry.</short>
		[Q_SIGNAL("void sceneRectAboutToChange()")]
		void SceneRectAboutToChange();
		/// <remarks>
		///  This signal is emitted whenever the containment being viewed has
		///  changed its geometry, and after the View has shifted the viewd scene rect
		///  to the new geometry. This is useful for Views which want to keep
		///  their rect() in sync with the containment's.
		///      </remarks>		<short>    This signal is emitted whenever the containment being viewed has  changed its geometry, and after the View has shifted the viewd scene rect  to the new geometry.</short>
		[Q_SIGNAL("void sceneRectChanged()")]
		void SceneRectChanged();
	}
}
