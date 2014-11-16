using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpCom
{
    public partial class BackUp : Component
    {
        public BackUp()
        {
            InitializeComponent();
        }

        public BackUp(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
