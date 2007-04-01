//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQFileDialogSignals"></see> for signals emitted by QFileDialog
	[SmokeClass("QFileDialog")]
	public class QFileDialog : QDialog, IDisposable {
 		protected QFileDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QFileDialog), "QFileDialog", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QFileDialog() {
			staticInterceptor = new SmokeInvocation(typeof(QFileDialog), "QFileDialog", null);
		}
		public enum ViewMode {
			Detail = 0,
			List = 1,
		}
		public enum FileMode {
			AnyFile = 0,
			ExistingFile = 1,
			Directory = 2,
			ExistingFiles = 3,
			DirectoryOnly = 4,
		}
		public enum AcceptMode {
			AcceptOpen = 0,
			AcceptSave = 1,
		}
		public enum DialogLabel {
			LookIn = 0,
			FileName = 1,
			FileType = 2,
			Accept = 3,
			Reject = 4,
		}
		public enum Option {
			ShowDirsOnly = 0x01,
			DontResolveSymlinks = 0x02,
			DontConfirmOverwrite = 0x04,
			DontUseSheet = 0x08,
			DontUseNativeDialog = 0x10,
		}
		[Q_PROPERTY("QFileDialog::ViewMode", "viewMode")]
		public QFileDialog.ViewMode viewMode {
			get { return (QFileDialog.ViewMode) interceptor.Invoke("viewMode", "viewMode()", typeof(QFileDialog.ViewMode)); }
			set { interceptor.Invoke("setViewMode$", "setViewMode(QFileDialog::ViewMode)", typeof(void), typeof(QFileDialog.ViewMode), value); }
		}
		[Q_PROPERTY("QFileDialog::FileMode", "fileMode")]
		public QFileDialog.FileMode fileMode {
			get { return (QFileDialog.FileMode) interceptor.Invoke("fileMode", "fileMode()", typeof(QFileDialog.FileMode)); }
			set { interceptor.Invoke("setFileMode$", "setFileMode(QFileDialog::FileMode)", typeof(void), typeof(QFileDialog.FileMode), value); }
		}
		[Q_PROPERTY("QFileDialog::AcceptMode", "acceptMode")]
		public QFileDialog.AcceptMode acceptMode {
			get { return (QFileDialog.AcceptMode) interceptor.Invoke("acceptMode", "acceptMode()", typeof(QFileDialog.AcceptMode)); }
			set { interceptor.Invoke("setAcceptMode$", "setAcceptMode(QFileDialog::AcceptMode)", typeof(void), typeof(QFileDialog.AcceptMode), value); }
		}
		[Q_PROPERTY("bool", "readOnly")]
		public bool ReadOnly {
			get { return (bool) interceptor.Invoke("isReadOnly", "isReadOnly()", typeof(bool)); }
			set { interceptor.Invoke("setReadOnly$", "setReadOnly(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "resolveSymlinks")]
		public bool ResolveSymlinks {
			get { return (bool) interceptor.Invoke("resolveSymlinks", "resolveSymlinks()", typeof(bool)); }
			set { interceptor.Invoke("setResolveSymlinks$", "setResolveSymlinks(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "confirmOverwrite")]
		public bool ConfirmOverwrite {
			get { return (bool) interceptor.Invoke("confirmOverwrite", "confirmOverwrite()", typeof(bool)); }
			set { interceptor.Invoke("setConfirmOverwrite$", "setConfirmOverwrite(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QString", "defaultSuffix")]
		public string DefaultSuffix {
			get { return (string) interceptor.Invoke("defaultSuffix", "defaultSuffix()", typeof(string)); }
			set { interceptor.Invoke("setDefaultSuffix$", "setDefaultSuffix(QString)", typeof(void), typeof(string), value); }
		}
		// QFileDialog* QFileDialog(const QFileDialogArgs& arg1); >>>> NOT CONVERTED
		public QFileDialog(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileDialog#$", "QFileDialog(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(int), f);
		}
		public QFileDialog(QWidget parent, string caption, string directory, string filter) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileDialog#$$$", "QFileDialog(QWidget*, const QString&, const QString&, const QString&)", typeof(void), typeof(QWidget), parent, typeof(string), caption, typeof(string), directory, typeof(string), filter);
		}
		public QFileDialog(QWidget parent, string caption, string directory) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileDialog#$$", "QFileDialog(QWidget*, const QString&, const QString&)", typeof(void), typeof(QWidget), parent, typeof(string), caption, typeof(string), directory);
		}
		public QFileDialog(QWidget parent, string caption) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileDialog#$", "QFileDialog(QWidget*, const QString&)", typeof(void), typeof(QWidget), parent, typeof(string), caption);
		}
		public QFileDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileDialog#", "QFileDialog(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QFileDialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileDialog", "QFileDialog()", typeof(void));
		}
		public void SetDirectory(string directory) {
			interceptor.Invoke("setDirectory$", "setDirectory(const QString&)", typeof(void), typeof(string), directory);
		}
		public void SetDirectory(QDir directory) {
			interceptor.Invoke("setDirectory#", "setDirectory(const QDir&)", typeof(void), typeof(QDir), directory);
		}
		public QDir Directory() {
			return (QDir) interceptor.Invoke("directory", "directory() const", typeof(QDir));
		}
		public void SelectFile(string filename) {
			interceptor.Invoke("selectFile$", "selectFile(const QString&)", typeof(void), typeof(string), filename);
		}
		public List<string> SelectedFiles() {
			return (List<string>) interceptor.Invoke("selectedFiles", "selectedFiles() const", typeof(List<string>));
		}
		public void SetFilter(string filter) {
			interceptor.Invoke("setFilter$", "setFilter(const QString&)", typeof(void), typeof(string), filter);
		}
		public void SetFilters(List<string> filters) {
			interceptor.Invoke("setFilters?", "setFilters(const QStringList&)", typeof(void), typeof(List<string>), filters);
		}
		public List<string> Filters() {
			return (List<string>) interceptor.Invoke("filters", "filters() const", typeof(List<string>));
		}
		public void SelectFilter(string filter) {
			interceptor.Invoke("selectFilter$", "selectFilter(const QString&)", typeof(void), typeof(string), filter);
		}
		public string SelectedFilter() {
			return (string) interceptor.Invoke("selectedFilter", "selectedFilter() const", typeof(string));
		}
		public bool IsReadOnly() {
			return (bool) interceptor.Invoke("isReadOnly", "isReadOnly() const", typeof(bool));
		}
		public void SetHistory(List<string> paths) {
			interceptor.Invoke("setHistory?", "setHistory(const QStringList&)", typeof(void), typeof(List<string>), paths);
		}
		public List<string> History() {
			return (List<string>) interceptor.Invoke("history", "history() const", typeof(List<string>));
		}
		public void SetItemDelegate(QAbstractItemDelegate arg1) {
			interceptor.Invoke("setItemDelegate#", "setItemDelegate(QAbstractItemDelegate*)", typeof(void), typeof(QAbstractItemDelegate), arg1);
		}
		public QAbstractItemDelegate ItemDelegate() {
			return (QAbstractItemDelegate) interceptor.Invoke("itemDelegate", "itemDelegate() const", typeof(QAbstractItemDelegate));
		}
		public void SetIconProvider(QFileIconProvider provider) {
			interceptor.Invoke("setIconProvider#", "setIconProvider(QFileIconProvider*)", typeof(void), typeof(QFileIconProvider), provider);
		}
		public QFileIconProvider IconProvider() {
			return (QFileIconProvider) interceptor.Invoke("iconProvider", "iconProvider() const", typeof(QFileIconProvider));
		}
		public void SetLabelText(QFileDialog.DialogLabel label, string text) {
			interceptor.Invoke("setLabelText$$", "setLabelText(QFileDialog::DialogLabel, const QString&)", typeof(void), typeof(QFileDialog.DialogLabel), label, typeof(string), text);
		}
		public string LabelText(QFileDialog.DialogLabel label) {
			return (string) interceptor.Invoke("labelText$", "labelText(QFileDialog::DialogLabel) const", typeof(string), typeof(QFileDialog.DialogLabel), label);
		}
		[SmokeMethod("done(int)")]
		protected new virtual void Done(int result) {
			interceptor.Invoke("done$", "done(int)", typeof(void), typeof(int), result);
		}
		[SmokeMethod("accept()")]
		protected new virtual void Accept() {
			interceptor.Invoke("accept", "accept()", typeof(void));
		}
		~QFileDialog() {
			interceptor.Invoke("~QFileDialog", "~QFileDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QFileDialog", "~QFileDialog()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return (string) staticInterceptor.Invoke("getOpenFileName#$$$$$", "getOpenFileName(QWidget*, const QString&, const QString&, const QString&, QString*, Options)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter, typeof(StringBuilder), selectedFilter, typeof(int), options);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return (string) staticInterceptor.Invoke("getOpenFileName#$$$$", "getOpenFileName(QWidget*, const QString&, const QString&, const QString&, QString*)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter, typeof(StringBuilder), selectedFilter);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter) {
			return (string) staticInterceptor.Invoke("getOpenFileName#$$$", "getOpenFileName(QWidget*, const QString&, const QString&, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir) {
			return (string) staticInterceptor.Invoke("getOpenFileName#$$", "getOpenFileName(QWidget*, const QString&, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir);
		}
		public static string GetOpenFileName(QWidget parent, string caption) {
			return (string) staticInterceptor.Invoke("getOpenFileName#$", "getOpenFileName(QWidget*, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), caption);
		}
		public static string GetOpenFileName(QWidget parent) {
			return (string) staticInterceptor.Invoke("getOpenFileName#", "getOpenFileName(QWidget*)", typeof(string), typeof(QWidget), parent);
		}
		public static string GetOpenFileName() {
			return (string) staticInterceptor.Invoke("getOpenFileName", "getOpenFileName()", typeof(string));
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return (string) staticInterceptor.Invoke("getSaveFileName#$$$$$", "getSaveFileName(QWidget*, const QString&, const QString&, const QString&, QString*, Options)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter, typeof(StringBuilder), selectedFilter, typeof(int), options);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return (string) staticInterceptor.Invoke("getSaveFileName#$$$$", "getSaveFileName(QWidget*, const QString&, const QString&, const QString&, QString*)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter, typeof(StringBuilder), selectedFilter);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter) {
			return (string) staticInterceptor.Invoke("getSaveFileName#$$$", "getSaveFileName(QWidget*, const QString&, const QString&, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir) {
			return (string) staticInterceptor.Invoke("getSaveFileName#$$", "getSaveFileName(QWidget*, const QString&, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir);
		}
		public static string GetSaveFileName(QWidget parent, string caption) {
			return (string) staticInterceptor.Invoke("getSaveFileName#$", "getSaveFileName(QWidget*, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), caption);
		}
		public static string GetSaveFileName(QWidget parent) {
			return (string) staticInterceptor.Invoke("getSaveFileName#", "getSaveFileName(QWidget*)", typeof(string), typeof(QWidget), parent);
		}
		public static string GetSaveFileName() {
			return (string) staticInterceptor.Invoke("getSaveFileName", "getSaveFileName()", typeof(string));
		}
		public static string GetExistingDirectory(QWidget parent, string caption, string dir, int options) {
			return (string) staticInterceptor.Invoke("getExistingDirectory#$$$", "getExistingDirectory(QWidget*, const QString&, const QString&, Options)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(int), options);
		}
		public static string GetExistingDirectory(QWidget parent, string caption, string dir) {
			return (string) staticInterceptor.Invoke("getExistingDirectory#$$", "getExistingDirectory(QWidget*, const QString&, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir);
		}
		public static string GetExistingDirectory(QWidget parent, string caption) {
			return (string) staticInterceptor.Invoke("getExistingDirectory#$", "getExistingDirectory(QWidget*, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), caption);
		}
		public static string GetExistingDirectory(QWidget parent) {
			return (string) staticInterceptor.Invoke("getExistingDirectory#", "getExistingDirectory(QWidget*)", typeof(string), typeof(QWidget), parent);
		}
		public static string GetExistingDirectory() {
			return (string) staticInterceptor.Invoke("getExistingDirectory", "getExistingDirectory()", typeof(string));
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return (List<string>) staticInterceptor.Invoke("getOpenFileNames#$$$$$", "getOpenFileNames(QWidget*, const QString&, const QString&, const QString&, QString*, Options)", typeof(List<string>), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter, typeof(StringBuilder), selectedFilter, typeof(int), options);
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return (List<string>) staticInterceptor.Invoke("getOpenFileNames#$$$$", "getOpenFileNames(QWidget*, const QString&, const QString&, const QString&, QString*)", typeof(List<string>), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter, typeof(StringBuilder), selectedFilter);
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter) {
			return (List<string>) staticInterceptor.Invoke("getOpenFileNames#$$$", "getOpenFileNames(QWidget*, const QString&, const QString&, const QString&)", typeof(List<string>), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir, typeof(string), filter);
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption, string dir) {
			return (List<string>) staticInterceptor.Invoke("getOpenFileNames#$$", "getOpenFileNames(QWidget*, const QString&, const QString&)", typeof(List<string>), typeof(QWidget), parent, typeof(string), caption, typeof(string), dir);
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption) {
			return (List<string>) staticInterceptor.Invoke("getOpenFileNames#$", "getOpenFileNames(QWidget*, const QString&)", typeof(List<string>), typeof(QWidget), parent, typeof(string), caption);
		}
		public static List<string> GetOpenFileNames(QWidget parent) {
			return (List<string>) staticInterceptor.Invoke("getOpenFileNames#", "getOpenFileNames(QWidget*)", typeof(List<string>), typeof(QWidget), parent);
		}
		public static List<string> GetOpenFileNames() {
			return (List<string>) staticInterceptor.Invoke("getOpenFileNames", "getOpenFileNames()", typeof(List<string>));
		}
		protected new IQFileDialogSignals Emit {
			get { return (IQFileDialogSignals) Q_EMIT; }
		}
	}

	public interface IQFileDialogSignals : IQDialogSignals {
		[Q_SIGNAL("void filesSelected(const QStringList&)")]
		void FilesSelected(List<string> files);
		[Q_SIGNAL("void currentChanged(const QString&)")]
		void CurrentChanged(string path);
	}
}
