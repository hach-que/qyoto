//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QImageIOHandler")]
	public abstract class QImageIOHandler : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QImageIOHandler(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QImageIOHandler), this);
			_interceptor = (QImageIOHandler) realProxy.GetTransparentProxy();
		}
		private QImageIOHandler ProxyQImageIOHandler() {
			return (QImageIOHandler) _interceptor;
		}
		public enum ImageOption {
			Size = 0,
			ClipRect = 1,
			Description = 2,
			ScaledClipRect = 3,
			ScaledSize = 4,
			CompressionRatio = 5,
			Gamma = 6,
			Quality = 7,
			Name = 8,
			SubType = 9,
			IncrementalReading = 10,
			Endianness = 11,
			Animation = 12,
			BackgroundColor = 13,
		}
		// QImageIOHandler* QImageIOHandler(QImageIOHandlerPrivate& arg1); >>>> NOT CONVERTED
		public QImageIOHandler() : this((Type) null) {
			CreateProxy();
			NewQImageIOHandler();
		}
		[SmokeMethod("QImageIOHandler", "()", "")]
		private void NewQImageIOHandler() {
			ProxyQImageIOHandler().NewQImageIOHandler();
		}
		[SmokeMethod("setDevice", "(QIODevice*)", "#")]
		public void SetDevice(QIODevice device) {
			ProxyQImageIOHandler().SetDevice(device);
		}
		[SmokeMethod("device", "() const", "")]
		public QIODevice Device() {
			return ProxyQImageIOHandler().Device();
		}
		[SmokeMethod("setFormat", "(const QByteArray&)", "#")]
		public void SetFormat(QByteArray format) {
			ProxyQImageIOHandler().SetFormat(format);
		}
		[SmokeMethod("format", "() const", "")]
		public QByteArray Format() {
			return ProxyQImageIOHandler().Format();
		}
		[SmokeMethod("name", "() const", "")]
		public virtual QByteArray Name() {
			return ProxyQImageIOHandler().Name();
		}
		public abstract bool CanRead();
		public abstract bool Read(QImage image);
		[SmokeMethod("write", "(const QImage&)", "#")]
		public virtual bool Write(QImage image) {
			return ProxyQImageIOHandler().Write(image);
		}
		[SmokeMethod("option", "(QImageIOHandler::ImageOption) const", "$")]
		public virtual QVariant Option(QImageIOHandler.ImageOption option) {
			return ProxyQImageIOHandler().Option(option);
		}
		[SmokeMethod("setOption", "(QImageIOHandler::ImageOption, const QVariant&)", "$#")]
		public virtual void SetOption(QImageIOHandler.ImageOption option, QVariant value) {
			ProxyQImageIOHandler().SetOption(option,value);
		}
		[SmokeMethod("supportsOption", "(QImageIOHandler::ImageOption) const", "$")]
		public virtual bool SupportsOption(QImageIOHandler.ImageOption option) {
			return ProxyQImageIOHandler().SupportsOption(option);
		}
		[SmokeMethod("jumpToNextImage", "()", "")]
		public virtual bool JumpToNextImage() {
			return ProxyQImageIOHandler().JumpToNextImage();
		}
		[SmokeMethod("jumpToImage", "(int)", "$")]
		public virtual bool JumpToImage(int imageNumber) {
			return ProxyQImageIOHandler().JumpToImage(imageNumber);
		}
		[SmokeMethod("loopCount", "() const", "")]
		public virtual int LoopCount() {
			return ProxyQImageIOHandler().LoopCount();
		}
		[SmokeMethod("imageCount", "() const", "")]
		public virtual int ImageCount() {
			return ProxyQImageIOHandler().ImageCount();
		}
		[SmokeMethod("nextImageDelay", "() const", "")]
		public virtual int NextImageDelay() {
			return ProxyQImageIOHandler().NextImageDelay();
		}
		[SmokeMethod("currentImageNumber", "() const", "")]
		public virtual int CurrentImageNumber() {
			return ProxyQImageIOHandler().CurrentImageNumber();
		}
		[SmokeMethod("currentImageRect", "() const", "")]
		public virtual QRect CurrentImageRect() {
			return ProxyQImageIOHandler().CurrentImageRect();
		}
	}
}
