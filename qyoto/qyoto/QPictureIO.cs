//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QPictureIO : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPictureIO(Type dummy) {}
		interface IQPictureIOProxy {
			QByteArray PictureFormat(string fileName);
			QByteArray PictureFormat(IQIODevice arg1);
		}

		protected void CreateQPictureIOProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPictureIO), this);
			_interceptor = (QPictureIO) realProxy.GetTransparentProxy();
		}
		private QPictureIO ProxyQPictureIO() {
			return (QPictureIO) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPictureIO() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPictureIOProxy), null);
			_staticInterceptor = (IQPictureIOProxy) realProxy.GetTransparentProxy();
		}
		private static IQPictureIOProxy StaticQPictureIO() {
			return (IQPictureIOProxy) _staticInterceptor;
		}

		public QPictureIO() : this((Type) null) {
			CreateQPictureIOProxy();
			NewQPictureIO();
		}
		private void NewQPictureIO() {
			ProxyQPictureIO().NewQPictureIO();
		}
		public QPictureIO(IQIODevice ioDevice, string format) : this((Type) null) {
			CreateQPictureIOProxy();
			NewQPictureIO(ioDevice,format);
		}
		private void NewQPictureIO(IQIODevice ioDevice, string format) {
			ProxyQPictureIO().NewQPictureIO(ioDevice,format);
		}
		public QPictureIO(string fileName, string format) : this((Type) null) {
			CreateQPictureIOProxy();
			NewQPictureIO(fileName,format);
		}
		private void NewQPictureIO(string fileName, string format) {
			ProxyQPictureIO().NewQPictureIO(fileName,format);
		}
		public QPicture Picture() {
			return ProxyQPictureIO().Picture();
		}
		public int Status() {
			return ProxyQPictureIO().Status();
		}
		public string Format() {
			return ProxyQPictureIO().Format();
		}
		public IQIODevice IoDevice() {
			return ProxyQPictureIO().IoDevice();
		}
		public string FileName() {
			return ProxyQPictureIO().FileName();
		}
		public int Quality() {
			return ProxyQPictureIO().Quality();
		}
		public string Description() {
			return ProxyQPictureIO().Description();
		}
		public string Parameters() {
			return ProxyQPictureIO().Parameters();
		}
		public float Gamma() {
			return ProxyQPictureIO().Gamma();
		}
		public void SetPicture(QPicture arg1) {
			ProxyQPictureIO().SetPicture(arg1);
		}
		public void SetStatus(int arg1) {
			ProxyQPictureIO().SetStatus(arg1);
		}
		public void SetFormat(string arg1) {
			ProxyQPictureIO().SetFormat(arg1);
		}
		public void SetIODevice(IQIODevice arg1) {
			ProxyQPictureIO().SetIODevice(arg1);
		}
		public void SetFileName(string arg1) {
			ProxyQPictureIO().SetFileName(arg1);
		}
		public void SetQuality(int arg1) {
			ProxyQPictureIO().SetQuality(arg1);
		}
		public void SetDescription(string arg1) {
			ProxyQPictureIO().SetDescription(arg1);
		}
		public void SetParameters(string arg1) {
			ProxyQPictureIO().SetParameters(arg1);
		}
		public void SetGamma(float arg1) {
			ProxyQPictureIO().SetGamma(arg1);
		}
		public bool Read() {
			return ProxyQPictureIO().Read();
		}
		public bool Write() {
			return ProxyQPictureIO().Write();
		}
		public static QByteArray PictureFormat(string fileName) {
			return StaticQPictureIO().PictureFormat(fileName);
		}
		public static QByteArray PictureFormat(IQIODevice arg1) {
			return StaticQPictureIO().PictureFormat(arg1);
		}
		// QList<QByteArray> inputFormats(); >>>> NOT CONVERTED
		// QList<QByteArray> outputFormats(); >>>> NOT CONVERTED
		// void defineIOHandler(const char* arg1,const char* arg2,const char* arg3,picture_io_handler arg4,picture_io_handler arg5); >>>> NOT CONVERTED
		~QPictureIO() {
			ProxyQPictureIO().Dispose();
		}
		public void Dispose() {
			ProxyQPictureIO().Dispose();
		}
	}
}
