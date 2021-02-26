

using System.Windows.Forms;
namespace ECOLE_SECONDAIRE.CLASS_DESIGN
{
    class DESIGN
    {
        public void APPEL_PANEL(UserControl s, Panel pan)
        {
            
            s.Dock = DockStyle.Fill;
            pan.Controls.Clear();
            pan.Controls.Add(s);
            pan.Show();

        }
        
    }
}
