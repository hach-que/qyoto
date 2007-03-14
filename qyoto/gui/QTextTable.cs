//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextTable")]
	public class QTextTable : QTextFrame, IDisposable {
 		protected QTextTable(Type dummy) : base((Type) null) {}
		[SmokeClass("QTextTable")]
		interface IQTextTableProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
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
		public QTextTable(QTextDocument doc) : this((Type) null) {
			CreateProxy();
			NewQTextTable(doc);
		}
		[SmokeMethod("QTextTable", "(QTextDocument*)", "#")]
		private void NewQTextTable(QTextDocument doc) {
			ProxyQTextTable().NewQTextTable(doc);
		}
		[SmokeMethod("resize", "(int, int)", "$$")]
		public void Resize(int rows, int cols) {
			ProxyQTextTable().Resize(rows,cols);
		}
		[SmokeMethod("insertRows", "(int, int)", "$$")]
		public void InsertRows(int pos, int num) {
			ProxyQTextTable().InsertRows(pos,num);
		}
		[SmokeMethod("insertColumns", "(int, int)", "$$")]
		public void InsertColumns(int pos, int num) {
			ProxyQTextTable().InsertColumns(pos,num);
		}
		[SmokeMethod("removeRows", "(int, int)", "$$")]
		public void RemoveRows(int pos, int num) {
			ProxyQTextTable().RemoveRows(pos,num);
		}
		[SmokeMethod("removeColumns", "(int, int)", "$$")]
		public void RemoveColumns(int pos, int num) {
			ProxyQTextTable().RemoveColumns(pos,num);
		}
		[SmokeMethod("mergeCells", "(int, int, int, int)", "$$$$")]
		public void MergeCells(int row, int col, int numRows, int numCols) {
			ProxyQTextTable().MergeCells(row,col,numRows,numCols);
		}
		[SmokeMethod("mergeCells", "(const QTextCursor&)", "#")]
		public void MergeCells(QTextCursor cursor) {
			ProxyQTextTable().MergeCells(cursor);
		}
		[SmokeMethod("splitCell", "(int, int, int, int)", "$$$$")]
		public void SplitCell(int row, int col, int numRows, int numCols) {
			ProxyQTextTable().SplitCell(row,col,numRows,numCols);
		}
		[SmokeMethod("rows", "() const", "")]
		public int Rows() {
			return ProxyQTextTable().Rows();
		}
		[SmokeMethod("columns", "() const", "")]
		public int Columns() {
			return ProxyQTextTable().Columns();
		}
		[SmokeMethod("cellAt", "(int, int) const", "$$")]
		public QTextTableCell CellAt(int row, int col) {
			return ProxyQTextTable().CellAt(row,col);
		}
		[SmokeMethod("cellAt", "(int) const", "$")]
		public QTextTableCell CellAt(int position) {
			return ProxyQTextTable().CellAt(position);
		}
		[SmokeMethod("cellAt", "(const QTextCursor&) const", "#")]
		public QTextTableCell CellAt(QTextCursor c) {
			return ProxyQTextTable().CellAt(c);
		}
		[SmokeMethod("rowStart", "(const QTextCursor&) const", "#")]
		public QTextCursor RowStart(QTextCursor c) {
			return ProxyQTextTable().RowStart(c);
		}
		[SmokeMethod("rowEnd", "(const QTextCursor&) const", "#")]
		public QTextCursor RowEnd(QTextCursor c) {
			return ProxyQTextTable().RowEnd(c);
		}
		[SmokeMethod("setFormat", "(const QTextTableFormat&)", "#")]
		public void SetFormat(QTextTableFormat format) {
			ProxyQTextTable().SetFormat(format);
		}
		[SmokeMethod("format", "() const", "")]
		public QTextTableFormat Format() {
			return ProxyQTextTable().Format();
		}
		~QTextTable() {
			DisposeQTextTable();
		}
		public new void Dispose() {
			DisposeQTextTable();
		}
		[SmokeMethod("~QTextTable", "()", "")]
		private void DisposeQTextTable() {
			ProxyQTextTable().DisposeQTextTable();
		}
		public static string Tr(string s, string c) {
			return StaticQTextTable().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQTextTable().Tr(s);
		}
		protected new IQTextTableSignals Emit {
			get { return (IQTextTableSignals) Q_EMIT; }
		}
	}

	public interface IQTextTableSignals : IQTextFrameSignals {
	}
}
