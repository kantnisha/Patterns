using System;

namespace Delegate.Code
{
    public delegate void ActionEventHadler(object sender, ActionCancelEventArgs ev);
    
    public class EventTest
    {
        public static event ActionEventHadler Action;
        private BusEntity _busEntity;
         protected void OnAction(object sender, ActionCancelEventArgs ev)
         {
             if (Action != null)
                 Action(sender, ev);
         }

        public void Click()
        {
            var cancelEvent = new ActionCancelEventArgs();
            OnAction(this, cancelEvent);
            if(cancelEvent.Cancel)
                Console.WriteLine(cancelEvent.Message);
            else
                Console.WriteLine(_busEntity.TimeString);
        }

        public EventTest()
        {
            _busEntity = new BusEntity();
        }

    }

    public class BusEntity
    {
        private string _time = String.Empty;

        public BusEntity()
        {
            EventTest.Action += DoAction;
        }

        private void DoAction(object sender, ActionCancelEventArgs ev)
        {
            ev.Cancel = !DoActions();
            if (ev.Cancel)
                ev.Message = "Bad time";
        }

        private bool DoActions()
        {
            bool retVal = false;
            DateTime tm = DateTime.Now;

            if (tm.Second < 30)
            {
                _time = "Current time " + DateTime.Now.ToLongTimeString();
                retVal = true;
            }
            else
            {
                _time = "";
            }
            return retVal;
        }

        public string TimeString
        {
            get { return _time; }
        }
    }

    public class ActionCancelEventArgs : System.ComponentModel.CancelEventArgs
    {
        private string _message = "";
        public ActionCancelEventArgs() : base(){}
        public ActionCancelEventArgs(bool cancel) : base(cancel) { }

        public ActionCancelEventArgs(bool cancel, string message)
            : base(cancel)
        {
            _message = message;
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

       
    }
}