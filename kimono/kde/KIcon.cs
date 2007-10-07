//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  \short A wrapper around QIcon that provides KDE icon features
	///  KIcon is a convenience class for creating a QIcon with an appropriate
	///  KIconEngine to perform loading and rendering.  KIcons thus adhere to
	///  KDE style and effect standards.
	///  \sa KIconEngine, KIconLoader, KIconTheme
	///  \author Hamish Rodda <rodda@kde.org>
	///  </remarks>		<short>    \short A wrapper around QIcon that provides KDE icon features </short>

	[SmokeClass("KIcon")]
	public class KIcon : QIcon, IDisposable {
 		protected KIcon(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KIcon), this);
		}
		/// <remarks>
		///  Constructor which takes a kde style icon name, and optionally
		///  a custom icon loader.
		///  \param iconName The name of the kde icon to load
		///  \param iconLoader The icon loader to use in loading this icon, or
		///                    null to use the default global icon loader.
		/// <param> name="overlays" A list of overlays to apply to this icon. They are
		///                  loaded from the emblems icons and up to four (one per
		///                  corner) is currently supported
		///      </param></remarks>		<short>    Constructor which takes a kde style icon name, and optionally  a custom icon loader.</short>
		public KIcon(string iconName, KIconLoader iconLoader, List<string> overlays) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIcon$#?", "KIcon(const QString&, KIconLoader*, const QStringList&)", typeof(void), typeof(string), iconName, typeof(KIconLoader), iconLoader, typeof(List<string>), overlays);
		}
		/// <remarks>
		///  \overload
		///      </remarks>		<short>    \overload      </short>
		public KIcon(string iconName, KIconLoader iconLoader) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIcon$#", "KIcon(const QString&, KIconLoader*)", typeof(void), typeof(string), iconName, typeof(KIconLoader), iconLoader);
		}
		/// <remarks>
		///  \overload
		///      </remarks>		<short>    \overload      </short>
		public KIcon(string iconName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIcon$", "KIcon(const QString&)", typeof(void), typeof(string), iconName);
		}
		/// <remarks>
		///  Copy constructor which takes any QIcon.
		///  \param copy the icon to copy.  This should have once been a KIcon,
		///              if you want to preserve KDE icon effects.
		///      </remarks>		<short>    Copy constructor which takes any QIcon.</short>
		public KIcon(QIcon copy) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIcon#", "KIcon(const QIcon&)", typeof(void), typeof(QIcon), copy);
		}
		/// <remarks>
		///  Constructor for a null icon.
		///      </remarks>		<short>    Constructor for a null icon.</short>
		public KIcon() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIcon", "KIcon()", typeof(void));
		}
		~KIcon() {
			interceptor.Invoke("~KIcon", "~KIcon()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KIcon", "~KIcon()", typeof(void));
		}
	}
}