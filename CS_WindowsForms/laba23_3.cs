using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_WindowsForms
{
    public partial class laba23_3 : laba23_2
    {

        //5.3.4 Создать обработчик загрузки формы и выполнить в обработчике изменение текста у метки на Задание №3. ????

        public laba23_3()
        {
            
            InitializeComponent();
        }

        private void laba23_3_Load(object sender, EventArgs e)
        {
            this.Text = "Задание 3";
        }
    }
}
