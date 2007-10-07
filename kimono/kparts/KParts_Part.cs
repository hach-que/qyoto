//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	namespace KParts {

	using System;
	using Qyoto;

	/// <remarks>
	///  Base class for parts.
	///  A "part" is a GUI component, featuring:
	/// 
	/// <li>
	/// A widget embeddedable in any application.
	/// </li>
	/// 
	/// <li>
	/// GUI elements that will be merged in the "host" user interface
	///  (menubars, toolbars... ).
	/// </li>
	///  <li><b>About the widget:</b></li>
	///  Note that KParts.Part does not inherit QWidget.
	///  This is due to the fact that the "visual representation"
	///  will probably not be a mere QWidget, but an elaborate one.
	///  That's why when implementing your KParts.Part (or derived)
	///  you should call KParts.Part.SetWidget() in your constructor.
	///  <li><b>About the GUI elements:</b></li>
	///  Those elements trigger actions, defined by the part ( action()).
	///  The layout of the actions in the GUI is defined by an XML file ( setXMLFile()).
	///  See also ReadOnlyPart and ReadWritePart, which define the
	///  framework for a "viewer" part and for an "editor"-like part.
	///  Use Part directly only if your part doesn't fit into those.
	///   See <see cref="IPartSignals"></see> for signals emitted by Part
	/// </remarks>		<short>    Base class for parts.</short>

	[SmokeClass("KParts::Part")]
	public class Part : QObject, KParts.IPartBase, IDisposable {
 		protected Part(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Part), this);
		}
		// void setPluginLoadingMode(KParts::PartBase::PluginLoadingMode arg1); >>>> NOT CONVERTED
		// KParts::PartBase* PartBase(KParts::PartBasePrivate& arg1); >>>> NOT CONVERTED
		/// <remarks>
		///   Constructor.
		/// <param> name="parent" Parent object of the part.
		///      </param></remarks>		<short>     Constructor.</short>
		public Part(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Part#", "Part(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public Part() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Part", "Part()", typeof(void));
		}
		/// <remarks>
		///  Embed this part into a host widget.
		///  You don't need to do this if you created the widget with the
		///  correct parent widget - this is just a QWidget.Reparent().
		///  Note that the Part is still the holder
		///  of the QWidget, meaning that if you delete the Part,
		///  then the widget gets destroyed as well, and vice-versa.
		///  This method is not recommended since creating the widget with the correct
		///  parent is simpler anyway.
		///      </remarks>		<short>    Embed this part into a host widget.</short>
		[SmokeMethod("embed(QWidget*)")]
		public virtual void Embed(QWidget parentWidget) {
			interceptor.Invoke("embed#", "embed(QWidget*)", typeof(void), typeof(QWidget), parentWidget);
		}
		/// <remarks>
		/// </remarks>		<return> The widget defined by this part, set by setWidget().
		///      </return>
		/// 		<short>   </short>
		[SmokeMethod("widget()")]
		public virtual QWidget Widget() {
			return (QWidget) interceptor.Invoke("widget", "widget()", typeof(QWidget));
		}
		/// <remarks>
		///  Used by the part manager.
		///      </remarks>		<short>   </short>
		[SmokeMethod("setManager(KParts::PartManager*)")]
		public virtual void SetManager(KParts.PartManager manager) {
			interceptor.Invoke("setManager#", "setManager(KParts::PartManager*)", typeof(void), typeof(KParts.PartManager), manager);
		}
		/// <remarks>
		///  Returns the part manager handling this part, if any (null otherwise).
		///      </remarks>		<short>    Returns the part manager handling this part, if any (0L otherwise).</short>
		public KParts.PartManager Manager() {
			return (KParts.PartManager) interceptor.Invoke("manager", "manager() const", typeof(KParts.PartManager));
		}
		/// <remarks>
		///  By default, the widget is deleted by the part when the part is deleted.
		///  The hosting application can call setAutoDeleteWidget(false) to
		///  disable this behavior, given that the widget is usually deleted by
		///  its parent widget anyway.
		///  This is a method for the hosting application only, Part subclasses
		///  should never call this.
		///      </remarks>		<short>    By default, the widget is deleted by the part when the part is deleted.</short>
		public void SetAutoDeleteWidget(bool autoDeleteWidget) {
			interceptor.Invoke("setAutoDeleteWidget$", "setAutoDeleteWidget(bool)", typeof(void), typeof(bool), autoDeleteWidget);
		}
		/// <remarks>
		///  By default, the part deletes itself when its widget is deleted.
		///  The hosting application can call setAutoDeletePart(false) to
		///  disable this behavior, to be able to delete the widget and then the part,
		///  independently.
		///  This is a method for the hosting application only, Part subclasses
		///  should never call this.
		///      </remarks>		<short>    By default, the part deletes itself when its widget is deleted.</short>
		public void SetAutoDeletePart(bool autoDeletePart) {
			interceptor.Invoke("setAutoDeletePart$", "setAutoDeletePart(bool)", typeof(void), typeof(bool), autoDeletePart);
		}
		/// <remarks>
		///  Returns the part (this, or a child part) at the given global position.
		///  This is called by the part manager to ask whether a part should be activated
		///  when clicking somewhere. In most cases the default implementation is enough.
		///  Reimplement this if your part has child parts in some areas (like in khtml or koffice)
		/// <param> name="widget" the part widget being clicked - usually the same as widget(), except in koffice.
		/// </param><param> name="globalPos" the mouse coordinates in global coordinates
		///      </param></remarks>		<short>    Returns the part (this, or a child part) at the given global position.</short>
		[SmokeMethod("hitTest(QWidget*, const QPoint&)")]
		public virtual KParts.Part HitTest(QWidget widget, QPoint globalPos) {
			return (KParts.Part) interceptor.Invoke("hitTest##", "hitTest(QWidget*, const QPoint&)", typeof(KParts.Part), typeof(QWidget), widget, typeof(QPoint), globalPos);
		}
		/// <remarks>
		/// <param> name="selectable" Indicates whether the part is selectable or not.
		///      </param></remarks>		<short>   </short>
		[SmokeMethod("setSelectable(bool)")]
		public virtual void SetSelectable(bool selectable) {
			interceptor.Invoke("setSelectable$", "setSelectable(bool)", typeof(void), typeof(bool), selectable);
		}
		/// <remarks>
		///   Returns whether the part is selectable or not.
		///      </remarks>		<short>     Returns whether the part is selectable or not.</short>
		public bool IsSelectable() {
			return (bool) interceptor.Invoke("isSelectable", "isSelectable() const", typeof(bool));
		}
		/// <remarks>
		///  Use this icon loader to load any icons that are specific to this part,
		///  i.e. icons installed into this part's own directories as opposed to standard
		///  kde icons. Use KIcon("myicon", iconLoader()).
		///  Make sure to call setComponentData before calling iconLoader.
		///      </remarks>		<short>    Use this icon loader to load any icons that are specific to this part,  i.</short>
		public KIconLoader IconLoader() {
			return (KIconLoader) interceptor.Invoke("iconLoader", "iconLoader()", typeof(KIconLoader));
		}
		/// <remarks>
		///  Set the main widget.
		///  Call this in the Part-inherited class constructor.
		///      </remarks>		<short>    Set the main widget.</short>
		[SmokeMethod("setWidget(QWidget*)")]
		protected virtual void SetWidget(QWidget widget) {
			interceptor.Invoke("setWidget#", "setWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		/// <remarks>
		///      </remarks>		<short>   </short>
		[SmokeMethod("customEvent(QEvent*)")]
		protected override void CustomEvent(QEvent arg1) {
			interceptor.Invoke("customEvent#", "customEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		/// <remarks>
		///  Convenience method which is called when the Part received a PartActivateEvent .
		///  Reimplement this if you don't want to reimplement event and test for the event yourself
		///  or even install an event filter.
		///      </remarks>		<short>    Convenience method which is called when the Part received a PartActivateEvent .</short>
		[SmokeMethod("partActivateEvent(KParts::PartActivateEvent*)")]
		protected virtual void PartActivateEvent(KParts.PartActivateEvent arg1) {
			interceptor.Invoke("partActivateEvent#", "partActivateEvent(KParts::PartActivateEvent*)", typeof(void), typeof(KParts.PartActivateEvent), arg1);
		}
		/// <remarks>
		///  Convenience method which is called when the Part received a
		///  PartSelectEvent .
		///  Reimplement this if you don't want to reimplement event and
		///  test for the event yourself or even install an event filter.
		///      </remarks>		<short>    Convenience method which is called when the Part received a  PartSelectEvent .</short>
		[SmokeMethod("partSelectEvent(KParts::PartSelectEvent*)")]
		protected virtual void PartSelectEvent(KParts.PartSelectEvent arg1) {
			interceptor.Invoke("partSelectEvent#", "partSelectEvent(KParts::PartSelectEvent*)", typeof(void), typeof(KParts.PartSelectEvent), arg1);
		}
		/// <remarks>
		///  Convenience method which is called when the Part received a
		///  GUIActivateEvent .
		///  Reimplement this if you don't want to reimplement event and
		///  test for the event yourself or even install an event filter.
		///      </remarks>		<short>    Convenience method which is called when the Part received a  GUIActivateEvent .</short>
		[SmokeMethod("guiActivateEvent(KParts::GUIActivateEvent*)")]
		protected virtual void GuiActivateEvent(KParts.GUIActivateEvent arg1) {
			interceptor.Invoke("guiActivateEvent#", "guiActivateEvent(KParts::GUIActivateEvent*)", typeof(void), typeof(KParts.GUIActivateEvent), arg1);
		}
		/// <remarks>
		///  Convenience method for KXMLGUIFactory.Container.
		/// </remarks>		<return> a container widget owned by the Part's GUI.
		///      </return>
		/// 		<short>    Convenience method for KXMLGUIFactory.Container.</short>
		protected QWidget HostContainer(string containerName) {
			return (QWidget) interceptor.Invoke("hostContainer$", "hostContainer(const QString&)", typeof(QWidget), typeof(string), containerName);
		}
		/// <remarks>
		///      </remarks>		<short>   </short>
		[Q_SLOT("void slotWidgetDestroyed()")]
		protected void SlotWidgetDestroyed() {
			interceptor.Invoke("slotWidgetDestroyed", "slotWidgetDestroyed()", typeof(void));
		}
		~Part() {
			interceptor.Invoke("~Part", "~Part()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Part", "~Part()", typeof(void));
		}
		/// <remarks>
		///   Internal method. Called by KParts.Part to specify the parent object for plugin objects.
		///    </remarks>		<short>     Internal method.</short>
		public void SetPartObject(QObject arg1) {
			interceptor.Invoke("setPartObject#", "setPartObject(QObject*)", typeof(void), typeof(QObject), arg1);
		}
		public QObject PartObject() {
			return (QObject) interceptor.Invoke("partObject", "partObject() const", typeof(QObject));
		}
		/// <remarks>
		///  Set the componentData(KComponentData) for this part.
		///  Call this first in the inherited class constructor,
		///  because it loads the i18n catalogs.
		///    </remarks>		<short>    Set the componentData(KComponentData) for this part.</short>
		[SmokeMethod("setComponentData(const KComponentData&)")]
		protected virtual void SetComponentData(KComponentData componentData) {
			interceptor.Invoke("setComponentData#", "setComponentData(const KComponentData&)", typeof(void), typeof(KComponentData), componentData);
		}
		/// <remarks>
		///  Set the componentData(KComponentData) for this part.
		///  Call this first in the inherited class constructor,
		///  because it loads the i18n catalogs.
		///    </remarks>		<short>    Set the componentData(KComponentData) for this part.</short>
		[SmokeMethod("setComponentData(const KComponentData&, bool)")]
		protected virtual void SetComponentData(KComponentData componentData, bool loadPlugins) {
			interceptor.Invoke("setComponentData#$", "setComponentData(const KComponentData&, bool)", typeof(void), typeof(KComponentData), componentData, typeof(bool), loadPlugins);
		}
		/// <remarks>
		///  Load the Plugins honoring the PluginLoadingMode.
		///  If you call this method in an already constructed GUI (like when the user
		///  has changed which plugins are enabled) you need to add the new plugins to
		///  the KXMLGUIFactory:
		///  <pre>
		///  if( factory() )
		///  {
		///    QList<KParts.Plugin > plugins = KParts.Plugin.PluginObjects( this );
		///    for(int i = 0; i != plugins.size(); ++i) {
		///       factory().AddClient( plugins[i] );
		///    }
		///  }
		///  </pre>
		///    </remarks>		<short>    Load the Plugins honoring the PluginLoadingMode.</short>
		protected void LoadPlugins(QObject parent, KXMLGUIClient parentGUIClient, KComponentData componentData) {
			interceptor.Invoke("loadPlugins###", "loadPlugins(QObject*, KXMLGUIClient*, const KComponentData&)", typeof(void), typeof(QObject), parent, typeof(KXMLGUIClient), parentGUIClient, typeof(KComponentData), componentData);
		}
		/// <remarks>
		///  Set how plugins should be loaded
		/// <param> name="loadingMode" see PluginLoadingMode
		/// </param> For a KParts.Part: call this before setComponentData.
		///  For a KParts.MainWindow: call this before createGUI.
		///    </remarks>		<short>    Set how plugins should be loaded </short>
		/// <remarks>
		///  If you change the binary interface offered by your part, you can avoid crashes
		///  from old plugins lying around by setting X-KDE-InterfaceVersion=2 in the
		///  .desktop files of the plugins, and calling setPluginInterfaceVersion( 2 ), so that
		///  the old plugins are not loaded. Increase both numbers every time a
		///  binary incompatible change in the application's plugin interface is made.
		/// <param> name="version" the interface version that plugins must have in order to be loaded.
		/// </param> For a KParts.Part: call this before setComponentData.
		///  For a KParts.MainWindow: call this before createGUI.
		///    </remarks>		<short>    If you change the binary interface offered by your part, you can avoid crashes  from old plugins lying around by setting X-KDE-InterfaceVersion=2 in the  .</short>
		protected void SetPluginInterfaceVersion(int version) {
			interceptor.Invoke("setPluginInterfaceVersion$", "setPluginInterfaceVersion(int)", typeof(void), typeof(int), version);
		}
		protected new IPartSignals Emit {
			get { return (IPartSignals) Q_EMIT; }
		}
	}

	public interface IPartSignals : IQObjectSignals {
		/// <remarks>
		///  Emitted by the part, to set the caption of the window(s)
		///  hosting this part
		///      </remarks>		<short>    Emitted by the part, to set the caption of the window(s)  hosting this part      </short>
		[Q_SIGNAL("void setWindowCaption(const QString&)")]
		void SetWindowCaption(string caption);
		/// <remarks>
		///  Emited by the part, to set a text in the statusbar of the window(s)
		///  hosting this part
		///      </remarks>		<short>    Emited by the part, to set a text in the statusbar of the window(s)  hosting this part      </short>
		[Q_SIGNAL("void setStatusBarText(const QString&)")]
		void SetStatusBarText(string text);
	}
	}
}