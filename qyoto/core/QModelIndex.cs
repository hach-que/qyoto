//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QModelIndex")]
	public partial class QModelIndex : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QModelIndex(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QModelIndex), "QModelIndex", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QModelIndex() {
			staticInterceptor = new SmokeInvocation(typeof(QModelIndex), "QModelIndex", null);
		}
		// void* internalPointer(); >>>> NOT CONVERTED
		public QModelIndex() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QModelIndex", "QModelIndex()", typeof(void));
		}
		public QModelIndex(QModelIndex other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QModelIndex#", "QModelIndex(const QModelIndex&)", typeof(void), typeof(QModelIndex), other);
		}
		public int Row() {
			return (int) interceptor.Invoke("row", "row() const", typeof(int));
		}
		public int Column() {
			return (int) interceptor.Invoke("column", "column() const", typeof(int));
		}
		public long InternalId() {
			return (long) interceptor.Invoke("internalId", "internalId() const", typeof(long));
		}
		public QModelIndex Parent() {
			return (QModelIndex) interceptor.Invoke("parent", "parent() const", typeof(QModelIndex));
		}
		public QModelIndex Sibling(int row, int column) {
			return (QModelIndex) interceptor.Invoke("sibling$$", "sibling(int, int) const", typeof(QModelIndex), typeof(int), row, typeof(int), column);
		}
		public QModelIndex Child(int row, int column) {
			return (QModelIndex) interceptor.Invoke("child$$", "child(int, int) const", typeof(QModelIndex), typeof(int), row, typeof(int), column);
		}
		public QVariant Data(int role) {
			return (QVariant) interceptor.Invoke("data$", "data(int) const", typeof(QVariant), typeof(int), role);
		}
		public QVariant Data() {
			return (QVariant) interceptor.Invoke("data", "data() const", typeof(QVariant));
		}
		public int Flags() {
			return (int) interceptor.Invoke("flags", "flags() const", typeof(int));
		}
		public QAbstractItemModel Model() {
			return (QAbstractItemModel) interceptor.Invoke("model", "model() const", typeof(QAbstractItemModel));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public override bool Equals(object o) {
			if (!(o is QModelIndex)) { return false; }
			return this == (QModelIndex) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QModelIndex() {
			QAbstractItemModel.DerefIndexHandle(InternalPointer());
			interceptor.Invoke("~QModelIndex", "~QModelIndex()", typeof(void));
		}
		public void Dispose() {
			QAbstractItemModel.DerefIndexHandle(InternalPointer());
			interceptor.Invoke("~QModelIndex", "~QModelIndex()", typeof(void));
		}
		public static bool operator==(QModelIndex lhs, QModelIndex other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), lhs, typeof(QModelIndex), other);
		}
		public static bool operator!=(QModelIndex lhs, QModelIndex other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), lhs, typeof(QModelIndex), other);
		}
		public static bool operator<(QModelIndex lhs, QModelIndex other) {
			return (bool) staticInterceptor.Invoke("operator<#", "operator<(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), lhs, typeof(QModelIndex), other);
		}
		public static bool operator>(QModelIndex lhs, QModelIndex other) {
			return !(bool) staticInterceptor.Invoke("operator<#", "operator<(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), lhs, typeof(QModelIndex), other)
						&& !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), lhs, typeof(QModelIndex), other);
		}
	}
}
