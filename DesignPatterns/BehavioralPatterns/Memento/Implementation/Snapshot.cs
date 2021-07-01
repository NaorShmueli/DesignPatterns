using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Implementation
{
    class Snapshot : IMemento
    {
        private Editor _editor;
        private string _text;
        private int _size;
        private bool _isBold;
        private DateTime _date;
        
        public Snapshot(Editor editor, string text,int size,bool isBold)
        {
            _editor = editor;
            _text = text;
            _size = size;
            _isBold = isBold;
            _date = DateTime.Now;
        }

        public bool GetBold()
        {
            return _isBold;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public int GetSize()
        {
            return _size;
        }

        public string GetFullState()
        {
            return $"{_date}::{_text}::{_size}::{_isBold}";
        }

        public string GetText()
        {
            return _text;
        }
    }
}
