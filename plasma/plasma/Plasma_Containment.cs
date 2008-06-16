//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  Containment objects provide the means to group applets into functional sets.
	///  They also provide the following:
	///  creation of focussing event
	///  - drawing of the background image (which can be interactive)
	///  - form factors (e.g. panel, desktop, full screen, etc)
	///  - applet layout management
	///  Since containment is actually just a Plasma.Applet, all the techniques used
	///  for writing the visual presentation of Applets is applicable to Containtments.
	///  Containments are differentiated from Applets by being marked with the ServiceType
	///  of Plasma/Containment. Plugins registered with both the Applet and the Containment
	///  ServiceTypes can be loaded for us in either situation.
	///  See techbase.kde.org for a tutorial on writing Containments using this class.
	///   See <see cref="IContainmentSignals"></see> for signals emitted by Containment
	/// </remarks>		<short> The base class for plugins that provide backgrounds and applet grouping containers.</short>
	[SmokeClass("Plasma::Containment")]
	public class Containment : Plasma.Applet, IDisposable {
 		protected Containment(Type dummy) : base((Type) null) {}
		[SmokeClass("Plasma::Containment::StyleOption")]
		public class StyleOption : QStyleOptionGraphicsItem, IDisposable {
	 		protected StyleOption(Type dummy) : base((Type) null) {}
			protected new void CreateProxy() {
				interceptor = new SmokeInvocation(typeof(StyleOption), this);
			}
			public StyleOption() : this((Type) null) {
				CreateProxy();
				interceptor.Invoke("StyleOption", "StyleOption()", typeof(void));
			}
			public StyleOption(Plasma.Containment.StyleOption other) : this((Type) null) {
				CreateProxy();
				interceptor.Invoke("StyleOption#", "StyleOption(const Plasma::Containment::StyleOption&)", typeof(void), typeof(Plasma.Containment.StyleOption), other);
			}
			public StyleOption(QStyleOptionGraphicsItem other) : this((Type) null) {
				CreateProxy();
				interceptor.Invoke("StyleOption#", "StyleOption(const QStyleOptionGraphicsItem&)", typeof(void), typeof(QStyleOptionGraphicsItem), other);
			}
			~StyleOption() {
				interceptor.Invoke("~StyleOption", "~StyleOption()", typeof(void));
			}
			public new void Dispose() {
				interceptor.Invoke("~StyleOption", "~StyleOption()", typeof(void));
			}
		}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Containment), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static Containment() {
			staticInterceptor = new SmokeInvocation(typeof(Containment), null);
		}
		public enum TypeOf {
			NoContainmentType = -1,
			DesktopContainment = 0,
			PanelContainment = 1,
			CustomContainment = 127,
		}
		/// <remarks>
		/// <param> name="parent" the QGraphicsItem this applet is parented to
		/// </param><param> name="serviceId" the name of the .desktop file containing the
		///       information about the widget
		/// </param><param> name="containmentId" a unique id used to differentiate between multiple
		///       instances of the same Applet type
		///          </param></remarks>		<short>   </short>
		public Containment(QGraphicsItem parent, string serviceId, uint containmentId) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Containment#$$", "Containment(QGraphicsItem*, const QString&, uint)", typeof(void), typeof(QGraphicsItem), parent, typeof(string), serviceId, typeof(uint), containmentId);
		}
		public Containment(QGraphicsItem parent, string serviceId) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Containment#$", "Containment(QGraphicsItem*, const QString&)", typeof(void), typeof(QGraphicsItem), parent, typeof(string), serviceId);
		}
		public Containment(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Containment#", "Containment(QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), parent);
		}
		public Containment() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Containment", "Containment()", typeof(void));
		}
		/// <remarks>
		///  This constructor is to be used with the plugin loading systems
		///  found in KPluginInfo and KService. The argument list is expected
		///  to have two elements: the KService service ID for the desktop entry
		///  and an applet ID which must be a base 10 number.
		/// <param> name="parent" a QObject parent; you probably want to pass in 0
		/// </param><param> name="args" a list of strings containing two entries: the service id
		///       and the applet id
		///          </param></remarks>		<short>    This constructor is to be used with the plugin loading systems  found in KPluginInfo and KService.</short>
		public Containment(QObject parent, List<QVariant> args) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Containment#?", "Containment(QObject*, const QVariantList&)", typeof(void), typeof(QObject), parent, typeof(List<QVariant>), args);
		}
		/// <remarks>
		///  Reimplemented from Applet
		///          </remarks>		<short>    Reimplemented from Applet          </short>
		[SmokeMethod("init()")]
		public override void Init() {
			interceptor.Invoke("init", "init()", typeof(void));
		}
		/// <remarks>
		///  Returns the type of containment
		///          </remarks>		<short>    Returns the type of containment          </short>
		public Plasma.Containment.TypeOf ContainmentType() {
			return (Plasma.Containment.TypeOf) interceptor.Invoke("containmentType", "containmentType() const", typeof(Plasma.Containment.TypeOf));
		}
		/// <remarks>
		///  Returns the Corona (if any) that this Containment is hosted by
		///          </remarks>		<short>    Returns the Corona (if any) that this Containment is hosted by          </short>
		public Plasma.Corona Corona() {
			return (Plasma.Corona) interceptor.Invoke("corona", "corona() const", typeof(Plasma.Corona));
		}
		/// <remarks>
		///  Adds an applet to this Containment
		/// <param> name="name" the plugin name for the applet, as given by
		///         KPluginInfo.PluginName()
		/// </param><param> name="args" argument list to pass to the plasmoid
		/// </param><param> name="id" to assign to this applet, or 0 to auto-assign it a new id
		/// </param><param> name="geometry" where to place the applet, or to auto-place it if an invalid
		///                  is provided
		/// </param><param> name="delayedInit" if true, init() will not be called on the applet
		/// </param></remarks>		<return> a pointer to the applet on success, or 0 on failure
		///          </return>
		/// 		<short>    Adds an applet to this Containment </short>
		public Plasma.Applet AddApplet(string name, List<QVariant> args, QRectF geometry) {
			return (Plasma.Applet) interceptor.Invoke("addApplet$?#", "addApplet(const QString&, const QVariantList&, const QRectF&)", typeof(Plasma.Applet), typeof(string), name, typeof(List<QVariant>), args, typeof(QRectF), geometry);
		}
		public Plasma.Applet AddApplet(string name, List<QVariant> args) {
			return (Plasma.Applet) interceptor.Invoke("addApplet$?", "addApplet(const QString&, const QVariantList&)", typeof(Plasma.Applet), typeof(string), name, typeof(List<QVariant>), args);
		}
		public Plasma.Applet AddApplet(string name) {
			return (Plasma.Applet) interceptor.Invoke("addApplet$", "addApplet(const QString&)", typeof(Plasma.Applet), typeof(string), name);
		}
		/// <remarks>
		///  add existing applet to this containment at pos
		/// <param> name="applet" the applet that should be added
		/// </param><param> name="pos" the containment-relative position
		/// </param><param> name="dontInit" if true, init() will not be called on the applet
		///          </param></remarks>		<short>    add existing applet to this containment at pos </short>
		public void AddApplet(Plasma.Applet applet, QPointF pos, bool dontInit) {
			interceptor.Invoke("addApplet##$", "addApplet(Plasma::Applet*, const QPointF&, bool)", typeof(void), typeof(Plasma.Applet), applet, typeof(QPointF), pos, typeof(bool), dontInit);
		}
		public void AddApplet(Plasma.Applet applet, QPointF pos) {
			interceptor.Invoke("addApplet##", "addApplet(Plasma::Applet*, const QPointF&)", typeof(void), typeof(Plasma.Applet), applet, typeof(QPointF), pos);
		}
		public void AddApplet(Plasma.Applet applet) {
			interceptor.Invoke("addApplet#", "addApplet(Plasma::Applet*)", typeof(void), typeof(Plasma.Applet), applet);
		}
		/// <remarks>
		/// </remarks>		<return> the applets currently in this Containment
		///          </return>
		/// 		<short>   </short>
		public List<Plasma.Applet> Applets() {
			return (List<Plasma.Applet>) interceptor.Invoke("applets", "applets() const", typeof(List<Plasma.Applet>));
		}
		/// <remarks>
		///  Removes all applets from this Containment
		///          </remarks>		<short>    Removes all applets from this Containment          </short>
		public void ClearApplets() {
			interceptor.Invoke("clearApplets", "clearApplets()", typeof(void));
		}
		/// <remarks>
		///  Sets the physical screen this Containment is associated with.
		/// <param> name="screen" the screen number this containment is the desktop for, or -1
		///                if it is not serving as the desktop for any screen
		///          </param></remarks>		<short>    Sets the physical screen this Containment is associated with.</short>
		public void SetScreen(int screen) {
			interceptor.Invoke("setScreen$", "setScreen(int)", typeof(void), typeof(int), screen);
		}
		/// <remarks>
		/// </remarks>		<return> the screen number this containment is serving as the desktop for
		///          or -1 if none
		///          </return>
		/// 		<short>   </short>
		public int Screen() {
			return (int) interceptor.Invoke("screen", "screen() const", typeof(int));
		}
		/// <remarks>
		/// </remarks>		<return> where top left corner of the containment maps to for the currently
		///          set screen. If no screen is associated, it will return QPoint()
		///          </return>
		/// 		<short>   </short>
		public QPoint EffectiveScreenPos() {
			return (QPoint) interceptor.Invoke("effectiveScreenPos", "effectiveScreenPos() const", typeof(QPoint));
		}
		/// <remarks>
		///  convenience function - enables or disables an action by name
		/// <param> name="name" the name of the action in our collection
		/// </param><param> name="enable" true to enable, false to disable
		///          </param></remarks>		<short>    convenience function - enables or disables an action by name </short>
		public void EnableAction(string name, bool enable) {
			interceptor.Invoke("enableAction$$", "enableAction(const QString&, bool)", typeof(void), typeof(string), name, typeof(bool), enable);
		}
		/// <remarks>
		///  Add an action to the toolbox
		///          </remarks>		<short>    Add an action to the toolbox          </short>
		public void AddToolBoxTool(QAction action) {
			interceptor.Invoke("addToolBoxTool#", "addToolBoxTool(QAction*)", typeof(void), typeof(QAction), action);
		}
		/// <remarks>
		///  Remove an action from the toolbox
		///          </remarks>		<short>    Remove an action from the toolbox          </short>
		public void RemoveToolBoxTool(QAction action) {
			interceptor.Invoke("removeToolBoxTool#", "removeToolBoxTool(QAction*)", typeof(void), typeof(QAction), action);
		}
		/// <remarks>
		///  Sets the open or closed state of the Containment's toolbox
		///  @arg open true to open the ToolBox, false to close it
		///          </remarks>		<short>    Sets the open or closed state of the Containment's toolbox </short>
		public void SetToolBoxOpen(bool open) {
			interceptor.Invoke("setToolBoxOpen$", "setToolBoxOpen(bool)", typeof(void), typeof(bool), open);
		}
		/// <remarks>
		///  Open the Containment's toolbox
		///          </remarks>		<short>    Open the Containment's toolbox          </short>
		public void OpenToolBox() {
			interceptor.Invoke("openToolBox", "openToolBox()", typeof(void));
		}
		/// <remarks>
		///  Closes Containment's toolbox
		///          </remarks>		<short>    Closes Containment's toolbox          </short>
		public void CloseToolBox() {
			interceptor.Invoke("closeToolBox", "closeToolBox()", typeof(void));
		}
		/// <remarks>
		///  associate actions with this widget, including ones added after this call.
		///  needed to make keyboard shortcuts work.
		///          </remarks>		<short>    associate actions with this widget, including ones added after this call.</short>
		[SmokeMethod("addAssociatedWidget(QWidget*)")]
		public override void AddAssociatedWidget(QWidget widget) {
			interceptor.Invoke("addAssociatedWidget#", "addAssociatedWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		/// <remarks>
		///  un-associate actions from this widget, including ones added after this call.
		///  needed to make keyboard shortcuts work.
		///          </remarks>		<short>    un-associate actions from this widget, including ones added after this call.</short>
		[SmokeMethod("removeAssociatedWidget(QWidget*)")]
		public override void RemoveAssociatedWidget(QWidget widget) {
			interceptor.Invoke("removeAssociatedWidget#", "removeAssociatedWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		/// <remarks>
		///  Informs the Corona as to what position it is in. This is informational
		///  only, as the Corona doesn't change it's actual location. This is,
		///  however, passed on to Applets that may be managed by this Corona.
		/// <param> name="location" the new location of this Corona
		///          </param></remarks>		<short>    Informs the Corona as to what position it is in.</short>
		[Q_SLOT("void setLocation(Plasma::Location)")]
		public void SetLocation(Plasma.Location location) {
			interceptor.Invoke("setLocation$", "setLocation(Plasma::Location)", typeof(void), typeof(Plasma.Location), location);
		}
		/// <remarks>
		///  Sets the form factor for this Containment. This may cause changes in both
		///  the arrangement of Applets as well as the display choices of individual
		///  Applets.
		///          </remarks>		<short>    Sets the form factor for this Containment.</short>
		[Q_SLOT("void setFormFactor(Plasma::FormFactor)")]
		public void SetFormFactor(Plasma.FormFactor formFactor) {
			interceptor.Invoke("setFormFactor$", "setFormFactor(Plasma::FormFactor)", typeof(void), typeof(Plasma.FormFactor), formFactor);
		}
		/// <remarks>
		///  Tells the corona to create a new desktop containment
		///          </remarks>		<short>    Tells the corona to create a new desktop containment          </short>
		[Q_SLOT("void addSiblingContainment()")]
		public void AddSiblingContainment() {
			interceptor.Invoke("addSiblingContainment", "addSiblingContainment()", typeof(void));
		}
		/// <remarks>
		///  switch keyboard focus to the next of our applets
		///          </remarks>		<short>    switch keyboard focus to the next of our applets          </short>
		[Q_SLOT("void focusNextApplet()")]
		public void FocusNextApplet() {
			interceptor.Invoke("focusNextApplet", "focusNextApplet()", typeof(void));
		}
		/// <remarks>
		///  switch keyboard focus to the previous one of our applets
		///          </remarks>		<short>    switch keyboard focus to the previous one of our applets          </short>
		[Q_SLOT("void focusPreviousApplet()")]
		public void FocusPreviousApplet() {
			interceptor.Invoke("focusPreviousApplet", "focusPreviousApplet()", typeof(void));
		}
		/// <remarks>
		///  Destroys this containment and all its applets (after a confirmation dialog);
		///  it will be removed nicely and deleted.
		///  Its configuration will also be deleted.
		///          </remarks>		<short>    Destroys this containment and all its applets (after a confirmation dialog);  it will be removed nicely and deleted.</short>
		[Q_SLOT("void destroy()")]
		[SmokeMethod("destroy()")]
		public override void Destroy() {
			interceptor.Invoke("destroy", "destroy()", typeof(void));
		}
		/// <remarks>
		///  Sets the type of this containment.
		///          </remarks>		<short>    Sets the type of this containment.</short>
		protected void SetContainmentType(Plasma.Containment.TypeOf type) {
			interceptor.Invoke("setContainmentType$", "setContainmentType(Plasma::Containment::Type)", typeof(void), typeof(Plasma.Containment.TypeOf), type);
		}
		/// <remarks>
		///  Called when the contents of the containment should be saved. By default this saves
		///  all loaded Applets
		/// <param> name="group" the KConfigGroup to save settings under
		///          </param></remarks>		<short>    Called when the contents of the containment should be saved.</short>
		[SmokeMethod("saveContents(KConfigGroup&) const")]
		protected virtual void SaveContents(KConfigGroup group) {
			interceptor.Invoke("saveContents#", "saveContents(KConfigGroup&) const", typeof(void), typeof(KConfigGroup), group);
		}
		/// <remarks>
		///  Called when the contents of the containment should be loaded. By default this loads
		///  all previously saved Applets
		/// <param> name="group" the KConfigGroup to save settings under
		///          </param></remarks>		<short>    Called when the contents of the containment should be loaded.</short>
		[SmokeMethod("restoreContents(KConfigGroup&)")]
		protected virtual void RestoreContents(KConfigGroup group) {
			interceptor.Invoke("restoreContents#", "restoreContents(KConfigGroup&)", typeof(void), typeof(KConfigGroup), group);
		}
		[SmokeMethod("contextMenuEvent(QGraphicsSceneContextMenuEvent*)")]
		protected override void ContextMenuEvent(QGraphicsSceneContextMenuEvent arg1) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QGraphicsSceneContextMenuEvent*)", typeof(void), typeof(QGraphicsSceneContextMenuEvent), arg1);
		}
		[SmokeMethod("hoverEnterEvent(QGraphicsSceneHoverEvent*)")]
		protected override void HoverEnterEvent(QGraphicsSceneHoverEvent arg1) {
			interceptor.Invoke("hoverEnterEvent#", "hoverEnterEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
		}
		[SmokeMethod("hoverLeaveEvent(QGraphicsSceneHoverEvent*)")]
		protected override void HoverLeaveEvent(QGraphicsSceneHoverEvent arg1) {
			interceptor.Invoke("hoverLeaveEvent#", "hoverLeaveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("sceneEventFilter(QGraphicsItem*, QEvent*)")]
		protected override bool SceneEventFilter(QGraphicsItem watched, QEvent arg2) {
			return (bool) interceptor.Invoke("sceneEventFilter##", "sceneEventFilter(QGraphicsItem*, QEvent*)", typeof(bool), typeof(QGraphicsItem), watched, typeof(QEvent), arg2);
		}
		[SmokeMethod("itemChange(QGraphicsItem::GraphicsItemChange, const QVariant&)")]
		protected override QVariant ItemChange(QGraphicsItem.GraphicsItemChange change, QVariant value) {
			return (QVariant) interceptor.Invoke("itemChange$#", "itemChange(QGraphicsItem::GraphicsItemChange, const QVariant&)", typeof(QVariant), typeof(QGraphicsItem.GraphicsItemChange), change, typeof(QVariant), value);
		}
		~Containment() {
			interceptor.Invoke("~Containment", "~Containment()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Containment", "~Containment()", typeof(void));
		}
		/// <remarks>
		///  Returns a list of all known containments.
		/// <param> name="category" Only applets matchin this category will be returned.
		///                  Useful in conjunction with knownCategories.
		///                  If "Misc" is passed in, then applets without a
		///                  Categories= entry are also returned.
		///                  If an empty string is passed in, all applets are
		///                  returned.
		/// </param><param> name="parentApp" the application to filter applets on. Uses the
		///                   X-KDE-ParentApp entry (if any) in the plugin info.
		///                   The default value of string() will result in a
		///                   list containing only applets not specifically
		///                   registered to an application.
		/// </param></remarks>		<return> list of applets
		/// </return>
		/// 		<short>    Returns a list of all known containments.</short>
		public static List<KPluginInfo> ListContainments(string category, string parentApp) {
			return (List<KPluginInfo>) staticInterceptor.Invoke("listContainments$$", "listContainments(const QString&, const QString&)", typeof(List<KPluginInfo>), typeof(string), category, typeof(string), parentApp);
		}
		public static List<KPluginInfo> ListContainments(string category) {
			return (List<KPluginInfo>) staticInterceptor.Invoke("listContainments$", "listContainments(const QString&)", typeof(List<KPluginInfo>), typeof(string), category);
		}
		public static List<KPluginInfo> ListContainments() {
			return (List<KPluginInfo>) staticInterceptor.Invoke("listContainments", "listContainments()", typeof(List<KPluginInfo>));
		}
		/// <remarks>
		///  Returns a list of all known applets associated with a certain mimetype
		/// </remarks>		<return> list of applets
		/// </return>
		/// 		<short>    Returns a list of all known applets associated with a certain mimetype </short>
		public static List<KPluginInfo> ListContainmentsForMimetype(string mimetype) {
			return (List<KPluginInfo>) staticInterceptor.Invoke("listContainmentsForMimetype$", "listContainmentsForMimetype(const QString&)", typeof(List<KPluginInfo>), typeof(string), mimetype);
		}
		protected new IContainmentSignals Emit {
			get { return (IContainmentSignals) Q_EMIT; }
		}
	}

	public interface IContainmentSignals : Plasma.IAppletSignals {
		/// <remarks>
		///  This signal is emitted when a new applet is created by the containment
		///          </remarks>		<short>    This signal is emitted when a new applet is created by the containment          </short>
		[Q_SIGNAL("void appletAdded(Plasma::Applet*, const QPointF&)")]
		void AppletAdded(Plasma.Applet applet, QPointF pos);
		/// <remarks>
		///  This signal is emitted when an applet is destroyed
		///          </remarks>		<short>    This signal is emitted when an applet is destroyed          </short>
		[Q_SIGNAL("void appletRemoved(Plasma::Applet*)")]
		void AppletRemoved(Plasma.Applet applet);
		/// <remarks>
		///  Emitted when the containment requests zooming in or out one step.
		///          </remarks>		<short>    Emitted when the containment requests zooming in or out one step.</short>
		[Q_SIGNAL("void zoomRequested(Plasma::Containment*, Plasma::ZoomDirection)")]
		void ZoomRequested(Plasma.Containment containment, Plasma.ZoomDirection direction);
		/// <remarks>
		///  Emitted when the user clicks on the toolbox
		///          </remarks>		<short>    Emitted when the user clicks on the toolbox          </short>
		[Q_SIGNAL("void toolBoxToggled()")]
		void ToolBoxToggled();
		/// <remarks>
		///  Emitted when the containment wants a new containment to be created.
		///  Usually only used for desktop containments.
		///          </remarks>		<short>    Emitted when the containment wants a new containment to be created.</short>
		[Q_SIGNAL("void addSiblingContainment(Plasma::Containment*)")]
		void AddSiblingContainment(Plasma.Containment arg1);
		/// <remarks>
		///  Emitted when the containment requests an add widgets dialog is shown.
		///  Usually only used for desktop containments.
		/// <param> name="pos" where in the containment this request was made from, or
		///             an invalid position (QPointF()) is not location specific
		///          </param></remarks>		<short>    Emitted when the containment requests an add widgets dialog is shown.</short>
		[Q_SIGNAL("void showAddWidgetsInterface(const QPointF&)")]
		void ShowAddWidgetsInterface(QPointF pos);
		/// <remarks>
		///  This signal indicates that a containment has been newly
		///  associated (or dissociated) with a physical screen.
		/// <param> name="wasScreen" the screen it was associated with
		/// </param><param> name="isScreen" the screen it is now associated with
		/// </param><param> name="containment" the containment switching screens
		///          </param></remarks>		<short>    This signal indicates that a containment has been newly  associated (or dissociated) with a physical screen.</short>
		[Q_SIGNAL("void screenChanged(int, int, Plasma::Containment*)")]
		void ScreenChanged(int wasScreen, int isScreen, Plasma.Containment containment);
		/// <remarks>
		///  Emitted when the containment wants to become active.
		///  Usually only used for desktop containments.
		///          </remarks>		<short>    Emitted when the containment wants to become active.</short>
		[Q_SIGNAL("void focusRequested(Plasma::Containment*)")]
		void FocusRequested(Plasma.Containment containment);
	}
}
