using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class Estado
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }

        public override string ToString()
        {
            return this.Nome; 
        }

        public static List<Estado> Lista()
        {
            var Lista = new List<Estado>();

            var e1 = new Estado();
            e1.id = 1;
            e1.Nome = "SPpppp";
            Lista.Add(e1);

            var s = e1.ToString();


            e1 = new Estado();
            e1.id = 2;
            e1.Nome = "JAPAO";
            Lista.Add(e1);

            e1 = new Estado();
            e1.id = 3;
            e1.Nome = "CHINA";
            Lista.Add(e1);



            List<String> estados = new List<String>();
            estados.Add("BH");
            estados.Add("PE");
            estados.Add("CEA");

            return Lista;
        }
    }
}
