//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QMimeData")]
	public class QMimeData : QObject, IDisposable {
 		protected QMimeData(Type dummy) : base((Type) null) {}
		interface IQMimeDataProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMimeData), this);
			_interceptor = (QMimeData) realProxy.GetTransparentProxy();
		}
		private QMimeData ProxyQMimeData() {
			return (QMimeData) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMimeData() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMimeDataProxy), null);
			_staticInterceptor = (IQMimeDataProxy) realProxy.GetTransparentProxy();
		}
		private static IQMimeDataProxy StaticQMimeData() {
			return (IQMimeDataProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QMimeData() : this((Type) null) {
			CreateProxy();
			NewQMimeData();
		}
		[SmokeMethod("QMimeData()")]
		private void NewQMimeData() {
			ProxyQMimeData().NewQMimeData();
		}
		[SmokeMethod("urls() const")]
		public List<QUrl> Urls() {
			return ProxyQMimeData().Urls();
		}
		[SmokeMethod("setUrls(const QList<QUrl>&)")]
		public void SetUrls(List<QUrl> urls) {
			ProxyQMimeData().SetUrls(urls);
		}
		[SmokeMethod("hasUrls() const")]
		public bool HasUrls() {
			return ProxyQMimeData().HasUrls();
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQMimeData().Text();
		}
		[SmokeMethod("setText(const QString&)")]
		public void SetText(string text) {
			ProxyQMimeData().SetText(text);
		}
		[SmokeMethod("hasText() const")]
		public bool HasText() {
			return ProxyQMimeData().HasText();
		}
		[SmokeMethod("html() const")]
		public string Html() {
			return ProxyQMimeData().Html();
		}
		[SmokeMethod("setHtml(const QString&)")]
		public void SetHtml(string html) {
			ProxyQMimeData().SetHtml(html);
		}
		[SmokeMethod("hasHtml() const")]
		public bool HasHtml() {
			return ProxyQMimeData().HasHtml();
		}
		[SmokeMethod("imageData() const")]
		public QVariant ImageData() {
			return ProxyQMimeData().ImageData();
		}
		[SmokeMethod("setImageData(const QVariant&)")]
		public void SetImageData(QVariant image) {
			ProxyQMimeData().SetImageData(image);
		}
		[SmokeMethod("hasImage() const")]
		public bool HasImage() {
			return ProxyQMimeData().HasImage();
		}
		[SmokeMethod("colorData() const")]
		public QVariant ColorData() {
			return ProxyQMimeData().ColorData();
		}
		[SmokeMethod("setColorData(const QVariant&)")]
		public void SetColorData(QVariant color) {
			ProxyQMimeData().SetColorData(color);
		}
		[SmokeMethod("hasColor() const")]
		public bool HasColor() {
			return ProxyQMimeData().HasColor();
		}
		[SmokeMethod("data(const QString&) const")]
		public QByteArray Data(string mimetype) {
			return ProxyQMimeData().Data(mimetype);
		}
		[SmokeMethod("setData(const QString&, const QByteArray&)")]
		public void SetData(string mimetype, QByteArray data) {
			ProxyQMimeData().SetData(mimetype,data);
		}
		[SmokeMethod("hasFormat(const QString&) const")]
		public virtual bool HasFormat(string mimetype) {
			return ProxyQMimeData().HasFormat(mimetype);
		}
		[SmokeMethod("formats() const")]
		public virtual List<string> Formats() {
			return ProxyQMimeData().Formats();
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQMimeData().Clear();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQMimeData().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQMimeData().Tr(s);
		}
		[SmokeMethod("retrieveData(const QString&, QVariant::Type) const")]
		protected virtual QVariant RetrieveData(string mimetype, QVariant.E_Type preferredType) {
			return ProxyQMimeData().RetrieveData(mimetype,preferredType);
		}
		~QMimeData() {
			DisposeQMimeData();
		}
		public new void Dispose() {
			DisposeQMimeData();
		}
		[SmokeMethod("~QMimeData()")]
		private void DisposeQMimeData() {
			ProxyQMimeData().DisposeQMimeData();
		}
		protected new IQMimeDataSignals Emit() {
			return (IQMimeDataSignals) Q_EMIT;
		}
	}

	public interface IQMimeDataSignals : IQObjectSignals {
	}
}