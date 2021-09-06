using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.SegurosModule;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using System.Net.Mail;
using System.Threading.Tasks;

using System.Windows.Forms;

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

                var documento = new Document(pdfDocument, PageSize.A4);
                documento.SetMargins(40,40,40,40);                          

                var img = new Image(ImageDataFactory.Create(@"..\..\..\LocadoraVeiculos.WindowsForm\Resources\Nova imagem para menu.png"));
                img.ScaleAbsolute(80, 60);            
                img.SetFixedPosition(40f, 740f);

                documento.Add(img);
                documento.Add(new Paragraph("Locadora Rech").SetTextAlignment(TextAlignment.CENTER).SetFontSize(22));
                documento.Add(new Paragraph("\n\n"));
                documento.Add(new Paragraph("Recibo de Locação").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(22));
                documento.Add(new Paragraph("\n\n"));
                documento.Add(new Paragraph("Cliente: " + cliente.NomeCliente.ToString()));
                documento.Add(new Paragraph("Condutor: " + cliente.NomeDoCondutor.ToString()));
                documento.Add(new Paragraph("Marca do Veículo: " + veiculo.marca.ToString()));
                documento.Add(new Paragraph("Placa do Veículo: " + veiculo.Placa.ToString())); 
                
                var imgDoVeiculo = new Image(ImageDataFactory.Create(veiculo.foto));
                imgDoVeiculo.ScaleAbsolute(90, 80);
                //imgDoVeiculo.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);            
                documento.Add(imgDoVeiculo);

                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph("Data da locação: " + locacao.dataLocacao.ToString("d")));
                documento.Add(new Paragraph("Data para devolução: " + locacao.dataDevolucao.ToString("d")));
                documento.Add(new Paragraph("Plano Escolhido: " + locacao.plano));               
                documento.Add(new Paragraph("Serviço adicional escolhido: " + taxasServicos.Nome));
                documento.Add(new Paragraph("Seguro escolhido: " + seguros.TipoSeguro));
                              
                documento.Add(new Paragraph("\n\n"));
                Paragraph rodape = new Paragraph("Obrigado por usar nossos serviços!").SetTextAlignment(TextAlignment.LEFT).SetBold().SetFontSize(14);                  
                documento.Add(rodape);

                documento.Close();

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

                        email.Subject = "Recibo de locação";
                        email.IsBodyHtml = false;
                        email.Body = "Obrigado por usar nossos serviços!";

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
