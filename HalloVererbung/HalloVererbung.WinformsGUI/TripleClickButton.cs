using System;
using System.Windows.Forms;

namespace HalloVererbung.WinformsGUI
{
    class TripleClickButton : Button
    {
        public event EventHandler TripleClick;

        int clickCounter = 0;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            clickCounter++;

            if (clickCounter % 3 == 0)
                TripleClick(this, new EventArgs());

        }
    }
}
