//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Runtime.InteropServices;
	using System.Text;

	/// <remarks>
	///    KDoubleValidator extends QDoubleValidator to be
	///    locale-aware. That means that - subject to not being disabled -
	///    KLocale.DecimalSymbol(), KLocale.ThousandsSeparator()
	///    and KLocale.PositiveSign() and KLocale.NegativeSign()
	///    are respected.
	/// </remarks>		<author> Marc Mutz <mutz@kde.org>
	/// </author>
	/// 		<short> A locale-aware QDoubleValidator.</short>
	/// 		<see> KIntValidator</see>

	[SmokeClass("KDoubleValidator")]
	public class KDoubleValidator : QDoubleValidator, IDisposable {
 		protected KDoubleValidator(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KDoubleValidator), this);
		}
		[Q_PROPERTY("bool", "acceptLocalizedNumbers")]
		public bool AcceptLocalizedNumbers {
			get { return (bool) interceptor.Invoke("acceptLocalizedNumbers", "acceptLocalizedNumbers()", typeof(bool)); }
			set { interceptor.Invoke("setAcceptLocalizedNumbers$", "setAcceptLocalizedNumbers(bool)", typeof(void), typeof(bool), value); }
		}
		/// <remarks> Constuct a locale-aware KDoubleValidator with default range
		///       (whatever QDoubleValidator uses for that) and parent <code>parent</code> </remarks>		<short>   Constuct a locale-aware KDoubleValidator with default range       (whatever QDoubleValidator uses for that) and parent <code>parent</code> </short>
		public KDoubleValidator(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDoubleValidator#", "KDoubleValidator(QObject*)", typeof(void), typeof(QObject), parent);
		}
		/// <remarks> Constuct a locale-aware KDoubleValidator for range [<code>bottom</code>,<code>top</code>] and a precision of <code>decimals</code> decimals after the decimal
		///       point.  </remarks>		<short>   Constuct a locale-aware KDoubleValidator for range [<code>bottom</code>,<code>top</code>] and a precision of <code>decimals</code> decimals after the decimal       point.</short>
		public KDoubleValidator(double bottom, double top, int decimals, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDoubleValidator$$$#", "KDoubleValidator(double, double, int, QObject*)", typeof(void), typeof(double), bottom, typeof(double), top, typeof(int), decimals, typeof(QObject), parent);
		}
		/// <remarks> Overloaded for internal reasons. The API is not affected. </remarks>		<short>   Overloaded for internal reasons.</short>
		[SmokeMethod("validate(QString&, int&) const")]
		public override QValidator.State Validate(StringBuilder input, ref int pos) {
			StackItem[] stack = new StackItem[3];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(input);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(input);
#endif
			stack[2].s_int = pos;
			interceptor.Invoke("validate$$", "validate(QString&, int&) const", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
			pos = stack[2].s_int;
			return (QValidator.State) Enum.ToObject(typeof(QValidator.State), stack[0].s_int);
		}
		~KDoubleValidator() {
			interceptor.Invoke("~KDoubleValidator", "~KDoubleValidator()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KDoubleValidator", "~KDoubleValidator()", typeof(void));
		}
		protected new IKDoubleValidatorSignals Emit {
			get { return (IKDoubleValidatorSignals) Q_EMIT; }
		}
	}

	public interface IKDoubleValidatorSignals : IQDoubleValidatorSignals {
	}
}