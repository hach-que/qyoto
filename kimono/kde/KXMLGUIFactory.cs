//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  KXMLGUIFactory, together with KXMLGUIClient objects, can be used to create
	///  a GUI of container widgets (like menus, toolbars, etc.) and container items
	///  (menu items, toolbar buttons, etc.) from an XML document and action objects.
	///  Each KXMLGUIClient represents a part of the GUI, composed from containers and
	///  actions. KXMLGUIFactory takes care of building (with the help of a KXMLGUIBuilder)
	///  and merging the GUI from an unlimited number of clients.
	///  Each client provides XML through a QDomDocument and actions through a
	///  KActionCollection . The XML document contains the rules for how to merge the
	///  GUI.
	///  KXMLGUIFactory processes the DOM tree provided by a client and plugs in the client's actions,
	///  according to the XML and the merging rules of previously inserted clients. Container widgets
	///  are built via a KXMLGUIBuilder , which has to be provided with the KXMLGUIFactory constructor.
	///   See <see cref="IKXMLGUIFactorySignals"></see> for signals emitted by KXMLGUIFactory
	/// </remarks>		<short>    KXMLGUIFactory, together with KXMLGUIClient objects, can be used to create  a GUI of container widgets (like menus, toolbars, etc.</short>

	[SmokeClass("KXMLGUIFactory")]
	public class KXMLGUIFactory : QObject, IDisposable {
 		protected KXMLGUIFactory(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KXMLGUIFactory), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KXMLGUIFactory() {
			staticInterceptor = new SmokeInvocation(typeof(KXMLGUIFactory), null);
		}
		// QList<KXMLGUIClient*> clients(); >>>> NOT CONVERTED
		/// <remarks>
		///  Constructs a KXMLGUIFactory. The provided <code>builder</code> KXMLGUIBuilder will be called
		///  for creating and removing container widgets, when clients are added/removed from the GUI.
		///  Note that the ownership of the given KXMLGUIBuilder object won't be transferred to this
		///  KXMLGUIFactory, so you have to take care of deleting it properly.
		///    </remarks>		<short>    Constructs a KXMLGUIFactory.</short>
		public KXMLGUIFactory(KXMLGUIBuilder builder, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KXMLGUIFactory##", "KXMLGUIFactory(KXMLGUIBuilder*, QObject*)", typeof(void), typeof(KXMLGUIBuilder), builder, typeof(QObject), parent);
		}
		public KXMLGUIFactory(KXMLGUIBuilder builder) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KXMLGUIFactory#", "KXMLGUIFactory(KXMLGUIBuilder*)", typeof(void), typeof(KXMLGUIBuilder), builder);
		}
		/// <remarks>
		///  Creates the GUI described by the QDomDocument of the client,
		///  using the client's actions, and merges it with the previously
		///  created GUI.
		///  This also means that the order in which clients are added to the factory
		///  is relevant; assuming that your application supports plugins, you should
		///  first add your application to the factory and then the plugin, so that the
		///  plugin's UI is merged into the UI of your application, and not the other
		///  way round.
		///    </remarks>		<short>    Creates the GUI described by the QDomDocument of the client,  using the client's actions, and merges it with the previously  created GUI.</short>
		public void AddClient(KXMLGUIClient client) {
			interceptor.Invoke("addClient#", "addClient(KXMLGUIClient*)", typeof(void), typeof(KXMLGUIClient), client);
		}
		/// <remarks>
		///  Removes the GUI described by the client, by unplugging all
		///  provided actions and removing all owned containers (and storing
		///  container state information in the given client)
		///    </remarks>		<short>    Removes the GUI described by the client, by unplugging all  provided actions and removing all owned containers (and storing  container state information in the given client)    </short>
		public void RemoveClient(KXMLGUIClient client) {
			interceptor.Invoke("removeClient#", "removeClient(KXMLGUIClient*)", typeof(void), typeof(KXMLGUIClient), client);
		}
		public void PlugActionList(KXMLGUIClient client, string name, List<QAction> actionList) {
			interceptor.Invoke("plugActionList#$?", "plugActionList(KXMLGUIClient*, const QString&, const QList<QAction*>&)", typeof(void), typeof(KXMLGUIClient), client, typeof(string), name, typeof(List<QAction>), actionList);
		}
		public void UnplugActionList(KXMLGUIClient client, string name) {
			interceptor.Invoke("unplugActionList#$", "unplugActionList(KXMLGUIClient*, const QString&)", typeof(void), typeof(KXMLGUIClient), client, typeof(string), name);
		}
		/// <remarks>
		///  Returns a list of all clients currently added to this factory
		///    </remarks>		<short>    Returns a list of all clients currently added to this factory    </short>
		/// <remarks>
		///  Use this method to get access to a container widget with the name specified with <code>containerName</code>
		///  and which is owned by the <code>client.</code> The container name is specified with a "name" attribute in the
		///  XML document.
		///  This function is particularly useful for getting hold of a popupmenu defined in an XMLUI file.
		///  For instance:
		///  <pre>
		///  QMenu popup = (QMenu)(guiFactory().Container("my_popup",this));
		///  </pre>
		///  where <code></code>"my_popup" is the name of the menu in the XMLUI file, and
		///  <code></code>"this" is XMLGUIClient which owns the popupmenu (e.g. the mainwindow, or the part, or the plugin...)
		/// <param> name="containerName" Name of the container widget
		/// </param><param> name="client" Owner of the container widget
		/// </param><param> name="useTagName" Specifies whether to compare the specified name with the name attribute or
		///         the tag name.
		/// </param> This method may return null if no container with the given name exists or is not owned by the client.
		///    </remarks>		<short>    Use this method to get access to a container widget with the name specified with <code>containerName</code>  and which is owned by the <code>client.</code></short>
		public QWidget Container(string containerName, KXMLGUIClient client, bool useTagName) {
			return (QWidget) interceptor.Invoke("container$#$", "container(const QString&, KXMLGUIClient*, bool)", typeof(QWidget), typeof(string), containerName, typeof(KXMLGUIClient), client, typeof(bool), useTagName);
		}
		public QWidget Container(string containerName, KXMLGUIClient client) {
			return (QWidget) interceptor.Invoke("container$#", "container(const QString&, KXMLGUIClient*)", typeof(QWidget), typeof(string), containerName, typeof(KXMLGUIClient), client);
		}
		public List<QWidget> Containers(string tagName) {
			return (List<QWidget>) interceptor.Invoke("containers$", "containers(const QString&)", typeof(List<QWidget>), typeof(string), tagName);
		}
		/// <remarks>
		///  Use this method to free all memory allocated by the KXMLGUIFactory. This deletes the internal node
		///  tree and therefore resets the internal state of the class. Please note that the actual GUI is
		///  NOT touched at all, meaning no containers are deleted nor any actions unplugged. That is
		///  something you have to do on your own. So use this method only if you know what you are doing :-)
		///  (also note that this will call KXMLGUIClient.SetFactory( null ) for all inserted clients)
		///    </remarks>		<short>    Use this method to free all memory allocated by the KXMLGUIFactory.</short>
		public void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		/// <remarks>
		///  Use this method to free all memory allocated by the KXMLGUIFactory for a specific container,
		///  including all child containers and actions. This deletes the internal node subtree for the
		///  specified container. The actual GUI is not touched, no containers are deleted or any actions
		///  unplugged. Use this method only if you know what you are doing :-)
		///  (also note that this will call KXMLGUIClient.SetFactory( null ) for all clients of the
		///  container)
		///    </remarks>		<short>    Use this method to free all memory allocated by the KXMLGUIFactory for a specific container,  including all child containers and actions.</short>
		public void ResetContainer(string containerName, bool useTagName) {
			interceptor.Invoke("resetContainer$$", "resetContainer(const QString&, bool)", typeof(void), typeof(string), containerName, typeof(bool), useTagName);
		}
		public void ResetContainer(string containerName) {
			interceptor.Invoke("resetContainer$", "resetContainer(const QString&)", typeof(void), typeof(string), containerName);
		}
		/// <remarks>
		///  Show a standard configure shortcut for every action in this factory.
		///  This slot can be connected directly to the action to configure shortcuts. This is very simple to
		///  do that by adding a single line
		///  <pre>
		///  KStdAction.KeyBindings( guiFactory(), SLOT("configureShortcuts()"), actionCollection() );
		///  </pre>
		/// <param> name="bAllowLetterShortcuts" Set to false if unmodified alphanumeric
		///       keys ('A', '1', etc.) are not permissible shortcuts.
		/// </param><param> name="bSaveSettings" if true, the settings will also be saved back to
		///       the uirc file which they were intially read from.
		///    </param></remarks>		<short>    Show a standard configure shortcut for every action in this factory.</short>
		[Q_SLOT("int configureShortcuts(bool, bool)")]
		public int ConfigureShortcuts(bool bAllowLetterShortcuts, bool bSaveSettings) {
			return (int) interceptor.Invoke("configureShortcuts$$", "configureShortcuts(bool, bool)", typeof(int), typeof(bool), bAllowLetterShortcuts, typeof(bool), bSaveSettings);
		}
		[Q_SLOT("int configureShortcuts(bool)")]
		public int ConfigureShortcuts(bool bAllowLetterShortcuts) {
			return (int) interceptor.Invoke("configureShortcuts$", "configureShortcuts(bool)", typeof(int), typeof(bool), bAllowLetterShortcuts);
		}
		[Q_SLOT("int configureShortcuts()")]
		public int ConfigureShortcuts() {
			return (int) interceptor.Invoke("configureShortcuts", "configureShortcuts()", typeof(int));
		}
		~KXMLGUIFactory() {
			interceptor.Invoke("~KXMLGUIFactory", "~KXMLGUIFactory()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KXMLGUIFactory", "~KXMLGUIFactory()", typeof(void));
		}
		public static string ReadConfigFile(string filename, bool never_null, KComponentData componentData) {
			return (string) staticInterceptor.Invoke("readConfigFile$$#", "readConfigFile(const QString&, bool, const KComponentData&)", typeof(string), typeof(string), filename, typeof(bool), never_null, typeof(KComponentData), componentData);
		}
		public static string ReadConfigFile(string filename, bool never_null) {
			return (string) staticInterceptor.Invoke("readConfigFile$$", "readConfigFile(const QString&, bool)", typeof(string), typeof(string), filename, typeof(bool), never_null);
		}
		public static string ReadConfigFile(string filename, KComponentData componentData) {
			return (string) staticInterceptor.Invoke("readConfigFile$#", "readConfigFile(const QString&, const KComponentData&)", typeof(string), typeof(string), filename, typeof(KComponentData), componentData);
		}
		public static string ReadConfigFile(string filename) {
			return (string) staticInterceptor.Invoke("readConfigFile$", "readConfigFile(const QString&)", typeof(string), typeof(string), filename);
		}
		public static bool SaveConfigFile(QDomDocument doc, string filename, KComponentData componentData) {
			return (bool) staticInterceptor.Invoke("saveConfigFile#$#", "saveConfigFile(const QDomDocument&, const QString&, const KComponentData&)", typeof(bool), typeof(QDomDocument), doc, typeof(string), filename, typeof(KComponentData), componentData);
		}
		public static bool SaveConfigFile(QDomDocument doc, string filename) {
			return (bool) staticInterceptor.Invoke("saveConfigFile#$", "saveConfigFile(const QDomDocument&, const QString&)", typeof(bool), typeof(QDomDocument), doc, typeof(string), filename);
		}
		public static string DocumentToXML(QDomDocument doc) {
			return (string) staticInterceptor.Invoke("documentToXML#", "documentToXML(const QDomDocument&)", typeof(string), typeof(QDomDocument), doc);
		}
		public static string ElementToXML(QDomElement elem) {
			return (string) staticInterceptor.Invoke("elementToXML#", "elementToXML(const QDomElement&)", typeof(string), typeof(QDomElement), elem);
		}
		/// <remarks>
		///  Removes all QDomComment objects from the specified node and all its children.
		///    </remarks>		<short>    Removes all QDomComment objects from the specified node and all its children.</short>
		public static void RemoveDOMComments(QDomNode node) {
			staticInterceptor.Invoke("removeDOMComments#", "removeDOMComments(QDomNode&)", typeof(void), typeof(QDomNode), node);
		}
		/// <remarks>
		///  Find or create the ActionProperties element, used when saving custom action properties
		///    </remarks>		<short>   </short>
		public static QDomElement ActionPropertiesElement(QDomDocument doc) {
			return (QDomElement) staticInterceptor.Invoke("actionPropertiesElement#", "actionPropertiesElement(QDomDocument&)", typeof(QDomElement), typeof(QDomDocument), doc);
		}
		/// <remarks>
		///  Find or create the element for a given action, by name.
		///  Used when saving custom action properties
		///    </remarks>		<short>   </short>
		public static QDomElement FindActionByName(QDomElement elem, string sName, bool create) {
			return (QDomElement) staticInterceptor.Invoke("findActionByName#$$", "findActionByName(QDomElement&, const QString&, bool)", typeof(QDomElement), typeof(QDomElement), elem, typeof(string), sName, typeof(bool), create);
		}
		protected new IKXMLGUIFactorySignals Emit {
			get { return (IKXMLGUIFactorySignals) Q_EMIT; }
		}
	}

	public interface IKXMLGUIFactorySignals : IQObjectSignals {
		[Q_SIGNAL("void clientAdded(KXMLGUIClient*)")]
		void ClientAdded(KXMLGUIClient client);
		[Q_SIGNAL("void clientRemoved(KXMLGUIClient*)")]
		void ClientRemoved(KXMLGUIClient client);
	}
}