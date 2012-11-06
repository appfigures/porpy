﻿using System;
using System.IO;

namespace Porpy.Readers
{
    public class EntityDecoder<TResponse>
    {
        private readonly Func<StreamReader, TResponse> Decoder;

        public EntityDecoder(Func<StreamReader, TResponse> decoder = null)
        {
            Decoder = decoder;
        }

        public virtual TResponse Read(StreamReader reader)
        {
            if (Decoder == null) {
                throw new ArgumentNullException("Decoder");
            }

            return Decoder(reader);
        }
    }
}
