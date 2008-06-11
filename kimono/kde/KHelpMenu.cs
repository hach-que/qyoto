//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  This class provides the standard %KDE help menu with the default "about"
	///  dialog boxes and help entry.
	///  This class is used in KMainWindow so
	///  normally you don't need to use this class yourself. However, if you
	///  need the help menu or any of its dialog boxes in your code that is
	///  not subclassed from KMainWindow you should use this class.
	///  The usage is simple:
	///  <pre>
	///  mHelpMenu = new KHelpMenu( this, <someText> );
	///  kmenubar.AddMenu(mHelpMenu.Menu() );
	///  </pre>
	///  or if you just want to open a dialog box:
	///  <pre>
	///  mHelpMenu = new KHelpMenu( this, <someText> );
	///  connect( this, SIGNAL("someSignal()"), mHelpMenu,SLOT("aboutKDE()"));
	///  </pre>
	///  IMPORTANT:
	///  The first time you use KHelpMenu.Menu(), a KMenu object is
	///  allocated. Only one object is created by the class so if you call
	///  KHelpMenu.Menu() twice or more, the same pointer is returned. The class
	///  will destroy the popupmenu in the destructor so do not delete this
	///  pointer yourself.
	///  The KHelpMenu object will be deleted when its parent is destroyed but you
	///  can delete it yourself if you want. The code below will always work.
	///  <pre>
	///  MyClass.~MyClass()
	///  {
	///    delete mHelpMenu;
	///  }
	///  </pre>
	///  Using your own "about application" dialog box:
	///  The standard "about application" dialog box is quite simple. If you
	///  need a dialog box with more functionality you must design that one
	///  yourself. When you want to display the dialog, you simply need to
	///  connect the help menu signal showAboutApplication() to your slot.
	///  <pre>
	///  void MyClass.MyFunc()
	///  {
	///    ..
	///    KHelpMenu helpMenu = new KHelpMenu( this );
	///    connect( helpMenu, SIGNAL("showAboutApplication()"),
	///           this, SLOT("myDialogSlot()"));
	///    ..
	///  }
	///  void MyClass.MyDialogSlot()
	///  {
	///    <activate your custom dialog>
	///  }
	///  </pre>
	///  See <see cref="IKHelpMenuSignals"></see> for signals emitted by KHelpMenu
	/// </remarks>		<author> Espen Sand (espen@kde.org)
	///  </author>
	/// 		<short> Standard %KDE help menu with dialog boxes. </short>

	[SmokeClass("KHelpMenu")]
	public class KHelpMenu : QObject, IDisposable {
 		protected KHelpMenu(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KHelpMenu), this);
		}
		public enum MenuId {
			menuHelpContents = 0,
			menuWhatsThis = 1,
			menuAboutApp = 2,
			menuAboutKDE = 3,
			menuReportBug = 4,
			menuSwitchLanguage = 5,
		}
		/// <remarks>
		///  Constructor.
		/// <param> name="parent" The parent of the dialog boxes. The boxes are modeless
		///         and will be centered with respect to the parent.
		/// </param><param> name="aboutAppText" User definable string that is used in the
		///         default application dialog box.
		/// </param><param> name="showWhatsThis" Decides whether a "Whats this" entry will be
		///         added to the dialog.
		/// </param>     </remarks>		<short>    Constructor.</short>
		public KHelpMenu(QWidget parent, string aboutAppText, bool showWhatsThis) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KHelpMenu#$$", "KHelpMenu(QWidget*, const QString&, bool)", typeof(void), typeof(QWidget), parent, typeof(string), aboutAppText, typeof(bool), showWhatsThis);
		}
		public KHelpMenu(QWidget parent, string aboutAppText) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KHelpMenu#$", "KHelpMenu(QWidget*, const QString&)", typeof(void), typeof(QWidget), parent, typeof(string), aboutAppText);
		}
		public KHelpMenu(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KHelpMenu#", "KHelpMenu(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KHelpMenu() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KHelpMenu", "KHelpMenu()", typeof(void));
		}
		/// <remarks>
		///  Constructor.
		///  This alternative constructor is mainly useful if you want to
		///  overide the standard actions (aboutApplication(), aboutKDE(),
		///  helpContents(), reportBug, and optionally whatsThis).
		/// <param> name="parent" The parent of the dialog boxes. The boxes are modeless
		///         and will be centered with respect to the parent.
		/// </param><param> name="aboutData" User and app data used in the About app dialog
		/// </param><param> name="showWhatsThis" Decides whether a "Whats this" entry will be
		///         added to the dialog.
		/// </param><param> name="actions" KActionCollection that is used instead of the
		///         standard actions.
		/// </param>     </remarks>		<short>    Constructor.</short>
		public KHelpMenu(QWidget parent, KAboutData aboutData, bool showWhatsThis, KActionCollection actions) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KHelpMenu##$#", "KHelpMenu(QWidget*, const KAboutData*, bool, KActionCollection*)", typeof(void), typeof(QWidget), parent, typeof(KAboutData), aboutData, typeof(bool), showWhatsThis, typeof(KActionCollection), actions);
		}
		public KHelpMenu(QWidget parent, KAboutData aboutData, bool showWhatsThis) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KHelpMenu##$", "KHelpMenu(QWidget*, const KAboutData*, bool)", typeof(void), typeof(QWidget), parent, typeof(KAboutData), aboutData, typeof(bool), showWhatsThis);
		}
		public KHelpMenu(QWidget parent, KAboutData aboutData) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KHelpMenu##", "KHelpMenu(QWidget*, const KAboutData*)", typeof(void), typeof(QWidget), parent, typeof(KAboutData), aboutData);
		}
		/// <remarks>
		///  Returns a popup menu you can use in the menu bar or where you
		///  need it.
		///  The returned menu is configured with an icon, a title and
		///  menu entries. Therefore adding the returned pointer to your menu
		///  is enougth to have access to the help menu.
		///  Note: This method will only create one instance of the menu. If
		///  you call this method twice or more the same pointer is returned.
		///      </remarks>		<short>    Returns a popup menu you can use in the menu bar or where you  need it.</short>
		public KMenu Menu() {
			return (KMenu) interceptor.Invoke("menu", "menu()", typeof(KMenu));
		}
		/// <remarks>
		///  Returns the QAction  associated with the given parameter
		///  Will return NULL pointers if menu() has not been called
		/// <param> name="id" The id of the action of which you want to get QAction  
		///      </param></remarks>		<short>    Returns the QAction   associated with the given parameter  Will return NULL pointers if menu() has not been called </short>
		public QAction Action(KHelpMenu.MenuId id) {
			return (QAction) interceptor.Invoke("action$", "action(KHelpMenu::MenuId) const", typeof(QAction), typeof(KHelpMenu.MenuId), id);
		}
		/// <remarks>
		///  Opens the help page for the application. The application name is
		///  used as a key to determine what to display and the system will attempt
		///  to open \<appName\>/index.html.
		///      </remarks>		<short>    Opens the help page for the application.</short>
		[Q_SLOT("void appHelpActivated()")]
		public void AppHelpActivated() {
			interceptor.Invoke("appHelpActivated", "appHelpActivated()", typeof(void));
		}
		/// <remarks>
		///  Activates What's This help for the application.
		///      </remarks>		<short>    Activates What's This help for the application.</short>
		[Q_SLOT("void contextHelpActivated()")]
		public void ContextHelpActivated() {
			interceptor.Invoke("contextHelpActivated", "contextHelpActivated()", typeof(void));
		}
		/// <remarks>
		///  Opens an application specific dialog box.
		///  The method will try to open the about box using the following steps:
		///  - If the showAboutApplication() signal is connected, then it will be called.
		///    This means there is an application defined aboutBox.
		///  - If the aboutData was set in the constructor a KAboutApplicationDialog will be created.
		///  - Else a default about box using the aboutAppText from the constructor will be created.
		///      </remarks>		<short>    Opens an application specific dialog box.</short>
		[Q_SLOT("void aboutApplication()")]
		public void AboutApplication() {
			interceptor.Invoke("aboutApplication", "aboutApplication()", typeof(void));
		}
		/// <remarks>
		///  Opens the standard "About KDE" dialog box.
		///      </remarks>		<short>    Opens the standard "About KDE" dialog box.</short>
		[Q_SLOT("void aboutKDE()")]
		public void AboutKDE() {
			interceptor.Invoke("aboutKDE", "aboutKDE()", typeof(void));
		}
		/// <remarks>
		///  Opens the standard "Report Bugs" dialog box.
		///      </remarks>		<short>    Opens the standard "Report Bugs" dialog box.</short>
		[Q_SLOT("void reportBug()")]
		public void ReportBug() {
			interceptor.Invoke("reportBug", "reportBug()", typeof(void));
		}
		/// <remarks>
		///  Opens the changing default application language dialog box.
		///      </remarks>		<short>    Opens the changing default application language dialog box.</short>
		[Q_SLOT("void switchApplicationLanguage()")]
		public void SwitchApplicationLanguage() {
			interceptor.Invoke("switchApplicationLanguage", "switchApplicationLanguage()", typeof(void));
		}
		~KHelpMenu() {
			interceptor.Invoke("~KHelpMenu", "~KHelpMenu()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KHelpMenu", "~KHelpMenu()", typeof(void));
		}
		protected new IKHelpMenuSignals Emit {
			get { return (IKHelpMenuSignals) Q_EMIT; }
		}
	}

	public interface IKHelpMenuSignals : IQObjectSignals {
		/// <remarks>
		///  This signal is emitted from aboutApplication() if no
		///  "about application" string has been defined. The standard
		///  application specific dialog box that is normally activated in
		///  aboutApplication() will not be displayed when this signal
		///  is emitted.
		///      </remarks>		<short>    This signal is emitted from aboutApplication() if no  "about application" string has been defined.</short>
		[Q_SIGNAL("void showAboutApplication()")]
		void ShowAboutApplication();
	}
}
