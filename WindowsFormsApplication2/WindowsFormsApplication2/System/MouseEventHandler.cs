namespace System
{
    internal class MouseEventHandler
    {
        private Action<object, EventArgs> button1_MouseDown;

        public MouseEventHandler(Action<object, EventArgs> button1_MouseDown)
        {
            this.button1_MouseDown = button1_MouseDown;
        }
    }
}