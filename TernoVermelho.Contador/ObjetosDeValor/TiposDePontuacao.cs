using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TernoVermelho.Contador.ObjetosDeValor
{
    public enum TiposDePontuacao
    {
        [Description("Batida")]
        Batida = 1,
        [Description("Canastras Limpas")]
        CanastrasLimpas = 2,
        [Description("Canastras Sujas")]
        CanastrasSujas = 3,
        [Description("Ternos Vermelhos")]
        TernosVermelhos = 4,
        [Description("Pegar Morto")]
        PegarMorto = 5
    }
}
