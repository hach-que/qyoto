//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAbstractPrintDialog")]
	public abstract class QAbstractPrintDialog : QDialog {
 		protected QAbstractPrintDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAbstractPrintDialog), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QAbstractPrintDialog() {
			staticInterceptor = new SmokeInvocation(typeof(QAbstractPrintDialog), null);
		}
		public enum PrintRange {
			AllPages = 0,
			Selection = 1,
			PageRange = 2,
		}
		public enum PrintDialogOption {
			None = 0x0000,
			PrintToFile = 0x0001,
			PrintSelection = 0x0002,
			PrintPageRange = 0x0004,
			PrintCollateCopies = 0x0010,
		}
		public QAbstractPrintDialog(QPrinter printer, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractPrintDialog##", "QAbstractPrintDialog(QPrinter*, QWidget*)", typeof(void), typeof(QPrinter), printer, typeof(QWidget), parent);
		}
		public QAbstractPrintDialog(QPrinter printer) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractPrintDialog#", "QAbstractPrintDialog(QPrinter*)", typeof(void), typeof(QPrinter), printer);
		}
		[SmokeMethod("exec()")]
		public abstract int Exec();
		public void AddEnabledOption(QAbstractPrintDialog.PrintDialogOption option) {
			interceptor.Invoke("addEnabledOption$", "addEnabledOption(QAbstractPrintDialog::PrintDialogOption)", typeof(void), typeof(QAbstractPrintDialog.PrintDialogOption), option);
		}
		public void SetEnabledOptions(int options) {
			interceptor.Invoke("setEnabledOptions$", "setEnabledOptions(PrintDialogOptions)", typeof(void), typeof(int), options);
		}
		public int EnabledOptions() {
			return (int) interceptor.Invoke("enabledOptions", "enabledOptions() const", typeof(int));
		}
		public bool IsOptionEnabled(QAbstractPrintDialog.PrintDialogOption option) {
			return (bool) interceptor.Invoke("isOptionEnabled$", "isOptionEnabled(QAbstractPrintDialog::PrintDialogOption) const", typeof(bool), typeof(QAbstractPrintDialog.PrintDialogOption), option);
		}
		public void SetPrintRange(QAbstractPrintDialog.PrintRange range) {
			interceptor.Invoke("setPrintRange$", "setPrintRange(QAbstractPrintDialog::PrintRange)", typeof(void), typeof(QAbstractPrintDialog.PrintRange), range);
		}
		public QAbstractPrintDialog.PrintRange printRange() {
			return (QAbstractPrintDialog.PrintRange) interceptor.Invoke("printRange", "printRange() const", typeof(QAbstractPrintDialog.PrintRange));
		}
		public void SetMinMax(int min, int max) {
			interceptor.Invoke("setMinMax$$", "setMinMax(int, int)", typeof(void), typeof(int), min, typeof(int), max);
		}
		public int MinPage() {
			return (int) interceptor.Invoke("minPage", "minPage() const", typeof(int));
		}
		public int MaxPage() {
			return (int) interceptor.Invoke("maxPage", "maxPage() const", typeof(int));
		}
		public void SetFromTo(int fromPage, int toPage) {
			interceptor.Invoke("setFromTo$$", "setFromTo(int, int)", typeof(void), typeof(int), fromPage, typeof(int), toPage);
		}
		public int FromPage() {
			return (int) interceptor.Invoke("fromPage", "fromPage() const", typeof(int));
		}
		public int ToPage() {
			return (int) interceptor.Invoke("toPage", "toPage() const", typeof(int));
		}
		public QPrinter Printer() {
			return (QPrinter) interceptor.Invoke("printer", "printer() const", typeof(QPrinter));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQAbstractPrintDialogSignals Emit {
			get { return (IQAbstractPrintDialogSignals) Q_EMIT; }
		}
	}

	public interface IQAbstractPrintDialogSignals : IQDialogSignals {
	}
}
