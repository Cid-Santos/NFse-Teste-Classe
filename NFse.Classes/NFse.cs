using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFse.Classes
{
        #region CompNfse tcCompNfse
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.abrasf.org.br/nfse.xsd")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.abrasf.org.br/nfse.xsd", IsNullable = false)]
        public class CompNfse
        {
            private tcNfse nfseField;

            private tcCancelamentoNfse nfseCancelamentoField;

            private tcSubstituicaoNfse nfseSubstituicaoField;

            /// <Observacoes/>
            public tcNfse Nfse
            {
                get
                {
                    return this.nfseField;
                }
                set
                {
                    this.nfseField = value;
                }
            }

            /// <Observacoes/>
            public tcCancelamentoNfse NfseCancelamento
            {
                get
                {
                    return this.nfseCancelamentoField;
                }
                set
                {
                    this.nfseCancelamentoField = value;
                }
            }

            /// <Observacoes/>
            public tcSubstituicaoNfse NfseSubstituicao
            {
                get
                {
                    return this.nfseSubstituicaoField;
                }
                set
                {
                    this.nfseSubstituicaoField = value;
                }
            }
        }


        #region Nfse tcNfse
        public class tcNfse
        {

            private tcInfNfse infNfseField;

            /// <Observacoes/>
            public tcInfNfse InfNfse
            {
                get
                {
                    return this.infNfseField;
                }
                set
                {
                    this.infNfseField = value;
                }
            }
        }

        #region InfNfse tcInfNfse
        public class tcInfNfse
        {

            private string numeroField;

            private string codigoVerificacaoField;

            private System.DateTime dataEmissaoField;

            private tcIdentificacaoRps identificacaoRpsField;

            private System.DateTime dataEmissaoRpsField;

            private bool dataEmissaoRpsFieldSpecified;

            private sbyte naturezaOperacaoField;

            private sbyte regimeEspecialTributacaoField;

            private bool regimeEspecialTributacaoFieldSpecified;

            private sbyte optanteSimplesNacionalField;

            private sbyte incentivadorCulturalField;

            private System.DateTime competenciaField;

            private string nfseSubstituidaField;

            private string outrasInformacoesField;

            private tcDadosServico servicoField;

            private decimal valorCreditoField;

            private bool valorCreditoFieldSpecified;

            private tcDadosPrestador prestadorServicoField;

            private tcDadosTomador tomadorServicoField;

            private tcIdentificacaoIntermediarioServico intermediarioServicoField;

            private tcIdentificacaoOrgaoGerador orgaoGeradorField;

            private tcDadosConstrucaoCivil contrucaoCivilField;

            private string idField;

            /// <Observacoes/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string Numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <Observacoes/>
            public string CodigoVerificacao
            {
                get
                {
                    return this.codigoVerificacaoField;
                }
                set
                {
                    this.codigoVerificacaoField = value;
                }
            }

            /// <Observacoes/>
            public System.DateTime DataEmissao
            {
                get
                {
                    return this.dataEmissaoField;
                }
                set
                {
                    this.dataEmissaoField = value;
                }
            }

            /// <Observacoes/>
            public tcIdentificacaoRps IdentificacaoRps
            {
                get
                {
                    return this.identificacaoRpsField;
                }
                set
                {
                    this.identificacaoRpsField = value;
                }
            }

            public System.DateTime DataEmissaoRps
            {
                get
                {
                    return this.dataEmissaoRpsField;
                }
                set
                {
                    this.dataEmissaoRpsField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DataEmissaoRpsSpecified
            {
                get
                {
                    return this.dataEmissaoRpsFieldSpecified;
                }
                set
                {
                    this.dataEmissaoRpsFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public sbyte NaturezaOperacao
            {
                get
                {
                    return this.naturezaOperacaoField;
                }
                set
                {
                    this.naturezaOperacaoField = value;
                }
            }

            /// <Observacoes/>
            public sbyte RegimeEspecialTributacao
            {
                get
                {
                    return this.regimeEspecialTributacaoField;
                }
                set
                {
                    this.regimeEspecialTributacaoField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RegimeEspecialTributacaoSpecified
            {
                get
                {
                    return this.regimeEspecialTributacaoFieldSpecified;
                }
                set
                {
                    this.regimeEspecialTributacaoFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public sbyte OptanteSimplesNacional
            {
                get
                {
                    return this.optanteSimplesNacionalField;
                }
                set
                {
                    this.optanteSimplesNacionalField = value;
                }
            }

            /// <Observacoes/>
            public sbyte IncentivadorCultural
            {
                get
                {
                    return this.incentivadorCulturalField;
                }
                set
                {
                    this.incentivadorCulturalField = value;
                }
            }

            /// <Observacoes/>
            public System.DateTime Competencia
            {
                get
                {
                    return this.competenciaField;
                }
                set
                {
                    this.competenciaField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string NfseSubstituida
            {
                get
                {
                    return this.nfseSubstituidaField;
                }
                set
                {
                    this.nfseSubstituidaField = value;
                }
            }

            /// <Observacoes/>
            public string OutrasInformacoes
            {
                get
                {
                    return this.outrasInformacoesField;
                }
                set
                {
                    this.outrasInformacoesField = value;
                }
            }

            /// <Observacoes/>
            public tcDadosServico Servico
            {
                get
                {
                    return this.servicoField;
                }
                set
                {
                    this.servicoField = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorCredito
            {
                get
                {
                    return this.valorCreditoField;
                }
                set
                {
                    this.valorCreditoField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorCreditoSpecified
            {
                get
                {
                    return this.valorCreditoFieldSpecified;
                }
                set
                {
                    this.valorCreditoFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public tcDadosPrestador PrestadorServico
            {
                get
                {
                    return this.prestadorServicoField;
                }
                set
                {
                    this.prestadorServicoField = value;
                }
            }

            /// <Observacoes/>
            public tcDadosTomador TomadorServico
            {
                get
                {
                    return this.tomadorServicoField;
                }
                set
                {
                    this.tomadorServicoField = value;
                }
            }

            /// <Observacoes/>
            public tcIdentificacaoIntermediarioServico IntermediarioServico
            {
                get
                {
                    return this.intermediarioServicoField;
                }
                set
                {
                    this.intermediarioServicoField = value;
                }
            }

            /// <Observacoes/>
            public tcIdentificacaoOrgaoGerador OrgaoGerador
            {
                get
                {
                    return this.orgaoGeradorField;
                }
                set
                {
                    this.orgaoGeradorField = value;
                }
            }

            /// <Observacoes/>
            public tcDadosConstrucaoCivil ContrucaoCivil
            {
                get
                {
                    return this.contrucaoCivilField;
                }
                set
                {
                    this.contrucaoCivilField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }


        #region IdentificacaoRps tcIdentificacaoRps
        public class tcIdentificacaoRps
        {

            private string numeroField;

            private string serieField;

            private sbyte tipoField;

            /// <Observacoes/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string Numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <Observacoes/>
            public string Serie
            {
                get
                {
                    return this.serieField;
                }
                set
                {
                    this.serieField = value;
                }
            }

            /// <Observacoes/>
            public sbyte Tipo
            {
                get
                {
                    return this.tipoField;
                }
                set
                {
                    this.tipoField = value;
                }
            }
        }
        #endregion

        #region Servico tcDadosServico
        public class tcDadosServico
        {

            private tcValores valoresField;

            private string itemListaServicoField;

            private int codigoCnaeField;

            private bool codigoCnaeFieldSpecified;

            private string codigoTributacaoMunicipioField;

            private string discriminacaoField;

            private int codigoMunicipioField;

            /// <Observacoes/>
            public tcValores Valores
            {
                get
                {
                    return this.valoresField;
                }
                set
                {
                    this.valoresField = value;
                }
            }

            /// <Observacoes/>
            public string ItemListaServico
            {
                get
                {
                    return this.itemListaServicoField;
                }
                set
                {
                    this.itemListaServicoField = value;
                }
            }

            /// <Observacoes/>
            public int CodigoCnae
            {
                get
                {
                    return this.codigoCnaeField;
                }
                set
                {
                    this.codigoCnaeField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CodigoCnaeSpecified
            {
                get
                {
                    return this.codigoCnaeFieldSpecified;
                }
                set
                {
                    this.codigoCnaeFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public string CodigoTributacaoMunicipio
            {
                get
                {
                    return this.codigoTributacaoMunicipioField;
                }
                set
                {
                    this.codigoTributacaoMunicipioField = value;
                }
            }

            /// <Observacoes/>
            public string Discriminacao
            {
                get
                {
                    return this.discriminacaoField;
                }
                set
                {
                    this.discriminacaoField = value;
                }
            }

            /// <Observacoes/>
            public int CodigoMunicipio
            {
                get
                {
                    return this.codigoMunicipioField;
                }
                set
                {
                    this.codigoMunicipioField = value;
                }
            }
        }

        #region Valores  tcValores
        public class tcValores
        {

            private decimal valorServicosField;

            private decimal valorDeducoesField;

            private bool valorDeducoesFieldSpecified;

            private decimal valorPisField;

            private bool valorPisFieldSpecified;

            private decimal valorCofinsField;

            private bool valorCofinsFieldSpecified;

            private decimal valorInssField;

            private bool valorInssFieldSpecified;

            private decimal valorIrField;

            private bool valorIrFieldSpecified;

            private decimal valorCsllField;

            private bool valorCsllFieldSpecified;

            private sbyte issRetidoField;

            private decimal valorIssField;

            private bool valorIssFieldSpecified;

            private decimal valorIssRetidoField;

            private bool valorIssRetidoFieldSpecified;

            private decimal outrasRetencoesField;

            private bool outrasRetencoesFieldSpecified;

            private decimal baseCalculoField;

            private bool baseCalculoFieldSpecified;

            private decimal aliquotaField;

            private bool aliquotaFieldSpecified;

            private decimal valorLiquidoNfseField;

            private bool valorLiquidoNfseFieldSpecified;

            private decimal descontoIncondicionadoField;

            private bool descontoIncondicionadoFieldSpecified;

            private decimal descontoCondicionadoField;

            private bool descontoCondicionadoFieldSpecified;

            /// <Observacoes/>
            public decimal ValorServicos
            {
                get
                {
                    return this.valorServicosField;
                }
                set
                {
                    this.valorServicosField = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorDeducoes
            {
                get
                {
                    return this.valorDeducoesField;
                }
                set
                {
                    this.valorDeducoesField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorDeducoesSpecified
            {
                get
                {
                    return this.valorDeducoesFieldSpecified;
                }
                set
                {
                    this.valorDeducoesFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorPis
            {
                get
                {
                    return this.valorPisField;
                }
                set
                {
                    this.valorPisField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorPisSpecified
            {
                get
                {
                    return this.valorPisFieldSpecified;
                }
                set
                {
                    this.valorPisFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorCofins
            {
                get
                {
                    return this.valorCofinsField;
                }
                set
                {
                    this.valorCofinsField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorCofinsSpecified
            {
                get
                {
                    return this.valorCofinsFieldSpecified;
                }
                set
                {
                    this.valorCofinsFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorInss
            {
                get
                {
                    return this.valorInssField;
                }
                set
                {
                    this.valorInssField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorInssSpecified
            {
                get
                {
                    return this.valorInssFieldSpecified;
                }
                set
                {
                    this.valorInssFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorIr
            {
                get
                {
                    return this.valorIrField;
                }
                set
                {
                    this.valorIrField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorIrSpecified
            {
                get
                {
                    return this.valorIrFieldSpecified;
                }
                set
                {
                    this.valorIrFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorCsll
            {
                get
                {
                    return this.valorCsllField;
                }
                set
                {
                    this.valorCsllField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorCsllSpecified
            {
                get
                {
                    return this.valorCsllFieldSpecified;
                }
                set
                {
                    this.valorCsllFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public sbyte IssRetido
            {
                get
                {
                    return this.issRetidoField;
                }
                set
                {
                    this.issRetidoField = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorIss
            {
                get
                {
                    return this.valorIssField;
                }
                set
                {
                    this.valorIssField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorIssSpecified
            {
                get
                {
                    return this.valorIssFieldSpecified;
                }
                set
                {
                    this.valorIssFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorIssRetido
            {
                get
                {
                    return this.valorIssRetidoField;
                }
                set
                {
                    this.valorIssRetidoField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorIssRetidoSpecified
            {
                get
                {
                    return this.valorIssRetidoFieldSpecified;
                }
                set
                {
                    this.valorIssRetidoFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal OutrasRetencoes
            {
                get
                {
                    return this.outrasRetencoesField;
                }
                set
                {
                    this.outrasRetencoesField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool OutrasRetencoesSpecified
            {
                get
                {
                    return this.outrasRetencoesFieldSpecified;
                }
                set
                {
                    this.outrasRetencoesFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal BaseCalculo
            {
                get
                {
                    return this.baseCalculoField;
                }
                set
                {
                    this.baseCalculoField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool BaseCalculoSpecified
            {
                get
                {
                    return this.baseCalculoFieldSpecified;
                }
                set
                {
                    this.baseCalculoFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal Aliquota
            {
                get
                {
                    return this.aliquotaField;
                }
                set
                {
                    this.aliquotaField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AliquotaSpecified
            {
                get
                {
                    return this.aliquotaFieldSpecified;
                }
                set
                {
                    this.aliquotaFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal ValorLiquidoNfse
            {
                get
                {
                    return this.valorLiquidoNfseField;
                }
                set
                {
                    this.valorLiquidoNfseField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ValorLiquidoNfseSpecified
            {
                get
                {
                    return this.valorLiquidoNfseFieldSpecified;
                }
                set
                {
                    this.valorLiquidoNfseFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal DescontoIncondicionado
            {
                get
                {
                    return this.descontoIncondicionadoField;
                }
                set
                {
                    this.descontoIncondicionadoField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DescontoIncondicionadoSpecified
            {
                get
                {
                    return this.descontoIncondicionadoFieldSpecified;
                }
                set
                {
                    this.descontoIncondicionadoFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public decimal DescontoCondicionado
            {
                get
                {
                    return this.descontoCondicionadoField;
                }
                set
                {
                    this.descontoCondicionadoField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DescontoCondicionadoSpecified
            {
                get
                {
                    return this.descontoCondicionadoFieldSpecified;
                }
                set
                {
                    this.descontoCondicionadoFieldSpecified = value;
                }
            }
        }
        #endregion
        #endregion

        #region PrestadorServico  tcDadosPrestador
        public class tcDadosPrestador
        {

            private tcIdentificacaoPrestador identificacaoPrestadorField;

            private string razaoSocialField;

            private string nomeFantasiaField;

            private tcEndereco enderecoField;

            private tcContato contatoField;

            /// <Observacoes/>
            public tcIdentificacaoPrestador IdentificacaoPrestador
            {
                get
                {
                    return this.identificacaoPrestadorField;
                }
                set
                {
                    this.identificacaoPrestadorField = value;
                }
            }

            /// <Observacoes/>
            public string RazaoSocial
            {
                get
                {
                    return this.razaoSocialField;
                }
                set
                {
                    this.razaoSocialField = value;
                }
            }

            /// <Observacoes/>
            public string NomeFantasia
            {
                get
                {
                    return this.nomeFantasiaField;
                }
                set
                {
                    this.nomeFantasiaField = value;
                }
            }

            /// <Observacoes/>
            public tcEndereco Endereco
            {
                get
                {
                    return this.enderecoField;
                }
                set
                {
                    this.enderecoField = value;
                }
            }

            /// <Observacoes/>
            public tcContato Contato
            {
                get
                {
                    return this.contatoField;
                }
                set
                {
                    this.contatoField = value;
                }
            }
        }

        #region IdentificacaoPrestador  tcIdentificacaoPrestador
        public class tcIdentificacaoPrestador
        {

            private string cnpjField;

            private string inscricaoMunicipalField;

            /// <Observacoes/>
            public string Cnpj
            {
                get
                {
                    return this.cnpjField;
                }
                set
                {
                    this.cnpjField = value;
                }
            }

            /// <Observacoes/>
            public string InscricaoMunicipal
            {
                get
                {
                    return this.inscricaoMunicipalField;
                }
                set
                {
                    this.inscricaoMunicipalField = value;
                }
            }
        }
        #endregion

        #region Endereco tcEndereco
        public class tcEndereco
        {

            private string enderecoField;

            private string numeroField;

            private string complementoField;

            private string bairroField;

            private int codigoMunicipioField;

            private bool codigoMunicipioFieldSpecified;

            private string ufField;

            private int cepField;

            private bool cepFieldSpecified;

            /// <Observacoes/>
            public string Endereco
            {
                get
                {
                    return this.enderecoField;
                }
                set
                {
                    this.enderecoField = value;
                }
            }

            /// <Observacoes/>
            public string Numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <Observacoes/>
            public string Complemento
            {
                get
                {
                    return this.complementoField;
                }
                set
                {
                    this.complementoField = value;
                }
            }

            /// <Observacoes/>
            public string Bairro
            {
                get
                {
                    return this.bairroField;
                }
                set
                {
                    this.bairroField = value;
                }
            }

            /// <Observacoes/>
            public int CodigoMunicipio
            {
                get
                {
                    return this.codigoMunicipioField;
                }
                set
                {
                    this.codigoMunicipioField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CodigoMunicipioSpecified
            {
                get
                {
                    return this.codigoMunicipioFieldSpecified;
                }
                set
                {
                    this.codigoMunicipioFieldSpecified = value;
                }
            }

            /// <Observacoes/>
            public string Uf
            {
                get
                {
                    return this.ufField;
                }
                set
                {
                    this.ufField = value;
                }
            }

            /// <Observacoes/>
            public int Cep
            {
                get
                {
                    return this.cepField;
                }
                set
                {
                    this.cepField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CepSpecified
            {
                get
                {
                    return this.cepFieldSpecified;
                }
                set
                {
                    this.cepFieldSpecified = value;
                }
            }
        }
        #endregion

        #region Contato  tcContato
        public class tcContato
        {

            private string telefoneField;

            private string emailField;

            /// <Observacoes/>
            public string Telefone
            {
                get
                {
                    return this.telefoneField;
                }
                set
                {
                    this.telefoneField = value;
                }
            }

            /// <Observacoes/>
            public string Email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }
        }

        #endregion


        #endregion

        #region TomadorServico tcDadosTomador
        public class tcDadosTomador
        {

            private tcIdentificacaoTomador identificacaoTomadorField;

            private string razaoSocialField;

            private tcEndereco enderecoField;

            private tcContato contatoField;

            /// <Observacoes/>
            public tcIdentificacaoTomador IdentificacaoTomador
            {
                get
                {
                    return this.identificacaoTomadorField;
                }
                set
                {
                    this.identificacaoTomadorField = value;
                }
            }

            /// <Observacoes/>
            public string RazaoSocial
            {
                get
                {
                    return this.razaoSocialField;
                }
                set
                {
                    this.razaoSocialField = value;
                }
            }

            /// <Observacoes/>
            public tcEndereco Endereco
            {
                get
                {
                    return this.enderecoField;
                }
                set
                {
                    this.enderecoField = value;
                }
            }

            /// <Observacoes/>
            public tcContato Contato
            {
                get
                {
                    return this.contatoField;
                }
                set
                {
                    this.contatoField = value;
                }
            }
        }

        #region IdentificacaoTomador  tcIdentificacaoTomador
        public class tcIdentificacaoTomador
        {

            private tcCpfCnpj cpfCnpjField;

            private string inscricaoMunicipalField;

            /// <Observacoes/>
            public tcCpfCnpj CpfCnpj
            {
                get
                {
                    return this.cpfCnpjField;
                }
                set
                {
                    this.cpfCnpjField = value;
                }
            }

            /// <Observacoes/>
            public string InscricaoMunicipal
            {
                get
                {
                    return this.inscricaoMunicipalField;
                }
                set
                {
                    this.inscricaoMunicipalField = value;
                }
            }
        }
        #endregion
        #endregion

        #region IntermediarioServico tcIdentificacaoIntermediarioServico
        public class tcIdentificacaoIntermediarioServico
        {

            private string razaoSocialField;

            private tcCpfCnpj cpfCnpjField;

            private string inscricaoMunicipalField;

            /// <Observacoes/>
            public string RazaoSocial
            {
                get
                {
                    return this.razaoSocialField;
                }
                set
                {
                    this.razaoSocialField = value;
                }
            }

            /// <Observacoes/>
            public tcCpfCnpj CpfCnpj
            {
                get
                {
                    return this.cpfCnpjField;
                }
                set
                {
                    this.cpfCnpjField = value;
                }
            }

            /// <Observacoes/>
            public string InscricaoMunicipal
            {
                get
                {
                    return this.inscricaoMunicipalField;
                }
                set
                {
                    this.inscricaoMunicipalField = value;
                }
            }
        }
        #region CpfCnpj  tcCpfCnpj
        public class tcCpfCnpj
        {

            private string itemField;

            private ItemChoiceType itemElementNameField;

            /// <Observacoes/>

            public string Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public ItemChoiceType ItemElementName
            {
                get
                {
                    return this.itemElementNameField;
                }
                set
                {
                    this.itemElementNameField = value;
                }
            }
        }
        #region ChoiceType ItemChoiceType
        public enum ItemChoiceType
        {

            /// <Observacoes/>
            Cnpj,

            /// <Observacoes/>
            Cpf,
        }
        #endregion 
        #endregion
        #endregion

        #region OrgaoGerador  tcIdentificacaoOrgaoGerador
        public class tcIdentificacaoOrgaoGerador
        {

            private int codigoMunicipioField;

            private string ufField;

            /// <Observacoes/>
            public int CodigoMunicipio
            {
                get
                {
                    return this.codigoMunicipioField;
                }
                set
                {
                    this.codigoMunicipioField = value;
                }
            }

            /// <Observacoes/>
            public string Uf
            {
                get
                {
                    return this.ufField;
                }
                set
                {
                    this.ufField = value;
                }
            }
        }
        #endregion 

        #region ConstrucaoCivil  tcDadosConstrucaoCivil
        public class tcDadosConstrucaoCivil
        {

            private string codigoObraField;

            private string artField;

            /// <Observacoes/>
            public string CodigoObra
            {
                get
                {
                    return this.codigoObraField;
                }
                set
                {
                    this.codigoObraField = value;
                }
            }

            /// <Observacoes/>
            public string Art
            {
                get
                {
                    return this.artField;
                }
                set
                {
                    this.artField = value;
                }
            }
        }
        #endregion 

        #endregion

        #endregion

        #region NfseCancelamento  tcCancelamentoNfse
        public class tcCancelamentoNfse
        {

            private tcConfirmacaoCancelamento confirmacaoField;

            /// <Observacoes/>
            public tcConfirmacaoCancelamento Confirmacao
            {
                get
                {
                    return this.confirmacaoField;
                }
                set
                {
                    this.confirmacaoField = value;
                }
            }

        }

        #region Confirmacao tcConfirmacaoCancelamento
        public class tcConfirmacaoCancelamento
        {

            private tcPedidoCancelamento pedidoField;

            private tcInfConfirmacaoCancelamento infConfirmacaoCancelamentoField;

            private string idField;

            /// <Observacoes/>
            public tcPedidoCancelamento Pedido
            {
                get
                {
                    return this.pedidoField;
                }
                set
                {
                    this.pedidoField = value;
                }
            }

            /// <Observacoes/>
            public tcInfConfirmacaoCancelamento InfConfirmacaoCancelamento
            {
                get
                {
                    return this.infConfirmacaoCancelamentoField;
                }
                set
                {
                    this.infConfirmacaoCancelamentoField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }
        #endregion

        #region InfConfirmacaoCancelamento tcInfConfirmacaoCancelamento
        public class tcInfConfirmacaoCancelamento
        {

            private bool sucessoField;

            private System.DateTime dataHoraField;

            /// <Observacoes/>
            public bool Sucesso
            {
                get
                {
                    return this.sucessoField;
                }
                set
                {
                    this.sucessoField = value;
                }
            }

            /// <Observacoes/>
            public System.DateTime DataHora
            {
                get
                {
                    return this.dataHoraField;
                }
                set
                {
                    this.dataHoraField = value;
                }
            }
        }
        #region 

        #region Pedido tcPedidoCancelamento
        public class tcPedidoCancelamento
        {

            private tcInfPedidoCancelamento infPedidoCancelamentoField;


            /// <Observacoes/>
            public tcInfPedidoCancelamento InfPedidoCancelamento
            {
                get
                {
                    return this.infPedidoCancelamentoField;
                }
                set
                {
                    this.infPedidoCancelamentoField = value;
                }
            }
        }

        #region InfPedidoCancelamento tcInfPedidoCancelamento
        public class tcInfPedidoCancelamento
        {

            private tcIdentificacaoNfse identificacaoNfseField;

            private string codigoCancelamentoField;

            private string idField;

            /// <Observacoes/>
            public tcIdentificacaoNfse IdentificacaoNfse
            {
                get
                {
                    return this.identificacaoNfseField;
                }
                set
                {
                    this.identificacaoNfseField = value;
                }
            }

            /// <Observacoes/>
            public string CodigoCancelamento
            {
                get
                {
                    return this.codigoCancelamentoField;
                }
                set
                {
                    this.codigoCancelamentoField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        #region IdentificacaoNfse tcIdentificacaoNfse
        public class tcIdentificacaoNfse
        {

            private string numeroField;

            private string cnpjField;

            private string inscricaoMunicipalField;

            private int codigoMunicipioField;

            /// <Observacoes/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string Numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <Observacoes/>
            public string Cnpj
            {
                get
                {
                    return this.cnpjField;
                }
                set
                {
                    this.cnpjField = value;
                }
            }

            /// <Observacoes/>
            public string InscricaoMunicipal
            {
                get
                {
                    return this.inscricaoMunicipalField;
                }
                set
                {
                    this.inscricaoMunicipalField = value;
                }
            }

            /// <Observacoes/>
            public int CodigoMunicipio
            {
                get
                {
                    return this.codigoMunicipioField;
                }
                set
                {
                    this.codigoMunicipioField = value;
                }
            }
        }
        #endregion 

        #endregion
        #endregion

        #endregion

        #endregion

        #endregion

        #region SubstituicaoNfse tcSubstituicaoNfse
        public class tcSubstituicaoNfse
        {

            private tcInfSubstituicaoNfse substituicaoNfseField;

            /// <Observacoes/>
            public tcInfSubstituicaoNfse SubstituicaoNfse
            {
                get
                {
                    return this.substituicaoNfseField;
                }
                set
                {
                    this.substituicaoNfseField = value;
                }
            }

        }

        #region InfSubstituicaoNfse tcInfSubstituicaoNfse
        public class tcInfSubstituicaoNfse
        {

            private string nfseSubstituidoraField;

            private string idField;

            /// <Observacoes/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string NfseSubstituidora
            {
                get
                {
                    return this.nfseSubstituidoraField;
                }
                set
                {
                    this.nfseSubstituidoraField = value;
                }
            }

            /// <Observacoes/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }
        #endregion
        #endregion

        #endregion
}
