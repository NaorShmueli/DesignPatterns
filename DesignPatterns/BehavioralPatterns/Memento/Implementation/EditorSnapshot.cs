using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Implementation
{
    class EditorSnapshot : IMemento
    {
        private Editor _editor;
        private string _text;
        private int _size;
        private bool _isBold;
        private DateTime _date;
        
        public EditorSnapshot(Editor editor, string text,int size,bool isBold)
        {
            _editor = editor;
            _text = text;
            _size = size;
            _isBold = isBold;
            _date = DateTime.Now;
        }

        public string GetFullState()
        {
            return $"{_date}::{_text}::{_size}::{_isBold}";
        }

        public void Restore()
        {
            _editor.IsBold = _isBold;
            _editor.Size = _size;
            _editor.Text = _text;
        }
    }
}
