using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace NFse.Classes
{
    public class ValidarXML
    {
        private bool falhou;
        public bool Falhou
        {
            get { return falhou; }
        }

        public bool ValidarXml(string xmlFilename, string schemaFilename)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            XmlSchemaSet schemas = new XmlSchemaSet();
            settings.Schemas = schemas;
            schemas.Add(null, schemaFilename);
            settings.ValidationEventHandler += ValidationEventHandler;
            XmlReader validator = XmlReader.Create(xmlFilename, settings);
            falhou = false;
            try
            {
                while (validator.Read()) { }
            }
            catch (XmlException err)
            {
                falhou = true;
                throw new Exception("Ocorreu um erro critico durante a validacao XML." + err.Message);
            }
            finally
            {
                validator.Close();
            }
            return !falhou;
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            falhou = true;
            throw new Exception("Erros da validação : " + args.Message);
        }
    }
}
