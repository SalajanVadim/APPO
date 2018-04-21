using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    internal abstract class Baseabstractclass
    {

       public abstract string Space();
        public abstract Color color();
        
    }
    internal  class Acces:Baseabstractclass
    {
        public override Color color() {
            Color colortext = Color.White;
            return colortext;

                                     }
        public override string Space()
        {
            string a="";
            return a;
        }
    }
}