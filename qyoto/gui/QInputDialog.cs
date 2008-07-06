//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    [SmokeClass("QInputDialog")]
    public class QInputDialog : QDialog {
        protected QInputDialog(Type dummy) : base((Type) null) {}
        private static SmokeInvocation staticInterceptor = null;
        static QInputDialog() {
            staticInterceptor = new SmokeInvocation(typeof(QInputDialog), null);
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text, ref bool ok, uint f) {
            StackItem[] stack = new StackItem[8];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(title);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(title);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
            stack[4].s_int = (int) echo;
#if DEBUG
            stack[5].s_class = (IntPtr) DebugGCHandle.Alloc(text);
#else
            stack[5].s_class = (IntPtr) GCHandle.Alloc(text);
#endif
            stack[6].s_bool = ok;
            stack[7].s_uint = f;
            staticInterceptor.Invoke("getText#$$$$$$", "getText(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&, bool*, Qt::WindowFlags)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[5].s_class);
#else
            ((GCHandle) stack[5].s_class).Free();
#endif
            ok = stack[6].s_bool;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).Free();
#endif
            return (string) returnValue;
        }
        public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text, ref bool ok) {
            StackItem[] stack = new StackItem[7];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(title);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(title);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
            stack[4].s_int = (int) echo;
#if DEBUG
            stack[5].s_class = (IntPtr) DebugGCHandle.Alloc(text);
#else
            stack[5].s_class = (IntPtr) GCHandle.Alloc(text);
#endif
            stack[6].s_bool = ok;
            staticInterceptor.Invoke("getText#$$$$$", "getText(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&, bool*)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[5].s_class);
#else
            ((GCHandle) stack[5].s_class).Free();
#endif
            ok = stack[6].s_bool;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).Free();
#endif
            return (string) returnValue;
        }
        public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text) {
            return (string) staticInterceptor.Invoke("getText#$$$$", "getText(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(QLineEdit.EchoMode), echo, typeof(string), text);
        }
        public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo) {
            return (string) staticInterceptor.Invoke("getText#$$$", "getText(QWidget*, const QString&, const QString&, QLineEdit::EchoMode)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(QLineEdit.EchoMode), echo);
        }
        public static string GetText(QWidget parent, string title, string label) {
            return (string) staticInterceptor.Invoke("getText#$$", "getText(QWidget*, const QString&, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label);
        }
        public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, ref bool ok, uint f) {
            StackItem[] stack = new StackItem[10];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(title);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(title);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
            stack[4].s_int = value;
            stack[5].s_int = minValue;
            stack[6].s_int = maxValue;
            stack[7].s_int = step;
            stack[8].s_bool = ok;
            stack[9].s_uint = f;
            staticInterceptor.Invoke("getInteger#$$$$$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int, int, int, bool*, Qt::WindowFlags)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
            ok = stack[8].s_bool;
            return stack[0].s_int;
        }
        public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, ref bool ok) {
            StackItem[] stack = new StackItem[9];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(title);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(title);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
            stack[4].s_int = value;
            stack[5].s_int = minValue;
            stack[6].s_int = maxValue;
            stack[7].s_int = step;
            stack[8].s_bool = ok;
            staticInterceptor.Invoke("getInteger#$$$$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int, int, int, bool*)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
            ok = stack[8].s_bool;
            return stack[0].s_int;
        }
        public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step) {
            return (int) staticInterceptor.Invoke("getInteger#$$$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int, int, int)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value, typeof(int), minValue, typeof(int), maxValue, typeof(int), step);
        }
        public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue) {
            return (int) staticInterceptor.Invoke("getInteger#$$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int, int)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value, typeof(int), minValue, typeof(int), maxValue);
        }
        public static int GetInteger(QWidget parent, string title, string label, int value, int minValue) {
            return (int) staticInterceptor.Invoke("getInteger#$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value, typeof(int), minValue);
        }
        public static int GetInteger(QWidget parent, string title, string label, int value) {
            return (int) staticInterceptor.Invoke("getInteger#$$$", "getInteger(QWidget*, const QString&, const QString&, int)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value);
        }
        public static int GetInteger(QWidget parent, string title, string label) {
            return (int) staticInterceptor.Invoke("getInteger#$$", "getInteger(QWidget*, const QString&, const QString&)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label);
        }
        public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, ref bool ok, uint f) {
            StackItem[] stack = new StackItem[10];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(title);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(title);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
            stack[4].s_double = value;
            stack[5].s_double = minValue;
            stack[6].s_double = maxValue;
            stack[7].s_int = decimals;
            stack[8].s_bool = ok;
            stack[9].s_uint = f;
            staticInterceptor.Invoke("getDouble#$$$$$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double, double, int, bool*, Qt::WindowFlags)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
            ok = stack[8].s_bool;
            return stack[0].s_double;
        }
        public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, ref bool ok) {
            StackItem[] stack = new StackItem[9];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(title);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(title);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
            stack[4].s_double = value;
            stack[5].s_double = minValue;
            stack[6].s_double = maxValue;
            stack[7].s_int = decimals;
            stack[8].s_bool = ok;
            staticInterceptor.Invoke("getDouble#$$$$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double, double, int, bool*)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
            ok = stack[8].s_bool;
            return stack[0].s_double;
        }
        public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals) {
            return (double) staticInterceptor.Invoke("getDouble#$$$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double, double, int)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value, typeof(double), minValue, typeof(double), maxValue, typeof(int), decimals);
        }
        public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue) {
            return (double) staticInterceptor.Invoke("getDouble#$$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double, double)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value, typeof(double), minValue, typeof(double), maxValue);
        }
        public static double GetDouble(QWidget parent, string title, string label, double value, double minValue) {
            return (double) staticInterceptor.Invoke("getDouble#$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value, typeof(double), minValue);
        }
        public static double GetDouble(QWidget parent, string title, string label, double value) {
            return (double) staticInterceptor.Invoke("getDouble#$$$", "getDouble(QWidget*, const QString&, const QString&, double)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value);
        }
        public static double GetDouble(QWidget parent, string title, string label) {
            return (double) staticInterceptor.Invoke("getDouble#$$", "getDouble(QWidget*, const QString&, const QString&)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label);
        }
        public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable, ref bool ok, uint f) {
            StackItem[] stack = new StackItem[9];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(title);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(title);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
            stack[4].s_class = (IntPtr) DebugGCHandle.Alloc(list);
#else
            stack[4].s_class = (IntPtr) GCHandle.Alloc(list);
#endif
            stack[5].s_int = current;
            stack[6].s_bool = editable;
            stack[7].s_bool = ok;
            stack[8].s_uint = f;
            staticInterceptor.Invoke("getItem#$$?$$$$", "getItem(QWidget*, const QString&, const QString&, const QStringList&, int, bool, bool*, Qt::WindowFlags)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[4].s_class);
#else
            ((GCHandle) stack[4].s_class).Free();
#endif
            ok = stack[7].s_bool;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).Free();
#endif
            return (string) returnValue;
        }
        public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable, ref bool ok) {
            StackItem[] stack = new StackItem[8];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(title);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(title);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
            stack[4].s_class = (IntPtr) DebugGCHandle.Alloc(list);
#else
            stack[4].s_class = (IntPtr) GCHandle.Alloc(list);
#endif
            stack[5].s_int = current;
            stack[6].s_bool = editable;
            stack[7].s_bool = ok;
            staticInterceptor.Invoke("getItem#$$?$$$", "getItem(QWidget*, const QString&, const QString&, const QStringList&, int, bool, bool*)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[4].s_class);
#else
            ((GCHandle) stack[4].s_class).Free();
#endif
            ok = stack[7].s_bool;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).Free();
#endif
            return (string) returnValue;
        }
        public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable) {
            return (string) staticInterceptor.Invoke("getItem#$$?$$", "getItem(QWidget*, const QString&, const QString&, const QStringList&, int, bool)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(List<string>), list, typeof(int), current, typeof(bool), editable);
        }
        public static string GetItem(QWidget parent, string title, string label, List<string> list, int current) {
            return (string) staticInterceptor.Invoke("getItem#$$?$", "getItem(QWidget*, const QString&, const QString&, const QStringList&, int)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(List<string>), list, typeof(int), current);
        }
        public static string GetItem(QWidget parent, string title, string label, List<string> list) {
            return (string) staticInterceptor.Invoke("getItem#$$?", "getItem(QWidget*, const QString&, const QString&, const QStringList&)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(List<string>), list);
        }
        protected new IQInputDialogSignals Emit {
            get { return (IQInputDialogSignals) Q_EMIT; }
        }
    }

    public interface IQInputDialogSignals : IQDialogSignals {
    }
}
