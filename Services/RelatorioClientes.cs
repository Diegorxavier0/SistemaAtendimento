

using QuestPDF.Fluent;

using QuestPDF.Helpers;

using QuestPDF.Infrastructure;

using QuestPDF.Companion;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Services

{

    public class RelatorioClientes

    {

        public string GerarListaClientes(List<Clientes> listaClientes)

        {

            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            string caminho = Path.Combine(Path.GetTempPath(), $"RelatorioCliente_{Guid.NewGuid}.pdf");

            Document.Create(container =>
            {

                container.Page(page =>
                {

                    page.Size(PageSizes.A4);

                    page.Margin(1, Unit.Centimetre);

                    page.PageColor(Colors.White);

                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.Verdana));


                    page.Header()//cabeçalho
                   .BorderBottom(2).PaddingBottom(10).Row(row =>
                   {
                       row.RelativeItem().Column(col =>
                       {
                          string logopath = Path.Combine(AppContext.BaseDirectory,"Assets", "logotiposenac.png");
                           if(File.Exists(logopath))
                           {
                               col.Item().Width(80).Image(logopath);
                           }
                           else
                           {
                               col.Item().Text("SENAC").FontSize(14).Bold();
                           }
                       });

                       row.RelativeItem(1).AlignCenter().AlignMiddle().Text("Lista de Clientes").FontSize(16).Bold();

                       row.RelativeItem().AlignRight().AlignMiddle().Text(t =>
                       {

                           t.Span("Data: ").Bold();
                           t.Span(DateTime.Now.ToString("dd/MM/yyyy"));
                       });

                   });

                    //corpo do relatório
                    page.Content().PaddingVertical(10).Table(table => {

                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(30); // Coluna para ID
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(2);
                            columns.RelativeColumn(2);//coluna para cpf/cnpj

                        });

                        // Cabeçalho da tabela   define a linha de titulo 
                        table.Header(header =>
                        {
                            header.Cell().BorderBottom(1).Text("ID").Bold();
                            header.Cell().BorderBottom(1).Text("NOME").Bold();
                            header.Cell().BorderBottom(1).Text("EMAIL").Bold();
                            header.Cell().BorderBottom(1).Text("TELEFONE").Bold();
                            header.Cell().BorderBottom(1).Text("CPF/CNPJ").Bold();
                        });

                        foreach (var cliente in listaClientes)
                        {
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(cliente.Id.ToString());
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(cliente.Nome ?? "-");
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(cliente.Email ?? "-");
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(cliente.Telefone ?? "-");
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(cliente.Cpf_Cnpj ?? "-");

                        }
                    });

                    //rodapé do relatório
                    page.Footer().AlignCenter().Text(t =>
                    {
                        t.Span("Página ");
                        t.CurrentPageNumber();
                        t.Span(" de ");
                        t.TotalPages();
                    });
                });


            }).GeneratePdf(caminho);

            return caminho;

        }

    }

}

