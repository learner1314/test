using System;
using System.Runtime.Serialization;

namespace NStore.Core
{
    /// <summary>
    /// NStore���ݿ��쳣
    /// </summary>
    [Serializable]
    public class DbException : BMAException
    {
        public DbException() : base() { }

        public DbException(string message) : base(message) { }

        public DbException(string message, Exception inner) : base(message, inner) { }

        public DbException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
