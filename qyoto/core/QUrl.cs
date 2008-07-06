//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QUrl")]
    public partial class QUrl : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QUrl(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QUrl), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QUrl() {
            staticInterceptor = new SmokeInvocation(typeof(QUrl), null);
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
        // QUrlPrivate*& data_ptr(); >>>> NOT CONVERTED
        public QUrl() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUrl", "QUrl()", typeof(void));
        }
        public QUrl(string url) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUrl$", "QUrl(const QString&)", typeof(void), typeof(string), url);
        }
        public QUrl(string url, QUrl.ParsingMode mode) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUrl$$", "QUrl(const QString&, QUrl::ParsingMode)", typeof(void), typeof(string), url, typeof(QUrl.ParsingMode), mode);
        }
        public QUrl(QUrl copy) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUrl#", "QUrl(const QUrl&)", typeof(void), typeof(QUrl), copy);
        }
        public void SetUrl(string url) {
            interceptor.Invoke("setUrl$", "setUrl(const QString&)", typeof(void), typeof(string), url);
        }
        public void SetUrl(string url, QUrl.ParsingMode mode) {
            interceptor.Invoke("setUrl$$", "setUrl(const QString&, QUrl::ParsingMode)", typeof(void), typeof(string), url, typeof(QUrl.ParsingMode), mode);
        }
        public void SetEncodedUrl(QByteArray url) {
            interceptor.Invoke("setEncodedUrl#", "setEncodedUrl(const QByteArray&)", typeof(void), typeof(QByteArray), url);
        }
        public void SetEncodedUrl(QByteArray url, QUrl.ParsingMode mode) {
            interceptor.Invoke("setEncodedUrl#$", "setEncodedUrl(const QByteArray&, QUrl::ParsingMode)", typeof(void), typeof(QByteArray), url, typeof(QUrl.ParsingMode), mode);
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        public void SetScheme(string scheme) {
            interceptor.Invoke("setScheme$", "setScheme(const QString&)", typeof(void), typeof(string), scheme);
        }
        public string Scheme() {
            return (string) interceptor.Invoke("scheme", "scheme() const", typeof(string));
        }
        public void SetAuthority(string authority) {
            interceptor.Invoke("setAuthority$", "setAuthority(const QString&)", typeof(void), typeof(string), authority);
        }
        public string Authority() {
            return (string) interceptor.Invoke("authority", "authority() const", typeof(string));
        }
        public void SetUserInfo(string userInfo) {
            interceptor.Invoke("setUserInfo$", "setUserInfo(const QString&)", typeof(void), typeof(string), userInfo);
        }
        public string UserInfo() {
            return (string) interceptor.Invoke("userInfo", "userInfo() const", typeof(string));
        }
        public void SetUserName(string userName) {
            interceptor.Invoke("setUserName$", "setUserName(const QString&)", typeof(void), typeof(string), userName);
        }
        public string UserName() {
            return (string) interceptor.Invoke("userName", "userName() const", typeof(string));
        }
        public void SetEncodedUserName(QByteArray userName) {
            interceptor.Invoke("setEncodedUserName#", "setEncodedUserName(const QByteArray&)", typeof(void), typeof(QByteArray), userName);
        }
        public QByteArray EncodedUserName() {
            return (QByteArray) interceptor.Invoke("encodedUserName", "encodedUserName() const", typeof(QByteArray));
        }
        public void SetPassword(string password) {
            interceptor.Invoke("setPassword$", "setPassword(const QString&)", typeof(void), typeof(string), password);
        }
        public string Password() {
            return (string) interceptor.Invoke("password", "password() const", typeof(string));
        }
        public void SetEncodedPassword(QByteArray password) {
            interceptor.Invoke("setEncodedPassword#", "setEncodedPassword(const QByteArray&)", typeof(void), typeof(QByteArray), password);
        }
        public QByteArray EncodedPassword() {
            return (QByteArray) interceptor.Invoke("encodedPassword", "encodedPassword() const", typeof(QByteArray));
        }
        public void SetHost(string host) {
            interceptor.Invoke("setHost$", "setHost(const QString&)", typeof(void), typeof(string), host);
        }
        public string Host() {
            return (string) interceptor.Invoke("host", "host() const", typeof(string));
        }
        public void SetEncodedHost(QByteArray host) {
            interceptor.Invoke("setEncodedHost#", "setEncodedHost(const QByteArray&)", typeof(void), typeof(QByteArray), host);
        }
        public QByteArray EncodedHost() {
            return (QByteArray) interceptor.Invoke("encodedHost", "encodedHost() const", typeof(QByteArray));
        }
        public void SetPort(int port) {
            interceptor.Invoke("setPort$", "setPort(int)", typeof(void), typeof(int), port);
        }
        public int Port() {
            return (int) interceptor.Invoke("port", "port() const", typeof(int));
        }
        public int Port(int defaultPort) {
            return (int) interceptor.Invoke("port$", "port(int) const", typeof(int), typeof(int), defaultPort);
        }
        public void SetPath(string path) {
            interceptor.Invoke("setPath$", "setPath(const QString&)", typeof(void), typeof(string), path);
        }
        public string Path() {
            return (string) interceptor.Invoke("path", "path() const", typeof(string));
        }
        public void SetEncodedPath(QByteArray path) {
            interceptor.Invoke("setEncodedPath#", "setEncodedPath(const QByteArray&)", typeof(void), typeof(QByteArray), path);
        }
        public QByteArray EncodedPath() {
            return (QByteArray) interceptor.Invoke("encodedPath", "encodedPath() const", typeof(QByteArray));
        }
        public bool HasQuery() {
            return (bool) interceptor.Invoke("hasQuery", "hasQuery() const", typeof(bool));
        }
        public void SetEncodedQuery(QByteArray query) {
            interceptor.Invoke("setEncodedQuery#", "setEncodedQuery(const QByteArray&)", typeof(void), typeof(QByteArray), query);
        }
        public QByteArray EncodedQuery() {
            return (QByteArray) interceptor.Invoke("encodedQuery", "encodedQuery() const", typeof(QByteArray));
        }
        public void SetQueryDelimiters(char valueDelimiter, char pairDelimiter) {
            interceptor.Invoke("setQueryDelimiters$$", "setQueryDelimiters(char, char)", typeof(void), typeof(char), valueDelimiter, typeof(char), pairDelimiter);
        }
        public char QueryValueDelimiter() {
            return (char) interceptor.Invoke("queryValueDelimiter", "queryValueDelimiter() const", typeof(char));
        }
        public char QueryPairDelimiter() {
            return (char) interceptor.Invoke("queryPairDelimiter", "queryPairDelimiter() const", typeof(char));
        }
        public void SetQueryItems(List<QPair<string, string>> query) {
            interceptor.Invoke("setQueryItems?", "setQueryItems(const QList<QPair<QString, QString> >&)", typeof(void), typeof(List<QPair<string, string>>), query);
        }
        public void AddQueryItem(string key, string value) {
            interceptor.Invoke("addQueryItem$$", "addQueryItem(const QString&, const QString&)", typeof(void), typeof(string), key, typeof(string), value);
        }
        public List<QPair<string, string>> QueryItems() {
            return (List<QPair<string, string>>) interceptor.Invoke("queryItems", "queryItems() const", typeof(List<QPair<string, string>>));
        }
        public bool HasQueryItem(string key) {
            return (bool) interceptor.Invoke("hasQueryItem$", "hasQueryItem(const QString&) const", typeof(bool), typeof(string), key);
        }
        public string QueryItemValue(string key) {
            return (string) interceptor.Invoke("queryItemValue$", "queryItemValue(const QString&) const", typeof(string), typeof(string), key);
        }
        public List<string> AllQueryItemValues(string key) {
            return (List<string>) interceptor.Invoke("allQueryItemValues$", "allQueryItemValues(const QString&) const", typeof(List<string>), typeof(string), key);
        }
        public void RemoveQueryItem(string key) {
            interceptor.Invoke("removeQueryItem$", "removeQueryItem(const QString&)", typeof(void), typeof(string), key);
        }
        public void RemoveAllQueryItems(string key) {
            interceptor.Invoke("removeAllQueryItems$", "removeAllQueryItems(const QString&)", typeof(void), typeof(string), key);
        }
        public void SetEncodedQueryItems(List<QPair<QByteArray, QByteArray>> query) {
            interceptor.Invoke("setEncodedQueryItems?", "setEncodedQueryItems(const QList<QPair<QByteArray, QByteArray> >&)", typeof(void), typeof(List<QPair<QByteArray, QByteArray>>), query);
        }
        public void AddEncodedQueryItem(QByteArray key, QByteArray value) {
            interceptor.Invoke("addEncodedQueryItem##", "addEncodedQueryItem(const QByteArray&, const QByteArray&)", typeof(void), typeof(QByteArray), key, typeof(QByteArray), value);
        }
        public List<QPair<QByteArray, QByteArray>> EncodedQueryItems() {
            return (List<QPair<QByteArray, QByteArray>>) interceptor.Invoke("encodedQueryItems", "encodedQueryItems() const", typeof(List<QPair<QByteArray, QByteArray>>));
        }
        public bool HasEncodedQueryItem(QByteArray key) {
            return (bool) interceptor.Invoke("hasEncodedQueryItem#", "hasEncodedQueryItem(const QByteArray&) const", typeof(bool), typeof(QByteArray), key);
        }
        public QByteArray EncodedQueryItemValue(QByteArray key) {
            return (QByteArray) interceptor.Invoke("encodedQueryItemValue#", "encodedQueryItemValue(const QByteArray&) const", typeof(QByteArray), typeof(QByteArray), key);
        }
        public List<QByteArray> AllEncodedQueryItemValues(QByteArray key) {
            return (List<QByteArray>) interceptor.Invoke("allEncodedQueryItemValues#", "allEncodedQueryItemValues(const QByteArray&) const", typeof(List<QByteArray>), typeof(QByteArray), key);
        }
        public void RemoveEncodedQueryItem(QByteArray key) {
            interceptor.Invoke("removeEncodedQueryItem#", "removeEncodedQueryItem(const QByteArray&)", typeof(void), typeof(QByteArray), key);
        }
        public void RemoveAllEncodedQueryItems(QByteArray key) {
            interceptor.Invoke("removeAllEncodedQueryItems#", "removeAllEncodedQueryItems(const QByteArray&)", typeof(void), typeof(QByteArray), key);
        }
        public void SetFragment(string fragment) {
            interceptor.Invoke("setFragment$", "setFragment(const QString&)", typeof(void), typeof(string), fragment);
        }
        public string Fragment() {
            return (string) interceptor.Invoke("fragment", "fragment() const", typeof(string));
        }
        public void SetEncodedFragment(QByteArray fragment) {
            interceptor.Invoke("setEncodedFragment#", "setEncodedFragment(const QByteArray&)", typeof(void), typeof(QByteArray), fragment);
        }
        public QByteArray EncodedFragment() {
            return (QByteArray) interceptor.Invoke("encodedFragment", "encodedFragment() const", typeof(QByteArray));
        }
        public bool HasFragment() {
            return (bool) interceptor.Invoke("hasFragment", "hasFragment() const", typeof(bool));
        }
        public QUrl Resolved(QUrl relative) {
            return (QUrl) interceptor.Invoke("resolved#", "resolved(const QUrl&) const", typeof(QUrl), typeof(QUrl), relative);
        }
        public bool IsRelative() {
            return (bool) interceptor.Invoke("isRelative", "isRelative() const", typeof(bool));
        }
        public bool IsParentOf(QUrl url) {
            return (bool) interceptor.Invoke("isParentOf#", "isParentOf(const QUrl&) const", typeof(bool), typeof(QUrl), url);
        }
        public string ToLocalFile() {
            return (string) interceptor.Invoke("toLocalFile", "toLocalFile() const", typeof(string));
        }
        public string ToString(uint options) {
            return (string) interceptor.Invoke("toString$", "toString(QUrl::FormattingOptions) const", typeof(string), typeof(uint), options);
        }
        public new string ToString() {
            return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
        }
        public QByteArray ToEncoded(uint options) {
            return (QByteArray) interceptor.Invoke("toEncoded$", "toEncoded(QUrl::FormattingOptions) const", typeof(QByteArray), typeof(uint), options);
        }
        public QByteArray ToEncoded() {
            return (QByteArray) interceptor.Invoke("toEncoded", "toEncoded() const", typeof(QByteArray));
        }
        public void Detach() {
            interceptor.Invoke("detach", "detach()", typeof(void));
        }
        public bool IsDetached() {
            return (bool) interceptor.Invoke("isDetached", "isDetached() const", typeof(bool));
        }
        public override bool Equals(object o) {
            if (!(o is QUrl)) { return false; }
            return this == (QUrl) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public string ErrorString() {
            return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
        }
        ~QUrl() {
            interceptor.Invoke("~QUrl", "~QUrl()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QUrl", "~QUrl()", typeof(void));
        }
        public static bool operator<(QUrl lhs, QUrl url) {
            return (bool) staticInterceptor.Invoke("operator<#", "operator<(const QUrl&) const", typeof(bool), typeof(QUrl), lhs, typeof(QUrl), url);
        }
        public static bool operator>(QUrl lhs, QUrl url) {
            return !(bool) staticInterceptor.Invoke("operator<#", "operator<(const QUrl&) const", typeof(bool), typeof(QUrl), lhs, typeof(QUrl), url)
                        && !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QUrl&) const", typeof(bool), typeof(QUrl), lhs, typeof(QUrl), url);
        }
        public static bool operator==(QUrl lhs, QUrl url) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QUrl&) const", typeof(bool), typeof(QUrl), lhs, typeof(QUrl), url);
        }
        public static bool operator!=(QUrl lhs, QUrl url) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QUrl&) const", typeof(bool), typeof(QUrl), lhs, typeof(QUrl), url);
        }
        public static QUrl FromLocalFile(string localfile) {
            return (QUrl) staticInterceptor.Invoke("fromLocalFile$", "fromLocalFile(const QString&)", typeof(QUrl), typeof(string), localfile);
        }
        public static QUrl FromEncoded(QByteArray url) {
            return (QUrl) staticInterceptor.Invoke("fromEncoded#", "fromEncoded(const QByteArray&)", typeof(QUrl), typeof(QByteArray), url);
        }
        public static QUrl FromEncoded(QByteArray url, QUrl.ParsingMode mode) {
            return (QUrl) staticInterceptor.Invoke("fromEncoded#$", "fromEncoded(const QByteArray&, QUrl::ParsingMode)", typeof(QUrl), typeof(QByteArray), url, typeof(QUrl.ParsingMode), mode);
        }
        public static string FromPercentEncoding(QByteArray arg1) {
            return (string) staticInterceptor.Invoke("fromPercentEncoding#", "fromPercentEncoding(const QByteArray&)", typeof(string), typeof(QByteArray), arg1);
        }
        public static QByteArray ToPercentEncoding(string arg1, QByteArray exclude, QByteArray include) {
            return (QByteArray) staticInterceptor.Invoke("toPercentEncoding$##", "toPercentEncoding(const QString&, const QByteArray&, const QByteArray&)", typeof(QByteArray), typeof(string), arg1, typeof(QByteArray), exclude, typeof(QByteArray), include);
        }
        public static QByteArray ToPercentEncoding(string arg1, QByteArray exclude) {
            return (QByteArray) staticInterceptor.Invoke("toPercentEncoding$#", "toPercentEncoding(const QString&, const QByteArray&)", typeof(QByteArray), typeof(string), arg1, typeof(QByteArray), exclude);
        }
        public static QByteArray ToPercentEncoding(string arg1) {
            return (QByteArray) staticInterceptor.Invoke("toPercentEncoding$", "toPercentEncoding(const QString&)", typeof(QByteArray), typeof(string), arg1);
        }
        public static string FromPunycode(QByteArray arg1) {
            return (string) staticInterceptor.Invoke("fromPunycode#", "fromPunycode(const QByteArray&)", typeof(string), typeof(QByteArray), arg1);
        }
        public static QByteArray ToPunycode(string arg1) {
            return (QByteArray) staticInterceptor.Invoke("toPunycode$", "toPunycode(const QString&)", typeof(QByteArray), typeof(string), arg1);
        }
        public static string FromAce(QByteArray arg1) {
            return (string) staticInterceptor.Invoke("fromAce#", "fromAce(const QByteArray&)", typeof(string), typeof(QByteArray), arg1);
        }
        public static QByteArray ToAce(string arg1) {
            return (QByteArray) staticInterceptor.Invoke("toAce$", "toAce(const QString&)", typeof(QByteArray), typeof(string), arg1);
        }
        public static List<string> IdnWhitelist() {
            return (List<string>) staticInterceptor.Invoke("idnWhitelist", "idnWhitelist()", typeof(List<string>));
        }
        public static void SetIdnWhitelist(List<string> arg1) {
            staticInterceptor.Invoke("setIdnWhitelist?", "setIdnWhitelist(const QStringList&)", typeof(void), typeof(List<string>), arg1);
        }
    }
}
