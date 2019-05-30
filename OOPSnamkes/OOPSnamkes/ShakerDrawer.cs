using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPSnamkes
{
    public class ShakerDrawer
    {
        Bitmap shakerImage;
        Image[] diceFaces = new Image[] { Properties.Resources.die1, Properties.Resources.die2, Properties.Resources.die3, Properties.Resources.die4, Properties.Resources.die5, Properties.Resources.die6, };
        Image felt = Properties.Resources.felt;

        RectangleF die1Location
        {
            get
            {
                int x = shakerImage.Width / 5;
                int y = shakerImage.Height / 4;
                int size = shakerImage.Width / 3;

                return new RectangleF(x, y,size,size);
            }
        }

        RectangleF die2Location
        {
            get
            {
                int x = (shakerImage.Width / 5) * 3;
                int y = shakerImage.Height / 4;
                int size = shakerImage.Width / 3;

                return new RectangleF(x, y, size, size);
            }
        }

        RectangleF die3Location
        {
            get
            {
                int x = (shakerImage.Width / 5) * 2;
                int y = (shakerImage.Height / 4) * 2;
                int size = shakerImage.Width / 3;

                return new RectangleF(x, y, size, size);
            }
        }

        public ShakerDrawer()
        {
            this.shakerImage = new Bitmap(400, 300);
        }

        public ShakerDrawer(int x, int y)
        {
            this.shakerImage = new Bitmap(x, y);
        }

        public Bitmap DrawShaker()
        {
            using (Graphics g = Graphics.FromImage(shakerImage))
            {
                g.DrawImage(felt, 0, 0, shakerImage.Width, shakerImage.Height);
                g.DrawImage(diceFaces[3], die1Location);
                g.DrawImage(diceFaces[4], die2Location);
            }
            return shakerImage;
        }

        public Bitmap DrawShaker(int die1, int die2)
        {
            using (Graphics g = Graphics.FromImage(shakerImage))
            {
                g.DrawImage(felt, 0, 0, shakerImage.Width, shakerImage.Height);
                g.DrawImage(diceFaces[die1 - 1], die1Location);
                g.DrawImage(diceFaces[die2 - 1], die2Location);
               
            }
            return shakerImage;
        }

        public Bitmap DrawShaker(int die1, int die2, int die3)
        {
            using (Graphics g = Graphics.FromImage(shakerImage))
            {
                g.DrawImage(felt, 0, 0, shakerImage.Width, shakerImage.Height);
                g.DrawImage(diceFaces[die1 - 1], die1Location);
                g.DrawImage(diceFaces[die2 - 1], die2Location);
                g.DrawImage(diceFaces[die3 - 1], die3Location);

            }
            return shakerImage;
        }

    }
}
