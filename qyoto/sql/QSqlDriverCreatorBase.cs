//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSqlDriverCreatorBase")]
	public abstract class QSqlDriverCreatorBase : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QSqlDriverCreatorBase(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSqlDriverCreatorBase), this);
		}
		// QSqlDriverCreatorBase* QSqlDriverCreatorBase(); >>>> NOT CONVERTED
		[SmokeMethod("createObject() const")]
		public abstract QSqlDriver CreateObject();
	}
}
