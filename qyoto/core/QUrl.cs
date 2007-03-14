//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	public interface IQUrl {
			void SetUrl(string url);
			void SetUrl(string url, QUrl.ParsingMode mode);
			void SetEncodedUrl(QByteArray url);
			void SetEncodedUrl(QByteArray url, QUrl.ParsingMode mode);
			bool IsValid();
			bool IsEmpty();
			void Clear();
			void SetScheme(string scheme);
			string Scheme();
			void SetAuthority(string authority);
			string Authority();
			void SetUserInfo(string userInfo);
			string UserInfo();
			void SetUserName(string userName);
			string UserName();
			void SetPassword(string password);
			string Password();
			void SetHost(string host);
			string Host();
			void SetPort(int port);
			int Port();
			int Port(int defaultPort);
			void SetPath(string path);
			string Path();
			bool HasQuery();
			void SetEncodedQuery(QByteArray query);
			QByteArray EncodedQuery();
			void SetQueryDelimiters(char valueDelimiter, char pairDelimiter);
			char QueryValueDelimiter();
			char QueryPairDelimiter();
			void SetQueryItems(List<QPair<string, string>> query);
			void AddQueryItem(string key, string value);
			List<QPair<string, string>> QueryItems();
			bool HasQueryItem(string key);
			string QueryItemValue(string key);
			List<string> AllQueryItemValues(string key);
			void RemoveQueryItem(string key);
			void RemoveAllQueryItems(string key);
			void SetFragment(string fragment);
			string Fragment();
			bool HasFragment();
			IQUrl Resolved(IQUrl relative);
			bool IsRelative();
			bool IsParentOf(IQUrl url);
			string ToLocalFile();
			string ToString(int options);
			string ToString();
			QByteArray ToEncoded(int options);
			QByteArray ToEncoded();
			void Detach();
			bool IsDetached();
			string ErrorString();
	}

	[SmokeClass("QUrl")]
	public class QUrl : MarshalByRefObject, IQUrl, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QUrl(Type dummy) {}
		[SmokeClass("QUrl")]
		interface IQUrlProxy {
			[SmokeMethod("fromLocalFile", "(const QString&)", "$")]
			IQUrl FromLocalFile(string localfile);
			[SmokeMethod("fromEncoded", "(const QByteArray&)", "#")]
			IQUrl FromEncoded(QByteArray url);
			[SmokeMethod("fromEncoded", "(const QByteArray&, QUrl::ParsingMode)", "#$")]
			IQUrl FromEncoded(QByteArray url, QUrl.ParsingMode mode);
			[SmokeMethod("fromPercentEncoding", "(const QByteArray&)", "#")]
			string FromPercentEncoding(QByteArray arg1);
			[SmokeMethod("toPercentEncoding", "(const QString&, const QByteArray&, const QByteArray&)", "$##")]
			QByteArray ToPercentEncoding(string arg1, QByteArray exclude, QByteArray include);
			[SmokeMethod("toPercentEncoding", "(const QString&, const QByteArray&)", "$#")]
			QByteArray ToPercentEncoding(string arg1, QByteArray exclude);
			[SmokeMethod("toPercentEncoding", "(const QString&)", "$")]
			QByteArray ToPercentEncoding(string arg1);
			[SmokeMethod("fromPunycode", "(const QByteArray&)", "#")]
			string FromPunycode(QByteArray arg1);
			[SmokeMethod("toPunycode", "(const QString&)", "$")]
			QByteArray ToPunycode(string arg1);
			[SmokeMethod("fromAce", "(const QByteArray&)", "#")]
			string FromAce(QByteArray arg1);
			[SmokeMethod("toAce", "(const QString&)", "$")]
			QByteArray ToAce(string arg1);
			[SmokeMethod("idnWhitelist", "()", "")]
			List<string> IdnWhitelist();
			[SmokeMethod("setIdnWhitelist", "(const QStringList&)", "?")]
			void SetIdnWhitelist(List<string> arg1);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QUrl), this);
			_interceptor = (QUrl) realProxy.GetTransparentProxy();
		}
		private QUrl ProxyQUrl() {
			return (QUrl) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QUrl() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQUrlProxy), null);
			_staticInterceptor = (IQUrlProxy) realProxy.GetTransparentProxy();
		}
		private static IQUrlProxy StaticQUrl() {
			return (IQUrlProxy) _staticInterceptor;
		}
		public enum ParsingMode {
			TolerantMode = 0,
			StrictMode = 1,
		}
		public enum FormattingOption {
			None = 0x0,
			RemoveScheme = 0x1,
			RemovePassword = 0x2,
			RemoveUserInfo = RemovePassword|0x4,
			RemovePort = 0x8,
			RemoveAuthority = RemoveUserInfo|RemovePort|0x10,
			RemovePath = 0x20,
			RemoveQuery = 0x40,
			RemoveFragment = 0x80,
			StripTrailingSlash = 0x10000,
		}
		public QUrl() : this((Type) null) {
			CreateProxy();
			NewQUrl();
		}
		[SmokeMethod("QUrl", "()", "")]
		private void NewQUrl() {
			ProxyQUrl().NewQUrl();
		}
		public QUrl(string url) : this((Type) null) {
			CreateProxy();
			NewQUrl(url);
		}
		[SmokeMethod("QUrl", "(const QString&)", "$")]
		private void NewQUrl(string url) {
			ProxyQUrl().NewQUrl(url);
		}
		public QUrl(string url, QUrl.ParsingMode mode) : this((Type) null) {
			CreateProxy();
			NewQUrl(url,mode);
		}
		[SmokeMethod("QUrl", "(const QString&, QUrl::ParsingMode)", "$$")]
		private void NewQUrl(string url, QUrl.ParsingMode mode) {
			ProxyQUrl().NewQUrl(url,mode);
		}
		public QUrl(IQUrl copy) : this((Type) null) {
			CreateProxy();
			NewQUrl(copy);
		}
		[SmokeMethod("QUrl", "(const QUrl&)", "#")]
		private void NewQUrl(IQUrl copy) {
			ProxyQUrl().NewQUrl(copy);
		}
		[SmokeMethod("setUrl", "(const QString&)", "$")]
		public void SetUrl(string url) {
			ProxyQUrl().SetUrl(url);
		}
		[SmokeMethod("setUrl", "(const QString&, QUrl::ParsingMode)", "$$")]
		public void SetUrl(string url, QUrl.ParsingMode mode) {
			ProxyQUrl().SetUrl(url,mode);
		}
		[SmokeMethod("setEncodedUrl", "(const QByteArray&)", "#")]
		public void SetEncodedUrl(QByteArray url) {
			ProxyQUrl().SetEncodedUrl(url);
		}
		[SmokeMethod("setEncodedUrl", "(const QByteArray&, QUrl::ParsingMode)", "#$")]
		public void SetEncodedUrl(QByteArray url, QUrl.ParsingMode mode) {
			ProxyQUrl().SetEncodedUrl(url,mode);
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQUrl().IsValid();
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public bool IsEmpty() {
			return ProxyQUrl().IsEmpty();
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQUrl().Clear();
		}
		[SmokeMethod("setScheme", "(const QString&)", "$")]
		public void SetScheme(string scheme) {
			ProxyQUrl().SetScheme(scheme);
		}
		[SmokeMethod("scheme", "() const", "")]
		public string Scheme() {
			return ProxyQUrl().Scheme();
		}
		[SmokeMethod("setAuthority", "(const QString&)", "$")]
		public void SetAuthority(string authority) {
			ProxyQUrl().SetAuthority(authority);
		}
		[SmokeMethod("authority", "() const", "")]
		public string Authority() {
			return ProxyQUrl().Authority();
		}
		[SmokeMethod("setUserInfo", "(const QString&)", "$")]
		public void SetUserInfo(string userInfo) {
			ProxyQUrl().SetUserInfo(userInfo);
		}
		[SmokeMethod("userInfo", "() const", "")]
		public string UserInfo() {
			return ProxyQUrl().UserInfo();
		}
		[SmokeMethod("setUserName", "(const QString&)", "$")]
		public void SetUserName(string userName) {
			ProxyQUrl().SetUserName(userName);
		}
		[SmokeMethod("userName", "() const", "")]
		public string UserName() {
			return ProxyQUrl().UserName();
		}
		[SmokeMethod("setPassword", "(const QString&)", "$")]
		public void SetPassword(string password) {
			ProxyQUrl().SetPassword(password);
		}
		[SmokeMethod("password", "() const", "")]
		public string Password() {
			return ProxyQUrl().Password();
		}
		[SmokeMethod("setHost", "(const QString&)", "$")]
		public void SetHost(string host) {
			ProxyQUrl().SetHost(host);
		}
		[SmokeMethod("host", "() const", "")]
		public string Host() {
			return ProxyQUrl().Host();
		}
		[SmokeMethod("setPort", "(int)", "$")]
		public void SetPort(int port) {
			ProxyQUrl().SetPort(port);
		}
		[SmokeMethod("port", "() const", "")]
		public int Port() {
			return ProxyQUrl().Port();
		}
		[SmokeMethod("port", "(int) const", "$")]
		public int Port(int defaultPort) {
			return ProxyQUrl().Port(defaultPort);
		}
		[SmokeMethod("setPath", "(const QString&)", "$")]
		public void SetPath(string path) {
			ProxyQUrl().SetPath(path);
		}
		[SmokeMethod("path", "() const", "")]
		public string Path() {
			return ProxyQUrl().Path();
		}
		[SmokeMethod("hasQuery", "() const", "")]
		public bool HasQuery() {
			return ProxyQUrl().HasQuery();
		}
		[SmokeMethod("setEncodedQuery", "(const QByteArray&)", "#")]
		public void SetEncodedQuery(QByteArray query) {
			ProxyQUrl().SetEncodedQuery(query);
		}
		[SmokeMethod("encodedQuery", "() const", "")]
		public QByteArray EncodedQuery() {
			return ProxyQUrl().EncodedQuery();
		}
		[SmokeMethod("setQueryDelimiters", "(char, char)", "$$")]
		public void SetQueryDelimiters(char valueDelimiter, char pairDelimiter) {
			ProxyQUrl().SetQueryDelimiters(valueDelimiter,pairDelimiter);
		}
		[SmokeMethod("queryValueDelimiter", "() const", "")]
		public char QueryValueDelimiter() {
			return ProxyQUrl().QueryValueDelimiter();
		}
		[SmokeMethod("queryPairDelimiter", "() const", "")]
		public char QueryPairDelimiter() {
			return ProxyQUrl().QueryPairDelimiter();
		}
		[SmokeMethod("setQueryItems", "(const QList<QPair<QString, QString> >&)", "?")]
		public void SetQueryItems(List<QPair<string, string>> query) {
			ProxyQUrl().SetQueryItems(query);
		}
		[SmokeMethod("addQueryItem", "(const QString&, const QString&)", "$$")]
		public void AddQueryItem(string key, string value) {
			ProxyQUrl().AddQueryItem(key,value);
		}
		[SmokeMethod("queryItems", "() const", "")]
		public List<QPair<string, string>> QueryItems() {
			return ProxyQUrl().QueryItems();
		}
		[SmokeMethod("hasQueryItem", "(const QString&) const", "$")]
		public bool HasQueryItem(string key) {
			return ProxyQUrl().HasQueryItem(key);
		}
		[SmokeMethod("queryItemValue", "(const QString&) const", "$")]
		public string QueryItemValue(string key) {
			return ProxyQUrl().QueryItemValue(key);
		}
		[SmokeMethod("allQueryItemValues", "(const QString&) const", "$")]
		public List<string> AllQueryItemValues(string key) {
			return ProxyQUrl().AllQueryItemValues(key);
		}
		[SmokeMethod("removeQueryItem", "(const QString&)", "$")]
		public void RemoveQueryItem(string key) {
			ProxyQUrl().RemoveQueryItem(key);
		}
		[SmokeMethod("removeAllQueryItems", "(const QString&)", "$")]
		public void RemoveAllQueryItems(string key) {
			ProxyQUrl().RemoveAllQueryItems(key);
		}
		[SmokeMethod("setFragment", "(const QString&)", "$")]
		public void SetFragment(string fragment) {
			ProxyQUrl().SetFragment(fragment);
		}
		[SmokeMethod("fragment", "() const", "")]
		public string Fragment() {
			return ProxyQUrl().Fragment();
		}
		[SmokeMethod("hasFragment", "() const", "")]
		public bool HasFragment() {
			return ProxyQUrl().HasFragment();
		}
		[SmokeMethod("resolved", "(const QUrl&) const", "#")]
		public IQUrl Resolved(IQUrl relative) {
			return ProxyQUrl().Resolved(relative);
		}
		[SmokeMethod("isRelative", "() const", "")]
		public bool IsRelative() {
			return ProxyQUrl().IsRelative();
		}
		[SmokeMethod("isParentOf", "(const QUrl&) const", "#")]
		public bool IsParentOf(IQUrl url) {
			return ProxyQUrl().IsParentOf(url);
		}
		[SmokeMethod("toLocalFile", "() const", "")]
		public string ToLocalFile() {
			return ProxyQUrl().ToLocalFile();
		}
		[SmokeMethod("toString", "(FormattingOptions) const", "$")]
		public string ToString(int options) {
			return ProxyQUrl().ToString(options);
		}
		[SmokeMethod("toString", "() const", "")]
		public string ToString() {
			return ProxyQUrl().ToString();
		}
		[SmokeMethod("toEncoded", "(FormattingOptions) const", "$")]
		public QByteArray ToEncoded(int options) {
			return ProxyQUrl().ToEncoded(options);
		}
		[SmokeMethod("toEncoded", "() const", "")]
		public QByteArray ToEncoded() {
			return ProxyQUrl().ToEncoded();
		}
		[SmokeMethod("detach", "()", "")]
		public void Detach() {
			ProxyQUrl().Detach();
		}
		[SmokeMethod("isDetached", "() const", "")]
		public bool IsDetached() {
			return ProxyQUrl().IsDetached();
		}
		[SmokeMethod("errorString", "() const", "")]
		public string ErrorString() {
			return ProxyQUrl().ErrorString();
		}
		~QUrl() {
			DisposeQUrl();
		}
		public void Dispose() {
			DisposeQUrl();
		}
		[SmokeMethod("~QUrl", "()", "")]
		private void DisposeQUrl() {
			ProxyQUrl().DisposeQUrl();
		}
		public static IQUrl FromLocalFile(string localfile) {
			return StaticQUrl().FromLocalFile(localfile);
		}
		public static IQUrl FromEncoded(QByteArray url) {
			return StaticQUrl().FromEncoded(url);
		}
		public static IQUrl FromEncoded(QByteArray url, QUrl.ParsingMode mode) {
			return StaticQUrl().FromEncoded(url,mode);
		}
		public static string FromPercentEncoding(QByteArray arg1) {
			return StaticQUrl().FromPercentEncoding(arg1);
		}
		public static QByteArray ToPercentEncoding(string arg1, QByteArray exclude, QByteArray include) {
			return StaticQUrl().ToPercentEncoding(arg1,exclude,include);
		}
		public static QByteArray ToPercentEncoding(string arg1, QByteArray exclude) {
			return StaticQUrl().ToPercentEncoding(arg1,exclude);
		}
		public static QByteArray ToPercentEncoding(string arg1) {
			return StaticQUrl().ToPercentEncoding(arg1);
		}
		public static string FromPunycode(QByteArray arg1) {
			return StaticQUrl().FromPunycode(arg1);
		}
		public static QByteArray ToPunycode(string arg1) {
			return StaticQUrl().ToPunycode(arg1);
		}
		public static string FromAce(QByteArray arg1) {
			return StaticQUrl().FromAce(arg1);
		}
		public static QByteArray ToAce(string arg1) {
			return StaticQUrl().ToAce(arg1);
		}
		public static List<string> IdnWhitelist() {
			return StaticQUrl().IdnWhitelist();
		}
		public static void SetIdnWhitelist(List<string> arg1) {
			StaticQUrl().SetIdnWhitelist(arg1);
		}
	}
}
