using System;
using System.Collections.Generic;

namespace DinkToPdf
{ 
    public class PechkinPaperSize
    {
        private static readonly Dictionary<PaperKind, PechkinPaperSize> dictionary = new Dictionary<PaperKind, PechkinPaperSize>()
        {
            // paper sizes from http://msdn.microsoft.com/en-us/library/system.drawing.printing.paperkind.aspx
            { PaperKind.Letter, new PechkinPaperSize("8.5in", "11in") },
            { PaperKind.Legal, new PechkinPaperSize("8.5in", "14in") },
            { PaperKind.A4, new PechkinPaperSize("210mm", "297mm") },
            { PaperKind.CSheet, new PechkinPaperSize("17in", "22in") },
            { PaperKind.DSheet, new PechkinPaperSize("22in", "34in") },
            { PaperKind.ESheet, new PechkinPaperSize("34in", "44in") },
            { PaperKind.LetterSmall, new PechkinPaperSize("8.5in", "11in") },
            { PaperKind.Tabloid, new PechkinPaperSize("11in", "17in") },
            { PaperKind.Ledger, new PechkinPaperSize("17in", "11in") },
            { PaperKind.Statement, new PechkinPaperSize("5.5in", "8.5in") },
            { PaperKind.Executive, new PechkinPaperSize("7.25in", "10.5in") },
            { PaperKind.A3, new PechkinPaperSize("297mm", "420mm") },
            { PaperKind.A4Small, new PechkinPaperSize("210mm", "297mm") },
            { PaperKind.A5, new PechkinPaperSize("148mm", "210mm") },
            { PaperKind.B4, new PechkinPaperSize("250mm", "353mm") },
            { PaperKind.B5, new PechkinPaperSize("176mm", "250mm") },
            { PaperKind.Folio, new PechkinPaperSize("8.5in", "13in") },
            { PaperKind.Quarto, new PechkinPaperSize("215mm", "275mm") },
            { PaperKind.Standard10x14, new PechkinPaperSize("10in", "14in") },
            { PaperKind.Standard11x17, new PechkinPaperSize("11in", "17in") },
            { PaperKind.Note, new PechkinPaperSize("8.5in", "11in") },
            { PaperKind.Number9Envelope, new PechkinPaperSize("3.875in", "8.875in") },
            { PaperKind.Number10Envelope, new PechkinPaperSize("4.125in", "9.5in") },
            { PaperKind.Number11Envelope, new PechkinPaperSize("4.5in", "10.375in") },
            { PaperKind.Number12Envelope, new PechkinPaperSize("4.75in", "11in") },
            { PaperKind.Number14Envelope, new PechkinPaperSize("5in", "11.5in") },
            { PaperKind.DLEnvelope, new PechkinPaperSize("110mm", "220mm") },
            { PaperKind.C5Envelope, new PechkinPaperSize("162mm", "229mm") },
            { PaperKind.C3Envelope, new PechkinPaperSize("324mm", "458mm") },
            { PaperKind.C4Envelope, new PechkinPaperSize("229mm", "324mm") },
            { PaperKind.C6Envelope, new PechkinPaperSize("114mm", "162mm") },
            { PaperKind.C65Envelope, new PechkinPaperSize("114mm", "229mm") },
            { PaperKind.B4Envelope, new PechkinPaperSize("250mm", "353mm") },
            { PaperKind.B5Envelope, new PechkinPaperSize("176mm", "250mm") },
            { PaperKind.B6Envelope, new PechkinPaperSize("176mm", "125mm") },
            { PaperKind.ItalyEnvelope, new PechkinPaperSize("110mm", "230mm") },
            { PaperKind.MonarchEnvelope, new PechkinPaperSize("3.875in", "7.5in") },
            { PaperKind.PersonalEnvelope, new PechkinPaperSize("3.625in", "6.5in") },
            { PaperKind.USStandardFanfold, new PechkinPaperSize("14.875in", "11in") },
            { PaperKind.GermanStandardFanfold, new PechkinPaperSize("8.5in", "12in") },
            { PaperKind.GermanLegalFanfold, new PechkinPaperSize("8.5in", "13in") },
            { PaperKind.IsoB4, new PechkinPaperSize("250mm", "353mm") },
            { PaperKind.JapanesePostcard, new PechkinPaperSize("100mm", "148mm") },
            { PaperKind.Standard9x11, new PechkinPaperSize("9in", "11in") },
            { PaperKind.Standard10x11, new PechkinPaperSize("10in", "11in") },
            { PaperKind.Standard15x11, new PechkinPaperSize("15in", "11in") },
            { PaperKind.InviteEnvelope, new PechkinPaperSize("220mm", "220mm") },
            { PaperKind.LetterExtra, new PechkinPaperSize("9.275in", "12in") },
            { PaperKind.LegalExtra, new PechkinPaperSize("9.275in", "15in") },
            { PaperKind.TabloidExtra, new PechkinPaperSize("11.69in", "18in") },
            { PaperKind.A4Extra, new PechkinPaperSize("236mm", "322mm") },
            { PaperKind.LetterTransverse, new PechkinPaperSize("8.275in", "11in") },
            { PaperKind.A4Transverse, new PechkinPaperSize("210mm", "297mm") },
            { PaperKind.LetterExtraTransverse, new PechkinPaperSize("9.275in", "12in") },
            { PaperKind.APlus, new PechkinPaperSize("227mm", "356mm") },
            { PaperKind.BPlus, new PechkinPaperSize("305mm", "487mm") },
            { PaperKind.LetterPlus, new PechkinPaperSize("8.5in", "12.69in") },
            { PaperKind.A4Plus, new PechkinPaperSize("210mm", "330mm") },
            { PaperKind.A5Transverse, new PechkinPaperSize("148mm", "210mm") },
            { PaperKind.B5Transverse, new PechkinPaperSize("182mm", "257mm") },
            { PaperKind.A3Extra, new PechkinPaperSize("322mm", "445mm") },
            { PaperKind.A5Extra, new PechkinPaperSize("174mm", "235mm") },
            { PaperKind.B5Extra, new PechkinPaperSize("201mm", "276mm") },
            { PaperKind.A2, new PechkinPaperSize("420mm", "594mm") },
            { PaperKind.A3Transverse, new PechkinPaperSize("297mm", "420mm") },
            { PaperKind.A3ExtraTransverse, new PechkinPaperSize("322mm", "445mm") },
            { PaperKind.JapaneseDoublePostcard, new PechkinPaperSize("200mm", "148mm") },
            { PaperKind.A6, new PechkinPaperSize("105mm", "148mm") },
            { PaperKind.LetterRotated, new PechkinPaperSize("11in", "8.5in") },
            { PaperKind.A3Rotated, new PechkinPaperSize("420mm", "297mm") },
            { PaperKind.A4Rotated, new PechkinPaperSize("297mm", "210mm") },
            { PaperKind.A5Rotated, new PechkinPaperSize("210mm", "148mm") },
            { PaperKind.B4JisRotated, new PechkinPaperSize("364mm", "257mm") },
            { PaperKind.B5JisRotated, new PechkinPaperSize("257mm", "182mm") },
            { PaperKind.JapanesePostcardRotated, new PechkinPaperSize("148mm", "100mm") },
            { PaperKind.JapaneseDoublePostcardRotated, new PechkinPaperSize("148mm", "200mm") },
            { PaperKind.A6Rotated, new PechkinPaperSize("148mm", "105mm") },
            { PaperKind.B6Jis, new PechkinPaperSize("128mm", "182mm") },
            { PaperKind.B6JisRotated, new PechkinPaperSize("182mm", "128mm") },
            { PaperKind.Standard12x11, new PechkinPaperSize("12in", "11in") },
            { PaperKind.Prc16K, new PechkinPaperSize("146mm", "215mm") },
            { PaperKind.Prc32K, new PechkinPaperSize("97mm", "151mm") },
            { PaperKind.Prc32KBig, new PechkinPaperSize("97mm", "151mm") },
            { PaperKind.PrcEnvelopeNumber1, new PechkinPaperSize("102mm", "165mm") },
            { PaperKind.PrcEnvelopeNumber2, new PechkinPaperSize("102mm", "176mm") },
            { PaperKind.PrcEnvelopeNumber3, new PechkinPaperSize("125mm", "176mm") },
            { PaperKind.PrcEnvelopeNumber4, new PechkinPaperSize("110mm", "208mm") },
            { PaperKind.PrcEnvelopeNumber5, new PechkinPaperSize("110mm", "220mm") },
            { PaperKind.PrcEnvelopeNumber6, new PechkinPaperSize("120mm", "230mm") },
            { PaperKind.PrcEnvelopeNumber7, new PechkinPaperSize("160mm", "230mm") },
            { PaperKind.PrcEnvelopeNumber8, new PechkinPaperSize("120mm", "309mm") },
            { PaperKind.PrcEnvelopeNumber9, new PechkinPaperSize("229mm", "324mm") },
            { PaperKind.PrcEnvelopeNumber10, new PechkinPaperSize("324mm", "458mm") },
            { PaperKind.Prc16KRotated, new PechkinPaperSize("146mm", "215mm") },
            { PaperKind.Prc32KRotated, new PechkinPaperSize("97mm", "151mm") },
            { PaperKind.Prc32KBigRotated, new PechkinPaperSize("97mm", "151mm") },
            { PaperKind.PrcEnvelopeNumber1Rotated, new PechkinPaperSize("165mm", "102mm") },
            { PaperKind.PrcEnvelopeNumber2Rotated, new PechkinPaperSize("176mm", "102mm") },
            { PaperKind.PrcEnvelopeNumber3Rotated, new PechkinPaperSize("176mm", "125mm") },
            { PaperKind.PrcEnvelopeNumber4Rotated, new PechkinPaperSize("208mm", "110mm") },
            { PaperKind.PrcEnvelopeNumber5Rotated, new PechkinPaperSize("220mm", "110mm") },
            { PaperKind.PrcEnvelopeNumber6Rotated, new PechkinPaperSize("230mm", "120mm") },
            { PaperKind.PrcEnvelopeNumber7Rotated, new PechkinPaperSize("230mm", "160mm") },
            { PaperKind.PrcEnvelopeNumber8Rotated, new PechkinPaperSize("309mm", "120mm") },
            { PaperKind.PrcEnvelopeNumber9Rotated, new PechkinPaperSize("324mm", "229mm") },
            { PaperKind.PrcEnvelopeNumber10Rotated, new PechkinPaperSize("458mm", "324mm") },
        };

        public PechkinPaperSize(string width, string height)
        {
            this.Width = width;
            this.Height = height;
        }

        public string Height { get; set; }

        public string Width { get; set; }

        public static implicit operator PechkinPaperSize(PaperKind paperKind)
        {
            return dictionary[paperKind];
        }
    }
}