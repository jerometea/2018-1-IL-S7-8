using System;
using System.Collections;
using System.Collections.Generic;

namespace ITI.Work
{
    public class ITIDictionary<TKey,TValue> : IEnumerable<KeyValuePair<TKey,TValue>>
    {
        int _count;
        Node[] _buckets;

        public ITIDictionary()
        {
            _buckets = new Node[6];
        }

        class Node
        {
            public readonly TKey Key;
            public TValue Value;
            public Node Next;

            public Node(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        public int Count => _count;

        public void Add( TKey key, TValue value )
        {
            Node node = _buckets[ key.GetHashCode() % _buckets.Length ];

            if(node == null )
            {
                _buckets[key.GetHashCode() % _buckets.Length] = new Node( key, value );
                _count++;
            }
            else
            {
                Node next = node.Next;
                Node lastNode = node;
                while(next != null)
                {
                    lastNode = next;
                    if( next.Key.GetHashCode().Equals( key.GetHashCode() ))
                    {
                        throw new Exception();
                    }
                    next = next.Next;
                }
                lastNode.Next = new Node( key, value );
                _count++;
            }
        }

        public void Remove( TKey key )
        {


        }

        public TValue this[ TKey key ]
        {
            get { return default( TValue ); }
            set { }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
