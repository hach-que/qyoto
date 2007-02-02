//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QTextTable")]
	public class QTextTable : QTextFrame, IDisposable {
 		protected QTextTable(Type dummy) : base((Type) null) {}
		interface IQTextTableProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextTable), this);
			_interceptor = (QTextTable) realProxy.GetTransparentProxy();
		}
		private QTextTable ProxyQTextTable() {
			return (QTextTable) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextTable() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextTableProxy), null);
			_staticInterceptor = (IQTextTableProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextTableProxy StaticQTextTable() {
			return (IQTextTableProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		// QTextTable* QTextTable(QTextDocument* arg1); >>>> NOT CONVERTED
		[SmokeMethod("resize$$", "(int, int)")]
		public void Resize(int rows, int cols) {
			ProxyQTextTable().Resize(rows,cols);
		}
		[SmokeMethod("insertRows$$", "(int, int)")]
		public void InsertRows(int pos, int num) {
			ProxyQTextTable().InsertRows(pos,num);
		}
		[SmokeMethod("insertColumns$$", "(int, int)")]
		public void InsertColumns(int pos, int num) {
			ProxyQTextTable().InsertColumns(pos,num);
		}
		[SmokeMethod("removeRows$$", "(int, int)")]
		public void RemoveRows(int pos, int num) {
			ProxyQTextTable().RemoveRows(pos,num);
		}
		[SmokeMethod("removeColumns$$", "(int, int)")]
		public void RemoveColumns(int pos, int num) {
			ProxyQTextTable().RemoveColumns(pos,num);
		}
		[SmokeMethod("mergeCells$$$$", "(int, int, int, int)")]
		public void MergeCells(int row, int col, int numRows, int numCols) {
			ProxyQTextTable().MergeCells(row,col,numRows,numCols);
		}
		// void mergeCells(const QTextCursor& arg1); >>>> NOT CONVERTED
		[SmokeMethod("splitCell$$$$", "(int, int, int, int)")]
		public void SplitCell(int row, int col, int numRows, int numCols) {
			ProxyQTextTable().SplitCell(row,col,numRows,numCols);
		}
		[SmokeMethod("rows", "() const")]
		public int Rows() {
			return ProxyQTextTable().Rows();
		}
		[SmokeMethod("columns", "() const")]
		public int Columns() {
			return ProxyQTextTable().Columns();
		}
		[SmokeMethod("cellAt$$", "(int, int) const")]
		public QTextTableCell CellAt(int row, int col) {
			return ProxyQTextTable().CellAt(row,col);
		}
		[SmokeMethod("cellAt$", "(int) const")]
		public QTextTableCell CellAt(int position) {
			return ProxyQTextTable().CellAt(position);
		}
		// QTextTableCell cellAt(const QTextCursor& arg1); >>>> NOT CONVERTED
		// QTextCursor rowStart(const QTextCursor& arg1); >>>> NOT CONVERTED
		// QTextCursor rowEnd(const QTextCursor& arg1); >>>> NOT CONVERTED
		[SmokeMethod("setFormat#", "(const QTextTableFormat&)")]
		public new void SetFormat(QTextTableFormat format) {
			ProxyQTextTable().SetFormat(format);
		}
		[SmokeMethod("format", "() const")]
		public new QTextTableFormat Format() {
			return ProxyQTextTable().Format();
		}
		public static new string Tr(string s, string c) {
			return StaticQTextTable().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQTextTable().Tr(s);
		}
		~QTextTable() {
			DisposeQTextTable();
		}
		public new void Dispose() {
			DisposeQTextTable();
		}
		[SmokeMethod("~QTextTable", "()")]
		private void DisposeQTextTable() {
			ProxyQTextTable().DisposeQTextTable();
		}
		protected new IQTextTableSignals Emit {
			get {
				return (IQTextTableSignals) Q_EMIT;
			}
		}
	}

	public interface IQTextTableSignals : IQTextFrameSignals {
	}
}
