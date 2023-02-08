using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer4WSCAD.Events
{
    public static class MyEvents
    {
        public static Event RefreshSub = new Event();
        //public static Event<ErrorDef> RunQueryForErrorDefEvent = new Event<ErrorDef>();
        //public static Event<ObservableCollection<TableDef_VM>> SetAvailableSelectTablesEvent = new Event<ObservableCollection<TableDef_VM>>();
    }

    public class Event
    {
        public List<Action> Subscribers = new List<Action>();

        public void Publish()
        {
            foreach (var Action in Subscribers)
            {
                if (Action == null)
                    return;
                Action.Invoke();
            }
        }
        public void Subscribe(Action subscriber)
        {
            if (Subscribers.Where(s => s == subscriber).Any())
                return;
            Subscribers.Add(subscriber);
        }
    }

    public class Event<TObj>
    {
        public List<Action<TObj>> Subscribers = new List<Action<TObj>>();

        public void Publish(TObj o)
        {
            foreach (var Action in Subscribers)
            {
                if (Action == null)
                    return;
                Action.Invoke(o);
            }
        }
        public void Subscribe(Action<TObj> subscriber)
        {
            if (Subscribers.Where(s => s.Equals(subscriber)).Any())
                return;
            Subscribers.Add(subscriber);
        }
    }

    public class Event<T1,T2>
    {
        public List<Action<T1,T2>> Subscribers = new List<Action<T1, T2>>();

        public void Publish(T1 o1, T2 o2)
        {
            foreach (var Action in Subscribers)
            {
                if (Action == null)
                    return;
                Action.Invoke(o1, o2);
            }
        }
        public void Subscribe(Action<T1, T2> subscriber)
        {
            if (Subscribers.Where(s => s.Equals(subscriber)).Any())
                return;
            Subscribers.Add(subscriber);
        }
    }







}
