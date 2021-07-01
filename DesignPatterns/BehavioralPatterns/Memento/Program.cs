using Memento.Implementation;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var command = new Caretaker(editor);
            editor.Text = "Text 1";
            editor.Size = 1;
            command.Backup();
            editor.Text = "Text 2";
            editor.Size = 10;
            command.Backup();
            editor.Text = "Text 3";
            editor.Size = 100;
            command.Backup();
            command.PrintHistory();
            editor.Text = "mistakeeeeeee";
            editor.Size = 1515;
            editor.IsBold = true;
            Console.WriteLine($"Before Undo editor text = {editor.Text}, Size = {editor.Size}, IsBold = { editor.IsBold}");
            command.Undo();
            Console.WriteLine($"After Undo => editor text = {editor.Text}, Size = {editor.Size}, IsBold = { editor.IsBold}");
        }
    }
}
