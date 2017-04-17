using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdf
{
    /// <summary>
    /// Enumaration of paper kinds from  http://msdn.microsoft.com/en-us/library/system.drawing.printing.paperkind.aspx
    /// Implemented here because Syste.Drawing.Printing is not ported to NET Core
    /// </summary>
    public enum PaperKind : int
    {
        //
        // Summary:
        //     The paper size is defined by the user.
        Custom = 0,
        //
        // Summary:
        //     Letter paper (8.5 in. by 11 in.).
        Letter = 1,
        //
        // Summary:
        //     Letter small paper (8.5 in. by 11 in.).
        LetterSmall = 2,
        //
        // Summary:
        //     Tabloid paper (11 in. by 17 in.).
        Tabloid = 3,
        //
        // Summary:
        //     Ledger paper (17 in. by 11 in.).
        Ledger = 4,
        //
        // Summary:
        //     Legal paper (8.5 in. by 14 in.).
        Legal = 5,
        //
        // Summary:
        //     Statement paper (5.5 in. by 8.5 in.).
        Statement = 6,
        //
        // Summary:
        //     Executive paper (7.25 in. by 10.5 in.).
        Executive = 7,
        //
        // Summary:
        //     A3 paper (297 mm by 420 mm).
        A3 = 8,
        //
        // Summary:
        //     A4 paper (210 mm by 297 mm).
        A4 = 9,
        //
        // Summary:
        //     A4 small paper (210 mm by 297 mm).
        A4Small = 10,
        //
        // Summary:
        //     A5 paper (148 mm by 210 mm).
        A5 = 11,
        //
        // Summary:
        //     B4 paper (250 mm by 353 mm).
        B4 = 12,
        //
        // Summary:
        //     B5 paper (176 mm by 250 mm).
        B5 = 13,
        //
        // Summary:
        //     Folio paper (8.5 in. by 13 in.).
        Folio = 14,
        //
        // Summary:
        //     Quarto paper (215 mm by 275 mm).
        Quarto = 15,
        //
        // Summary:
        //     Standard paper (10 in. by 14 in.).
        Standard10x14 = 16,
        //
        // Summary:
        //     Standard paper (11 in. by 17 in.).
        Standard11x17 = 17,
        //
        // Summary:
        //     Note paper (8.5 in. by 11 in.).
        Note = 18,
        //
        // Summary:
        //     #9 envelope (3.875 in. by 8.875 in.).
        Number9Envelope = 19,
        //
        // Summary:
        //     #10 envelope (4.125 in. by 9.5 in.).
        Number10Envelope = 20,
        //
        // Summary:
        //     #11 envelope (4.5 in. by 10.375 in.).
        Number11Envelope = 21,
        //
        // Summary:
        //     #12 envelope (4.75 in. by 11 in.).
        Number12Envelope = 22,
        //
        // Summary:
        //     #14 envelope (5 in. by 11.5 in.).
        Number14Envelope = 23,
        //
        // Summary:
        //     C paper (17 in. by 22 in.).
        CSheet = 24,
        //
        // Summary:
        //     D paper (22 in. by 34 in.).
        DSheet = 25,
        //
        // Summary:
        //     E paper (34 in. by 44 in.).
        ESheet = 26,
        //
        // Summary:
        //     DL envelope (110 mm by 220 mm).
        DLEnvelope = 27,
        //
        // Summary:
        //     C5 envelope (162 mm by 229 mm).
        C5Envelope = 28,
        //
        // Summary:
        //     C3 envelope (324 mm by 458 mm).
        C3Envelope = 29,
        //
        // Summary:
        //     C4 envelope (229 mm by 324 mm).
        C4Envelope = 30,
        //
        // Summary:
        //     C6 envelope (114 mm by 162 mm).
        C6Envelope = 31,
        //
        // Summary:
        //     C65 envelope (114 mm by 229 mm).
        C65Envelope = 32,
        //
        // Summary:
        //     B4 envelope (250 mm by 353 mm).
        B4Envelope = 33,
        //
        // Summary:
        //     B5 envelope (176 mm by 250 mm).
        B5Envelope = 34,
        //
        // Summary:
        //     B6 envelope (176 mm by 125 mm).
        B6Envelope = 35,
        //
        // Summary:
        //     Italy envelope (110 mm by 230 mm).
        ItalyEnvelope = 36,
        //
        // Summary:
        //     Monarch envelope (3.875 in. by 7.5 in.).
        MonarchEnvelope = 37,
        //
        // Summary:
        //     6 3/4 envelope (3.625 in. by 6.5 in.).
        PersonalEnvelope = 38,
        //
        // Summary:
        //     US standard fanfold (14.875 in. by 11 in.).
        USStandardFanfold = 39,
        //
        // Summary:
        //     German standard fanfold (8.5 in. by 12 in.).
        GermanStandardFanfold = 40,
        //
        // Summary:
        //     German legal fanfold (8.5 in. by 13 in.).
        GermanLegalFanfold = 41,
        //
        // Summary:
        //     ISO B4 (250 mm by 353 mm).
        IsoB4 = 42,
        //
        // Summary:
        //     Japanese postcard (100 mm by 148 mm).
        JapanesePostcard = 43,
        //
        // Summary:
        //     Standard paper (9 in. by 11 in.).
        Standard9x11 = 44,
        //
        // Summary:
        //     Standard paper (10 in. by 11 in.).
        Standard10x11 = 45,
        //
        // Summary:
        //     Standard paper (15 in. by 11 in.).
        Standard15x11 = 46,
        //
        // Summary:
        //     Invitation envelope (220 mm by 220 mm).
        InviteEnvelope = 47,
        //
        // Summary:
        //     Letter extra paper (9.275 in. by 12 in.). This value is specific to the PostScript
        //     driver and is used only by Linotronic printers in order to conserve paper.
        LetterExtra = 50,
        //
        // Summary:
        //     Legal extra paper (9.275 in. by 15 in.). This value is specific to the PostScript
        //     driver and is used only by Linotronic printers in order to conserve paper.
        LegalExtra = 51,
        //
        // Summary:
        //     Tabloid extra paper (11.69 in. by 18 in.). This value is specific to the PostScript
        //     driver and is used only by Linotronic printers in order to conserve paper.
        TabloidExtra = 52,
        //
        // Summary:
        //     A4 extra paper (236 mm by 322 mm). This value is specific to the PostScript driver
        //     and is used only by Linotronic printers to help save paper.
        A4Extra = 53,
        //
        // Summary:
        //     Letter transverse paper (8.275 in. by 11 in.).
        LetterTransverse = 54,
        //
        // Summary:
        //     A4 transverse paper (210 mm by 297 mm).
        A4Transverse = 55,
        //
        // Summary:
        //     Letter extra transverse paper (9.275 in. by 12 in.).
        LetterExtraTransverse = 56,
        //
        // Summary:
        //     SuperA/SuperA/A4 paper (227 mm by 356 mm).
        APlus = 57,
        //
        // Summary:
        //     SuperB/SuperB/A3 paper (305 mm by 487 mm).
        BPlus = 58,
        //
        // Summary:
        //     Letter plus paper (8.5 in. by 12.69 in.).
        LetterPlus = 59,
        //
        // Summary:
        //     A4 plus paper (210 mm by 330 mm).
        A4Plus = 60,
        //
        // Summary:
        //     A5 transverse paper (148 mm by 210 mm).
        A5Transverse = 61,
        //
        // Summary:
        //     JIS B5 transverse paper (182 mm by 257 mm).
        B5Transverse = 62,
        //
        // Summary:
        //     A3 extra paper (322 mm by 445 mm).
        A3Extra = 63,
        //
        // Summary:
        //     A5 extra paper (174 mm by 235 mm).
        A5Extra = 64,
        //
        // Summary:
        //     ISO B5 extra paper (201 mm by 276 mm).
        B5Extra = 65,
        //
        // Summary:
        //     A2 paper (420 mm by 594 mm).
        A2 = 66,
        //
        // Summary:
        //     A3 transverse paper (297 mm by 420 mm).
        A3Transverse = 67,
        //
        // Summary:
        //     A3 extra transverse paper (322 mm by 445 mm).
        A3ExtraTransverse = 68,
        //
        // Summary:
        //     Japanese double postcard (200 mm by 148 mm). Requires Windows 98, Windows NT
        //     4.0, or later.
        JapaneseDoublePostcard = 69,
        //
        // Summary:
        //     A6 paper (105 mm by 148 mm). Requires Windows 98, Windows NT 4.0, or later.
        A6 = 70,
        //
        // Summary:
        //     Japanese Kaku #2 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeKakuNumber2 = 71,
        //
        // Summary:
        //     Japanese Kaku #3 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeKakuNumber3 = 72,
        //
        // Summary:
        //     Japanese Chou #3 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeChouNumber3 = 73,
        //
        // Summary:
        //     Japanese Chou #4 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeChouNumber4 = 74,
        //
        // Summary:
        //     Letter rotated paper (11 in. by 8.5 in.).
        LetterRotated = 75,
        //
        // Summary:
        //     A3 rotated paper (420 mm by 297 mm).
        A3Rotated = 76,
        //
        // Summary:
        //     A4 rotated paper (297 mm by 210 mm). Requires Windows 98, Windows NT 4.0, or
        //     later.
        A4Rotated = 77,
        //
        // Summary:
        //     A5 rotated paper (210 mm by 148 mm). Requires Windows 98, Windows NT 4.0, or
        //     later.
        A5Rotated = 78,
        //
        // Summary:
        //     JIS B4 rotated paper (364 mm by 257 mm). Requires Windows 98, Windows NT 4.0,
        //     or later.
        B4JisRotated = 79,
        //
        // Summary:
        //     JIS B5 rotated paper (257 mm by 182 mm). Requires Windows 98, Windows NT 4.0,
        //     or later.
        B5JisRotated = 80,
        //
        // Summary:
        //     Japanese rotated postcard (148 mm by 100 mm). Requires Windows 98, Windows NT
        //     4.0, or later.
        JapanesePostcardRotated = 81,
        //
        // Summary:
        //     Japanese rotated double postcard (148 mm by 200 mm). Requires Windows 98, Windows
        //     NT 4.0, or later.
        JapaneseDoublePostcardRotated = 82,
        //
        // Summary:
        //     A6 rotated paper (148 mm by 105 mm). Requires Windows 98, Windows NT 4.0, or
        //     later.
        A6Rotated = 83,
        //
        // Summary:
        //     Japanese rotated Kaku #2 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeKakuNumber2Rotated = 84,
        //
        // Summary:
        //     Japanese rotated Kaku #3 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeKakuNumber3Rotated = 85,
        //
        // Summary:
        //     Japanese rotated Chou #3 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeChouNumber3Rotated = 86,
        //
        // Summary:
        //     Japanese rotated Chou #4 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeChouNumber4Rotated = 87,
        //
        // Summary:
        //     JIS B6 paper (128 mm by 182 mm). Requires Windows 98, Windows NT 4.0, or later.
        B6Jis = 88,
        //
        // Summary:
        //     JIS B6 rotated paper (182 mm by 128 mm). Requires Windows 98, Windows NT 4.0,
        //     or later.
        B6JisRotated = 89,
        //
        // Summary:
        //     Standard paper (12 in. by 11 in.). Requires Windows 98, Windows NT 4.0, or later.
        Standard12x11 = 90,
        //
        // Summary:
        //     Japanese You #4 envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeYouNumber4 = 91,
        //
        // Summary:
        //     Japanese You #4 rotated envelope. Requires Windows 98, Windows NT 4.0, or later.
        JapaneseEnvelopeYouNumber4Rotated = 92,
        //
        // Summary:
        //     People's Republic of China 16K paper (146 mm by 215 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        Prc16K = 93,
        //
        // Summary:
        //     People's Republic of China 32K paper (97 mm by 151 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        Prc32K = 94,
        //
        // Summary:
        //     People's Republic of China 32K big paper (97 mm by 151 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        Prc32KBig = 95,
        //
        // Summary:
        //     People's Republic of China #1 envelope (102 mm by 165 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber1 = 96,
        //
        // Summary:
        //     People's Republic of China #2 envelope (102 mm by 176 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber2 = 97,
        //
        // Summary:
        //     People's Republic of China #3 envelope (125 mm by 176 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber3 = 98,
        //
        // Summary:
        //     People's Republic of China #4 envelope (110 mm by 208 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber4 = 99,
        //
        // Summary:
        //     People's Republic of China #5 envelope (110 mm by 220 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber5 = 100,
        //
        // Summary:
        //     People's Republic of China #6 envelope (120 mm by 230 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber6 = 101,
        //
        // Summary:
        //     People's Republic of China #7 envelope (160 mm by 230 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber7 = 102,
        //
        // Summary:
        //     People's Republic of China #8 envelope (120 mm by 309 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber8 = 103,
        //
        // Summary:
        //     People's Republic of China #9 envelope (229 mm by 324 mm). Requires Windows 98,
        //     Windows NT 4.0, or later.
        PrcEnvelopeNumber9 = 104,
        //
        // Summary:
        //     People's Republic of China #10 envelope (324 mm by 458 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber10 = 105,
        //
        // Summary:
        //     People's Republic of China 16K rotated paper (146 mm by 215 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        Prc16KRotated = 106,
        //
        // Summary:
        //     People's Republic of China 32K rotated paper (97 mm by 151 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        Prc32KRotated = 107,
        //
        // Summary:
        //     People's Republic of China 32K big rotated paper (97 mm by 151 mm). Requires
        //     Windows 98, Windows NT 4.0, or later.
        Prc32KBigRotated = 108,
        //
        // Summary:
        //     People's Republic of China #1 rotated envelope (165 mm by 102 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber1Rotated = 109,
        //
        // Summary:
        //     People's Republic of China #2 rotated envelope (176 mm by 102 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber2Rotated = 110,
        //
        // Summary:
        //     People's Republic of China #3 rotated envelope (176 mm by 125 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber3Rotated = 111,
        //
        // Summary:
        //     People's Republic of China #4 rotated envelope (208 mm by 110 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber4Rotated = 112,
        //
        // Summary:
        //     People's Republic of China Envelope #5 rotated envelope (220 mm by 110 mm). Requires
        //     Windows 98, Windows NT 4.0, or later.
        PrcEnvelopeNumber5Rotated = 113,
        //
        // Summary:
        //     People's Republic of China #6 rotated envelope (230 mm by 120 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber6Rotated = 114,
        //
        // Summary:
        //     People's Republic of China #7 rotated envelope (230 mm by 160 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber7Rotated = 115,
        //
        // Summary:
        //     People's Republic of China #8 rotated envelope (309 mm by 120 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber8Rotated = 116,
        //
        // Summary:
        //     People's Republic of China #9 rotated envelope (324 mm by 229 mm). Requires Windows
        //     98, Windows NT 4.0, or later.
        PrcEnvelopeNumber9Rotated = 117,
        //
        // Summary:
        //     People's Republic of China #10 rotated envelope (458 mm by 324 mm). Requires
        //     Windows 98, Windows NT 4.0, or later.
        PrcEnvelopeNumber10Rotated = 118
    }
}
