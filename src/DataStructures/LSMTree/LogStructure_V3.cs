using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LSMTree
{
    /// <summary>
    /// 
    /// </summary>
    public class LogStructure_V3
    {
        const int LOG_SEGMENTS_LIMIT = 10;
        private IList<LogSegment_V3> _logSegments;
        private LogSegment_V3 _currentSegment;
        public LogStructure_V3()
        {
            _logSegments = new List<LogSegment_V3>();
            _currentSegment = LogSegment_V3.Create();
            _logSegments.Add(_currentSegment);
        }

        public void Add(int key, string value)
        {
            if (_logSegments.Count >= LOG_SEGMENTS_LIMIT)
            {
                _logSegments = CompactLogSegments();
            }

            if (_currentSegment.Add(key, value))
            {
                return;
            }
            _currentSegment = LogSegment_V3.Create();
            _currentSegment.Add(key, value);
            _logSegments.Add(_currentSegment);
        }

        private IList<LogSegment_V3> CompactLogSegments()
        {
            var compactedSegments = new List<LogSegment_V3>();
            foreach (var segment in _logSegments)
            {
                compactedSegments.Add(segment.Compact());
            }
            return compactedSegments;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class LogSegment_V3
    {
        const int LOG_ITEMS_LIMIT = 100;
        private int _offset;
        readonly IDictionary<int, int> _lookup;
        readonly IList<(int key, string value)> _logs;
        private LogSegment_V3()
        {
            _offset = -1;
            _lookup = new Dictionary<int, int>();
            _logs = new List<(int key, string value)>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        internal bool Add(int key, string value)
        {
            if (_offset + 1 >= LOG_ITEMS_LIMIT)
            {
                return false;
            }
            _logs.Add((key, value));
            _offset += 1;
            if (!_lookup.ContainsKey(key))
            {
                _lookup.Add(key, _offset);
                return true;
            }
            _lookup[key] = _offset;
            return true;
        }

        internal LogSegment_V3 Compact()
        {
            var logSegment = Create();
            foreach (var lookupItem in _lookup)
            {
                logSegment.Add(lookupItem.Key, _logs[lookupItem.Value].value);
            }
            return logSegment;
        }

        public static LogSegment_V3 Create() => new LogSegment_V3();
    }
}
