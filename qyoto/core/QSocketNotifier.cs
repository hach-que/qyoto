//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	///<remarks>*************************************************
	///
	///* Copyright (C) 1992-2006 Trolltech ASA. All rights reserved.
	///
	///* This file is part of the QtCore module of the Qt Toolkit.
	///
	///* This file may be used under the terms of the GNU General Public
	/// License version 2.0 as published by the Free Software Foundation
	/// and appearing in the file LICENSE.GPL included in the packaging of
	/// this file.  Please review the following information to ensure GNU
	/// General Public Licensing requirements will be met:
	/// http://www.trolltech.com/products/qt/opensource.html
	///
	///* If you are unsure which license is appropriate for your use, please
	/// review the following information:
	/// http://www.trolltech.com/products/qt/licensing.html or contact the
	/// sales department at sales@trolltech.com.
	///
	///* This file is provided AS IS with NO WARRANTY OF ANY KIND, INCLUDING THE
	/// WARRANTY OF DESIGN, MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
	///
	///************************************************** See <see cref="IQSocketNotifierSignals"></see> for signals emitted by QSocketNotifier
	///</remarks>		<short>                                                                                 Copyright (C) 1992-2006 Trolltech ASA.</short>

	[SmokeClass("QSocketNotifier")]
	public class QSocketNotifier : QObject, IDisposable {
 		protected QSocketNotifier(Type dummy) : base((Type) null) {}
		interface IQSocketNotifierProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSocketNotifier), this);
			_interceptor = (QSocketNotifier) realProxy.GetTransparentProxy();
		}
		private QSocketNotifier ProxyQSocketNotifier() {
			return (QSocketNotifier) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSocketNotifier() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSocketNotifierProxy), null);
			_staticInterceptor = (IQSocketNotifierProxy) realProxy.GetTransparentProxy();
		}
		private static IQSocketNotifierProxy StaticQSocketNotifier() {
			return (IQSocketNotifierProxy) _staticInterceptor;
		}

		public enum E_Type {
			Read = 0,
			Write = 1,
			Exception = 2,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSocketNotifier(int socket, QSocketNotifier.E_Type arg2, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSocketNotifier(socket,arg2,parent);
		}
		[SmokeMethod("QSocketNotifier(int, QSocketNotifier::Type, QObject*)")]
		private void NewQSocketNotifier(int socket, QSocketNotifier.E_Type arg2, QObject parent) {
			ProxyQSocketNotifier().NewQSocketNotifier(socket,arg2,parent);
		}
		public QSocketNotifier(int socket, QSocketNotifier.E_Type arg2) : this((Type) null) {
			CreateProxy();
			NewQSocketNotifier(socket,arg2);
		}
		[SmokeMethod("QSocketNotifier(int, QSocketNotifier::Type)")]
		private void NewQSocketNotifier(int socket, QSocketNotifier.E_Type arg2) {
			ProxyQSocketNotifier().NewQSocketNotifier(socket,arg2);
		}
		[SmokeMethod("socket() const")]
		public int Socket() {
			return ProxyQSocketNotifier().Socket();
		}
		[SmokeMethod("type() const")]
		public QSocketNotifier.E_Type type() {
			return ProxyQSocketNotifier().type();
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQSocketNotifier().IsEnabled();
		}
		[SmokeMethod("setEnabled(bool)")]
		public void SetEnabled(bool arg1) {
			ProxyQSocketNotifier().SetEnabled(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQSocketNotifier().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQSocketNotifier().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQSocketNotifier().Event(arg1);
		}
		~QSocketNotifier() {
			DisposeQSocketNotifier();
		}
		public new void Dispose() {
			DisposeQSocketNotifier();
		}
		[SmokeMethod("~QSocketNotifier()")]
		private void DisposeQSocketNotifier() {
			ProxyQSocketNotifier().DisposeQSocketNotifier();
		}
		protected new IQSocketNotifierSignals Emit {
			get {
				return (IQSocketNotifierSignals) Q_EMIT;
			}
		}
	}

	public interface IQSocketNotifierSignals : IQObjectSignals {
		[Q_SIGNAL("void activated(int)")]
		void Activated(int socket);
	}
}
