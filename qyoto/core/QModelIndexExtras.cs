namespace Qyoto {

	using System;
	using System.Runtime.InteropServices;

	public partial class QModelIndex : Object, IDisposable {
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr ModelIndexInternalPointer(IntPtr obj);
		
		public object InternalPointer() {
			IntPtr ptr = ModelIndexInternalPointer((IntPtr) GCHandle.Alloc(this));
			return ((GCHandle) ptr).Target;
		}
	}
}
