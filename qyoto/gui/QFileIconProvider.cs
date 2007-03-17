//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFileIconProvider")]
	public class QFileIconProvider : MarshalByRefObject, IDisposable {
		protected QFileIconProvider interceptor = null;
		private IntPtr smokeObject;
		protected QFileIconProvider(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFileIconProvider), this);
			interceptor = (QFileIconProvider) realProxy.GetTransparentProxy();
		}
		public enum IconType {
			Computer = 0,
			Desktop = 1,
			Trashcan = 2,
			Network = 3,
			Drive = 4,
			Folder = 5,
			File = 6,
		}
		public QFileIconProvider() : this((Type) null) {
			CreateProxy();
			NewQFileIconProvider();
		}
		[SmokeMethod("QFileIconProvider", "()", "")]
		private void NewQFileIconProvider() {
			((QFileIconProvider) interceptor).NewQFileIconProvider();
		}
		[SmokeMethod("icon", "(QFileIconProvider::IconType) const", "$")]
		public virtual QIcon Icon(QFileIconProvider.IconType type) {
			return ((QFileIconProvider) interceptor).Icon(type);
		}
		[SmokeMethod("icon", "(const QFileInfo&) const", "#")]
		public virtual QIcon Icon(QFileInfo info) {
			return ((QFileIconProvider) interceptor).Icon(info);
		}
		[SmokeMethod("type", "(const QFileInfo&) const", "#")]
		public virtual string type(QFileInfo info) {
			return ((QFileIconProvider) interceptor).type(info);
		}
		~QFileIconProvider() {
			DisposeQFileIconProvider();
		}
		public void Dispose() {
			DisposeQFileIconProvider();
		}
		[SmokeMethod("~QFileIconProvider", "()", "")]
		private void DisposeQFileIconProvider() {
			((QFileIconProvider) interceptor).DisposeQFileIconProvider();
		}
	}
}
