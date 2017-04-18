using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using DinkToPdf;

namespace DinkToPdf.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var converter = new BasicConverter(new PdfTools());

            converter.PhaseChanged += Converter_PhaseChanged;
            converter.ProgressChanged += Converter_ProgressChanged;
            converter.Finished += Converter_Finished;
            converter.Warning += Converter_Warning;
            converter.Error += Converter_Error;

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4,
                },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consectetur mauris eget ultrices iaculis. Ut et odio viverra, molestie lectus nec, venenatis turpis. Nulla quis euismod nisl. Duis scelerisque eros nec dui facilisis, sit amet porta odio varius. Praesent vitae sollicitudin leo. Sed vitae quam in massa eleifend porta. Aliquam pulvinar orci dapibus porta laoreet. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed commodo tortor eget dolor hendrerit dapibus.
                                        Vivamus lorem diam, vulputate at ultrices quis, tristique eu nunc. Sed bibendum hendrerit leo. Nulla nec risus turpis. Vivamus at tortor felis. Donec eget posuere libero. Pellentesque erat nunc, molestie eget gravida vitae, eleifend a eros. Integer in tortor sed elit aliquam vehicula eget a erat. Vivamus nisi augue, venenatis ut commodo vel, congue id neque. Curabitur convallis dictum semper. Nulla accumsan urna aliquet, mattis dolor molestie, fermentum metus. Quisque at nisi non augue tempor commodo et pretium orci.
                                        Quisque blandit libero ut laoreet venenatis. Morbi sit amet quam varius, euismod dui et, volutpat felis. Sed nec ante vel est convallis placerat. Morbi mollis pretium tempor. Aliquam luctus eu justo vitae tristique. Sed in elit et elit sagittis pharetra sed vitae velit. Proin eget mi facilisis, scelerisque justo in, ornare urna. Aenean auctor ante ex, eget mattis neque pretium id. Aliquam ut risus leo. Vivamus ullamcorper et mauris in vehicula. Maecenas tristique interdum tempus. Etiam mattis lorem eget odio faucibus, in rhoncus nisi ultrices. Etiam at convallis nibh. Suspendisse tincidunt velit arcu, a volutpat nulla euismod sed.
                                        Aliquam mollis placerat blandit. Morbi in nibh urna. Donec nisl enim, tristique id tincidunt sed, pharetra non mi. Morbi viverra arcu vulputate risus dignissim efficitur. Vivamus dolor eros, finibus et porttitor a, pellentesque a lectus. Integer pellentesque maximus velit sit amet sollicitudin. Nulla a elit eget augue pretium luctus quis eu metus. Aenean nec dui id nibh tempor dapibus. Pellentesque dignissim ullamcorper mauris, vitae pharetra turpis sodales sit amet. Etiam et bibendum neque.
                                        Nulla gravida sit amet velit eu aliquet. Etiam sit amet elit leo. Sed nec arcu tincidunt, placerat turpis quis, laoreet nulla. Aenean neque est, fringilla non nulla in, laoreet vehicula nunc. Etiam vel nisl sit amet lectus pellentesque eleifend. Etiam sed nisi dolor. Mauris quis tincidunt ex. Aliquam porta mattis tempor. Maecenas fringilla bibendum elementum. Vestibulum quis tempus libero, vitae cursus neque. Suspendisse lectus risus, lacinia consectetur enim quis, ullamcorper porta tortor. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                        FooterSettings = { FontSize = 9, Right = "Page [page] of [toPage]" }
                    }
                }
            };
            
            byte[] pdf = converter.Convert(doc);

            if (!Directory.Exists("Files"))
            {
                Directory.CreateDirectory("Files");
            }

            using (FileStream stream = new FileStream(@"Files\" + DateTime.UtcNow.Ticks.ToString() + ".pdf", FileMode.Create))
            {
                stream.Write(pdf, 0, pdf.Length);
            }
           
            Console.ReadKey();
        }

        private static void Converter_Error(object sender, EventDefinitions.ErrorArgs e)
        {
            Console.WriteLine("[ERROR] {0}", e.Message);
        }

        private static void Converter_Warning(object sender, EventDefinitions.WarningArgs e)
        {
            Console.WriteLine("[WARN] {0}", e.Message);
        }

        private static void Converter_Finished(object sender, EventDefinitions.FinishedArgs e)
        {
            Console.WriteLine("Conversion {0} ", e.Success ? "successful" : "unsucessful");
        }

        private static void Converter_ProgressChanged(object sender, EventDefinitions.ProgressChangedArgs e)
        {
            Console.WriteLine("Progress changed {0}", e.Description);
        }

        private static void Converter_PhaseChanged(object sender, EventDefinitions.PhaseChangedArgs e)
        {
            Console.WriteLine("Phase changed {0} - {1}", e.CurrentPhase, e.Description);
        }
    }
}
