using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Management.View.UC;
using Project_Management.View;

namespace Project_Management.Utils
{
    public static class StackForm
    {
        static private List<Form> forms = new List<Form>();

        // Lưu form main 
        private static FormMain formMain;

        public static FormMain FormMain { get => formMain; set => formMain = value; }

    }
}
