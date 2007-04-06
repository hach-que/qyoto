//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QPictureIO")]
	public class QPictureIO : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QPictureIO(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QPictureIO), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QPictureIO() {
			staticInterceptor = new SmokeInvocation(typeof(QPictureIO), null);
		}
		// void defineIOHandler(const char* arg1,const char* arg2,const char* arg3,picture_io_handler arg4,picture_io_handler arg5); >>>> NOT CONVERTED
		public QPictureIO() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPictureIO", "QPictureIO()", typeof(void));
		}
		public QPictureIO(QIODevice ioDevice, string format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPictureIO#$", "QPictureIO(QIODevice*, const char*)", typeof(void), typeof(QIODevice), ioDevice, typeof(string), format);
		}
		public QPictureIO(string fileName, string format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPictureIO$$", "QPictureIO(const QString&, const char*)", typeof(void), typeof(string), fileName, typeof(string), format);
		}
		public QPicture Picture() {
			return (QPicture) interceptor.Invoke("picture", "picture() const", typeof(QPicture));
		}
		public int Status() {
			return (int) interceptor.Invoke("status", "status() const", typeof(int));
		}
		public string Format() {
			return (string) interceptor.Invoke("format", "format() const", typeof(string));
		}
		public QIODevice IoDevice() {
			return (QIODevice) interceptor.Invoke("ioDevice", "ioDevice() const", typeof(QIODevice));
		}
		public string FileName() {
			return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
		}
		public int Quality() {
			return (int) interceptor.Invoke("quality", "quality() const", typeof(int));
		}
		public string Description() {
			return (string) interceptor.Invoke("description", "description() const", typeof(string));
		}
		public string Parameters() {
			return (string) interceptor.Invoke("parameters", "parameters() const", typeof(string));
		}
		public float Gamma() {
			return (float) interceptor.Invoke("gamma", "gamma() const", typeof(float));
		}
		public void SetPicture(QPicture arg1) {
			interceptor.Invoke("setPicture#", "setPicture(const QPicture&)", typeof(void), typeof(QPicture), arg1);
		}
		public void SetStatus(int arg1) {
			interceptor.Invoke("setStatus$", "setStatus(int)", typeof(void), typeof(int), arg1);
		}
		public void SetFormat(string arg1) {
			interceptor.Invoke("setFormat$", "setFormat(const char*)", typeof(void), typeof(string), arg1);
		}
		public void SetIODevice(QIODevice arg1) {
			interceptor.Invoke("setIODevice#", "setIODevice(QIODevice*)", typeof(void), typeof(QIODevice), arg1);
		}
		public void SetFileName(string arg1) {
			interceptor.Invoke("setFileName$", "setFileName(const QString&)", typeof(void), typeof(string), arg1);
		}
		public void SetQuality(int arg1) {
			interceptor.Invoke("setQuality$", "setQuality(int)", typeof(void), typeof(int), arg1);
		}
		public void SetDescription(string arg1) {
			interceptor.Invoke("setDescription$", "setDescription(const QString&)", typeof(void), typeof(string), arg1);
		}
		public void SetParameters(string arg1) {
			interceptor.Invoke("setParameters$", "setParameters(const char*)", typeof(void), typeof(string), arg1);
		}
		public void SetGamma(float arg1) {
			interceptor.Invoke("setGamma$", "setGamma(float)", typeof(void), typeof(float), arg1);
		}
		public bool Read() {
			return (bool) interceptor.Invoke("read", "read()", typeof(bool));
		}
		public bool Write() {
			return (bool) interceptor.Invoke("write", "write()", typeof(bool));
		}
		~QPictureIO() {
			interceptor.Invoke("~QPictureIO", "~QPictureIO()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QPictureIO", "~QPictureIO()", typeof(void));
		}
		public static QByteArray PictureFormat(string fileName) {
			return (QByteArray) staticInterceptor.Invoke("pictureFormat$", "pictureFormat(const QString&)", typeof(QByteArray), typeof(string), fileName);
		}
		public static QByteArray PictureFormat(QIODevice arg1) {
			return (QByteArray) staticInterceptor.Invoke("pictureFormat#", "pictureFormat(QIODevice*)", typeof(QByteArray), typeof(QIODevice), arg1);
		}
		public static List<QByteArray> InputFormats() {
			return (List<QByteArray>) staticInterceptor.Invoke("inputFormats", "inputFormats()", typeof(List<QByteArray>));
		}
		public static List<QByteArray> OutputFormats() {
			return (List<QByteArray>) staticInterceptor.Invoke("outputFormats", "outputFormats()", typeof(List<QByteArray>));
		}
	}
}
