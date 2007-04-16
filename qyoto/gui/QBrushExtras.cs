namespace Qyoto {

	using System;

	public partial class QBrush : Object, IDisposable {
		public static implicit operator QBrush(Qt.GlobalColor arg) {
			return new QBrush(arg);
		}
		public static implicit operator QBrush(QColor arg) {
			return new QBrush(arg);
		}
	}
}
