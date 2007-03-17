//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSizePolicy")]
	public class QSizePolicy : MarshalByRefObject, IDisposable {
		protected QSizePolicy interceptor = null;
		private IntPtr smokeObject;
		protected QSizePolicy(Type dummy) {}
		[SmokeClass("QSizePolicy")]
		interface IQSizePolicyProxy {
			[SmokeMethod("operator==", "(const QSizePolicy&) const", "#")]
			bool op_equals(QSizePolicy lhs, QSizePolicy s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSizePolicy), this);
			interceptor = (QSizePolicy) realProxy.GetTransparentProxy();
		}
		private static IQSizePolicyProxy staticInterceptor = null;
		static QSizePolicy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSizePolicyProxy), null);
			staticInterceptor = (IQSizePolicyProxy) realProxy.GetTransparentProxy();
		}
		public enum PolicyFlag {
			GrowFlag = 1,
			ExpandFlag = 2,
			ShrinkFlag = 4,
			IgnoreFlag = 8,
		}
		public enum Policy {
			Fixed = 0,
			Minimum = PolicyFlag.GrowFlag,
			Maximum = PolicyFlag.ShrinkFlag,
			Preferred = PolicyFlag.GrowFlag|PolicyFlag.ShrinkFlag,
			MinimumExpanding = PolicyFlag.GrowFlag|PolicyFlag.ExpandFlag,
			Expanding = PolicyFlag.GrowFlag|PolicyFlag.ShrinkFlag|PolicyFlag.ExpandFlag,
			Ignored = PolicyFlag.ShrinkFlag|PolicyFlag.GrowFlag|PolicyFlag.IgnoreFlag,
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		public QSizePolicy() : this((Type) null) {
			CreateProxy();
			NewQSizePolicy();
		}
		[SmokeMethod("QSizePolicy", "()", "")]
		private void NewQSizePolicy() {
			((QSizePolicy) interceptor).NewQSizePolicy();
		}
		public QSizePolicy(QSizePolicy.Policy horizontal, QSizePolicy.Policy vertical) : this((Type) null) {
			CreateProxy();
			NewQSizePolicy(horizontal,vertical);
		}
		[SmokeMethod("QSizePolicy", "(QSizePolicy::Policy, QSizePolicy::Policy)", "$$")]
		private void NewQSizePolicy(QSizePolicy.Policy horizontal, QSizePolicy.Policy vertical) {
			((QSizePolicy) interceptor).NewQSizePolicy(horizontal,vertical);
		}
		[SmokeMethod("horizontalPolicy", "() const", "")]
		public QSizePolicy.Policy HorizontalPolicy() {
			return ((QSizePolicy) interceptor).HorizontalPolicy();
		}
		[SmokeMethod("verticalPolicy", "() const", "")]
		public QSizePolicy.Policy VerticalPolicy() {
			return ((QSizePolicy) interceptor).VerticalPolicy();
		}
		[SmokeMethod("setHorizontalPolicy", "(QSizePolicy::Policy)", "$")]
		public void SetHorizontalPolicy(QSizePolicy.Policy d) {
			((QSizePolicy) interceptor).SetHorizontalPolicy(d);
		}
		[SmokeMethod("setVerticalPolicy", "(QSizePolicy::Policy)", "$")]
		public void SetVerticalPolicy(QSizePolicy.Policy d) {
			((QSizePolicy) interceptor).SetVerticalPolicy(d);
		}
		[SmokeMethod("expandingDirections", "() const", "")]
		public int ExpandingDirections() {
			return ((QSizePolicy) interceptor).ExpandingDirections();
		}
		[SmokeMethod("setHeightForWidth", "(bool)", "$")]
		public void SetHeightForWidth(bool b) {
			((QSizePolicy) interceptor).SetHeightForWidth(b);
		}
		[SmokeMethod("hasHeightForWidth", "() const", "")]
		public bool HasHeightForWidth() {
			return ((QSizePolicy) interceptor).HasHeightForWidth();
		}
		public override bool Equals(object o) {
			if (!(o is QSizePolicy)) { return false; }
			return this == (QSizePolicy) o;
		}
		public override int GetHashCode() {
			return ((QSizePolicy) interceptor).GetHashCode();
		}
		[SmokeMethod("horizontalStretch", "() const", "")]
		public int HorizontalStretch() {
			return ((QSizePolicy) interceptor).HorizontalStretch();
		}
		[SmokeMethod("verticalStretch", "() const", "")]
		public int VerticalStretch() {
			return ((QSizePolicy) interceptor).VerticalStretch();
		}
		[SmokeMethod("setHorizontalStretch", "(uchar)", "$")]
		public void SetHorizontalStretch(ushort stretchFactor) {
			((QSizePolicy) interceptor).SetHorizontalStretch(stretchFactor);
		}
		[SmokeMethod("setVerticalStretch", "(uchar)", "$")]
		public void SetVerticalStretch(ushort stretchFactor) {
			((QSizePolicy) interceptor).SetVerticalStretch(stretchFactor);
		}
		[SmokeMethod("transpose", "()", "")]
		public void Transpose() {
			((QSizePolicy) interceptor).Transpose();
		}
		~QSizePolicy() {
			DisposeQSizePolicy();
		}
		public void Dispose() {
			DisposeQSizePolicy();
		}
		[SmokeMethod("~QSizePolicy", "()", "")]
		private void DisposeQSizePolicy() {
			((QSizePolicy) interceptor).DisposeQSizePolicy();
		}
		public static bool operator==(QSizePolicy lhs, QSizePolicy s) {
			return staticInterceptor.op_equals(lhs,s);
		}
		public static bool operator!=(QSizePolicy lhs, QSizePolicy s) {
			return !staticInterceptor.op_equals(lhs,s);
		}
	}
}
