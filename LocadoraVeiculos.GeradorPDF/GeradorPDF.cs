using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iTextSharp.text.pdf;
using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.SegurosModule;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfDocument = iText.Kernel.Pdf.PdfDocument;
using PdfWriter = iText.Kernel.Pdf.PdfWriter;

namespace LocadoraVeiculos.GeradorPDF
{
    public  static class GeradorPDF
    {
        public static void GerarPDF(Locacao locacao)
        {
            ControladorCliente controladorCliente = new ControladorCliente();
            ControladorVeiculo controladorVeiculo = new ControladorVeiculo();
            ControladorSeguros controladorSeguros = new ControladorSeguros();
            ControladorTaxasServicos controladorTaxasServicos = new ControladorTaxasServicos();

            Cliente cliente = controladorCliente.SelecionarPorId(locacao.id_cliente);
            Veiculo veiculo = controladorVeiculo.SelecionarPorId(locacao.id_veiculo);
            Seguros seguros = controladorSeguros.SelecionarPorId(locacao.id_seguro);
            TaxasServicos taxasServicos = controladorTaxasServicos.SelecionarPorId(locacao.id_taxa);

            using (PdfWriter wPdf = new PdfWriter($@"..\..\..\Recibos\recibo{locacao.Id}.pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("Recibo de Locação").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));
                document.Add(new Paragraph("\n\n"));
                document.Add(new Paragraph("Cliente: " + cliente.NomeCliente.ToString()));
                document.Add(new Paragraph("Condutor: " + cliente.NomeDoCondutor.ToString()));
                document.Add(new Paragraph("Marca do Veículo: " + veiculo.marca.ToString()));
                document.Add(new Paragraph("Placa do Veículo: " + veiculo.Placa.ToString()));
                document.Add(new Paragraph("Data da locação: " + locacao.dataLocacao.ToString("d")));
                document.Add(new Paragraph("Data para devolução: " + locacao.dataDevolucao.ToString("d")));
                document.Add(new Paragraph("Plano Escolhido: " + locacao.plano));               
                document.Add(new Paragraph("Serviço adicional escolhido: " + taxasServicos.Nome));
                document.Add(new Paragraph("Seguro escolhido" + seguros.TipoSeguro));
                document.Add(new Paragraph("\n\n"));
                document.Add(new Paragraph("Locadora Rech"));

                document.Close();

                pdfDocument.Close();
            }

            Task.Run(() => EnviarRelatorioParaEmailCliente(cliente, locacao));
        }

        private static void EnviarRelatorioParaEmailCliente(Cliente cliente, Locacao locacao)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        //SERVIDOR
                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential("arraydepessoas@gmail.com", "array2021");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        //EMAIL
                        email.From = new MailAddress("arraydepessoas@gmail.com");
                        email.To.Add(cliente.Email);

                        email.Subject = "ArrayDePessoas";
                        email.IsBodyHtml = false;
                        email.Body = "Obrigado por utilizar nossos serviços, volte sempre!";

                        email.Attachments.Add(new Attachment($@"..\..\..\Recibos\recibo{locacao.Id}.pdf"));

                        //ENVIAR
                        smtp.Send(email);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
