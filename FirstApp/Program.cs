using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class ButtonClickedEventArgs : EventArgs
    {
        public string Location { get; }
        public int Number { get; }

        public ButtonClickedEventArgs(string identity)
        {
            string[] strings = identity.Split('#');
            Location = strings[0];
            Number = Convert.ToInt32(strings[1]);
        }
    }

    public class Button
    {
        private string identity;
        public event EventHandler<ButtonClickedEventArgs> ClickHandler;

        public Button(string identity)
        {
            this.identity = identity;
        }

        public void Clicked()
        {
            ClickHandler?.Invoke(null, new ButtonClickedEventArgs(identity));
        }
    }

    public class Door
    {
        private void Open(object sender, ButtonClickedEventArgs e)
        {
            Console.WriteLine($"Дверь открыта кнопкой с номером {e.Number} в комнате {e.Location}");
        }

        public void Init(Button button)
        {
            button.ClickHandler += Open;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button("Столовая#4");
            Door doorA = new Door();
            Door doorB = new Door();
            doorA.Init(button);
            doorB.Init(button);
            button.Clicked();
            //Дверь открыта кнопкой с номером 4 в комнате Столовая
            //Дверь открыта кнопкой с номером 4 в комнате Столовая
        }
    }
}