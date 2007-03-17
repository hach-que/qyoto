//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QClipboard")]
	public class QClipboard : QObject {
 		protected QClipboard(Type dummy) : base((Type) null) {}
		[SmokeClass("QClipboard")]
		interface IQClipboardProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QClipboard), this);
			interceptor = (QClipboard) realProxy.GetTransparentProxy();
		}
		private static IQClipboardProxy staticInterceptor = null;
		static QClipboard() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQClipboardProxy), null);
			staticInterceptor = (IQClipboardProxy) realProxy.GetTransparentProxy();
		}
		public enum Mode {
			Clipboard = 0,
			Selection = 1,
			FindBuffer = 2,
			LastMode = FindBuffer,
		}
		[SmokeMethod("clear", "(QClipboard::Mode)", "$")]
		public void Clear(QClipboard.Mode mode) {
			((QClipboard) interceptor).Clear(mode);
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			((QClipboard) interceptor).Clear();
		}
		[SmokeMethod("supportsSelection", "() const", "")]
		public bool SupportsSelection() {
			return ((QClipboard) interceptor).SupportsSelection();
		}
		[SmokeMethod("supportsFindBuffer", "() const", "")]
		public bool SupportsFindBuffer() {
			return ((QClipboard) interceptor).SupportsFindBuffer();
		}
		[SmokeMethod("ownsSelection", "() const", "")]
		public bool OwnsSelection() {
			return ((QClipboard) interceptor).OwnsSelection();
		}
		[SmokeMethod("ownsClipboard", "() const", "")]
		public bool OwnsClipboard() {
			return ((QClipboard) interceptor).OwnsClipboard();
		}
		[SmokeMethod("ownsFindBuffer", "() const", "")]
		public bool OwnsFindBuffer() {
			return ((QClipboard) interceptor).OwnsFindBuffer();
		}
		[SmokeMethod("text", "(QClipboard::Mode) const", "$")]
		public string Text(QClipboard.Mode mode) {
			return ((QClipboard) interceptor).Text(mode);
		}
		[SmokeMethod("text", "() const", "")]
		public string Text() {
			return ((QClipboard) interceptor).Text();
		}
		[SmokeMethod("text", "(QString&, QClipboard::Mode) const", "$$")]
		public string Text(StringBuilder subtype, QClipboard.Mode mode) {
			return ((QClipboard) interceptor).Text(subtype,mode);
		}
		[SmokeMethod("text", "(QString&) const", "$")]
		public string Text(StringBuilder subtype) {
			return ((QClipboard) interceptor).Text(subtype);
		}
		[SmokeMethod("setText", "(const QString&, QClipboard::Mode)", "$$")]
		public void SetText(string arg1, QClipboard.Mode mode) {
			((QClipboard) interceptor).SetText(arg1,mode);
		}
		[SmokeMethod("setText", "(const QString&)", "$")]
		public void SetText(string arg1) {
			((QClipboard) interceptor).SetText(arg1);
		}
		[SmokeMethod("mimeData", "(QClipboard::Mode) const", "$")]
		public QMimeData MimeData(QClipboard.Mode mode) {
			return ((QClipboard) interceptor).MimeData(mode);
		}
		[SmokeMethod("mimeData", "() const", "")]
		public QMimeData MimeData() {
			return ((QClipboard) interceptor).MimeData();
		}
		[SmokeMethod("setMimeData", "(QMimeData*, QClipboard::Mode)", "#$")]
		public void SetMimeData(QMimeData data, QClipboard.Mode mode) {
			((QClipboard) interceptor).SetMimeData(data,mode);
		}
		[SmokeMethod("setMimeData", "(QMimeData*)", "#")]
		public void SetMimeData(QMimeData data) {
			((QClipboard) interceptor).SetMimeData(data);
		}
		[SmokeMethod("image", "(QClipboard::Mode) const", "$")]
		public QImage Image(QClipboard.Mode mode) {
			return ((QClipboard) interceptor).Image(mode);
		}
		[SmokeMethod("image", "() const", "")]
		public QImage Image() {
			return ((QClipboard) interceptor).Image();
		}
		[SmokeMethod("pixmap", "(QClipboard::Mode) const", "$")]
		public QPixmap Pixmap(QClipboard.Mode mode) {
			return ((QClipboard) interceptor).Pixmap(mode);
		}
		[SmokeMethod("pixmap", "() const", "")]
		public QPixmap Pixmap() {
			return ((QClipboard) interceptor).Pixmap();
		}
		[SmokeMethod("setImage", "(const QImage&, QClipboard::Mode)", "#$")]
		public void SetImage(QImage arg1, QClipboard.Mode mode) {
			((QClipboard) interceptor).SetImage(arg1,mode);
		}
		[SmokeMethod("setImage", "(const QImage&)", "#")]
		public void SetImage(QImage arg1) {
			((QClipboard) interceptor).SetImage(arg1);
		}
		[SmokeMethod("setPixmap", "(const QPixmap&, QClipboard::Mode)", "#$")]
		public void SetPixmap(QPixmap arg1, QClipboard.Mode mode) {
			((QClipboard) interceptor).SetPixmap(arg1,mode);
		}
		[SmokeMethod("setPixmap", "(const QPixmap&)", "#")]
		public void SetPixmap(QPixmap arg1) {
			((QClipboard) interceptor).SetPixmap(arg1);
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQClipboardSignals Emit {
			get { return (IQClipboardSignals) Q_EMIT; }
		}
	}

	public interface IQClipboardSignals : IQObjectSignals {
	}
}
