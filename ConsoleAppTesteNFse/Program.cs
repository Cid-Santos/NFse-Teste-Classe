using NFse.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ConsoleAppTesteNFse
{
    public class Program
    {
        private static string caminhoXml;
        private static string caminhoXsd;

        static void Main(string[] args)
        {
            try
            {
                var serializar = new Serializador();
                openFile();
                CompNfse objXml = serializar.LerXml<CompNfse>(caminhoXml, caminhoXsd);
                Console.WriteLine("+ InfNfse\n");
                Console.WriteLine("Numero:                          " + objXml.Nfse.InfNfse.DataEmissao);
                Console.WriteLine("Codigo Verificacao:              " + objXml.Nfse.InfNfse.CodigoVerificacao);
                Console.WriteLine("Data Emissao:                    " + objXml.Nfse.InfNfse.DataEmissao);
                Console.WriteLine("Natureza Operacao:               " + objXml.Nfse.InfNfse.NaturezaOperacao);
                Console.WriteLine("Regime Especial Tributacao:      " + objXml.Nfse.InfNfse.RegimeEspecialTributacao);
                Console.WriteLine("Optante Simples Nacional:        " + objXml.Nfse.InfNfse.OptanteSimplesNacional);
                Console.WriteLine("Incentivador Cultural:           " + objXml.Nfse.InfNfse.IncentivadorCultural);
                Console.WriteLine("Competencia:                     " + objXml.Nfse.InfNfse.Competencia);
                Console.WriteLine("\n+ Servico");
                Console.WriteLine("  + Valores\n");
                Console.WriteLine("ValorServicos:                   " + objXml.Nfse.InfNfse.Servico.Valores.ValorServicos);
                Console.WriteLine("IssRetido:                       " + objXml.Nfse.InfNfse.Servico.Valores.IssRetido);
                Console.WriteLine("BaseCalculo:                     " + objXml.Nfse.InfNfse.Servico.Valores.BaseCalculo);
                Console.WriteLine("ValorLiquidoNfse:                " + objXml.Nfse.InfNfse.Servico.Valores.ValorLiquidoNfse);
                Console.WriteLine("ItemListaServico:                " + objXml.Nfse.InfNfse.Servico.ItemListaServico);
                Console.WriteLine("Codigo Tributacao Municipio:     " + objXml.Nfse.InfNfse.Servico.CodigoTributacaoMunicipio);
                Console.WriteLine("Discriminacao:                   " + objXml.Nfse.InfNfse.Servico.Discriminacao);
                Console.WriteLine("CodigoMunicipio:                 " + objXml.Nfse.InfNfse.Servico.CodigoMunicipio);
                Console.WriteLine("\n+ PrestadorServico\n");
                Console.WriteLine("  + IdentificacaoPrestador");
                Console.WriteLine("Cnpj :                           " + objXml.Nfse.InfNfse.PrestadorServico.IdentificacaoPrestador.Cnpj);
                Console.WriteLine("InscricaoMunicipal:              " + objXml.Nfse.InfNfse.PrestadorServico.IdentificacaoPrestador.InscricaoMunicipal);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void openFile()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string pahtNFse = path.Remove(path.LastIndexOf("\\bin")) + " ";
            caminhoXml = pahtNFse + "\\xml\\NFSe\\lote-final.xml";
            caminhoXsd = pahtNFse + "\\schemas\\NFSe\\nfse.xsd";
        }
    }
}

