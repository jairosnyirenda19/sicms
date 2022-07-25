namespace SPC_Managememt_System
{
    public class PanelDoubleBuffered : System.Windows.Forms.Panel
    {
        public PanelDoubleBuffered()
        {
            this.DoubleBuffered = true;
            this.UpdateStyles();
        }
    }
}
