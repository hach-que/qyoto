//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QMessageBox")]
	public class QMessageBox : QDialog, IDisposable {
 		protected QMessageBox(Type dummy) : base((Type) null) {}
		[SmokeClass("QMessageBox")]
		interface IQMessageBoxProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, StandardButtons, QMessageBox::StandardButton)", "#$$$$")]
			QMessageBox.StandardButton Information(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, StandardButtons)", "#$$$")]
			QMessageBox.StandardButton Information(QWidget parent, string title, string text, int buttons);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&)", "#$$")]
			QMessageBox.StandardButton Information(QWidget parent, string title, string text);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, StandardButtons, QMessageBox::StandardButton)", "#$$$$")]
			QMessageBox.StandardButton Question(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, StandardButtons)", "#$$$")]
			QMessageBox.StandardButton Question(QWidget parent, string title, string text, int buttons);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&)", "#$$")]
			QMessageBox.StandardButton Question(QWidget parent, string title, string text);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, StandardButtons, QMessageBox::StandardButton)", "#$$$$")]
			QMessageBox.StandardButton Warning(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, StandardButtons)", "#$$$")]
			QMessageBox.StandardButton Warning(QWidget parent, string title, string text, int buttons);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&)", "#$$")]
			QMessageBox.StandardButton Warning(QWidget parent, string title, string text);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, StandardButtons, QMessageBox::StandardButton)", "#$$$$")]
			QMessageBox.StandardButton Critical(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, StandardButtons)", "#$$$")]
			QMessageBox.StandardButton Critical(QWidget parent, string title, string text, int buttons);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&)", "#$$")]
			QMessageBox.StandardButton Critical(QWidget parent, string title, string text);
			[SmokeMethod("about", "(QWidget*, const QString&, const QString&)", "#$$")]
			void About(QWidget parent, string title, string text);
			[SmokeMethod("aboutQt", "(QWidget*, const QString&)", "#$")]
			void AboutQt(QWidget parent, string title);
			[SmokeMethod("aboutQt", "(QWidget*)", "#")]
			void AboutQt(QWidget parent);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, int, int, int)", "#$$$$$")]
			int Information(QWidget parent, string title, string text, int button0, int button1, int button2);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, int, int)", "#$$$$")]
			int Information(QWidget parent, string title, string text, int button0, int button1);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)", "#$$$$$$$")]
			int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)", "#$$$$$$")]
			int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)", "#$$$$$")]
			int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, const QString&, const QString&)", "#$$$$")]
			int Information(QWidget parent, string title, string text, string button0Text, string button1Text);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, const QString&)", "#$$$")]
			int Information(QWidget parent, string title, string text, string button0Text);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, QMessageBox::StandardButton, QMessageBox::StandardButton)", "#$$$$")]
			QMessageBox.StandardButton Information(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1);
			[SmokeMethod("information", "(QWidget*, const QString&, const QString&, QMessageBox::StandardButton)", "#$$$")]
			QMessageBox.StandardButton Information(QWidget parent, string title, string text, QMessageBox.StandardButton button0);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, int, int, int)", "#$$$$$")]
			int Question(QWidget parent, string title, string text, int button0, int button1, int button2);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, int, int)", "#$$$$")]
			int Question(QWidget parent, string title, string text, int button0, int button1);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)", "#$$$$$$$")]
			int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)", "#$$$$$$")]
			int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)", "#$$$$$")]
			int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, const QString&, const QString&)", "#$$$$")]
			int Question(QWidget parent, string title, string text, string button0Text, string button1Text);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, const QString&)", "#$$$")]
			int Question(QWidget parent, string title, string text, string button0Text);
			[SmokeMethod("question", "(QWidget*, const QString&, const QString&, QMessageBox::StandardButton, QMessageBox::StandardButton)", "#$$$$")]
			int Question(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, int, int, int)", "#$$$$$")]
			int Warning(QWidget parent, string title, string text, int button0, int button1, int button2);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, int, int)", "#$$$$")]
			int Warning(QWidget parent, string title, string text, int button0, int button1);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)", "#$$$$$$$")]
			int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)", "#$$$$$$")]
			int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)", "#$$$$$")]
			int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, const QString&, const QString&)", "#$$$$")]
			int Warning(QWidget parent, string title, string text, string button0Text, string button1Text);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, const QString&)", "#$$$")]
			int Warning(QWidget parent, string title, string text, string button0Text);
			[SmokeMethod("warning", "(QWidget*, const QString&, const QString&, QMessageBox::StandardButton, QMessageBox::StandardButton)", "#$$$$")]
			int Warning(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, int, int, int)", "#$$$$$")]
			int Critical(QWidget parent, string title, string text, int button0, int button1, int button2);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, int, int)", "#$$$$")]
			int Critical(QWidget parent, string title, string text, int button0, int button1);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)", "#$$$$$$$")]
			int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)", "#$$$$$$")]
			int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)", "#$$$$$")]
			int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, const QString&, const QString&)", "#$$$$")]
			int Critical(QWidget parent, string title, string text, string button0Text, string button1Text);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, const QString&)", "#$$$")]
			int Critical(QWidget parent, string title, string text, string button0Text);
			[SmokeMethod("critical", "(QWidget*, const QString&, const QString&, QMessageBox::StandardButton, QMessageBox::StandardButton)", "#$$$$")]
			int Critical(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1);
			[SmokeMethod("standardIcon", "(QMessageBox::Icon)", "$")]
			QPixmap StandardIcon(QMessageBox.Icon icon);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMessageBox), this);
			interceptor = (QMessageBox) realProxy.GetTransparentProxy();
		}
		private static IQMessageBoxProxy staticInterceptor = null;
		static QMessageBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMessageBoxProxy), null);
			staticInterceptor = (IQMessageBoxProxy) realProxy.GetTransparentProxy();
		}
		public enum Icon {
			NoIcon = 0,
			Information = 1,
			Warning = 2,
			Critical = 3,
			Question = 4,
		}
		public enum ButtonRole {
			InvalidRole = -1,
			AcceptRole = 0,
			RejectRole = 1,
			DestructiveRole = 2,
			ActionRole = 3,
			HelpRole = 4,
			YesRole = 5,
			NoRole = 6,
			ResetRole = 7,
			ApplyRole = 8,
			NRoles = 9,
		}
		public enum StandardButton {
			NoButton = 0x00000000,
			Ok = 0x00000400,
			Save = 0x00000800,
			SaveAll = 0x00001000,
			Open = 0x00002000,
			Yes = 0x00004000,
			YesToAll = 0x00008000,
			No = 0x00010000,
			NoToAll = 0x00020000,
			Abort = 0x00040000,
			Retry = 0x00080000,
			Ignore = 0x00100000,
			Close = 0x00200000,
			Cancel = 0x00400000,
			Discard = 0x00800000,
			Help = 0x01000000,
			Apply = 0x02000000,
			Reset = 0x04000000,
			RestoreDefaults = 0x08000000,
			FirstButton = Ok,
			LastButton = RestoreDefaults,
			YesAll = YesToAll,
			NoAll = NoToAll,
			Default = 0x00000100,
			Escape = 0x00000200,
			FlagMask = 0x00000300,
			ButtonMask = ~FlagMask,
		}
		[Q_PROPERTY("QString", "text")]
		public string Text {
			get { return Property("text").Value<string>(); }
			set { SetProperty("text", QVariant.FromValue<string>(value)); }
		}
		[Q_PROPERTY("QMessageBox::Icon", "icon")]
		public QMessageBox.Icon icon {
			get { return Property("icon").Value<QMessageBox.Icon>(); }
			set { SetProperty("icon", QVariant.FromValue<QMessageBox.Icon>(value)); }
		}
		[Q_PROPERTY("QPixmap", "iconPixmap")]
		public QPixmap IconPixmap {
			get { return Property("iconPixmap").Value<QPixmap>(); }
			set { SetProperty("iconPixmap", QVariant.FromValue<QPixmap>(value)); }
		}
		[Q_PROPERTY("Qt::TextFormat", "textFormat")]
		public Qt.TextFormat TextFormat {
			get { return Property("textFormat").Value<Qt.TextFormat>(); }
			set { SetProperty("textFormat", QVariant.FromValue<Qt.TextFormat>(value)); }
		}
		[Q_PROPERTY("StandardButtons", "standardButtons")]
		public int StandardButtons {
			get { return Property("standardButtons").Value<int>(); }
			set { SetProperty("standardButtons", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("QString", "detailedText")]
		public string DetailedText {
			get { return Property("detailedText").Value<string>(); }
			set { SetProperty("detailedText", QVariant.FromValue<string>(value)); }
		}
		[Q_PROPERTY("QString", "informativeText")]
		public string InformativeText {
			get { return Property("informativeText").Value<string>(); }
			set { SetProperty("informativeText", QVariant.FromValue<string>(value)); }
		}
		public QMessageBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(parent);
		}
		[SmokeMethod("QMessageBox", "(QWidget*)", "#")]
		private void NewQMessageBox(QWidget parent) {
			((QMessageBox) interceptor).NewQMessageBox(parent);
		}
		public QMessageBox() : this((Type) null) {
			CreateProxy();
			NewQMessageBox();
		}
		[SmokeMethod("QMessageBox", "()", "")]
		private void NewQMessageBox() {
			((QMessageBox) interceptor).NewQMessageBox();
		}
		public QMessageBox(QMessageBox.Icon icon, string title, string text, int buttons, QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(icon,title,text,buttons,parent,f);
		}
		[SmokeMethod("QMessageBox", "(QMessageBox::Icon, const QString&, const QString&, StandardButtons, QWidget*, Qt::WindowFlags)", "$$$$#$")]
		private void NewQMessageBox(QMessageBox.Icon icon, string title, string text, int buttons, QWidget parent, int f) {
			((QMessageBox) interceptor).NewQMessageBox(icon,title,text,buttons,parent,f);
		}
		public QMessageBox(QMessageBox.Icon icon, string title, string text, int buttons, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(icon,title,text,buttons,parent);
		}
		[SmokeMethod("QMessageBox", "(QMessageBox::Icon, const QString&, const QString&, StandardButtons, QWidget*)", "$$$$#")]
		private void NewQMessageBox(QMessageBox.Icon icon, string title, string text, int buttons, QWidget parent) {
			((QMessageBox) interceptor).NewQMessageBox(icon,title,text,buttons,parent);
		}
		public QMessageBox(QMessageBox.Icon icon, string title, string text, int buttons) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(icon,title,text,buttons);
		}
		[SmokeMethod("QMessageBox", "(QMessageBox::Icon, const QString&, const QString&, StandardButtons)", "$$$$")]
		private void NewQMessageBox(QMessageBox.Icon icon, string title, string text, int buttons) {
			((QMessageBox) interceptor).NewQMessageBox(icon,title,text,buttons);
		}
		public QMessageBox(QMessageBox.Icon icon, string title, string text) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(icon,title,text);
		}
		[SmokeMethod("QMessageBox", "(QMessageBox::Icon, const QString&, const QString&)", "$$$")]
		private void NewQMessageBox(QMessageBox.Icon icon, string title, string text) {
			((QMessageBox) interceptor).NewQMessageBox(icon,title,text);
		}
		[SmokeMethod("addButton", "(QAbstractButton*, QMessageBox::ButtonRole)", "#$")]
		public void AddButton(QAbstractButton button, QMessageBox.ButtonRole role) {
			((QMessageBox) interceptor).AddButton(button,role);
		}
		[SmokeMethod("addButton", "(const QString&, QMessageBox::ButtonRole)", "$$")]
		public QPushButton AddButton(string text, QMessageBox.ButtonRole role) {
			return ((QMessageBox) interceptor).AddButton(text,role);
		}
		[SmokeMethod("addButton", "(QMessageBox::StandardButton)", "$")]
		public QPushButton AddButton(QMessageBox.StandardButton button) {
			return ((QMessageBox) interceptor).AddButton(button);
		}
		[SmokeMethod("removeButton", "(QAbstractButton*)", "#")]
		public void RemoveButton(QAbstractButton button) {
			((QMessageBox) interceptor).RemoveButton(button);
		}
		[SmokeMethod("standardButton", "(QAbstractButton*) const", "#")]
		public QMessageBox.StandardButton standardButton(QAbstractButton button) {
			return ((QMessageBox) interceptor).standardButton(button);
		}
		[SmokeMethod("button", "(QMessageBox::StandardButton) const", "$")]
		public QAbstractButton Button(QMessageBox.StandardButton which) {
			return ((QMessageBox) interceptor).Button(which);
		}
		[SmokeMethod("defaultButton", "() const", "")]
		public QPushButton DefaultButton() {
			return ((QMessageBox) interceptor).DefaultButton();
		}
		[SmokeMethod("setDefaultButton", "(QPushButton*)", "#")]
		public void SetDefaultButton(QPushButton button) {
			((QMessageBox) interceptor).SetDefaultButton(button);
		}
		[SmokeMethod("escapeButton", "() const", "")]
		public QAbstractButton EscapeButton() {
			return ((QMessageBox) interceptor).EscapeButton();
		}
		[SmokeMethod("setEscapeButton", "(QAbstractButton*)", "#")]
		public void SetEscapeButton(QAbstractButton button) {
			((QMessageBox) interceptor).SetEscapeButton(button);
		}
		[SmokeMethod("clickedButton", "() const", "")]
		public QAbstractButton ClickedButton() {
			return ((QMessageBox) interceptor).ClickedButton();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QMessageBox) interceptor).SizeHint();
		}
		public QMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(title,text,icon,button0,button1,button2,parent,f);
		}
		[SmokeMethod("QMessageBox", "(const QString&, const QString&, QMessageBox::Icon, int, int, int, QWidget*, Qt::WindowFlags)", "$$$$$$#$")]
		private void NewQMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, int f) {
			((QMessageBox) interceptor).NewQMessageBox(title,text,icon,button0,button1,button2,parent,f);
		}
		public QMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(title,text,icon,button0,button1,button2,parent);
		}
		[SmokeMethod("QMessageBox", "(const QString&, const QString&, QMessageBox::Icon, int, int, int, QWidget*)", "$$$$$$#")]
		private void NewQMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent) {
			((QMessageBox) interceptor).NewQMessageBox(title,text,icon,button0,button1,button2,parent);
		}
		public QMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(title,text,icon,button0,button1,button2);
		}
		[SmokeMethod("QMessageBox", "(const QString&, const QString&, QMessageBox::Icon, int, int, int)", "$$$$$$")]
		private void NewQMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2) {
			((QMessageBox) interceptor).NewQMessageBox(title,text,icon,button0,button1,button2);
		}
		[SmokeMethod("buttonText", "(int) const", "$")]
		public string ButtonText(int button) {
			return ((QMessageBox) interceptor).ButtonText(button);
		}
		[SmokeMethod("setButtonText", "(int, const QString&)", "$$")]
		public void SetButtonText(int button, string text) {
			((QMessageBox) interceptor).SetButtonText(button,text);
		}
		[SmokeMethod("setWindowTitle", "(const QString&)", "$")]
		public void SetWindowTitle(string title) {
			((QMessageBox) interceptor).SetWindowTitle(title);
		}
		[SmokeMethod("setWindowModality", "(Qt::WindowModality)", "$")]
		public void SetWindowModality(Qt.WindowModality windowModality) {
			((QMessageBox) interceptor).SetWindowModality(windowModality);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			((QMessageBox) interceptor).ResizeEvent(arg1);
		}
		[SmokeMethod("showEvent", "(QShowEvent*)", "#")]
		protected override void ShowEvent(QShowEvent arg1) {
			((QMessageBox) interceptor).ShowEvent(arg1);
		}
		[SmokeMethod("closeEvent", "(QCloseEvent*)", "#")]
		protected override void CloseEvent(QCloseEvent arg1) {
			((QMessageBox) interceptor).CloseEvent(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			((QMessageBox) interceptor).KeyPressEvent(arg1);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected override void ChangeEvent(QEvent arg1) {
			((QMessageBox) interceptor).ChangeEvent(arg1);
		}
		~QMessageBox() {
			DisposeQMessageBox();
		}
		public new void Dispose() {
			DisposeQMessageBox();
		}
		[SmokeMethod("~QMessageBox", "()", "")]
		private void DisposeQMessageBox() {
			((QMessageBox) interceptor).DisposeQMessageBox();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton) {
			return staticInterceptor.Information(parent,title,text,buttons,defaultButton);
		}
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text, int buttons) {
			return staticInterceptor.Information(parent,title,text,buttons);
		}
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text) {
			return staticInterceptor.Information(parent,title,text);
		}
		public static QMessageBox.StandardButton Question(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton) {
			return staticInterceptor.Question(parent,title,text,buttons,defaultButton);
		}
		public static QMessageBox.StandardButton Question(QWidget parent, string title, string text, int buttons) {
			return staticInterceptor.Question(parent,title,text,buttons);
		}
		public static QMessageBox.StandardButton Question(QWidget parent, string title, string text) {
			return staticInterceptor.Question(parent,title,text);
		}
		public static QMessageBox.StandardButton Warning(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton) {
			return staticInterceptor.Warning(parent,title,text,buttons,defaultButton);
		}
		public static QMessageBox.StandardButton Warning(QWidget parent, string title, string text, int buttons) {
			return staticInterceptor.Warning(parent,title,text,buttons);
		}
		public static QMessageBox.StandardButton Warning(QWidget parent, string title, string text) {
			return staticInterceptor.Warning(parent,title,text);
		}
		public static QMessageBox.StandardButton Critical(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton) {
			return staticInterceptor.Critical(parent,title,text,buttons,defaultButton);
		}
		public static QMessageBox.StandardButton Critical(QWidget parent, string title, string text, int buttons) {
			return staticInterceptor.Critical(parent,title,text,buttons);
		}
		public static QMessageBox.StandardButton Critical(QWidget parent, string title, string text) {
			return staticInterceptor.Critical(parent,title,text);
		}
		public static void About(QWidget parent, string title, string text) {
			staticInterceptor.About(parent,title,text);
		}
		public static void AboutQt(QWidget parent, string title) {
			staticInterceptor.AboutQt(parent,title);
		}
		public static void AboutQt(QWidget parent) {
			staticInterceptor.AboutQt(parent);
		}
		public static int Information(QWidget parent, string title, string text, int button0, int button1, int button2) {
			return staticInterceptor.Information(parent,title,text,button0,button1,button2);
		}
		public static int Information(QWidget parent, string title, string text, int button0, int button1) {
			return staticInterceptor.Information(parent,title,text,button0,button1);
		}
		public static int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return staticInterceptor.Information(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		public static int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return staticInterceptor.Information(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		public static int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text) {
			return staticInterceptor.Information(parent,title,text,button0Text,button1Text,button2Text);
		}
		public static int Information(QWidget parent, string title, string text, string button0Text, string button1Text) {
			return staticInterceptor.Information(parent,title,text,button0Text,button1Text);
		}
		public static int Information(QWidget parent, string title, string text, string button0Text) {
			return staticInterceptor.Information(parent,title,text,button0Text);
		}
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1) {
			return staticInterceptor.Information(parent,title,text,button0,button1);
		}
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text, QMessageBox.StandardButton button0) {
			return staticInterceptor.Information(parent,title,text,button0);
		}
		public static int Question(QWidget parent, string title, string text, int button0, int button1, int button2) {
			return staticInterceptor.Question(parent,title,text,button0,button1,button2);
		}
		public static int Question(QWidget parent, string title, string text, int button0, int button1) {
			return staticInterceptor.Question(parent,title,text,button0,button1);
		}
		public static int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return staticInterceptor.Question(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		public static int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return staticInterceptor.Question(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		public static int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text) {
			return staticInterceptor.Question(parent,title,text,button0Text,button1Text,button2Text);
		}
		public static int Question(QWidget parent, string title, string text, string button0Text, string button1Text) {
			return staticInterceptor.Question(parent,title,text,button0Text,button1Text);
		}
		public static int Question(QWidget parent, string title, string text, string button0Text) {
			return staticInterceptor.Question(parent,title,text,button0Text);
		}
		public static int Question(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1) {
			return staticInterceptor.Question(parent,title,text,button0,button1);
		}
		public static int Warning(QWidget parent, string title, string text, int button0, int button1, int button2) {
			return staticInterceptor.Warning(parent,title,text,button0,button1,button2);
		}
		public static int Warning(QWidget parent, string title, string text, int button0, int button1) {
			return staticInterceptor.Warning(parent,title,text,button0,button1);
		}
		public static int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return staticInterceptor.Warning(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		public static int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return staticInterceptor.Warning(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		public static int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text) {
			return staticInterceptor.Warning(parent,title,text,button0Text,button1Text,button2Text);
		}
		public static int Warning(QWidget parent, string title, string text, string button0Text, string button1Text) {
			return staticInterceptor.Warning(parent,title,text,button0Text,button1Text);
		}
		public static int Warning(QWidget parent, string title, string text, string button0Text) {
			return staticInterceptor.Warning(parent,title,text,button0Text);
		}
		public static int Warning(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1) {
			return staticInterceptor.Warning(parent,title,text,button0,button1);
		}
		public static int Critical(QWidget parent, string title, string text, int button0, int button1, int button2) {
			return staticInterceptor.Critical(parent,title,text,button0,button1,button2);
		}
		public static int Critical(QWidget parent, string title, string text, int button0, int button1) {
			return staticInterceptor.Critical(parent,title,text,button0,button1);
		}
		public static int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return staticInterceptor.Critical(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		public static int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return staticInterceptor.Critical(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		public static int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text) {
			return staticInterceptor.Critical(parent,title,text,button0Text,button1Text,button2Text);
		}
		public static int Critical(QWidget parent, string title, string text, string button0Text, string button1Text) {
			return staticInterceptor.Critical(parent,title,text,button0Text,button1Text);
		}
		public static int Critical(QWidget parent, string title, string text, string button0Text) {
			return staticInterceptor.Critical(parent,title,text,button0Text);
		}
		public static int Critical(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1) {
			return staticInterceptor.Critical(parent,title,text,button0,button1);
		}
		public static QPixmap StandardIcon(QMessageBox.Icon icon) {
			return staticInterceptor.StandardIcon(icon);
		}
		protected new IQMessageBoxSignals Emit {
			get { return (IQMessageBoxSignals) Q_EMIT; }
		}
	}

	public interface IQMessageBoxSignals : IQDialogSignals {
	}
}
