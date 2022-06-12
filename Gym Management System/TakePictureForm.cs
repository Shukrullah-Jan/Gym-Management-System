using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class TakePictureForm : Form
    {
        public static Boolean isDoneClicked = false;
        public static Image capturedImage = null;

        public TakePictureForm()
        {
            InitializeComponent();
        }

        private void TakePictureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
