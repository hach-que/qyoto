//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QImageReader")]
	public class QImageReader : MarshalByRefObject, IDisposable {
		protected QImageReader interceptor = null;
		private IntPtr smokeObject;
		protected QImageReader(Type dummy) {}
		[SmokeClass("QImageReader")]
		interface IQImageReaderProxy {
			[SmokeMethod("imageFormat", "(const QString&)", "$")]
			QByteArray ImageFormat(string fileName);
			[SmokeMethod("imageFormat", "(QIODevice*)", "#")]
			QByteArray ImageFormat(QIODevice device);
			[SmokeMethod("supportedImageFormats", "()", "")]
			List<QByteArray> SupportedImageFormats();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QImageReader), this);
			interceptor = (QImageReader) realProxy.GetTransparentProxy();
		}
		private static IQImageReaderProxy staticInterceptor = null;
		static QImageReader() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQImageReaderProxy), null);
			staticInterceptor = (IQImageReaderProxy) realProxy.GetTransparentProxy();
		}
		public enum ImageReaderError {
			UnknownError = 0,
			FileNotFoundError = 1,
			DeviceError = 2,
			UnsupportedFormatError = 3,
			InvalidDataError = 4,
		}
		public QImageReader() : this((Type) null) {
			CreateProxy();
			NewQImageReader();
		}
		[SmokeMethod("QImageReader", "()", "")]
		private void NewQImageReader() {
			((QImageReader) interceptor).NewQImageReader();
		}
		public QImageReader(QIODevice device, QByteArray format) : this((Type) null) {
			CreateProxy();
			NewQImageReader(device,format);
		}
		[SmokeMethod("QImageReader", "(QIODevice*, const QByteArray&)", "##")]
		private void NewQImageReader(QIODevice device, QByteArray format) {
			((QImageReader) interceptor).NewQImageReader(device,format);
		}
		public QImageReader(QIODevice device) : this((Type) null) {
			CreateProxy();
			NewQImageReader(device);
		}
		[SmokeMethod("QImageReader", "(QIODevice*)", "#")]
		private void NewQImageReader(QIODevice device) {
			((QImageReader) interceptor).NewQImageReader(device);
		}
		public QImageReader(string fileName, QByteArray format) : this((Type) null) {
			CreateProxy();
			NewQImageReader(fileName,format);
		}
		[SmokeMethod("QImageReader", "(const QString&, const QByteArray&)", "$#")]
		private void NewQImageReader(string fileName, QByteArray format) {
			((QImageReader) interceptor).NewQImageReader(fileName,format);
		}
		public QImageReader(string fileName) : this((Type) null) {
			CreateProxy();
			NewQImageReader(fileName);
		}
		[SmokeMethod("QImageReader", "(const QString&)", "$")]
		private void NewQImageReader(string fileName) {
			((QImageReader) interceptor).NewQImageReader(fileName);
		}
		[SmokeMethod("setFormat", "(const QByteArray&)", "#")]
		public void SetFormat(QByteArray format) {
			((QImageReader) interceptor).SetFormat(format);
		}
		[SmokeMethod("format", "() const", "")]
		public QByteArray Format() {
			return ((QImageReader) interceptor).Format();
		}
		[SmokeMethod("setDevice", "(QIODevice*)", "#")]
		public void SetDevice(QIODevice device) {
			((QImageReader) interceptor).SetDevice(device);
		}
		[SmokeMethod("device", "() const", "")]
		public QIODevice Device() {
			return ((QImageReader) interceptor).Device();
		}
		[SmokeMethod("setFileName", "(const QString&)", "$")]
		public void SetFileName(string fileName) {
			((QImageReader) interceptor).SetFileName(fileName);
		}
		[SmokeMethod("fileName", "() const", "")]
		public string FileName() {
			return ((QImageReader) interceptor).FileName();
		}
		[SmokeMethod("size", "() const", "")]
		public QSize Size() {
			return ((QImageReader) interceptor).Size();
		}
		[SmokeMethod("textKeys", "() const", "")]
		public List<string> TextKeys() {
			return ((QImageReader) interceptor).TextKeys();
		}
		[SmokeMethod("text", "(const QString&) const", "$")]
		public string Text(string key) {
			return ((QImageReader) interceptor).Text(key);
		}
		[SmokeMethod("setClipRect", "(const QRect&)", "#")]
		public void SetClipRect(QRect rect) {
			((QImageReader) interceptor).SetClipRect(rect);
		}
		[SmokeMethod("clipRect", "() const", "")]
		public QRect ClipRect() {
			return ((QImageReader) interceptor).ClipRect();
		}
		[SmokeMethod("setScaledSize", "(const QSize&)", "#")]
		public void SetScaledSize(QSize size) {
			((QImageReader) interceptor).SetScaledSize(size);
		}
		[SmokeMethod("scaledSize", "() const", "")]
		public QSize ScaledSize() {
			return ((QImageReader) interceptor).ScaledSize();
		}
		[SmokeMethod("setQuality", "(int)", "$")]
		public void SetQuality(int quality) {
			((QImageReader) interceptor).SetQuality(quality);
		}
		[SmokeMethod("quality", "() const", "")]
		public int Quality() {
			return ((QImageReader) interceptor).Quality();
		}
		[SmokeMethod("setScaledClipRect", "(const QRect&)", "#")]
		public void SetScaledClipRect(QRect rect) {
			((QImageReader) interceptor).SetScaledClipRect(rect);
		}
		[SmokeMethod("scaledClipRect", "() const", "")]
		public QRect ScaledClipRect() {
			return ((QImageReader) interceptor).ScaledClipRect();
		}
		[SmokeMethod("setBackgroundColor", "(const QColor&)", "#")]
		public void SetBackgroundColor(QColor color) {
			((QImageReader) interceptor).SetBackgroundColor(color);
		}
		[SmokeMethod("backgroundColor", "() const", "")]
		public QColor BackgroundColor() {
			return ((QImageReader) interceptor).BackgroundColor();
		}
		[SmokeMethod("supportsAnimation", "() const", "")]
		public bool SupportsAnimation() {
			return ((QImageReader) interceptor).SupportsAnimation();
		}
		[SmokeMethod("canRead", "() const", "")]
		public bool CanRead() {
			return ((QImageReader) interceptor).CanRead();
		}
		[SmokeMethod("read", "()", "")]
		public QImage Read() {
			return ((QImageReader) interceptor).Read();
		}
		[SmokeMethod("read", "(QImage*)", "#")]
		public bool Read(QImage image) {
			return ((QImageReader) interceptor).Read(image);
		}
		[SmokeMethod("jumpToNextImage", "()", "")]
		public bool JumpToNextImage() {
			return ((QImageReader) interceptor).JumpToNextImage();
		}
		[SmokeMethod("jumpToImage", "(int)", "$")]
		public bool JumpToImage(int imageNumber) {
			return ((QImageReader) interceptor).JumpToImage(imageNumber);
		}
		[SmokeMethod("loopCount", "() const", "")]
		public int LoopCount() {
			return ((QImageReader) interceptor).LoopCount();
		}
		[SmokeMethod("imageCount", "() const", "")]
		public int ImageCount() {
			return ((QImageReader) interceptor).ImageCount();
		}
		[SmokeMethod("nextImageDelay", "() const", "")]
		public int NextImageDelay() {
			return ((QImageReader) interceptor).NextImageDelay();
		}
		[SmokeMethod("currentImageNumber", "() const", "")]
		public int CurrentImageNumber() {
			return ((QImageReader) interceptor).CurrentImageNumber();
		}
		[SmokeMethod("currentImageRect", "() const", "")]
		public QRect CurrentImageRect() {
			return ((QImageReader) interceptor).CurrentImageRect();
		}
		[SmokeMethod("error", "() const", "")]
		public int Error() {
			return ((QImageReader) interceptor).Error();
		}
		[SmokeMethod("errorString", "() const", "")]
		public string ErrorString() {
			return ((QImageReader) interceptor).ErrorString();
		}
		[SmokeMethod("supportsOption", "(QImageIOHandler::ImageOption) const", "$")]
		public bool SupportsOption(QImageIOHandler.ImageOption option) {
			return ((QImageReader) interceptor).SupportsOption(option);
		}
		~QImageReader() {
			DisposeQImageReader();
		}
		public void Dispose() {
			DisposeQImageReader();
		}
		[SmokeMethod("~QImageReader", "()", "")]
		private void DisposeQImageReader() {
			((QImageReader) interceptor).DisposeQImageReader();
		}
		public static QByteArray ImageFormat(string fileName) {
			return staticInterceptor.ImageFormat(fileName);
		}
		public static QByteArray ImageFormat(QIODevice device) {
			return staticInterceptor.ImageFormat(device);
		}
		public static List<QByteArray> SupportedImageFormats() {
			return staticInterceptor.SupportedImageFormats();
		}
	}
}
