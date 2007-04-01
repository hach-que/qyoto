//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QMimeData")]
	public class QMimeData : QObject, IDisposable {
 		protected QMimeData(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QMimeData), "QMimeData", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QMimeData() {
			staticInterceptor = new SmokeInvocation(typeof(QMimeData), "QMimeData", null);
		}
		public QMimeData() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMimeData", "QMimeData()", typeof(void));
		}
		public List<QUrl> Urls() {
			return (List<QUrl>) interceptor.Invoke("urls", "urls() const", typeof(List<QUrl>));
		}
		public void SetUrls(List<QUrl> urls) {
			interceptor.Invoke("setUrls?", "setUrls(const QList<QUrl>&)", typeof(void), typeof(List<QUrl>), urls);
		}
		public bool HasUrls() {
			return (bool) interceptor.Invoke("hasUrls", "hasUrls() const", typeof(bool));
		}
		public string Text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		public void SetText(string text) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
		}
		public bool HasText() {
			return (bool) interceptor.Invoke("hasText", "hasText() const", typeof(bool));
		}
		public string Html() {
			return (string) interceptor.Invoke("html", "html() const", typeof(string));
		}
		public void SetHtml(string html) {
			interceptor.Invoke("setHtml$", "setHtml(const QString&)", typeof(void), typeof(string), html);
		}
		public bool HasHtml() {
			return (bool) interceptor.Invoke("hasHtml", "hasHtml() const", typeof(bool));
		}
		public QVariant ImageData() {
			return (QVariant) interceptor.Invoke("imageData", "imageData() const", typeof(QVariant));
		}
		public void SetImageData(QVariant image) {
			interceptor.Invoke("setImageData#", "setImageData(const QVariant&)", typeof(void), typeof(QVariant), image);
		}
		public bool HasImage() {
			return (bool) interceptor.Invoke("hasImage", "hasImage() const", typeof(bool));
		}
		public QVariant ColorData() {
			return (QVariant) interceptor.Invoke("colorData", "colorData() const", typeof(QVariant));
		}
		public void SetColorData(QVariant color) {
			interceptor.Invoke("setColorData#", "setColorData(const QVariant&)", typeof(void), typeof(QVariant), color);
		}
		public bool HasColor() {
			return (bool) interceptor.Invoke("hasColor", "hasColor() const", typeof(bool));
		}
		public QByteArray Data(string mimetype) {
			return (QByteArray) interceptor.Invoke("data$", "data(const QString&) const", typeof(QByteArray), typeof(string), mimetype);
		}
		public void SetData(string mimetype, QByteArray data) {
			interceptor.Invoke("setData$#", "setData(const QString&, const QByteArray&)", typeof(void), typeof(string), mimetype, typeof(QByteArray), data);
		}
		[SmokeMethod("hasFormat(const QString&) const")]
		public virtual bool HasFormat(string mimetype) {
			return (bool) interceptor.Invoke("hasFormat$", "hasFormat(const QString&) const", typeof(bool), typeof(string), mimetype);
		}
		[SmokeMethod("formats() const")]
		public virtual List<string> Formats() {
			return (List<string>) interceptor.Invoke("formats", "formats() const", typeof(List<string>));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[SmokeMethod("retrieveData(const QString&, QVariant::Type) const")]
		protected virtual QVariant RetrieveData(string mimetype, QVariant.TypeOf preferredType) {
			return (QVariant) interceptor.Invoke("retrieveData$$", "retrieveData(const QString&, QVariant::Type) const", typeof(QVariant), typeof(string), mimetype, typeof(QVariant.TypeOf), preferredType);
		}
		~QMimeData() {
			interceptor.Invoke("~QMimeData", "~QMimeData()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QMimeData", "~QMimeData()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQMimeDataSignals Emit {
			get { return (IQMimeDataSignals) Q_EMIT; }
		}
	}

	public interface IQMimeDataSignals : IQObjectSignals {
	}
}
