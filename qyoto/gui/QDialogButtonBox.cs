//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQDialogButtonBoxSignals"></see> for signals emitted by QDialogButtonBox
	[SmokeClass("QDialogButtonBox")]
	public class QDialogButtonBox : QWidget, IDisposable {
 		protected QDialogButtonBox(Type dummy) : base((Type) null) {}
		interface IQDialogButtonBoxProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDialogButtonBox), this);
			_interceptor = (QDialogButtonBox) realProxy.GetTransparentProxy();
		}
		private QDialogButtonBox ProxyQDialogButtonBox() {
			return (QDialogButtonBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDialogButtonBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDialogButtonBoxProxy), null);
			_staticInterceptor = (IQDialogButtonBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQDialogButtonBoxProxy StaticQDialogButtonBox() {
			return (IQDialogButtonBoxProxy) _staticInterceptor;
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
		}
		public enum ButtonLayout {
			WinLayout = 0,
			MacLayout = 1,
			KdeLayout = 2,
			GnomeLayout = 3,
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public Qt.Orientation Orientation {
			get {
				return Property("orientation").Value<Qt.Orientation>();
			}
			set {
				SetProperty("orientation", QVariant.FromValue<Qt.Orientation>(value));
			}
		}
		[Q_PROPERTY("StandardButtons", "standardButtons")]
		public int StandardButtons {
			get {
				return Property("standardButtons").Value<int>();
			}
			set {
				SetProperty("standardButtons", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("bool", "centerButtons")]
		public bool CenterButtons {
			get {
				return Property("centerButtons").Value<bool>();
			}
			set {
				SetProperty("centerButtons", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDialogButtonBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDialogButtonBox(parent);
		}
		[SmokeMethod("QDialogButtonBox#", "(QWidget*)")]
		private void NewQDialogButtonBox(QWidget parent) {
			ProxyQDialogButtonBox().NewQDialogButtonBox(parent);
		}
		public QDialogButtonBox() : this((Type) null) {
			CreateProxy();
			NewQDialogButtonBox();
		}
		[SmokeMethod("QDialogButtonBox", "()")]
		private void NewQDialogButtonBox() {
			ProxyQDialogButtonBox().NewQDialogButtonBox();
		}
		public QDialogButtonBox(Qt.Orientation orientation, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDialogButtonBox(orientation,parent);
		}
		[SmokeMethod("QDialogButtonBox$$", "(Qt::Orientation, QWidget*)")]
		private void NewQDialogButtonBox(Qt.Orientation orientation, QWidget parent) {
			ProxyQDialogButtonBox().NewQDialogButtonBox(orientation,parent);
		}
		public QDialogButtonBox(Qt.Orientation orientation) : this((Type) null) {
			CreateProxy();
			NewQDialogButtonBox(orientation);
		}
		[SmokeMethod("QDialogButtonBox$", "(Qt::Orientation)")]
		private void NewQDialogButtonBox(Qt.Orientation orientation) {
			ProxyQDialogButtonBox().NewQDialogButtonBox(orientation);
		}
		public QDialogButtonBox(int buttons, Qt.Orientation orientation, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDialogButtonBox(buttons,orientation,parent);
		}
		[SmokeMethod("QDialogButtonBox$$$", "(StandardButtons, Qt::Orientation, QWidget*)")]
		private void NewQDialogButtonBox(int buttons, Qt.Orientation orientation, QWidget parent) {
			ProxyQDialogButtonBox().NewQDialogButtonBox(buttons,orientation,parent);
		}
		public QDialogButtonBox(int buttons, Qt.Orientation orientation) : this((Type) null) {
			CreateProxy();
			NewQDialogButtonBox(buttons,orientation);
		}
		[SmokeMethod("QDialogButtonBox$$", "(StandardButtons, Qt::Orientation)")]
		private void NewQDialogButtonBox(int buttons, Qt.Orientation orientation) {
			ProxyQDialogButtonBox().NewQDialogButtonBox(buttons,orientation);
		}
		public QDialogButtonBox(int buttons) : this((Type) null) {
			CreateProxy();
			NewQDialogButtonBox(buttons);
		}
		[SmokeMethod("QDialogButtonBox$", "(StandardButtons)")]
		private void NewQDialogButtonBox(int buttons) {
			ProxyQDialogButtonBox().NewQDialogButtonBox(buttons);
		}
		[SmokeMethod("addButton##", "(QAbstractButton*, QDialogButtonBox::ButtonRole)")]
		public void AddButton(QAbstractButton button, QDialogButtonBox.ButtonRole role) {
			ProxyQDialogButtonBox().AddButton(button,role);
		}
		[SmokeMethod("addButton$$", "(const QString&, QDialogButtonBox::ButtonRole)")]
		public QPushButton AddButton(string text, QDialogButtonBox.ButtonRole role) {
			return ProxyQDialogButtonBox().AddButton(text,role);
		}
		[SmokeMethod("addButton$", "(QDialogButtonBox::StandardButton)")]
		public QPushButton AddButton(QDialogButtonBox.StandardButton button) {
			return ProxyQDialogButtonBox().AddButton(button);
		}
		[SmokeMethod("removeButton#", "(QAbstractButton*)")]
		public void RemoveButton(QAbstractButton button) {
			ProxyQDialogButtonBox().RemoveButton(button);
		}
		[SmokeMethod("clear", "()")]
		public void Clear() {
			ProxyQDialogButtonBox().Clear();
		}
		[SmokeMethod("buttons", "() const")]
		public List<QAbstractButton> Buttons() {
			return ProxyQDialogButtonBox().Buttons();
		}
		[SmokeMethod("buttonRole#", "(QAbstractButton*) const")]
		public QDialogButtonBox.ButtonRole buttonRole(QAbstractButton button) {
			return ProxyQDialogButtonBox().buttonRole(button);
		}
		[SmokeMethod("standardButton#", "(QAbstractButton*) const")]
		public QDialogButtonBox.StandardButton standardButton(QAbstractButton button) {
			return ProxyQDialogButtonBox().standardButton(button);
		}
		[SmokeMethod("button$", "(QDialogButtonBox::StandardButton) const")]
		public QPushButton Button(QDialogButtonBox.StandardButton which) {
			return ProxyQDialogButtonBox().Button(which);
		}
		public static new string Tr(string s, string c) {
			return StaticQDialogButtonBox().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQDialogButtonBox().Tr(s);
		}
		[SmokeMethod("changeEvent#", "(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQDialogButtonBox().ChangeEvent(arg1);
		}
		[SmokeMethod("event#", "(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQDialogButtonBox().Event(arg1);
		}
		~QDialogButtonBox() {
			DisposeQDialogButtonBox();
		}
		public new void Dispose() {
			DisposeQDialogButtonBox();
		}
		[SmokeMethod("~QDialogButtonBox", "()")]
		private void DisposeQDialogButtonBox() {
			ProxyQDialogButtonBox().DisposeQDialogButtonBox();
		}
		protected new IQDialogButtonBoxSignals Emit {
			get {
				return (IQDialogButtonBoxSignals) Q_EMIT;
			}
		}
	}

	public interface IQDialogButtonBoxSignals : IQWidgetSignals {
		[Q_SIGNAL("void (QAbstractButton*)")]
		void Clicked(QAbstractButton button);
		[Q_SIGNAL("void ()")]
		void Accepted();
		[Q_SIGNAL("void ()")]
		void HelpRequested();
		[Q_SIGNAL("void ()")]
		void Rejected();
	}
}
