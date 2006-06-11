//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionTab")]
	public class QStyleOptionTab : QStyleOption, IDisposable {
 		protected QStyleOptionTab(Type dummy) : base((Type) null) {}
		interface IQStyleOptionTabProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionTab), this);
			_interceptor = (QStyleOptionTab) realProxy.GetTransparentProxy();
		}
		private QStyleOptionTab ProxyQStyleOptionTab() {
			return (QStyleOptionTab) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionTab() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionTabProxy), null);
			_staticInterceptor = (IQStyleOptionTabProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionTabProxy StaticQStyleOptionTab() {
			return (IQStyleOptionTabProxy) _staticInterceptor;
		}

		public enum TabPosition {
			Beginning = 0,
			Middle = 1,
			End = 2,
			OnlyOneTab = 3,
		}
		public enum SelectedPosition {
			NotAdjacent = 0,
			NextIsSelected = 1,
			PreviousIsSelected = 2,
		}
		public enum CornerWidget {
			NoCornerWidgets = 0x00,
			LeftCornerWidget = 0x01,
			RightCornerWidget = 0x02,
		}
		public const int Type = (int) QStyleOption.OptionType.SO_Tab;

		public const int Version = 1;

		public QStyleOptionTab() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTab();
		}
		[SmokeMethod("QStyleOptionTab()")]
		private void NewQStyleOptionTab() {
			ProxyQStyleOptionTab().NewQStyleOptionTab();
		}
		public QStyleOptionTab(QStyleOptionTab other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTab(other);
		}
		[SmokeMethod("QStyleOptionTab(const QStyleOptionTab&)")]
		private void NewQStyleOptionTab(QStyleOptionTab other) {
			ProxyQStyleOptionTab().NewQStyleOptionTab(other);
		}
		public QStyleOptionTab(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTab(version);
		}
		[SmokeMethod("QStyleOptionTab(int)")]
		private void NewQStyleOptionTab(int version) {
			ProxyQStyleOptionTab().NewQStyleOptionTab(version);
		}
		~QStyleOptionTab() {
			DisposeQStyleOptionTab();
		}
		public void Dispose() {
			DisposeQStyleOptionTab();
		}
		[SmokeMethod("~QStyleOptionTab()")]
		private void DisposeQStyleOptionTab() {
			ProxyQStyleOptionTab().DisposeQStyleOptionTab();
		}
	}
}
