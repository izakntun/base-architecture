﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
