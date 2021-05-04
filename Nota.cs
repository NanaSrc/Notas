using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do_Teste
{
    class Nota
    {
        private string nome;
        private string categoria;
        private string[] categorias;
        private int imp;
        private string desc;

        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Imp { get => imp; set => imp = value; }
        public string Desc { get => desc; set => desc = value; }

        public Nota()
        {
            this.nome = "";
            this.categoria = "";
            this.imp = 0;
            this.desc = "";
        }

        public Nota(string nome, string categoria, int imp, string desc)
        {
            this.nome = nome;
            this.categoria = categoria;
            this.imp = imp;
            this.desc = desc;
        }

        private void AddCategoria(int index, string categoria)
        {
            foreach(string i in this.categorias)
            {
                this.categorias[index] = categoria;
            }
        }
        private void CLS(Nota nota)
        {
            nota.nome = "";
            nota.categoria = "";
            nota.imp = 0;
            nota.desc = "";
        }

        private void Update(Nota nota, string nome, string categoria, int imp, string desc)
        {
            nota.nome = nome;
            nota.categoria = categoria;
            nota.imp = imp;
            nota.desc = desc;
        }

        public override string ToString()
        {
            return string.Format("{0} - [{1}] {3} | Importância: {2}", this.nome.ToUpper(), this.categoria, this.imp, this.desc);
        }
    }
}
