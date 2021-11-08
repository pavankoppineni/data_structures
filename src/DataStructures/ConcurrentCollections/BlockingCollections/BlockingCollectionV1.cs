using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace DataStructures.ConcurrentCollections.BlockingCollections
{
    public class BlockingCollectionV1
    {
        private readonly BlockingCollection<int> _blockingCollection;
        public BlockingCollectionV1()
        {
            _blockingCollection = new BlockingCollection<int>();
        }

        public void Playground()
        {
            var consumerTask = Task.Run(RunConsumer);
        }

        private void RunConsumer()
        {
            if (_blockingCollection.IsAddingCompleted)
            {
            }
        }
    }
}
