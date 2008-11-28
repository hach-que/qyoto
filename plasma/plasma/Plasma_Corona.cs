//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @class Corona plasma/corona.h <Plasma/Corona>
    ///  See <see cref="ICoronaSignals"></see> for signals emitted by Corona
    /// </remarks>        <short> A QGraphicsScene for Plasma.Applets.</short>
    [SmokeClass("Plasma::Corona")]
    public class Corona : QGraphicsScene, IDisposable {
        protected Corona(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Corona), this);
        }
        public Corona(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Corona#", "Corona(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public Corona() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Corona", "Corona()", typeof(void));
        }
        /// <remarks>
        ///   Sets the mimetype of Drag/Drop items. Default is
        ///   text/x-plasmoidservicename
        ///      </remarks>        <short>     Sets the mimetype of Drag/Drop items.</short>
        public void SetAppletMimeType(string mimetype) {
            interceptor.Invoke("setAppletMimeType$", "setAppletMimeType(const QString&)", typeof(void), typeof(string), mimetype);
        }
        /// <remarks>
        ///  The current mime type of Drag/Drop items.
        ///      </remarks>        <short>    The current mime type of Drag/Drop items.</short>
        public string AppletMimeType() {
            return (string) interceptor.Invoke("appletMimeType", "appletMimeType()", typeof(string));
        }
        /// <remarks>
        /// </remarks>        <return> all containments on this Corona
        ///      </return>
        ///         <short>   </short>
        public List<Plasma.Containment> Containments() {
            return (List<Plasma.Containment>) interceptor.Invoke("containments", "containments() const", typeof(List<Plasma.Containment>));
        }
        /// <remarks>
        ///  Clear the Corona from all applets.
        ///      </remarks>        <short>    Clear the Corona from all applets.</short>
        public void ClearContainments() {
            interceptor.Invoke("clearContainments", "clearContainments()", typeof(void));
        }
        /// <remarks>
        ///  Returns the config file used to store the configuration for this Corona
        ///      </remarks>        <short>    Returns the config file used to store the configuration for this Corona      </short>
        public KSharedConfig Config() {
            return (KSharedConfig) interceptor.Invoke("config", "config() const", typeof(KSharedConfig));
        }
        /// <remarks>
        ///  Adds a Containment to the Corona
        /// <param> name="name" the plugin name for the containment, as given by
        ///         KPluginInfo.PluginName(). If an empty string is passed in, the defalt
        ///         containment plugin will be used (usually DesktopContainment). If the
        ///         string literal "null" is passed in, then no plugin will be loaded and
        ///         a simple Containment object will be created instead.
        /// </param><param> name="args" argument list to pass to the containment
        /// </param></remarks>        <return> a pointer to the containment on success, or 0 on failure
        ///      </return>
        ///         <short>    Adds a Containment to the Corona </short>
        public Plasma.Containment AddContainment(string name, List<QVariant> args) {
            return (Plasma.Containment) interceptor.Invoke("addContainment$?", "addContainment(const QString&, const QList<QVariant>&)", typeof(Plasma.Containment), typeof(string), name, typeof(List<QVariant>), args);
        }
        public Plasma.Containment AddContainment(string name) {
            return (Plasma.Containment) interceptor.Invoke("addContainment$", "addContainment(const QString&)", typeof(Plasma.Containment), typeof(string), name);
        }
        /// <remarks>
        ///  Returns the Containment, if any, for a given physical screen
        /// <param> name="screen" number of the physical screen to locate
        /// </param><param> name="desktop" the dekstop) to locate; if < 0 then it will
        ///         simply return the first Containment associated with screen
        ///      </param></remarks>        <short>    Returns the Containment, if any, for a given physical screen </short>
        public Plasma.Containment ContainmentForScreen(int screen, int desktop) {
            return (Plasma.Containment) interceptor.Invoke("containmentForScreen$$", "containmentForScreen(int, int) const", typeof(Plasma.Containment), typeof(int), screen, typeof(int), desktop);
        }
        public Plasma.Containment ContainmentForScreen(int screen) {
            return (Plasma.Containment) interceptor.Invoke("containmentForScreen$", "containmentForScreen(int) const", typeof(Plasma.Containment), typeof(int), screen);
        }
        /// <remarks>
        ///  Adds a widget in the topleft quadrant in the scene. Widgets in the topleft quadrant are
        ///  normally never shown unless you specifically aim a view at it, which makes it ideal for
        ///  toplevel views etc.
        /// <param> name="widget" the widget to add.
        ///      </param></remarks>        <short>    Adds a widget in the topleft quadrant in the scene.</short>
        public void AddOffscreenWidget(QGraphicsWidget widget) {
            interceptor.Invoke("addOffscreenWidget#", "addOffscreenWidget(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), widget);
        }
        /// <remarks>
        ///  Removes a widget from the topleft quadrant in the scene.
        /// <param> name="widget" the widget to remove.
        ///      </param></remarks>        <short>    Removes a widget from the topleft quadrant in the scene.</short>
        public void RemoveOffscreenWidget(QGraphicsWidget widget) {
            interceptor.Invoke("removeOffscreenWidget#", "removeOffscreenWidget(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), widget);
        }
        /// <remarks>
        ///  Returns the number of screens available to plasma.
        ///  Subclasses should override this method as the default
        ///  implementation returns a meaningless value.
        ///      </remarks>        <short>    Returns the number of screens available to plasma.</short>
        [SmokeMethod("numScreens() const")]
        public virtual int NumScreens() {
            return (int) interceptor.Invoke("numScreens", "numScreens() const", typeof(int));
        }
        /// <remarks>
        ///  Returns the geometry of a given screen.
        ///  Valid screen ids are 0 to numScreen()-1, or -1 for the full desktop geometry.
        ///  Subclasses should override this method as the default
        ///  implementation returns a meaningless value.
        ///      </remarks>        <short>    Returns the geometry of a given screen.</short>
        [SmokeMethod("screenGeometry(int) const")]
        public virtual QRect ScreenGeometry(int id) {
            return (QRect) interceptor.Invoke("screenGeometry$", "screenGeometry(int) const", typeof(QRect), typeof(int), id);
        }
        /// <remarks>
        ///  Returns the available region for a given screen.
        ///  The available region excludes panels and similar windows.
        ///  Valid screen ids are 0 to numScreens()-1.
        ///  By default this method returns a rectangular region
        ///  equal to screenGeometry(id); subclasses that need another
        ///  behavior should override this method.
        ///      </remarks>        <short>    Returns the available region for a given screen.</short>
        [SmokeMethod("availableScreenRegion(int) const")]
        public virtual QRegion AvailableScreenRegion(int id) {
            return (QRegion) interceptor.Invoke("availableScreenRegion$", "availableScreenRegion(int) const", typeof(QRegion), typeof(int), id);
        }
        /// <remarks>
        ///  Reccomended position for a popup window like a menu or a tooltip
        ///  given its size
        /// <param> name="s" size of the popup
        /// </param></remarks>        <return> reccomended position
        ///     </return>
        ///         <short>    Reccomended position for a popup window like a menu or a tooltip  given its size </short>
        public QPoint PopupPosition(IQGraphicsItem item, QSize s) {
            return (QPoint) interceptor.Invoke("popupPosition##", "popupPosition(const QGraphicsItem*, const QSize&)", typeof(QPoint), typeof(IQGraphicsItem), item, typeof(QSize), s);
        }
        /// <remarks>
        ///  Initializes the layout from a config file. This will first clear any existing
        ///  Containments, load a layout from the requested configuration file, request the
        ///  default layout if needed and update immutability.
        /// <param> name="config" the name of the config file to load from,
        ///                or the default config file if string()
        ///      </param></remarks>        <short>    Initializes the layout from a config file.</short>
        [Q_SLOT("void initializeLayout(QString)")]
        public void InitializeLayout(string config) {
            interceptor.Invoke("initializeLayout$", "initializeLayout(const QString&)", typeof(void), typeof(string), config);
        }
        [Q_SLOT("void initializeLayout()")]
        public void InitializeLayout() {
            interceptor.Invoke("initializeLayout", "initializeLayout()", typeof(void));
        }
        /// <remarks>
        ///  Load applet layout from a config file. The results will be added to the
        ///  current set of Containments.
        /// <param> name="config" the name of the config file to load from,
        ///                or the default config file if string()
        ///      </param></remarks>        <short>    Load applet layout from a config file.</short>
        [Q_SLOT("void loadLayout(QString)")]
        public void LoadLayout(string config) {
            interceptor.Invoke("loadLayout$", "loadLayout(const QString&)", typeof(void), typeof(string), config);
        }
        [Q_SLOT("void loadLayout()")]
        public void LoadLayout() {
            interceptor.Invoke("loadLayout", "loadLayout()", typeof(void));
        }
        /// <remarks>
        ///  Save applets layout to file
        ///  @arg config the file to save to, or the default config file if string()
        ///      </remarks>        <short>    Save applets layout to file  @arg config the file to save to, or the default config file if string()      </short>
        [Q_SLOT("void saveLayout(QString)")]
        public void SaveLayout(string config) {
            interceptor.Invoke("saveLayout$", "saveLayout(const QString&) const", typeof(void), typeof(string), config);
        }
        [Q_SLOT("void saveLayout()")]
        public void SaveLayout() {
            interceptor.Invoke("saveLayout", "saveLayout() const", typeof(void));
        }
        /// <remarks>
        /// </remarks>        <return> The type of immutability of this Corona
        ///      </return>
        ///         <short>   </short>
        [Q_SLOT("Plasma::ImmutabilityType immutability()")]
        public Plasma.ImmutabilityType Immutability() {
            return (Plasma.ImmutabilityType) interceptor.Invoke("immutability", "immutability() const", typeof(Plasma.ImmutabilityType));
        }
        /// <remarks>
        ///  Sets the immutability type for this Corona (not immutable,
        ///  user immutable or system immutable)
        ///  @arg immutable the new immutability type of this applet
        ///      </remarks>        <short>    Sets the immutability type for this Corona (not immutable,  user immutable or system immutable)  @arg immutable the new immutability type of this applet      </short>
        [Q_SLOT("void setImmutability(ImmutabilityType)")]
        public void SetImmutability(Plasma.ImmutabilityType immutable) {
            interceptor.Invoke("setImmutability$", "setImmutability(const Plasma::ImmutabilityType)", typeof(void), typeof(Plasma.ImmutabilityType), immutable);
        }
        /// <remarks>
        ///  Schedules a flush-to-disk synchronization of the configuration state
        ///  at the next convenient moment.
        ///      </remarks>        <short>    Schedules a flush-to-disk synchronization of the configuration state  at the next convenient moment.</short>
        [Q_SLOT("void requestConfigSync()")]
        public void RequestConfigSync() {
            interceptor.Invoke("requestConfigSync", "requestConfigSync()", typeof(void));
        }
        /// <remarks>
        ///  Loads the default (system wide) layout for this user
        /// </remarks>        <short>    Loads the default (system wide) layout for this user </short>
        [SmokeMethod("loadDefaultLayout()")]
        protected virtual void LoadDefaultLayout() {
            interceptor.Invoke("loadDefaultLayout", "loadDefaultLayout()", typeof(void));
        }
        /// <remarks>
        ///  Loads a containment with delayed initialization, primarily useful
        ///  for implementations of loadDefaultLayout. The caller is responsible
        ///  for all initializating, saving and notification of a new containment.
        /// <param> name="name" the plugin name for the containment, as given by
        ///         KPluginInfo.PluginName(). If an empty string is passed in, the defalt
        ///         containment plugin will be used (usually DesktopContainment). If the
        ///         string literal "null" is passed in, then no plugin will be loaded and
        ///         a simple Containment object will be created instead.
        /// </param><param> name="args" argument list to pass to the containment
        /// </param></remarks>        <return> a pointer to the containment on success, or 0 on failure
        /// </return>
        ///         <short>    Loads a containment with delayed initialization, primarily useful  for implementations of loadDefaultLayout.</short>
        protected Plasma.Containment AddContainmentDelayed(string name, List<QVariant> args) {
            return (Plasma.Containment) interceptor.Invoke("addContainmentDelayed$?", "addContainmentDelayed(const QString&, const QList<QVariant>&)", typeof(Plasma.Containment), typeof(string), name, typeof(List<QVariant>), args);
        }
        protected Plasma.Containment AddContainmentDelayed(string name) {
            return (Plasma.Containment) interceptor.Invoke("addContainmentDelayed$", "addContainmentDelayed(const QString&)", typeof(Plasma.Containment), typeof(string), name);
        }
        [SmokeMethod("dragEnterEvent(QGraphicsSceneDragDropEvent*)")]
        protected override void DragEnterEvent(QGraphicsSceneDragDropEvent arg1) {
            interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
        }
        [SmokeMethod("dragLeaveEvent(QGraphicsSceneDragDropEvent*)")]
        protected override void DragLeaveEvent(QGraphicsSceneDragDropEvent arg1) {
            interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
        }
        [SmokeMethod("dragMoveEvent(QGraphicsSceneDragDropEvent*)")]
        protected override void DragMoveEvent(QGraphicsSceneDragDropEvent arg1) {
            interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
        }
        ~Corona() {
            interceptor.Invoke("~Corona", "~Corona()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~Corona", "~Corona()", typeof(void));
        }
        protected new ICoronaSignals Emit {
            get { return (ICoronaSignals) Q_EMIT; }
        }
    }

    public interface ICoronaSignals : IQGraphicsSceneSignals {
        /// <remarks>
        ///  This signal indicates a new containment has been added to
        ///  the Corona
        ///      </remarks>        <short>    This signal indicates a new containment has been added to  the Corona      </short>
        [Q_SIGNAL("void containmentAdded(Plasma::Containment*)")]
        void ContainmentAdded(Plasma.Containment containment);
        /// <remarks>
        ///  This signal indicates that a containment has been newly
        ///  associated (or dissociated) with a physical screen.
        /// <param> name="wasScreen" the screen it was associated with
        /// </param><param> name="isScreen" the screen it is now associated with
        /// </param><param> name="containment" the containment switching screens
        ///      </param></remarks>        <short>    This signal indicates that a containment has been newly  associated (or dissociated) with a physical screen.</short>
        [Q_SIGNAL("void screenOwnerChanged(int, int, Plasma::Containment*)")]
        void ScreenOwnerChanged(int wasScreen, int isScreen, Plasma.Containment containment);
        /// <remarks>
        ///  This signal indicates that an application launch, window
        ///  creation or window focus event was triggered. This is used, for instance,
        ///  to ensure that the Dashboard view in Plasma hides when such an event is
        ///  triggered by an item it is displaying.
        ///      </remarks>        <short>    This signal indicates that an application launch, window  creation or window focus event was triggered.</short>
        [Q_SIGNAL("void releaseVisualFocus()")]
        void ReleaseVisualFocus();
        /// <remarks>
        ///  This signal indicates that the configuration file was flushed to disc.
        ///      </remarks>        <short>    This signal indicates that the configuration file was flushed to disc.</short>
        [Q_SIGNAL("void configSynced()")]
        void ConfigSynced();
        /// <remarks>
        ///  This signal inicates that a change in available screen goemetry occured.
        ///      </remarks>        <short>    This signal inicates that a change in available screen goemetry occured.</short>
        [Q_SIGNAL("void availableScreenRegionChanged()")]
        void AvailableScreenRegionChanged();
    }
}
