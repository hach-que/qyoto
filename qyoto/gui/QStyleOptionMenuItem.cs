//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionMenuItem")]
	public class QStyleOptionMenuItem : QStyleOption, IDisposable {
 		protected QStyleOptionMenuItem(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionMenuItem), this);
			interceptor = (QStyleOptionMenuItem) realProxy.GetTransparentProxy();
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_MenuItem,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public enum MenuItemType {
			Normal = 0,
			DefaultItem = 1,
			Separator = 2,
			SubMenu = 3,
			Scroller = 4,
			TearOff = 5,
			Margin = 6,
			EmptyArea = 7,
		}
		public enum CheckType {
			NotCheckable = 0,
			Exclusive = 1,
			NonExclusive = 2,
		}
		public QStyleOptionMenuItem() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionMenuItem();
		}
		[SmokeMethod("QStyleOptionMenuItem", "()", "")]
		private void NewQStyleOptionMenuItem() {
			((QStyleOptionMenuItem) interceptor).NewQStyleOptionMenuItem();
		}
		public QStyleOptionMenuItem(QStyleOptionMenuItem other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionMenuItem(other);
		}
		[SmokeMethod("QStyleOptionMenuItem", "(const QStyleOptionMenuItem&)", "#")]
		private void NewQStyleOptionMenuItem(QStyleOptionMenuItem other) {
			((QStyleOptionMenuItem) interceptor).NewQStyleOptionMenuItem(other);
		}
		public QStyleOptionMenuItem(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionMenuItem(version);
		}
		[SmokeMethod("QStyleOptionMenuItem", "(int)", "$")]
		private void NewQStyleOptionMenuItem(int version) {
			((QStyleOptionMenuItem) interceptor).NewQStyleOptionMenuItem(version);
		}
		~QStyleOptionMenuItem() {
			DisposeQStyleOptionMenuItem();
		}
		public void Dispose() {
			DisposeQStyleOptionMenuItem();
		}
		[SmokeMethod("~QStyleOptionMenuItem", "()", "")]
		private void DisposeQStyleOptionMenuItem() {
			((QStyleOptionMenuItem) interceptor).DisposeQStyleOptionMenuItem();
		}
	}
}
