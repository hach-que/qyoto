//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QDirModel")]
	public class QDirModel : QAbstractItemModel, IDisposable {
 		protected QDirModel(Type dummy) : base((Type) null) {}
		interface IQDirModelProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDirModel), this);
			_interceptor = (QDirModel) realProxy.GetTransparentProxy();
		}
		private QDirModel ProxyQDirModel() {
			return (QDirModel) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDirModel() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDirModelProxy), null);
			_staticInterceptor = (IQDirModelProxy) realProxy.GetTransparentProxy();
		}
		private static IQDirModelProxy StaticQDirModel() {
			return (IQDirModelProxy) _staticInterceptor;
		}

		public enum Roles {
			FileIconRole = Qt.ItemDataRole.DecorationRole,
			FilePathRole = Qt.ItemDataRole.UserRole+1,
			FileNameRole = 0,
		}
		public bool ResolveSymlinks {
			get {
				return Property("resolveSymlinks").Value<bool>();
			}
			set {
				SetProperty("resolveSymlinks", QVariant.FromValue<bool>(value));
			}
		}
		public bool ReadOnly {
			get {
				return Property("readOnly").Value<bool>();
			}
			set {
				SetProperty("readOnly", QVariant.FromValue<bool>(value));
			}
		}
		public bool LazyChildCount {
			get {
				return Property("lazyChildCount").Value<bool>();
			}
			set {
				SetProperty("lazyChildCount", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDirModel(List<string> nameFilters, int filters, int sort, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDirModel(nameFilters,filters,sort,parent);
		}
		[SmokeMethod("QDirModel(const QStringList&, QDir::Filters, QDir::SortFlags, QObject*)")]
		private void NewQDirModel(List<string> nameFilters, int filters, int sort, QObject parent) {
			ProxyQDirModel().NewQDirModel(nameFilters,filters,sort,parent);
		}
		public QDirModel(List<string> nameFilters, int filters, int sort) : this((Type) null) {
			CreateProxy();
			NewQDirModel(nameFilters,filters,sort);
		}
		[SmokeMethod("QDirModel(const QStringList&, QDir::Filters, QDir::SortFlags)")]
		private void NewQDirModel(List<string> nameFilters, int filters, int sort) {
			ProxyQDirModel().NewQDirModel(nameFilters,filters,sort);
		}
		public QDirModel(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDirModel(parent);
		}
		[SmokeMethod("QDirModel(QObject*)")]
		private void NewQDirModel(QObject parent) {
			ProxyQDirModel().NewQDirModel(parent);
		}
		public QDirModel() : this((Type) null) {
			CreateProxy();
			NewQDirModel();
		}
		[SmokeMethod("QDirModel()")]
		private void NewQDirModel() {
			ProxyQDirModel().NewQDirModel();
		}
		[SmokeMethod("index(int, int, const QModelIndex&) const")]
		public new QModelIndex Index(int row, int column, QModelIndex parent) {
			return ProxyQDirModel().Index(row,column,parent);
		}
		[SmokeMethod("index(int, int) const")]
		public new QModelIndex Index(int row, int column) {
			return ProxyQDirModel().Index(row,column);
		}
		[SmokeMethod("parent(const QModelIndex&) const")]
		public new QModelIndex Parent(QModelIndex child) {
			return ProxyQDirModel().Parent(child);
		}
		[SmokeMethod("rowCount(const QModelIndex&) const")]
		public new int RowCount(QModelIndex parent) {
			return ProxyQDirModel().RowCount(parent);
		}
		[SmokeMethod("rowCount() const")]
		public new int RowCount() {
			return ProxyQDirModel().RowCount();
		}
		[SmokeMethod("columnCount(const QModelIndex&) const")]
		public new int ColumnCount(QModelIndex parent) {
			return ProxyQDirModel().ColumnCount(parent);
		}
		[SmokeMethod("columnCount() const")]
		public new int ColumnCount() {
			return ProxyQDirModel().ColumnCount();
		}
		[SmokeMethod("data(const QModelIndex&, int) const")]
		public new QVariant Data(QModelIndex index, int role) {
			return ProxyQDirModel().Data(index,role);
		}
		[SmokeMethod("data(const QModelIndex&) const")]
		public new QVariant Data(QModelIndex index) {
			return ProxyQDirModel().Data(index);
		}
		[SmokeMethod("setData(const QModelIndex&, const QVariant&, int)")]
		public new bool SetData(QModelIndex index, QVariant value, int role) {
			return ProxyQDirModel().SetData(index,value,role);
		}
		[SmokeMethod("setData(const QModelIndex&, const QVariant&)")]
		public new bool SetData(QModelIndex index, QVariant value) {
			return ProxyQDirModel().SetData(index,value);
		}
		[SmokeMethod("headerData(int, Qt::Orientation, int) const")]
		public new QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
			return ProxyQDirModel().HeaderData(section,orientation,role);
		}
		[SmokeMethod("headerData(int, Qt::Orientation) const")]
		public new QVariant HeaderData(int section, Qt.Orientation orientation) {
			return ProxyQDirModel().HeaderData(section,orientation);
		}
		[SmokeMethod("hasChildren(const QModelIndex&) const")]
		public new bool HasChildren(QModelIndex index) {
			return ProxyQDirModel().HasChildren(index);
		}
		[SmokeMethod("hasChildren() const")]
		public new bool HasChildren() {
			return ProxyQDirModel().HasChildren();
		}
		[SmokeMethod("flags(const QModelIndex&) const")]
		public new int Flags(QModelIndex index) {
			return ProxyQDirModel().Flags(index);
		}
		[SmokeMethod("sort(int, Qt::SortOrder)")]
		public new void Sort(int column, Qt.SortOrder order) {
			ProxyQDirModel().Sort(column,order);
		}
		[SmokeMethod("sort(int)")]
		public new void Sort(int column) {
			ProxyQDirModel().Sort(column);
		}
		[SmokeMethod("mimeTypes() const")]
		public new List<string> MimeTypes() {
			return ProxyQDirModel().MimeTypes();
		}
		[SmokeMethod("mimeData(const QModelIndexList&) const")]
		public new QMimeData MimeData(List<QModelIndex> indexes) {
			return ProxyQDirModel().MimeData(indexes);
		}
		[SmokeMethod("dropMimeData(const QMimeData*, Qt::DropAction, int, int, const QModelIndex&)")]
		public new bool DropMimeData(QMimeData data, Qt.DropAction action, int row, int column, QModelIndex parent) {
			return ProxyQDirModel().DropMimeData(data,action,row,column,parent);
		}
		[SmokeMethod("supportedDropActions() const")]
		public new int SupportedDropActions() {
			return ProxyQDirModel().SupportedDropActions();
		}
		[SmokeMethod("setIconProvider(QFileIconProvider*)")]
		public void SetIconProvider(QFileIconProvider provider) {
			ProxyQDirModel().SetIconProvider(provider);
		}
		[SmokeMethod("iconProvider() const")]
		public QFileIconProvider IconProvider() {
			return ProxyQDirModel().IconProvider();
		}
		[SmokeMethod("setNameFilters(const QStringList&)")]
		public void SetNameFilters(List<string> filters) {
			ProxyQDirModel().SetNameFilters(filters);
		}
		[SmokeMethod("nameFilters() const")]
		public List<string> NameFilters() {
			return ProxyQDirModel().NameFilters();
		}
		[SmokeMethod("setFilter(QDir::Filters)")]
		public void SetFilter(int filters) {
			ProxyQDirModel().SetFilter(filters);
		}
		[SmokeMethod("filter() const")]
		public int Filter() {
			return ProxyQDirModel().Filter();
		}
		[SmokeMethod("setSorting(QDir::SortFlags)")]
		public void SetSorting(int sort) {
			ProxyQDirModel().SetSorting(sort);
		}
		[SmokeMethod("sorting() const")]
		public int Sorting() {
			return ProxyQDirModel().Sorting();
		}
		[SmokeMethod("isReadOnly() const")]
		public bool IsReadOnly() {
			return ProxyQDirModel().IsReadOnly();
		}
		[SmokeMethod("refresh(const QModelIndex&)")]
		public void Refresh(QModelIndex parent) {
			ProxyQDirModel().Refresh(parent);
		}
		[SmokeMethod("refresh()")]
		public void Refresh() {
			ProxyQDirModel().Refresh();
		}
		[SmokeMethod("index(const QString&, int) const")]
		public new QModelIndex Index(string path, int column) {
			return ProxyQDirModel().Index(path,column);
		}
		[SmokeMethod("index(const QString&) const")]
		public new QModelIndex Index(string path) {
			return ProxyQDirModel().Index(path);
		}
		[SmokeMethod("isDir(const QModelIndex&) const")]
		public bool IsDir(QModelIndex index) {
			return ProxyQDirModel().IsDir(index);
		}
		[SmokeMethod("mkdir(const QModelIndex&, const QString&)")]
		public QModelIndex Mkdir(QModelIndex parent, string name) {
			return ProxyQDirModel().Mkdir(parent,name);
		}
		[SmokeMethod("rmdir(const QModelIndex&)")]
		public bool Rmdir(QModelIndex index) {
			return ProxyQDirModel().Rmdir(index);
		}
		[SmokeMethod("remove(const QModelIndex&)")]
		public bool Remove(QModelIndex index) {
			return ProxyQDirModel().Remove(index);
		}
		[SmokeMethod("filePath(const QModelIndex&) const")]
		public string FilePath(QModelIndex index) {
			return ProxyQDirModel().FilePath(index);
		}
		[SmokeMethod("fileName(const QModelIndex&) const")]
		public string FileName(QModelIndex index) {
			return ProxyQDirModel().FileName(index);
		}
		[SmokeMethod("fileIcon(const QModelIndex&) const")]
		public QIcon FileIcon(QModelIndex index) {
			return ProxyQDirModel().FileIcon(index);
		}
		[SmokeMethod("fileInfo(const QModelIndex&) const")]
		public QFileInfo FileInfo(QModelIndex index) {
			return ProxyQDirModel().FileInfo(index);
		}
		[SmokeMethod("parent() const")]
		public new QObject Parent() {
			return ProxyQDirModel().Parent();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQDirModel().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQDirModel().Tr(s);
		}
		~QDirModel() {
			DisposeQDirModel();
		}
		public new void Dispose() {
			DisposeQDirModel();
		}
		[SmokeMethod("~QDirModel()")]
		private void DisposeQDirModel() {
			ProxyQDirModel().DisposeQDirModel();
		}
		protected new IQDirModelSignals Emit() {
			return (IQDirModelSignals) Q_EMIT;
		}
	}

	public interface IQDirModelSignals : IQAbstractItemModelSignals {
	}
}
