//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	public class QGL : MarshalByRefObject {
		protected QGL interceptor = null;
		public enum FormatOption {
			DoubleBuffer = 0x0001,
			DepthBuffer = 0x0002,
			Rgba = 0x0004,
			AlphaChannel = 0x0008,
			AccumBuffer = 0x0010,
			StencilBuffer = 0x0020,
			StereoBuffers = 0x0040,
			DirectRendering = 0x0080,
			HasOverlay = 0x0100,
			SampleBuffers = 0x0200,
			SingleBuffer = DoubleBuffer<<16,
			NoDepthBuffer = DepthBuffer<<16,
			ColorIndex = Rgba<<16,
			NoAlphaChannel = AlphaChannel<<16,
			NoAccumBuffer = AccumBuffer<<16,
			NoStencilBuffer = StencilBuffer<<16,
			NoStereoBuffers = StereoBuffers<<16,
			IndirectRendering = DirectRendering<<16,
			NoOverlay = HasOverlay<<16,
			NoSampleBuffers = SampleBuffers<<16,
		}
	}
}
