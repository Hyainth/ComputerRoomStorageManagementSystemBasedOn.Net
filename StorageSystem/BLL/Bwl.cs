using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Group_08_StorageSystem
{
    public class Originator
    {
        private DataView _state;

        public DataView State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public dataMemento CreateMemento()
        {
            return (new dataMemento(_state));
        }

        public void SetMemento(dataMemento memento)
        {
            State = memento.State;
        }
    }

    public class dataMemento
    {
        private DataView _state;
        public dataMemento(DataView state)
        {
            this._state = state;
        }
        public DataView State
        {
            get { return _state; }
        }
    }

    public class Caretaker
    {
        private dataMemento _memento;

        public dataMemento Memento
        {
            get
            {
                return _memento;
            }
            set
            {
                _memento = value;
            }
        }
    }
}
