using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.Work
{
    public interface IITIReadOnlyList<T>
    {
        int Count { get; }

        T this[int index] { get; }

        int IndexOf( T value );
    }

    public interface IITIList<T> : IITIReadOnlyList<T>
    {
        new T this[ int index ] { get; set; }

        void Add( T i );

        void RemoveAt( int index );

        void InsertAt( int index, T value );
    }

}
