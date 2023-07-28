using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    internal class Agendamentos : IEnumerable<Agendamentos>
    {
        public string ID { get; set; }
        public string nada { get; set; }
        public string Fornecedor { get; set; }
        public string Data { get; set; }
        public string Observacao { get; set; }

        public IEnumerator<Agendamentos> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
