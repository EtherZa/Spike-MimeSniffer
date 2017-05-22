namespace MIME.Sniffer.Tests.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MimeTypeAttribute : Attribute
    {
        public MimeTypeAttribute(Type resourceCollectionType, string mimeType)
        {
            if (!typeof(IResourceCollection).IsAssignableFrom(resourceCollectionType))
            {
                throw new Exception($"'{resourceCollectionType}' expected to be derived from {nameof(IResourceCollection)}");
            }

            var collection = (IResourceCollection)Activator.CreateInstance(resourceCollectionType);
            this.Resources = collection.All.ToArray();
            this.MimeType = mimeType;
        }

        public IEnumerable<Resource> Resources { get; }

        public string MimeType { get; }
    }
}