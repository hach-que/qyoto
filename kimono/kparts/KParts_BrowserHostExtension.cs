//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {

	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  An extension class for container parts, i.e. parts that contain
	///  other parts.
	///  For instance a KHTMLPart hosts one part per frame.
	///  </remarks>		<short>    An extension class for container parts, i.</short>

	[SmokeClass("KParts::BrowserHostExtension")]
	public class BrowserHostExtension : QObject, IDisposable {
 		protected BrowserHostExtension(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(BrowserHostExtension), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static BrowserHostExtension() {
			staticInterceptor = new SmokeInvocation(typeof(BrowserHostExtension), null);
		}
		public BrowserHostExtension(KParts.ReadOnlyPart parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BrowserHostExtension#", "BrowserHostExtension(KParts::ReadOnlyPart*)", typeof(void), typeof(KParts.ReadOnlyPart), parent);
		}
		/// <remarks>
		///  Returns a list of the names of all hosted child objects.
		///  Note that this method does not query the child objects recursively.
		///    </remarks>		<short>    Returns a list of the names of all hosted child objects.</short>
		[SmokeMethod("frameNames() const")]
		public virtual List<string> FrameNames() {
			return (List<string>) interceptor.Invoke("frameNames", "frameNames() const", typeof(List<string>));
		}
		/// <remarks>
		///  Returns a list of pointers to all hosted child objects.
		///  Note that this method does not query the child objects recursively.
		///    </remarks>		<short>    Returns a list of pointers to all hosted child objects.</short>
		[SmokeMethod("frames() const")]
		public virtual List<KParts.ReadOnlyPart> Frames() {
			return (List<KParts.ReadOnlyPart>) interceptor.Invoke("frames", "frames() const", typeof(List<KParts.ReadOnlyPart>));
		}
		/// <remarks>
		///  Returns the part that contains <code>frame</code> and that may be accessed
		///  by <code>callingPart</code>
		///    </remarks>		<short>    Returns the part that contains <code>frame</code> and that may be accessed  by <code>callingPart</code>    </short>
		[SmokeMethod("findFrameParent(KParts::ReadOnlyPart*, const QString&)")]
		public virtual KParts.BrowserHostExtension FindFrameParent(KParts.ReadOnlyPart callingPart, string frame) {
			return (KParts.BrowserHostExtension) interceptor.Invoke("findFrameParent#$", "findFrameParent(KParts::ReadOnlyPart*, const QString&)", typeof(KParts.BrowserHostExtension), typeof(KParts.ReadOnlyPart), callingPart, typeof(string), frame);
		}
		/// <remarks>
		///  Opens the given url in a hosted child frame. The frame name is specified in the
		///  frameName variable in the <code>browserArguments</code> parameter (see KParts.BrowserArguments ) .
		///    </remarks>		<short>    Opens the given url in a hosted child frame.</short>
		[SmokeMethod("openUrlInFrame(const KUrl&, const KParts::OpenUrlArguments&, const KParts::BrowserArguments&)")]
		public virtual bool OpenUrlInFrame(KUrl url, KParts.OpenUrlArguments arguments, KParts.BrowserArguments browserArguments) {
			return (bool) interceptor.Invoke("openUrlInFrame###", "openUrlInFrame(const KUrl&, const KParts::OpenUrlArguments&, const KParts::BrowserArguments&)", typeof(bool), typeof(KUrl), url, typeof(KParts.OpenUrlArguments), arguments, typeof(KParts.BrowserArguments), browserArguments);
		}
		~BrowserHostExtension() {
			interceptor.Invoke("~BrowserHostExtension", "~BrowserHostExtension()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~BrowserHostExtension", "~BrowserHostExtension()", typeof(void));
		}
		/// <remarks>
		///  Queries <code>obj</code> for a child object which inherits from this
		///  BrowserHostExtension class. Convenience method.
		///    </remarks>		<short>    Queries <code>obj</code> for a child object which inherits from this  BrowserHostExtension class.</short>
		public static KParts.BrowserHostExtension ChildObject(QObject arg1) {
			return (KParts.BrowserHostExtension) staticInterceptor.Invoke("childObject#", "childObject(QObject*)", typeof(KParts.BrowserHostExtension), typeof(QObject), arg1);
		}
		protected new IBrowserHostExtensionSignals Emit {
			get { return (IBrowserHostExtensionSignals) Q_EMIT; }
		}
	}

	public interface IBrowserHostExtensionSignals : IQObjectSignals {
	}
}
