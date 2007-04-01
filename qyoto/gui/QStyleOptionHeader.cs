//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionHeader")]
	public class QStyleOptionHeader : QStyleOption, IDisposable {
 		protected QStyleOptionHeader(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStyleOptionHeader), "QStyleOptionHeader", this);
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_Header,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public enum SectionPosition {
			Beginning = 0,
			Middle = 1,
			End = 2,
			OnlyOneSection = 3,
		}
		public enum SelectedPosition {
			NotAdjacent = 0,
			NextIsSelected = 1,
			PreviousIsSelected = 2,
			NextAndPreviousAreSelected = 3,
		}
		public enum SortIndicator {
			None = 0,
			SortUp = 1,
			SortDown = 2,
		}
		public QStyleOptionHeader() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionHeader", "QStyleOptionHeader()", typeof(void));
		}
		public QStyleOptionHeader(QStyleOptionHeader other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionHeader#", "QStyleOptionHeader(const QStyleOptionHeader&)", typeof(void), typeof(QStyleOptionHeader), other);
		}
		public QStyleOptionHeader(int version) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionHeader$", "QStyleOptionHeader(int)", typeof(void), typeof(int), version);
		}
		~QStyleOptionHeader() {
			interceptor.Invoke("~QStyleOptionHeader", "~QStyleOptionHeader()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QStyleOptionHeader", "~QStyleOptionHeader()", typeof(void));
		}
	}
}
