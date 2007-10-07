//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;


	[SmokeClass("KRockerGesture")]
	public class KRockerGesture : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KRockerGesture(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KRockerGesture), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KRockerGesture() {
			staticInterceptor = new SmokeInvocation(typeof(KRockerGesture), null);
		}
		/// <remarks>
		///  Create a new invalid rocker gesture.
		///      </remarks>		<short>    Create a new invalid rocker gesture.</short>
		public KRockerGesture() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRockerGesture", "KRockerGesture()", typeof(void));
		}
		/// <remarks>
		///  Creates a new gesture consisting of given buttons.
		/// <param> name="description" create gesture according to this
		///      </param></remarks>		<short>    Creates a new gesture consisting of given buttons.</short>
		public KRockerGesture(Qt.MouseButton hold, Qt.MouseButton thenPush) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRockerGesture$$", "KRockerGesture(Qt::MouseButton, Qt::MouseButton)", typeof(void), typeof(Qt.MouseButton), hold, typeof(Qt.MouseButton), thenPush);
		}
		/// <remarks>
		///  Creates a new gesture from a string description.
		/// <param> name="description" create gesture according to this
		///      </param></remarks>		<short>    Creates a new gesture from a string description.</short>
		public KRockerGesture(string description) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRockerGesture$", "KRockerGesture(const QString&)", typeof(void), typeof(string), description);
		}
		/// <remarks>
		///  Copies the given gesture.
		/// <param> name="other" gesture to copy
		///      </param></remarks>		<short>    Copies the given gesture.</short>
		public KRockerGesture(KRockerGesture other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRockerGesture#", "KRockerGesture(const KRockerGesture&)", typeof(void), typeof(KRockerGesture), other);
		}
		/// <remarks>
		///  set button combination to trigger
		///      </remarks>		<short>    set button combination to trigger      </short>
		public void SetButtons(Qt.MouseButton hold, Qt.MouseButton thenPush) {
			interceptor.Invoke("setButtons$$", "setButtons(Qt::MouseButton, Qt::MouseButton)", typeof(void), typeof(Qt.MouseButton), hold, typeof(Qt.MouseButton), thenPush);
		}
		/// <remarks>
		///  Write the button combination to hold and thenPush
		///      </remarks>		<short>    Write the button combination to hold and thenPush      </short>
		public void GetButtons(Qt.MouseButton hold, Qt.MouseButton thenPush) {
			interceptor.Invoke("getButtons$$", "getButtons(Qt::MouseButton*, Qt::MouseButton*) const", typeof(void), typeof(Qt.MouseButton), hold, typeof(Qt.MouseButton), thenPush);
		}
		/// <remarks>
		///  Return a user-friendly name of the button combination.
		///      </remarks>		<short>    Return a user-friendly name of the button combination.</short>
		public string RockerName() {
			return (string) interceptor.Invoke("rockerName", "rockerName() const", typeof(string));
		}
		/// <remarks>
		///  Return true if this gesture is valid.
		///      </remarks>		<short>    Return true if this gesture is valid.</short>
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		/// <remarks>
		///  Return a string representation of this gesture.
		///  Return an empty string if invalid.
		///  This function is mainly for use with config files.
		/// </remarks>		<short>    Return a string representation of this gesture.</short>
		/// 		<see> rockerName</see>
		public new string ToString() {
			return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
		}
		/// <remarks>
		///  Return whether this gesture is equal to the other gesture.
		///      </remarks>		<short>    Return whether this gesture is equal to the other gesture.</short>
		public override bool Equals(object o) {
			if (!(o is KRockerGesture)) { return false; }
			return this == (KRockerGesture) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		/// <remarks>
		///  Return an opaque value for use in hash tables
		///      </remarks>		<short>    Return an opaque value for use in hash tables      </short>
		public uint Hashable() {
			return (uint) interceptor.Invoke("hashable", "hashable() const", typeof(uint));
		}
		~KRockerGesture() {
			interceptor.Invoke("~KRockerGesture", "~KRockerGesture()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KRockerGesture", "~KRockerGesture()", typeof(void));
		}
		public static bool operator==(KRockerGesture lhs, KRockerGesture other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const KRockerGesture&) const", typeof(bool), typeof(KRockerGesture), lhs, typeof(KRockerGesture), other);
		}
		public static bool operator!=(KRockerGesture lhs, KRockerGesture other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const KRockerGesture&) const", typeof(bool), typeof(KRockerGesture), lhs, typeof(KRockerGesture), other);
		}
		/// <remarks>
		///  Return a user-friendly name for the mouse button button
		///      </remarks>		<short>    Return a user-friendly name for the mouse button button      </short>
		public static string MouseButtonName(Qt.MouseButton button) {
			return (string) staticInterceptor.Invoke("mouseButtonName$", "mouseButtonName(Qt::MouseButton)", typeof(string), typeof(Qt.MouseButton), button);
		}
	}
}