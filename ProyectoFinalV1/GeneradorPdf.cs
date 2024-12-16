using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProyectoFinalV1
{
    public class GeneradorPdf
    {

        private int folio;//Declaramos un folio para la compra
        private Persona usuario;//Declaramos un objeto de tipo persona
        private List<Juegos> carrito;//Declaramos una lista
        private bool metodo_pago;//Declaramos un booleano para el metodo de pago
        private int cashin;//Declaramos un entero para el cashin
        private int total;//Declaramos un entero para el total
        public int Folio { get; set; }//Propiedad para el folio



        public GeneradorPdf()
        {
        }

        public GeneradorPdf(Persona usuario, List<Juegos> carrito, bool metodo_pago, int cashin, int total)
        {
            this.usuario = usuario;
            this.carrito = carrito;
            this.metodo_pago = metodo_pago;
            this.cashin = cashin;
            this.total = total;
        }
        public void CrearPDF()
        {
            // Generar el folio antes de crear el PDF
            Folio = GeneradorFolio();

            string rutaArchivo = Ruta(Folio);
            FileStream fs = new FileStream(rutaArchivo, FileMode.Create);//Creamos un archivo PDF en la ruta especificada
            Document doc = new Document(PageSize.LETTER, 70.8661f, 70.8661f, 70.8661f, 70.8661f);//Creamos un documento PDF con márgenes de 2.5 cm (70.8661 puntos)
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fs);//Creamos un escritor de PDF

            // Abrimos el documento
            doc.Open();

            // Agregamos un titulo al documento
            doc.AddTitle("Ticket de Compra");

            // Creamos una tabla con dos columnas
            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            float[] widths = new float[] { 1f, 3f };
            headerTable.SetWidths(widths);

            // Agregamos la imagen en la primera celda
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Imagenes\Steam-Logo.png");
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaImagen);
            logo.ScaleAbsolute(50, 50); // Escalamos la imagen
            PdfPCell imageCell = new PdfPCell(logo);
            imageCell.Border = PdfPCell.NO_BORDER;
            headerTable.AddCell(imageCell);

            // Agregamos el texto en la segunda celda
            PdfPCell textCell = new PdfPCell();
            textCell.Border = PdfPCell.NO_BORDER;
            textCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            textCell.AddElement(new Paragraph("ESTIM", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)));
            textCell.AddElement(new Paragraph("La diversión a la palma de tus manos", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.ITALIC)));
            textCell.AddElement(new Paragraph($"Folio: {Folio}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12)));
            textCell.AddElement(new Paragraph($"Cliente: {usuario.Nombre}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12)));
            textCell.AddElement(new Paragraph($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12)));
            textCell.AddElement(new Paragraph("\n"));
            headerTable.AddCell(textCell);

            // Agregamos la tabla al documento
            doc.Add(headerTable);

            // Agregamos un salto de línea para evitar que la tabla de juegos se empalme con la imagen y la información del ticket
            doc.Add(new Paragraph("\n\n\n\n"));

            // Combinamos los juegos iguales
            var juegosCombinados = carrito
                .GroupBy(j => new { j.Nombre, j.Precio })
                .Select(g => new
                {
                    Nombre = g.Key.Nombre,
                    Precio = g.Key.Precio,
                    Cantidad = g.Count(),
                    Importe = g.Count() * g.Key.Precio
                })
                .ToList();

            // Agregamos los juegos del carrito
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 3f, 1f, 2f, 2f }); // Anchos relativos de las columnas
            table.AddCell(new PdfPCell(new Phrase("Nombre", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            table.AddCell(new PdfPCell(new Phrase("Cantidad", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            table.AddCell(new PdfPCell(new Phrase("Precio Unitario", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            table.AddCell(new PdfPCell(new Phrase("Importe", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });

            foreach (var juego in juegosCombinados)
            {
                table.AddCell(new PdfPCell(new Phrase(juego.Nombre, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))));
                table.AddCell(new PdfPCell(new Phrase(juego.Cantidad.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))));
                table.AddCell(new PdfPCell(new Phrase(juego.Precio.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))));
                table.AddCell(new PdfPCell(new Phrase(juego.Importe.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))));
            }

            doc.Add(table);

            // Agregamos un salto de línea para evitar que la tabla de juegos se empalme con la imagen y la información del ticket
            doc.Add(new Paragraph("\n"));

            // Calcular el impuesto y el total con impuesto
            decimal totalSinImpuesto = juegosCombinados.Sum(j => j.Importe);
            decimal impuesto = totalSinImpuesto * 0.06m;
            decimal totalConImpuesto = totalSinImpuesto + impuesto;

            // Crear una subtabla para el resumen de pago
            PdfPTable resumenTable = new PdfPTable(2);
            resumenTable.WidthPercentage = 50;
            resumenTable.HorizontalAlignment = Element.ALIGN_RIGHT;

            resumenTable.AddCell(new PdfPCell(new Phrase("Método de Pago:", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { Border = PdfPCell.NO_BORDER });
            resumenTable.AddCell(new PdfPCell(new Phrase(metodo_pago ? "Tarjeta" : "Efectivo", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))) { Border = PdfPCell.NO_BORDER });

            resumenTable.AddCell(new PdfPCell(new Phrase("Subtotal:", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { Border = PdfPCell.NO_BORDER });
            resumenTable.AddCell(new PdfPCell(new Phrase(totalSinImpuesto.ToString("C"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))) { Border = PdfPCell.NO_BORDER });

            resumenTable.AddCell(new PdfPCell(new Phrase("Impuesto (6%):", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { Border = PdfPCell.NO_BORDER });
            resumenTable.AddCell(new PdfPCell(new Phrase(impuesto.ToString("C"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))) { Border = PdfPCell.NO_BORDER });

            resumenTable.AddCell(new PdfPCell(new Phrase("Total:", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { Border = PdfPCell.NO_BORDER });
            resumenTable.AddCell(new PdfPCell(new Phrase(totalConImpuesto.ToString("C"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))) { Border = PdfPCell.NO_BORDER });

            if (!metodo_pago)
            {
                resumenTable.AddCell(new PdfPCell(new Phrase("Efectivo Recibido:", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { Border = PdfPCell.NO_BORDER });
                resumenTable.AddCell(new PdfPCell(new Phrase(cashin.ToString("C"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))) { Border = PdfPCell.NO_BORDER });

                resumenTable.AddCell(new PdfPCell(new Phrase("Cambio:", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) { Border = PdfPCell.NO_BORDER });
                resumenTable.AddCell(new PdfPCell(new Phrase((cashin - totalConImpuesto).ToString("C"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))) { Border = PdfPCell.NO_BORDER });
            }

            doc.Add(resumenTable);

            // Agregamos un mensaje de agradecimiento y una nota
            doc.Add(new Paragraph("\n"));
            Paragraph gracias = new Paragraph("¡Gracias por su compra!", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
            gracias.Alignment = Element.ALIGN_CENTER;
            doc.Add(gracias);

            Paragraph nota = new Paragraph("Esto no es una factura", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.ITALIC));
            nota.Alignment = Element.ALIGN_CENTER;
            doc.Add(nota);

            // Cerramos el documento
            doc.Close();
            pdfWriter.Close();//Cerramos el escritor de PDF

            MessageBox.Show("Ticket generado con exito.");

            // Abrir el PDF automáticamente
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = rutaArchivo,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        //Declaramos un comportamiento en la clase con el cual podremos acceder a ruta de tickets en cualquier equipo que tenga el proyecto.
        public static string Ruta(int Folio)
        {
            // Se obtiene el directorio base de la aplicación en tiempo de ejecución
            string rutaBaseDirectorio = AppDomain.CurrentDomain.BaseDirectory;

            // Subimos varios niveles en el directorio para llegar a la carpeta del proyecto
            string rutaProyecto = Path.GetFullPath(Path.Combine(rutaBaseDirectorio, @"..\..\.."));

            // Combinamos el directorio del proyecto con la carpeta "Tickets" para formar la ruta completa
            string rutaTickets = Path.Combine(rutaProyecto, "Tickets");

            // Si la carpeta "Tickets" no existe, la creamos
            if (!Directory.Exists(rutaTickets))
            {
                Directory.CreateDirectory(rutaTickets);
            }
 
            string nombreArchivo = $"Ticket_{Folio}.pdf";//Colocamos el nombre del archivo

            //Si el archivo ya existe, añadimos 1 o 2 o 3 etc. al final del nombre del archivo
            int contador = 1;
            while (File.Exists(Path.Combine(rutaTickets, nombreArchivo)))
            {
                nombreArchivo = $"Ticket_{Folio}_{contador}.pdf"; // Cambiar el nombre del archivo
                contador++;
            }

            // Devuelve la ruta completa del archivo PDF
            return Path.Combine(rutaTickets, nombreArchivo);
        }

        static int GeneradorFolio()
        {
            Random random = new Random();
            return random.Next(1, 10000);
        }

       
    }
}
