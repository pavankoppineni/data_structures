using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures.LSMTree
{
    public class LogStructure_V2
    {
        LogSegment_V2 _currentSegment;
        public LogStructure_V2()
        {
            _currentSegment = LogSegment_V2.Create();
        }
        public void Add(int key, string value)
        {
            if (!_currentSegment.Add(key, value))
            {
                _currentSegment.Dispose();
                _currentSegment = LogSegment_V2.Create();
                _currentSegment.Add(key, value);
            }
        }

        public void Dispose()
        {
            _currentSegment.Dispose();
        }
    }

    internal class LogSegment_V2 : IDisposable
    {
        readonly string _fileName;
        const int MAX_BYTES = 1024 * 1024;
        const string LOG_SEGMENT_PREFIX = "LOG_SEGMENT_";
        readonly FileStream _logStream;
        int _offset;

        private LogSegment_V2()
        {
            _fileName = $"{LOG_SEGMENT_PREFIX}_{Guid.NewGuid()}.log";
            _logStream = File.Create(_fileName);
        }

        internal string FileName => _fileName;

        internal bool Add(int key, string value)
        {
            if (_logStream.Length > MAX_BYTES)
            {
                return false;
            }
            var newLine = string.Format("key : {0}, value : {1} \r\n", key % 1000, value);
            var byteArray = Encoding.ASCII.GetBytes(newLine);
            _logStream.Write(byteArray, 0, byteArray.Length);
            _offset += byteArray.Length;
            return true;
        }

        internal static LogSegment_V2 Create()
        {
            return new LogSegment_V2();
        }

        public void Dispose()
        {
            _logStream.Close();
            _logStream.Dispose();
        }
    }
}
