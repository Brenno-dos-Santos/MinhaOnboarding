using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MinhaOnboardingPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaOnboardingPage.ViewModel
{
    public partial class OnboudingViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<OnboardingItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Itens.Count - 1;

        public bool ExibirBotao => !IsLastPosicao;

        public OnboudingViewModel()
        {
            Itens = new List<OnboardingItem>
            {
                new OnboardingItem
                {
                    Titulo = "Compre agora!",
                    Descricao = "Qualquer hora, qualquer lugar",
                    ImagemUrl = "shop.png"
                },
                new OnboardingItem
                {
                    Titulo = "Entrega rápida",
                    Descricao = "Receba em casa ou retire na loja",
                    ImagemUrl = "shipping.png"
                },
                new OnboardingItem
                {
                    Titulo = "Pague como quiser",
                    Descricao = "Receba em casa ou retire na loja",
                    ImagemUrl = "payment.png"
                }
            };
        }
        [RelayCommand]
        private void Proximo()
        {
            if(Posicao < Itens.Count - 1)
            {
                Posicao++;
            }
            
        }
    }
}
