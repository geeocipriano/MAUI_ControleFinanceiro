using MAUI_ControleFinanceiro.Models;
using System.Collections.ObjectModel;

namespace MAUI_ControleFinanceiro.ViewModels
{
    public class HomeViewModel
    {
        public ObservableCollection<SaldoModel> SaldoItems { get; set; }
        public ObservableCollection<LancamentosModel> Lancamentos { get; set; }

        public HomeViewModel()
        {
            SaldoItems = new ObservableCollection<SaldoModel>
            {
                new SaldoModel {Nome = "Saldo" , Saldo = "-1500,00" },
                new SaldoModel {Nome = "Credito" , Saldo = " 1500,00" },
                new SaldoModel {Nome = "Debito",  Saldo = " 3000,00" }
            };
            Lancamentos = new ObservableCollection<LancamentosModel>
            {
                new LancamentosModel
                {
                    Nome = "Fernanda",
                    Valor = "1500,00",
                    Descricao = "Salario",
                    Data = "05/03/2023",
                    CorFundo = Color.FromHex("#2a9d8f")
                },
                new LancamentosModel
                {
                    Nome = "Geovany",
                    Valor = "3000,00",
                    Descricao = "Descricao Teste",
                    Data = "05/03/2023",
                    CorFundo = Color.FromHex("#e76f51")
                },
                                new LancamentosModel
                {
                    Nome = "Fernanda",
                    Valor = "1500,00",
                    Descricao = "Salario",
                    Data = "05/03/2023",
                    CorFundo = Color.FromHex("#2a9d8f")
                },
                new LancamentosModel
                {
                    Nome = "Geovany",
                    Valor = "3000,00",
                    Descricao = "Descricao Teste",
                    Data = "05/03/2023",
                    CorFundo = Color.FromHex("#e76f51")
                },
                                new LancamentosModel
                {
                    Nome = "Fernanda",
                    Valor = "1500,00",
                    Descricao = "Salario",
                    Data = "05/03/2023",
                    CorFundo = Color.FromHex("#2a9d8f")
                },
                new LancamentosModel
                {
                    Nome = "Geovany",
                    Valor = "3000,00",
                    Descricao = "Descricao Teste",
                    Data = "05/03/2023",
                    CorFundo = Color.FromHex("#e76f51")
                },
                                new LancamentosModel
                {
                    Nome = "Fernanda",
                    Valor = "1500,00",
                    Descricao = "Salario",
                    Data = "05/03/2023",
                    CorFundo = Color.FromHex("#2a9d8f")
                },
                new LancamentosModel
                {
                    Nome = "Geovany",
                    Valor = "3000,00",
                    Descricao = "Descricao Teste",
                    Data = "05/03/2023",
                    //CorFundo = Color.FromHex("#e63946")
                    CorFundo = Color.FromHex("#e76f51")
                }
            };
        }
    }
}
