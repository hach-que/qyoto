//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	///<remarks>*************************************************
	///
	///* Copyright (C) 1992-2007 Trolltech ASA. All rights reserved.
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
	///</remarks>		<short>                                                                                 Copyright (C) 1992-2007 Trolltech ASA.</short>

	[SmokeClass("QSocketNotifier")]
	public class QSocketNotifier : QObject, IDisposable {
 		protected QSocketNotifier(Type dummy) : base((Type) null) {}
		[SmokeClass("QSocketNotifier")]
		interface IQSocketNotifierProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSocketNotifier), this);
			interceptor = (QSocketNotifier) realProxy.GetTransparentProxy();
		}
		private static IQSocketNotifierProxy staticInterceptor = null;
		static QSocketNotifier() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSocketNotifierProxy), null);
			staticInterceptor = (IQSocketNotifierProxy) realProxy.GetTransparentProxy();
		}
		public enum TypeOf {
			Read = 0,
			Write = 1,
			Exception = 2,
		}
		public QSocketNotifier(int socket, QSocketNotifier.TypeOf arg2, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSocketNotifier(socket,arg2,parent);
		}
		[SmokeMethod("QSocketNotifier", "(int, QSocketNotifier::Type, QObject*)", "$$#")]
		private void NewQSocketNotifier(int socket, QSocketNotifier.TypeOf arg2, QObject parent) {
			((QSocketNotifier) interceptor).NewQSocketNotifier(socket,arg2,parent);
		}
		public QSocketNotifier(int socket, QSocketNotifier.TypeOf arg2) : this((Type) null) {
			CreateProxy();
			NewQSocketNotifier(socket,arg2);
		}
		[SmokeMethod("QSocketNotifier", "(int, QSocketNotifier::Type)", "$$")]
		private void NewQSocketNotifier(int socket, QSocketNotifier.TypeOf arg2) {
			((QSocketNotifier) interceptor).NewQSocketNotifier(socket,arg2);
		}
		[SmokeMethod("socket", "() const", "")]
		public int Socket() {
			return ((QSocketNotifier) interceptor).Socket();
		}
		[SmokeMethod("type", "() const", "")]
		public QSocketNotifier.TypeOf type() {
			return ((QSocketNotifier) interceptor).type();
		}
		[SmokeMethod("isEnabled", "() const", "")]
		public bool IsEnabled() {
			return ((QSocketNotifier) interceptor).IsEnabled();
		}
		[Q_SLOT("void setEnabled(bool)")]
		[SmokeMethod("setEnabled", "(bool)", "$")]
		public void SetEnabled(bool arg1) {
			((QSocketNotifier) interceptor).SetEnabled(arg1);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected new virtual bool Event(QEvent arg1) {
			return ((QSocketNotifier) interceptor).Event(arg1);
		}
		~QSocketNotifier() {
			DisposeQSocketNotifier();
		}
		public new void Dispose() {
			DisposeQSocketNotifier();
		}
		[SmokeMethod("~QSocketNotifier", "()", "")]
		private void DisposeQSocketNotifier() {
			((QSocketNotifier) interceptor).DisposeQSocketNotifier();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQSocketNotifierSignals Emit {
			get { return (IQSocketNotifierSignals) Q_EMIT; }
		}
	}

	public interface IQSocketNotifierSignals : IQObjectSignals {
		[Q_SIGNAL("void activated(int)")]
		void Activated(int socket);
	}
}
