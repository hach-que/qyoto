//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QImageReader : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QImageReader(Type dummy) {}
		interface IQImageReaderProxy {
			QByteArray ImageFormat(string fileName);
			QByteArray ImageFormat(IQIODevice device);
		}

		protected void CreateQImageReaderProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QImageReader), this);
			_interceptor = (QImageReader) realProxy.GetTransparentProxy();
		}
		private QImageReader ProxyQImageReader() {
			return (QImageReader) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QImageReader() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQImageReaderProxy), null);
			_staticInterceptor = (IQImageReaderProxy) realProxy.GetTransparentProxy();
		}
		private static IQImageReaderProxy StaticQImageReader() {
			return (IQImageReaderProxy) _staticInterceptor;
		}

		enum ImageReaderError {
			UnknownError = 0,
			FileNotFoundError = 1,
			DeviceError = 2,
			UnsupportedFormatError = 3,
			InvalidDataError = 4,
		}
		public QImageReader() : this((Type) null) {
			CreateQImageReaderProxy();
			NewQImageReader();
		}
		private void NewQImageReader() {
			ProxyQImageReader().NewQImageReader();
		}
		public QImageReader(IQIODevice device, QByteArray format) : this((Type) null) {
			CreateQImageReaderProxy();
			NewQImageReader(device,format);
		}
		private void NewQImageReader(IQIODevice device, QByteArray format) {
			ProxyQImageReader().NewQImageReader(device,format);
		}
		public QImageReader(IQIODevice device) : this((Type) null) {
			CreateQImageReaderProxy();
			NewQImageReader(device);
		}
		private void NewQImageReader(IQIODevice device) {
			ProxyQImageReader().NewQImageReader(device);
		}
		public QImageReader(string fileName, QByteArray format) : this((Type) null) {
			CreateQImageReaderProxy();
			NewQImageReader(fileName,format);
		}
		private void NewQImageReader(string fileName, QByteArray format) {
			ProxyQImageReader().NewQImageReader(fileName,format);
		}
		public QImageReader(string fileName) : this((Type) null) {
			CreateQImageReaderProxy();
			NewQImageReader(fileName);
		}
		private void NewQImageReader(string fileName) {
			ProxyQImageReader().NewQImageReader(fileName);
		}
		public void SetFormat(QByteArray format) {
			ProxyQImageReader().SetFormat(format);
		}
		public QByteArray Format() {
			return ProxyQImageReader().Format();
		}
		public void SetDevice(IQIODevice device) {
			ProxyQImageReader().SetDevice(device);
		}
		public IQIODevice Device() {
			return ProxyQImageReader().Device();
		}
		public void SetFileName(string fileName) {
			ProxyQImageReader().SetFileName(fileName);
		}
		public string FileName() {
			return ProxyQImageReader().FileName();
		}
		public QSize Size() {
			return ProxyQImageReader().Size();
		}
		public void SetClipRect(QRect rect) {
			ProxyQImageReader().SetClipRect(rect);
		}
		public QRect ClipRect() {
			return ProxyQImageReader().ClipRect();
		}
		public void SetScaledSize(QSize size) {
			ProxyQImageReader().SetScaledSize(size);
		}
		public QSize ScaledSize() {
			return ProxyQImageReader().ScaledSize();
		}
		public void SetScaledClipRect(QRect rect) {
			ProxyQImageReader().SetScaledClipRect(rect);
		}
		public QRect ScaledClipRect() {
			return ProxyQImageReader().ScaledClipRect();
		}
		public bool CanRead() {
			return ProxyQImageReader().CanRead();
		}
		public QImage Read() {
			return ProxyQImageReader().Read();
		}
		public bool JumpToNextImage() {
			return ProxyQImageReader().JumpToNextImage();
		}
		public bool JumpToImage(int imageNumber) {
			return ProxyQImageReader().JumpToImage(imageNumber);
		}
		public int LoopCount() {
			return ProxyQImageReader().LoopCount();
		}
		public int ImageCount() {
			return ProxyQImageReader().ImageCount();
		}
		public int NextImageDelay() {
			return ProxyQImageReader().NextImageDelay();
		}
		public int CurrentImageNumber() {
			return ProxyQImageReader().CurrentImageNumber();
		}
		public QRect CurrentImageRect() {
			return ProxyQImageReader().CurrentImageRect();
		}
		public int Error() {
			return ProxyQImageReader().Error();
		}
		public string ErrorString() {
			return ProxyQImageReader().ErrorString();
		}
		public static QByteArray ImageFormat(string fileName) {
			return StaticQImageReader().ImageFormat(fileName);
		}
		public static QByteArray ImageFormat(IQIODevice device) {
			return StaticQImageReader().ImageFormat(device);
		}
		// QList<QByteArray> supportedImageFormats(); >>>> NOT CONVERTED
		~QImageReader() {
			ProxyQImageReader().Dispose();
		}
		public void Dispose() {
			ProxyQImageReader().Dispose();
		}
	}
}
