//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IQProcessSignals"></see> for signals emitted by QProcess
    /// </remarks>
    [SmokeClass("QProcess")]
    public class QProcess : QIODevice, IDisposable {
        protected QProcess(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QProcess), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QProcess() {
            staticInterceptor = new SmokeInvocation(typeof(QProcess), null);
        }
        public enum ProcessError {
            FailedToStart = 0,
            Crashed = 1,
            Timedout = 2,
            ReadError = 3,
            WriteError = 4,
            UnknownError = 5,
        }
        public enum ProcessState {
            NotRunning = 0,
            Starting = 1,
            Running = 2,
        }
        public enum ProcessChannel {
            StandardOutput = 0,
            StandardError = 1,
        }
        public enum ProcessChannelMode {
            SeparateChannels = 0,
            MergedChannels = 1,
            ForwardedChannels = 2,
        }
        public enum ExitStatus {
            NormalExit = 0,
            CrashExit = 1,
        }
        public QProcess(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QProcess#", "QProcess(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QProcess() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QProcess", "QProcess()", typeof(void));
        }
        public void Start(string program, List<string> arguments, uint mode) {
            interceptor.Invoke("start$?$", "start(const QString&, const QStringList&, QIODevice::OpenMode)", typeof(void), typeof(string), program, typeof(List<string>), arguments, typeof(uint), mode);
        }
        public void Start(string program, List<string> arguments) {
            interceptor.Invoke("start$?", "start(const QString&, const QStringList&)", typeof(void), typeof(string), program, typeof(List<string>), arguments);
        }
        public void Start(string program, uint mode) {
            interceptor.Invoke("start$$", "start(const QString&, QIODevice::OpenMode)", typeof(void), typeof(string), program, typeof(uint), mode);
        }
        public void Start(string program) {
            interceptor.Invoke("start$", "start(const QString&)", typeof(void), typeof(string), program);
        }
        public QProcess.ProcessChannelMode ReadChannelMode() {
            return (QProcess.ProcessChannelMode) interceptor.Invoke("readChannelMode", "readChannelMode() const", typeof(QProcess.ProcessChannelMode));
        }
        public void SetReadChannelMode(QProcess.ProcessChannelMode mode) {
            interceptor.Invoke("setReadChannelMode$", "setReadChannelMode(QProcess::ProcessChannelMode)", typeof(void), typeof(QProcess.ProcessChannelMode), mode);
        }
        public QProcess.ProcessChannelMode processChannelMode() {
            return (QProcess.ProcessChannelMode) interceptor.Invoke("processChannelMode", "processChannelMode() const", typeof(QProcess.ProcessChannelMode));
        }
        public void SetProcessChannelMode(QProcess.ProcessChannelMode mode) {
            interceptor.Invoke("setProcessChannelMode$", "setProcessChannelMode(QProcess::ProcessChannelMode)", typeof(void), typeof(QProcess.ProcessChannelMode), mode);
        }
        public QProcess.ProcessChannel ReadChannel() {
            return (QProcess.ProcessChannel) interceptor.Invoke("readChannel", "readChannel() const", typeof(QProcess.ProcessChannel));
        }
        public void SetReadChannel(QProcess.ProcessChannel channel) {
            interceptor.Invoke("setReadChannel$", "setReadChannel(QProcess::ProcessChannel)", typeof(void), typeof(QProcess.ProcessChannel), channel);
        }
        public void CloseReadChannel(QProcess.ProcessChannel channel) {
            interceptor.Invoke("closeReadChannel$", "closeReadChannel(QProcess::ProcessChannel)", typeof(void), typeof(QProcess.ProcessChannel), channel);
        }
        public void CloseWriteChannel() {
            interceptor.Invoke("closeWriteChannel", "closeWriteChannel()", typeof(void));
        }
        public void SetStandardInputFile(string fileName) {
            interceptor.Invoke("setStandardInputFile$", "setStandardInputFile(const QString&)", typeof(void), typeof(string), fileName);
        }
        public void SetStandardOutputFile(string fileName, uint mode) {
            interceptor.Invoke("setStandardOutputFile$$", "setStandardOutputFile(const QString&, QIODevice::OpenMode)", typeof(void), typeof(string), fileName, typeof(uint), mode);
        }
        public void SetStandardOutputFile(string fileName) {
            interceptor.Invoke("setStandardOutputFile$", "setStandardOutputFile(const QString&)", typeof(void), typeof(string), fileName);
        }
        public void SetStandardErrorFile(string fileName, uint mode) {
            interceptor.Invoke("setStandardErrorFile$$", "setStandardErrorFile(const QString&, QIODevice::OpenMode)", typeof(void), typeof(string), fileName, typeof(uint), mode);
        }
        public void SetStandardErrorFile(string fileName) {
            interceptor.Invoke("setStandardErrorFile$", "setStandardErrorFile(const QString&)", typeof(void), typeof(string), fileName);
        }
        public void SetStandardOutputProcess(QProcess destination) {
            interceptor.Invoke("setStandardOutputProcess#", "setStandardOutputProcess(QProcess*)", typeof(void), typeof(QProcess), destination);
        }
        public string WorkingDirectory() {
            return (string) interceptor.Invoke("workingDirectory", "workingDirectory() const", typeof(string));
        }
        public void SetWorkingDirectory(string dir) {
            interceptor.Invoke("setWorkingDirectory$", "setWorkingDirectory(const QString&)", typeof(void), typeof(string), dir);
        }
        public void SetEnvironment(List<string> environment) {
            interceptor.Invoke("setEnvironment?", "setEnvironment(const QStringList&)", typeof(void), typeof(List<string>), environment);
        }
        public List<string> Environment() {
            return (List<string>) interceptor.Invoke("environment", "environment() const", typeof(List<string>));
        }
        public QProcess.ProcessError Error() {
            return (QProcess.ProcessError) interceptor.Invoke("error", "error() const", typeof(QProcess.ProcessError));
        }
        public QProcess.ProcessState State() {
            return (QProcess.ProcessState) interceptor.Invoke("state", "state() const", typeof(QProcess.ProcessState));
        }
        public long Pid() {
            return (long) interceptor.Invoke("pid", "pid() const", typeof(long));
        }
        public bool WaitForStarted(int msecs) {
            return (bool) interceptor.Invoke("waitForStarted$", "waitForStarted(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForStarted() {
            return (bool) interceptor.Invoke("waitForStarted", "waitForStarted()", typeof(bool));
        }
        [SmokeMethod("waitForReadyRead(int)")]
        public override bool WaitForReadyRead(int msecs) {
            return (bool) interceptor.Invoke("waitForReadyRead$", "waitForReadyRead(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForReadyRead() {
            return (bool) interceptor.Invoke("waitForReadyRead", "waitForReadyRead()", typeof(bool));
        }
        [SmokeMethod("waitForBytesWritten(int)")]
        public override bool WaitForBytesWritten(int msecs) {
            return (bool) interceptor.Invoke("waitForBytesWritten$", "waitForBytesWritten(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForBytesWritten() {
            return (bool) interceptor.Invoke("waitForBytesWritten", "waitForBytesWritten()", typeof(bool));
        }
        public bool WaitForFinished(int msecs) {
            return (bool) interceptor.Invoke("waitForFinished$", "waitForFinished(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForFinished() {
            return (bool) interceptor.Invoke("waitForFinished", "waitForFinished()", typeof(bool));
        }
        public QByteArray ReadAllStandardOutput() {
            return (QByteArray) interceptor.Invoke("readAllStandardOutput", "readAllStandardOutput()", typeof(QByteArray));
        }
        public QByteArray ReadAllStandardError() {
            return (QByteArray) interceptor.Invoke("readAllStandardError", "readAllStandardError()", typeof(QByteArray));
        }
        public int ExitCode() {
            return (int) interceptor.Invoke("exitCode", "exitCode() const", typeof(int));
        }
        public QProcess.ExitStatus exitStatus() {
            return (QProcess.ExitStatus) interceptor.Invoke("exitStatus", "exitStatus() const", typeof(QProcess.ExitStatus));
        }
        [SmokeMethod("bytesAvailable() const")]
        public override long BytesAvailable() {
            return (long) interceptor.Invoke("bytesAvailable", "bytesAvailable() const", typeof(long));
        }
        [SmokeMethod("bytesToWrite() const")]
        public override long BytesToWrite() {
            return (long) interceptor.Invoke("bytesToWrite", "bytesToWrite() const", typeof(long));
        }
        [SmokeMethod("isSequential() const")]
        public override bool IsSequential() {
            return (bool) interceptor.Invoke("isSequential", "isSequential() const", typeof(bool));
        }
        [SmokeMethod("canReadLine() const")]
        public override bool CanReadLine() {
            return (bool) interceptor.Invoke("canReadLine", "canReadLine() const", typeof(bool));
        }
        [SmokeMethod("close()")]
        public override void Close() {
            interceptor.Invoke("close", "close()", typeof(void));
        }
        [SmokeMethod("atEnd() const")]
        public override bool AtEnd() {
            return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
        }
        [Q_SLOT("void terminate()")]
        public void Terminate() {
            interceptor.Invoke("terminate", "terminate()", typeof(void));
        }
        [Q_SLOT("void kill()")]
        public void Kill() {
            interceptor.Invoke("kill", "kill()", typeof(void));
        }
        protected void SetProcessState(QProcess.ProcessState state) {
            interceptor.Invoke("setProcessState$", "setProcessState(QProcess::ProcessState)", typeof(void), typeof(QProcess.ProcessState), state);
        }
        [SmokeMethod("setupChildProcess()")]
        protected virtual void SetupChildProcess() {
            interceptor.Invoke("setupChildProcess", "setupChildProcess()", typeof(void));
        }
        [SmokeMethod("readData(char*, qint64)")]
        protected override long ReadData(Pointer<sbyte> data, long maxlen) {
            return (long) interceptor.Invoke("readData$$", "readData(char*, qint64)", typeof(long), typeof(Pointer<sbyte>), data, typeof(long), maxlen);
        }
        [SmokeMethod("writeData(const char*, qint64)")]
        protected override long WriteData(string data, long len) {
            return (long) interceptor.Invoke("writeData$$", "writeData(const char*, qint64)", typeof(long), typeof(string), data, typeof(long), len);
        }
        ~QProcess() {
            interceptor.Invoke("~QProcess", "~QProcess()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QProcess", "~QProcess()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        public static int Execute(string program, List<string> arguments) {
            return (int) staticInterceptor.Invoke("execute$?", "execute(const QString&, const QStringList&)", typeof(int), typeof(string), program, typeof(List<string>), arguments);
        }
        public static int Execute(string program) {
            return (int) staticInterceptor.Invoke("execute$", "execute(const QString&)", typeof(int), typeof(string), program);
        }
        public static bool StartDetached(string program, List<string> arguments, string workingDirectory, ref long pid) {
            StackItem[] stack = new StackItem[5];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(program);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(program);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(arguments);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(arguments);
#endif
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(workingDirectory);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(workingDirectory);
#endif
            stack[4].s_long = pid;
            staticInterceptor.Invoke("startDetached$?$?", "startDetached(const QString&, const QStringList&, const QString&, qint64*)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).SynchronizedFree();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).SynchronizedFree();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).SynchronizedFree();
#endif
            pid = stack[4].s_long;
            return stack[0].s_bool;
        }
        public static bool StartDetached(string program, List<string> arguments, string workingDirectory) {
            return (bool) staticInterceptor.Invoke("startDetached$?$", "startDetached(const QString&, const QStringList&, const QString&)", typeof(bool), typeof(string), program, typeof(List<string>), arguments, typeof(string), workingDirectory);
        }
        public static bool StartDetached(string program, List<string> arguments) {
            return (bool) staticInterceptor.Invoke("startDetached$?", "startDetached(const QString&, const QStringList&)", typeof(bool), typeof(string), program, typeof(List<string>), arguments);
        }
        public static bool StartDetached(string program) {
            return (bool) staticInterceptor.Invoke("startDetached$", "startDetached(const QString&)", typeof(bool), typeof(string), program);
        }
        public static List<string> SystemEnvironment() {
            return (List<string>) staticInterceptor.Invoke("systemEnvironment", "systemEnvironment()", typeof(List<string>));
        }
        protected new IQProcessSignals Emit {
            get { return (IQProcessSignals) Q_EMIT; }
        }
    }

    public interface IQProcessSignals : IQIODeviceSignals {
        [Q_SIGNAL("void started()")]
        void Started();
        [Q_SIGNAL("void finished(int)")]
        void Finished(int exitCode);
        [Q_SIGNAL("void finished(int, QProcess::ExitStatus)")]
        void Finished(int exitCode, QProcess.ExitStatus exitStatus);
        [Q_SIGNAL("void error(QProcess::ProcessError)")]
        void Error(QProcess.ProcessError error);
        [Q_SIGNAL("void stateChanged(QProcess::ProcessState)")]
        void StateChanged(QProcess.ProcessState state);
        [Q_SIGNAL("void readyReadStandardOutput()")]
        void ReadyReadStandardOutput();
        [Q_SIGNAL("void readyReadStandardError()")]
        void ReadyReadStandardError();
    }
}
