//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QPrinterInfo")]
	public class QPrinterInfo : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QPrinterInfo(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QPrinterInfo), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QPrinterInfo() {
			staticInterceptor = new SmokeInvocation(typeof(QPrinterInfo), null);
		}
		// QList<QPrinter::PaperSize> supportedPaperSizes(); >>>> NOT CONVERTED
		public QPrinterInfo() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPrinterInfo", "QPrinterInfo()", typeof(void));
		}
		public QPrinterInfo(QPrinterInfo src) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPrinterInfo#", "QPrinterInfo(const QPrinterInfo&)", typeof(void), typeof(QPrinterInfo), src);
		}
		public QPrinterInfo(QPrinter printer) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPrinterInfo#", "QPrinterInfo(const QPrinter&)", typeof(void), typeof(QPrinter), printer);
		}
		public string PrinterName() {
			return (string) interceptor.Invoke("printerName", "printerName() const", typeof(string));
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public bool IsDefault() {
			return (bool) interceptor.Invoke("isDefault", "isDefault() const", typeof(bool));
		}
		~QPrinterInfo() {
			interceptor.Invoke("~QPrinterInfo", "~QPrinterInfo()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QPrinterInfo", "~QPrinterInfo()", typeof(void));
		}
		public static List<QPrinterInfo> AvailablePrinters() {
			return (List<QPrinterInfo>) staticInterceptor.Invoke("availablePrinters", "availablePrinters()", typeof(List<QPrinterInfo>));
		}
		public static QPrinterInfo DefaultPrinter() {
			return (QPrinterInfo) staticInterceptor.Invoke("defaultPrinter", "defaultPrinter()", typeof(QPrinterInfo));
		}
	}
}
