﻿using System;

namespace Radix.Event
{
    public class EventListener
    {
        public static void Register(Enum _event, EventReceiverHandler _callback)
        {
            //ErrorManager.AssertNull(_callback);

            EventListener eventListener = new EventListener();

            eventListener.Event = _event;
            eventListener.Listener = _callback.Target.GetType();
            eventListener.Callback = _callback;

            EventService.RegisterEventListener(eventListener);
        }

        public void Dispose()
        {
            Event = null;
            Listener = null;
            Callback = null;
        }

        public Enum Event
        {
            get;
            private set;
        }

        public Type Listener
        {
            get;
            private set;
        }

        public EventReceiverHandler Callback
        {
            get;
            private set;
        }

        public bool Equals(EventListener _otherListener)
        {
            return Event == _otherListener.Event &&
                   Listener == _otherListener.Listener &&
                   Callback == _otherListener.Callback;
        }
    }
}
