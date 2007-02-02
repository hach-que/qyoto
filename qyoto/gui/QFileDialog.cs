//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQFileDialogSignals"></see> for signals emitted by QFileDialog
	[SmokeClass("QFileDialog")]
	public class QFileDialog : QDialog, IDisposable {
 		protected QFileDialog(Type dummy) : base((Type) null) {}
		interface IQFileDialogProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
			[SmokeMethod("getOpenFileName######", "(QWidget*, const QString&, const QString&, const QString&, QString*, Options)")]
			string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options);
			[SmokeMethod("getOpenFileName#####", "(QWidget*, const QString&, const QString&, const QString&, QString*)")]
			string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter);
			[SmokeMethod("getOpenFileName####", "(QWidget*, const QString&, const QString&, const QString&)")]
			string GetOpenFileName(QWidget parent, string caption, string dir, string filter);
			[SmokeMethod("getOpenFileName###", "(QWidget*, const QString&, const QString&)")]
			string GetOpenFileName(QWidget parent, string caption, string dir);
			[SmokeMethod("getOpenFileName##", "(QWidget*, const QString&)")]
			string GetOpenFileName(QWidget parent, string caption);
			[SmokeMethod("getOpenFileName#", "(QWidget*)")]
			string GetOpenFileName(QWidget parent);
			[SmokeMethod("getOpenFileName", "()")]
			string GetOpenFileName();
			[SmokeMethod("getSaveFileName######", "(QWidget*, const QString&, const QString&, const QString&, QString*, Options)")]
			string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options);
			[SmokeMethod("getSaveFileName#####", "(QWidget*, const QString&, const QString&, const QString&, QString*)")]
			string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter);
			[SmokeMethod("getSaveFileName####", "(QWidget*, const QString&, const QString&, const QString&)")]
			string GetSaveFileName(QWidget parent, string caption, string dir, string filter);
			[SmokeMethod("getSaveFileName###", "(QWidget*, const QString&, const QString&)")]
			string GetSaveFileName(QWidget parent, string caption, string dir);
			[SmokeMethod("getSaveFileName##", "(QWidget*, const QString&)")]
			string GetSaveFileName(QWidget parent, string caption);
			[SmokeMethod("getSaveFileName#", "(QWidget*)")]
			string GetSaveFileName(QWidget parent);
			[SmokeMethod("getSaveFileName", "()")]
			string GetSaveFileName();
			[SmokeMethod("getExistingDirectory####", "(QWidget*, const QString&, const QString&, Options)")]
			string GetExistingDirectory(QWidget parent, string caption, string dir, int options);
			[SmokeMethod("getExistingDirectory###", "(QWidget*, const QString&, const QString&)")]
			string GetExistingDirectory(QWidget parent, string caption, string dir);
			[SmokeMethod("getExistingDirectory##", "(QWidget*, const QString&)")]
			string GetExistingDirectory(QWidget parent, string caption);
			[SmokeMethod("getExistingDirectory#", "(QWidget*)")]
			string GetExistingDirectory(QWidget parent);
			[SmokeMethod("getExistingDirectory", "()")]
			string GetExistingDirectory();
			[SmokeMethod("getOpenFileNames######", "(QWidget*, const QString&, const QString&, const QString&, QString*, Options)")]
			List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options);
			[SmokeMethod("getOpenFileNames#####", "(QWidget*, const QString&, const QString&, const QString&, QString*)")]
			List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter);
			[SmokeMethod("getOpenFileNames####", "(QWidget*, const QString&, const QString&, const QString&)")]
			List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter);
			[SmokeMethod("getOpenFileNames###", "(QWidget*, const QString&, const QString&)")]
			List<string> GetOpenFileNames(QWidget parent, string caption, string dir);
			[SmokeMethod("getOpenFileNames##", "(QWidget*, const QString&)")]
			List<string> GetOpenFileNames(QWidget parent, string caption);
			[SmokeMethod("getOpenFileNames#", "(QWidget*)")]
			List<string> GetOpenFileNames(QWidget parent);
			[SmokeMethod("getOpenFileNames", "()")]
			List<string> GetOpenFileNames();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFileDialog), this);
			_interceptor = (QFileDialog) realProxy.GetTransparentProxy();
		}
		private QFileDialog ProxyQFileDialog() {
			return (QFileDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFileDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFileDialogProxy), null);
			_staticInterceptor = (IQFileDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQFileDialogProxy StaticQFileDialog() {
			return (IQFileDialogProxy) _staticInterceptor;
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
			get {
				return Property("viewMode").Value<QFileDialog.ViewMode>();
			}
			set {
				SetProperty("viewMode", QVariant.FromValue<QFileDialog.ViewMode>(value));
			}
		}
		[Q_PROPERTY("QFileDialog::FileMode", "fileMode")]
		public QFileDialog.FileMode fileMode {
			get {
				return Property("fileMode").Value<QFileDialog.FileMode>();
			}
			set {
				SetProperty("fileMode", QVariant.FromValue<QFileDialog.FileMode>(value));
			}
		}
		[Q_PROPERTY("QFileDialog::AcceptMode", "acceptMode")]
		public QFileDialog.AcceptMode acceptMode {
			get {
				return Property("acceptMode").Value<QFileDialog.AcceptMode>();
			}
			set {
				SetProperty("acceptMode", QVariant.FromValue<QFileDialog.AcceptMode>(value));
			}
		}
		[Q_PROPERTY("bool", "readOnly")]
		public bool ReadOnly {
			get {
				return Property("readOnly").Value<bool>();
			}
			set {
				SetProperty("readOnly", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "resolveSymlinks")]
		public bool ResolveSymlinks {
			get {
				return Property("resolveSymlinks").Value<bool>();
			}
			set {
				SetProperty("resolveSymlinks", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "confirmOverwrite")]
		public bool ConfirmOverwrite {
			get {
				return Property("confirmOverwrite").Value<bool>();
			}
			set {
				SetProperty("confirmOverwrite", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("QString", "defaultSuffix")]
		public string DefaultSuffix {
			get {
				return Property("defaultSuffix").Value<string>();
			}
			set {
				SetProperty("defaultSuffix", QVariant.FromValue<string>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QFileDialog(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQFileDialog(parent,f);
		}
		[SmokeMethod("QFileDialog##", "(QWidget*, Qt::WindowFlags)")]
		private void NewQFileDialog(QWidget parent, int f) {
			ProxyQFileDialog().NewQFileDialog(parent,f);
		}
		public QFileDialog(QWidget parent, string caption, string directory, string filter) : this((Type) null) {
			CreateProxy();
			NewQFileDialog(parent,caption,directory,filter);
		}
		[SmokeMethod("QFileDialog####", "(QWidget*, const QString&, const QString&, const QString&)")]
		private void NewQFileDialog(QWidget parent, string caption, string directory, string filter) {
			ProxyQFileDialog().NewQFileDialog(parent,caption,directory,filter);
		}
		public QFileDialog(QWidget parent, string caption, string directory) : this((Type) null) {
			CreateProxy();
			NewQFileDialog(parent,caption,directory);
		}
		[SmokeMethod("QFileDialog###", "(QWidget*, const QString&, const QString&)")]
		private void NewQFileDialog(QWidget parent, string caption, string directory) {
			ProxyQFileDialog().NewQFileDialog(parent,caption,directory);
		}
		public QFileDialog(QWidget parent, string caption) : this((Type) null) {
			CreateProxy();
			NewQFileDialog(parent,caption);
		}
		[SmokeMethod("QFileDialog##", "(QWidget*, const QString&)")]
		private void NewQFileDialog(QWidget parent, string caption) {
			ProxyQFileDialog().NewQFileDialog(parent,caption);
		}
		public QFileDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQFileDialog(parent);
		}
		[SmokeMethod("QFileDialog#", "(QWidget*)")]
		private void NewQFileDialog(QWidget parent) {
			ProxyQFileDialog().NewQFileDialog(parent);
		}
		public QFileDialog() : this((Type) null) {
			CreateProxy();
			NewQFileDialog();
		}
		[SmokeMethod("QFileDialog", "()")]
		private void NewQFileDialog() {
			ProxyQFileDialog().NewQFileDialog();
		}
		[SmokeMethod("setDirectory$", "(const QString&)")]
		public void SetDirectory(string directory) {
			ProxyQFileDialog().SetDirectory(directory);
		}
		[SmokeMethod("setDirectory#", "(const QDir&)")]
		public void SetDirectory(QDir directory) {
			ProxyQFileDialog().SetDirectory(directory);
		}
		[SmokeMethod("directory", "() const")]
		public QDir Directory() {
			return ProxyQFileDialog().Directory();
		}
		[SmokeMethod("selectFile$", "(const QString&)")]
		public void SelectFile(string filename) {
			ProxyQFileDialog().SelectFile(filename);
		}
		[SmokeMethod("selectedFiles", "() const")]
		public List<string> SelectedFiles() {
			return ProxyQFileDialog().SelectedFiles();
		}
		[SmokeMethod("setFilter$", "(const QString&)")]
		public void SetFilter(string filter) {
			ProxyQFileDialog().SetFilter(filter);
		}
		[SmokeMethod("setFilters?", "(const QStringList&)")]
		public void SetFilters(List<string> filters) {
			ProxyQFileDialog().SetFilters(filters);
		}
		[SmokeMethod("filters", "() const")]
		public List<string> Filters() {
			return ProxyQFileDialog().Filters();
		}
		[SmokeMethod("selectFilter$", "(const QString&)")]
		public void SelectFilter(string filter) {
			ProxyQFileDialog().SelectFilter(filter);
		}
		[SmokeMethod("selectedFilter", "() const")]
		public string SelectedFilter() {
			return ProxyQFileDialog().SelectedFilter();
		}
		[SmokeMethod("isReadOnly", "() const")]
		public bool IsReadOnly() {
			return ProxyQFileDialog().IsReadOnly();
		}
		[SmokeMethod("setHistory?", "(const QStringList&)")]
		public void SetHistory(List<string> paths) {
			ProxyQFileDialog().SetHistory(paths);
		}
		[SmokeMethod("history", "() const")]
		public List<string> History() {
			return ProxyQFileDialog().History();
		}
		[SmokeMethod("setItemDelegate#", "(QAbstractItemDelegate*)")]
		public void SetItemDelegate(QAbstractItemDelegate arg1) {
			ProxyQFileDialog().SetItemDelegate(arg1);
		}
		[SmokeMethod("itemDelegate", "() const")]
		public QAbstractItemDelegate ItemDelegate() {
			return ProxyQFileDialog().ItemDelegate();
		}
		[SmokeMethod("setIconProvider#", "(QFileIconProvider*)")]
		public void SetIconProvider(QFileIconProvider provider) {
			ProxyQFileDialog().SetIconProvider(provider);
		}
		[SmokeMethod("iconProvider", "() const")]
		public QFileIconProvider IconProvider() {
			return ProxyQFileDialog().IconProvider();
		}
		[SmokeMethod("setLabelText$$", "(QFileDialog::DialogLabel, const QString&)")]
		public void SetLabelText(QFileDialog.DialogLabel label, string text) {
			ProxyQFileDialog().SetLabelText(label,text);
		}
		[SmokeMethod("labelText$", "(QFileDialog::DialogLabel) const")]
		public string LabelText(QFileDialog.DialogLabel label) {
			return ProxyQFileDialog().LabelText(label);
		}
		public static new string Tr(string s, string c) {
			return StaticQFileDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQFileDialog().Tr(s);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return StaticQFileDialog().GetOpenFileName(parent,caption,dir,filter,selectedFilter,options);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetOpenFileName(parent,caption,dir,filter,selectedFilter);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter) {
			return StaticQFileDialog().GetOpenFileName(parent,caption,dir,filter);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir) {
			return StaticQFileDialog().GetOpenFileName(parent,caption,dir);
		}
		public static string GetOpenFileName(QWidget parent, string caption) {
			return StaticQFileDialog().GetOpenFileName(parent,caption);
		}
		public static string GetOpenFileName(QWidget parent) {
			return StaticQFileDialog().GetOpenFileName(parent);
		}
		public static string GetOpenFileName() {
			return StaticQFileDialog().GetOpenFileName();
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return StaticQFileDialog().GetSaveFileName(parent,caption,dir,filter,selectedFilter,options);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetSaveFileName(parent,caption,dir,filter,selectedFilter);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter) {
			return StaticQFileDialog().GetSaveFileName(parent,caption,dir,filter);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir) {
			return StaticQFileDialog().GetSaveFileName(parent,caption,dir);
		}
		public static string GetSaveFileName(QWidget parent, string caption) {
			return StaticQFileDialog().GetSaveFileName(parent,caption);
		}
		public static string GetSaveFileName(QWidget parent) {
			return StaticQFileDialog().GetSaveFileName(parent);
		}
		public static string GetSaveFileName() {
			return StaticQFileDialog().GetSaveFileName();
		}
		public static string GetExistingDirectory(QWidget parent, string caption, string dir, int options) {
			return StaticQFileDialog().GetExistingDirectory(parent,caption,dir,options);
		}
		public static string GetExistingDirectory(QWidget parent, string caption, string dir) {
			return StaticQFileDialog().GetExistingDirectory(parent,caption,dir);
		}
		public static string GetExistingDirectory(QWidget parent, string caption) {
			return StaticQFileDialog().GetExistingDirectory(parent,caption);
		}
		public static string GetExistingDirectory(QWidget parent) {
			return StaticQFileDialog().GetExistingDirectory(parent);
		}
		public static string GetExistingDirectory() {
			return StaticQFileDialog().GetExistingDirectory();
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption,dir,filter,selectedFilter,options);
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption,dir,filter,selectedFilter);
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption, string dir, string filter) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption,dir,filter);
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption, string dir) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption,dir);
		}
		public static List<string> GetOpenFileNames(QWidget parent, string caption) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption);
		}
		public static List<string> GetOpenFileNames(QWidget parent) {
			return StaticQFileDialog().GetOpenFileNames(parent);
		}
		public static List<string> GetOpenFileNames() {
			return StaticQFileDialog().GetOpenFileNames();
		}
		// QFileDialog* QFileDialog(const QFileDialogArgs& arg1); >>>> NOT CONVERTED
		[SmokeMethod("done$", "(int)")]
		protected new void Done(int result) {
			ProxyQFileDialog().Done(result);
		}
		[SmokeMethod("accept", "()")]
		protected new void Accept() {
			ProxyQFileDialog().Accept();
		}
		~QFileDialog() {
			DisposeQFileDialog();
		}
		public new void Dispose() {
			DisposeQFileDialog();
		}
		[SmokeMethod("~QFileDialog", "()")]
		private void DisposeQFileDialog() {
			ProxyQFileDialog().DisposeQFileDialog();
		}
		protected new IQFileDialogSignals Emit {
			get {
				return (IQFileDialogSignals) Q_EMIT;
			}
		}
	}

	public interface IQFileDialogSignals : IQDialogSignals {
		[Q_SIGNAL("void (const QStringList&)")]
		void FilesSelected(List<string> files);
		[Q_SIGNAL("void (const QString&)")]
		void CurrentChanged(string path);
	}
}
