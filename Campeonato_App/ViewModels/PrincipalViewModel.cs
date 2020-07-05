using Campeonato_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato_App.ViewModels
{
    public class PrincipalViewModel
    {
        public List<Jogo> jogos { get; set; }

        public PrincipalViewModel()
        {
            jogos = new List<Jogo>
            {
                new Jogo
                {
                    id = 1,
                    estadio = "Bernabéu",
                    data  = DateTime.Now,
                    placarCasa = 3,
                    placarVisitante = 1,
                    penaltisCasa = 0,
                    penaltisVisitante = 0,
                    selecaoCasa = 5,
                    selecaoVisitante = 1        
                },
                new Jogo
                {
                    id = 2,
                    estadio = "Morumbi",
                    data  = DateTime.Now,
                    placarCasa = 4,
                    placarVisitante = 2,
                    penaltisCasa = 0,
                    penaltisVisitante = 0,
                    selecaoCasa = 3,
                    selecaoVisitante = 2
                }
            };
        }
    }
}
